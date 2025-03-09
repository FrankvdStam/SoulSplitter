// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

use std::any::Any;
use std::{mem, ptr};
use std::ops::Deref;
use hudhook::tracing::event;
use ilhook::x64::{CallbackOption, Hooker, HookFlags, HookType, Registers};
use log::info;
use crate::App;
use crate::darkscript3::sekiro_emedf::Emedf;
use crate::games::{Game, GameExt, Sekiro};
use crate::games::dx_version::DxVersion;
use crate::games::traits::buffered_emevd_logger::{BufferedEmevdCall, BufferedEmevdLogger};
use crate::games::traits::buffered_event_flags::{BufferedEventFlags, EventFlag};
use crate::games::traits::player_position::PlayerPosition;

#[cfg(target_arch = "x86_64")]
use crate::games::sekiro::emevd::emevd_event_hook_fn;

impl Game for Sekiro
{
    fn refresh(&mut self) -> Result<(), String> {
        if !self.process.is_attached()
        {
            unsafe
            {
                self.process.refresh()?;

                self.event_flag_man = self.process.scan_rel("SprjEventFlagMan", "48 8b 0d ? ? ? ? 48 89 5c 24 50 48 89 6c 24 58 48 89 74 24 60", 3, 7, vec![0])?;
                self.position = self.process.scan_rel("WorldChrManImp", "48 8B 35 ? ? ? ? 44 0F 28 18", 3, 7, vec![0, 0x48, 0x28])?;
                self.chr_dbg_flags = self.process.scan_rel("chr dbg", "80 3d ? ? ? ? 00 0f ? ? ? ? ? 48 8b 9b d0 11 00 00", 2, 7, Vec::new())?;
                self.menu_man = self.process.scan_rel("MenuMan", "48 8b 05 ? ? ? ? 0f b6 d1 48 8b 88 08 33 00 00", 3, 7, vec![0])?;

                let set_event_flag_address = self.process.scan_abs("set_event_flag", "40 55 41 54 41 55 41 56 48 83 ec 58 80 b9 28 02 00 00 00 45 0f b6 e1 45 0f b6 e8 44 8b f2 48 8b e9", 0, Vec::new())?.get_base_address();
                let get_event_flag_address = self.process.scan_abs("get_event_flag", "40 53 48 83 ec 20 80 b9 28 02 00 00 00 8b da", 0, Vec::new())?.get_base_address();
                let emevd_events_address = self.process.scan_abs("emevd_events", "40 53 56 57 48 81 ec 40 01 00 00 48 c7 44 24 20 fe ff ff ff 0f 29 b4 24 30 01 00 00", 0, Vec::new())?.get_base_address();
                self.fn_get_event_flag = mem::transmute(get_event_flag_address);

                info!("event_flag_man base address: 0x{:x}", self.event_flag_man.get_base_address());
                info!("WorldChrManImp base address: 0x{:x}", self.position.get_base_address());
                info!("chr dbg flags  base address: 0x{:x}", self.chr_dbg_flags.get_base_address());
                info!("MenuMan        base address: 0x{:x}", self.menu_man.get_base_address());
                info!("set event flag address     : 0x{:x}", set_event_flag_address);
                info!("get event flag address     : 0x{:x}", get_event_flag_address);
                info!("emevd events               : 0x{:x}", emevd_events_address);

                #[cfg(target_arch = "x86_64")]
                {
                    let h = Hooker::new(set_event_flag_address, HookType::JmpBack(set_event_flag_hook_fn), CallbackOption::None, 0, HookFlags::empty());
                    self.set_event_flag_hook = Some(h.hook().unwrap());

                    let h = Hooker::new(emevd_events_address, HookType::JmpBack(emevd_event_hook_fn), CallbackOption::None, 0, HookFlags::empty());
                    self.emevd_event_hook = Some(h.hook().unwrap());
                }
            }
        }
        else
        {
            self.process.refresh()?;
        }
        Ok(())
    }

    fn get_dx_version(&self) -> DxVersion {
        DxVersion::Dx11
    }
    fn event_flags(&mut self) -> Option<Box<&mut dyn BufferedEventFlags>> { Some(Box::new(self)) }
    fn player_position(&mut self) -> Option<Box<&mut dyn PlayerPosition>>{ Some(Box::new(self)) }
    fn buffered_emevd_logger(&mut self) -> Option<Box<&mut dyn BufferedEmevdLogger>>{ Some(Box::new(self)) }
    fn as_any(&self) -> &dyn Any
    {
        self
    }
    fn as_any_mut(&mut self) -> &mut dyn Any { self }
}


fn format_event(group: u32, type_: u32, emedf: &Emedf) -> String
{
    let item = emedf.main_classes.iter().find(|p| p.index as u32 == group);
    if let Some(class_doc) = item
    {
        let item = class_doc.instrs.iter().find(|p| p.index as u32 == type_);
        if let Some(inst_doc) = item
        {
            return format!("group: {} - type: {}", class_doc.name, inst_doc.name);
        }
        else
        {
            return format!("known group {} but unknown type: {}", class_doc.name, type_);
        }
    }
    else
    {
        return format!("unknown group and type: {} {}", group, type_);
    }
}



#[cfg(target_arch = "x86_64")]
unsafe extern "win64" fn set_event_flag_hook_fn(registers: *mut Registers, _:usize)
{
    let instance = App::get_instance();
    let app = instance.lock().unwrap();

    if let Some(sekiro) = GameExt::get_game_ref::<Sekiro>(app.game.deref())
    {
        let event_flag_id = (*registers).rdx as u32;
        let value = (*registers).r8 as u8;

        let mut guard = sekiro.event_flags.lock().unwrap();
        guard.push(EventFlag::new(chrono::offset::Local::now(), event_flag_id, value != 0));
    }
}