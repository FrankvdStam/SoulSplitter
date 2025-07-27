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

#![allow(dead_code)]
#![allow(unused_imports)]


use std::any::Any;
use std::{mem, ptr};
use std::ops::Deref;
use std::sync::{Arc, Mutex};
use ilhook::x64::{CallbackOption, Hooker, HookFlags, HookPoint, HookType, Registers};
use log::info;
use mem_rs::prelude::*;
use crate::App;
use crate::darkscript3::emevd_definition::EmevdDefinition;
use crate::darkscript3::{emevd_format_event, load_emevd};
use crate::games::dx_version::DxVersion;
use crate::games::traits::buffered_event_flags::{BufferedEventFlags, EventFlag};
use crate::games::game::Game;
use crate::games::{GameExt, Sekiro};
use crate::games::traits::buffered_emevd_logger::{BufferedEmevdCall, BufferedEmevdLogger};

mod buffered_emevd_logger;
mod buffered_event_flags;

static EMEVD_JSON: &str = include_str!("../../../../../../darkscript3/ds3-common.emedf.json");

pub struct DarkSouls3
{
    process: Process,

    event_flags: Arc<Mutex<Vec<EventFlag>>>,
    event_flag_man: Pointer,
    fn_get_event_flag: fn(event_flag_man: u64, event_flag: u32) -> u8,
    set_event_flag_hook: Option<HookPoint>,
    emevd_hook: Option<HookPoint>,
    emevd_definition: EmevdDefinition,
    emevd_buffer: Arc<Mutex<Vec<BufferedEmevdCall>>>,
}

impl DarkSouls3
{
    pub fn new() -> Self
    {
        DarkSouls3
        {
            process: Process::new_with_memory_type("darksoulsiii.exe", MemoryType::Direct),

            event_flags: Arc::new(Mutex::new(Vec::new())),
            event_flag_man: Pointer::default(),
            fn_get_event_flag: |_,_|{0},

            emevd_definition: load_emevd(EMEVD_JSON),

            set_event_flag_hook: None,
            emevd_hook: None,
            emevd_buffer: Arc::new(Mutex::new(Vec::new())),
        }
    }
}



impl Game for DarkSouls3
{
    fn refresh(&mut self) -> Result<(), String> {
        if !self.process.is_attached()
        {
            unsafe
            {
                self.process.refresh()?;


                self.event_flag_man = self.process.scan_rel("SprjEventFlagMan", "48 c7 05 ? ? ? ? 00 00 00 00 48 8b 7c 24 38 c7 46 54 ff ff ff ff 48 83 c4 20 5e c3", 3, 11, vec![0])?;
                //.ScanRelative("playerIns", "48 8b 0d ? ? ? ? 45 33 c0 48 8d 55 e7 e8 ? ? ? ? 0f 2f 73 70 72 0d f3 ? ? ? ? ? ? ? ? 0f 11 43 70", 3, 7)
                //.CreatePointer(out _playerIns, 0, 0x80)
                //.CreatePointer(out _sprjChrPhysicsModule, 0, 0x40, 0x28) -> position
                //_sprjChrPhysicsModule.ReadFloat(0x80),
                //_sprjChrPhysicsModule.ReadFloat(0x84),
                //_sprjChrPhysicsModule.ReadFloat(0x88)

                let set_event_flag_address = self.process.scan_abs("set_event_flag", "40 55 57 41 54 41 57 48 83 ec 58 80 b9 28 02 00 00 00 45 0f b6 f9 45 0f b6 e0 8b ea 48 8b f9", 0, Vec::new())?.get_base_address();
                let get_event_flag_address = self.process.scan_abs("get_event_flag", "40 53 48 83 ec 20 80 b9 28 02 00 00 00 8b da 74 4d", 0, Vec::new())?.get_base_address();
                let emevd_address = self.process.scan_abs("emevd", "48 83 ec 28 49 8b 80 b0 00 00 00 b2 01 44 8b 08", 0, Vec::new())?.get_base_address();
                self.fn_get_event_flag = mem::transmute(get_event_flag_address);

                let h = Hooker::new(set_event_flag_address, HookType::JmpBack(set_event_flag_hook_fn), CallbackOption::None, 0, HookFlags::empty());
                self.set_event_flag_hook = Some(h.hook().unwrap());

                let h = Hooker::new(emevd_address, HookType::JmpBack(emevd_event_hook_fn), CallbackOption::None, 0, HookFlags::empty());
                self.emevd_hook = Some(h.hook().unwrap());

                info!("event_flag_man base address: 0x{:x}", self.event_flag_man.get_base_address());
                info!("set event flag address     : 0x{:x}", set_event_flag_address);
                info!("get event flag address     : 0x{:x}", get_event_flag_address);
                info!("emevd address              : 0x{:x}", emevd_address);
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
    fn buffered_emevd_logger(&mut self) -> Option<Box<&mut dyn BufferedEmevdLogger>>{ Some(Box::new(self)) }
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

    if let Some(game) = GameExt::get_game_ref::<DarkSouls3>(app.game.deref())
    {
        let event_flag_id = unsafe{ (*registers).rdx as u32 };
        let value = unsafe{ (*registers).r8 as u8 };

        let mut guard = game.event_flags.lock().unwrap();
        guard.push(EventFlag::new(chrono::offset::Local::now(), event_flag_id, value != 0));
    }
}

unsafe extern "win64" fn emevd_event_hook_fn(registers: *mut Registers, _:usize)
{
    unsafe
    {
        let instance = App::get_instance();
        let app = instance.lock().unwrap();

        if let Some(darksouls3) = GameExt::get_game_ref::<DarkSouls3>(app.game.deref())
        {
            let sprj_emk_event_ins_ptr = (*registers).r8;
            let event_type_ptr = ptr::read((sprj_emk_event_ins_ptr + 0xb0) as *const u64);
            let event_group = ptr::read(event_type_ptr as *const u64) as u32;
            let event_type = ptr::read((event_type_ptr + 0x4) as *const u64) as u32;
            let event_id = ptr::read((sprj_emk_event_ins_ptr + 0x28) as *const u64) as u32;
            let arg_struct_ptr = ptr::read((sprj_emk_event_ins_ptr + 0xb8) as *const u64);

            let emedf = darksouls3.get_game_emevd_definitions();
            let s = emevd_format_event(emedf, event_group, event_type, event_id, arg_struct_ptr);

            let mut guard = darksouls3.emevd_buffer.lock().unwrap();
            guard.push(BufferedEmevdCall::new(chrono::offset::Local::now(), event_id, event_group, event_type, s));
        }
    }
}
