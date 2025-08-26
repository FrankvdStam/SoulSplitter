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
use std::mem;
use std::ops::Deref;
use std::sync::{Arc, Mutex};
use ilhook::x64::{CallbackOption, Hooker, HookFlags, HookPoint, HookType, Registers};
use log::info;
use mem_rs::prelude::*;
use crate::App;
use crate::games::traits::buffered_event_flags::{BufferedEventFlags, EventFlag, FnGetEventFlag};
use crate::games::dx_version::DxVersion;
use crate::games::game::Game;
use crate::games::GameExt;

pub struct ArmoredCore6
{
    process: Process,

    event_flags: Arc<Mutex<Vec<EventFlag>>>,
    virtual_memory_flag: Pointer,
    fn_get_event_flag: FnGetEventFlag,
    set_event_flag_address: usize,
    set_event_flag_hook: Option<HookPoint>,
}

impl ArmoredCore6
{
    pub fn new() -> Self
    {
        ArmoredCore6
        {
            process: Process::new_with_memory_type("armoredcore6.exe", MemoryType::Direct),

            event_flags: Arc::new(Mutex::new(Vec::new())),
            virtual_memory_flag: Pointer::default(),
            fn_get_event_flag: |_,_|{0},
            set_event_flag_address: 0,
            set_event_flag_hook: None,
        }
    }
}

impl BufferedEventFlags for ArmoredCore6
{
    fn access_flag_storage(&self) -> &Arc<Mutex<Vec<EventFlag>>>
    {
        return &self.event_flags;
    }

    fn get_event_flag_state(&self, event_flag: u32) -> bool {
        let result = (self.fn_get_event_flag)(self.virtual_memory_flag.read_u64_rel(None), event_flag);
        return result == 1;
    }
}

impl Game for ArmoredCore6
{
    fn refresh(&mut self) -> Result<(), String>
    {
        unsafe
        {
            if !self.process.is_attached()
            {
                self.process.refresh()?;

                self.virtual_memory_flag = self.process.scan_rel("CSEventFlagMan", "48 8b 35 ? ? ? ? 83 f8 ff 0f 44 c1", 3, 7, vec![0])?;

                self.set_event_flag_address = self.process.scan_abs("set_event_flag", "48 89 5c 24 18 56 41 56 41 57 48 83 ec 20 44 8b 49 1c 44 8b f2", 0, Vec::new())?.get_base_address();
                let get_event_flag_address = self.process.scan_abs("get_event_flag", "44 8b 41 1c 44 8b da 33 d2 41 8b c3 41 f7 f0 4c 8b d1 45 33 c9 44 0f af c0", 0, Vec::new())?.get_base_address();
                self.fn_get_event_flag = mem::transmute(get_event_flag_address);

                let h = Hooker::new(self.set_event_flag_address, HookType::JmpBack(set_event_flag_hook_fn), CallbackOption::None, 0, HookFlags::empty());
                self.set_event_flag_hook = Some(h.hook().unwrap());

                info!("event_flag_man base address: 0x{:x}", self.virtual_memory_flag.get_base_address());
                info!("set event flag address     : 0x{:x}", self.set_event_flag_address);
                info!("get event flag address     : 0x{:x}", get_event_flag_address);
            }
            else
            {
                let mut buffer: [u8; 1] = [0x0];
                self.process.read_memory_abs(self.set_event_flag_address, &mut buffer);
                let byte = buffer[0];
                if byte == 0x48
                {
                    info!("re-hook set event flag");
                    let hookpoint = self.set_event_flag_hook.take();
                    hookpoint.unwrap().unhook().unwrap();

                    let h = Hooker::new(self.set_event_flag_address, HookType::JmpBack(set_event_flag_hook_fn), CallbackOption::None, 0, HookFlags::empty());
                    self.set_event_flag_hook = Some(h.hook().unwrap());
                }

                self.process.refresh()?;
            }
            Ok(())
        }
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

    if let Some(game) = GameExt::get_game_ref::<ArmoredCore6>(app.game.deref())
    {
        let event_flag_id = unsafe{ (*registers).rdx as u32 };
        let value = unsafe{ (*registers).r8 as u8 };

        let mut guard = game.event_flags.lock().unwrap();
        guard.push(EventFlag::new(chrono::offset::Local::now(), event_flag_id, value != 0));
    }
}
