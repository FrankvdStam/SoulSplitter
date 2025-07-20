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

//emevd: 48 89 5c 24 08 57 48 83 ec 20 49 8b 80 c0 00 00 00

use std::any::Any;
use std::mem;
use std::ops::Deref;
use std::sync::{Arc, Mutex};
use ilhook::x64::{CallbackOption, HookFlags, HookPoint, HookType, Hooker, Registers};
use log::info;
use mem_rs::pointer::Pointer;
use mem_rs::prelude::{Process, ReadWrite};
use crate::App;
use crate::games::{Game, GameExt};
use crate::games::dx_version::DxVersion;
use crate::games::traits::buffered_event_flags::{BufferedEventFlags, EventFlag, FnGetEventFlag};

pub struct Nightreign
{
    process: Process,

    event_flags: Arc<Mutex<Vec<EventFlag>>>,
    event_flag_man: Pointer,
    fn_get_event_flag: FnGetEventFlag,
    set_event_flag_hook: Option<HookPoint>,
}

impl Nightreign
{
    pub fn new() -> Self
    {
        Nightreign
        {
            process: Process::new("nightreign.exe"),

            event_flags: Arc::new(Mutex::new(Vec::new())),
            event_flag_man: Pointer::default(),
            fn_get_event_flag: |_,_|{0},
            set_event_flag_hook: None,
        }
    }
}

impl BufferedEventFlags for Nightreign
{
    fn access_flag_storage(&self) -> &Arc<Mutex<Vec<EventFlag>>>
    {
        return &self.event_flags;
    }

    fn get_event_flag_state(&self, event_flag: u32) -> bool {
        let result = (self.fn_get_event_flag)(self.event_flag_man.read_u64_rel(None), event_flag);
        return result == 1;
    }
}

impl Game for Nightreign
{
    fn refresh(&mut self) -> Result<(), String>
    {
        if !self.process.is_attached()
        {
            unsafe
            {
                self.process.refresh()?;

                self.event_flag_man = self.process.scan_rel("CSEventFlagMan", "48 8b 35 ? ? ? ? 0f b6 e8 48 85 f6", 3, 7, Vec::new())?;

                let set_event_flag_address = self.process.scan_abs("set_event_flag", "48 89 5c 24 08 48 89 74 24 18 57 48 83 ec 50 41 0f b6 f0", 0, Vec::new())?.get_base_address();
                let get_event_flag_address = self.process.scan_abs("get_event_flag", "44 8b 41 1c 44 8b da 33 d2 41 8b c3 41 f7 f0 4c 8b d1 45 33 c9 44 0f af c0 45 2b d8", 0, Vec::new())?.get_base_address();
                self.fn_get_event_flag = mem::transmute(get_event_flag_address);

                let h = Hooker::new(set_event_flag_address, HookType::JmpBack(set_event_flag_hook_fn), CallbackOption::None, 0, HookFlags::empty());
                self.set_event_flag_hook = Some(h.hook().unwrap());

                info!("event_flag_man base address: 0x{:x}", self.event_flag_man.get_base_address());
                info!("set event flag address     : 0x{:x}", set_event_flag_address);
                info!("get event flag address     : 0x{:x}", get_event_flag_address);
            }
        }
        else
        {
            self.process.refresh()?;
        }
        Ok(())
    }

    fn get_dx_version(&self) -> DxVersion {
        DxVersion::Dx12
    }
    fn event_flags(&mut self) -> Option<Box<&mut dyn BufferedEventFlags>> { Some(Box::new(self)) }
    fn as_any(&self) -> &dyn Any
    {
        self
    }
    fn as_any_mut(&mut self) -> &mut dyn Any { self }
}

unsafe extern "win64" fn set_event_flag_hook_fn(registers: *mut Registers, _:usize)
{
    let instance = App::get_instance();
    let app = instance.lock().unwrap();

    if let Some(game) = GameExt::get_game_ref::<Nightreign>(app.game.deref())
    {
        let event_flag_id = unsafe{ (*registers).rdx as u32};
        let value = unsafe{ (*registers).r8 as u8};

        let mut guard = game.event_flags.lock().unwrap();
        guard.push(EventFlag::new(chrono::offset::Local::now(), event_flag_id, value != 0));
    }
}