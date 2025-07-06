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
use std::ops::Deref;
use std::sync::{Arc, Mutex};
use mem_rs::prelude::*;
use crate::games::dx_version::DxVersion;
use crate::games::{Game, GameExt};
use crate::games::ilhook::*;
use crate::App;
use crate::games::traits::buffered_event_flags::{BufferedEventFlags, EventFlag};

mod buffered_event_flags;

pub struct Bloodborne
{
    process: Process,

    #[allow(dead_code)]
    set_event_flag_hook: Option<HookPoint>,
    event_flags: Arc<Mutex<Vec<EventFlag>>>,
}

impl Bloodborne
{
    pub fn new() -> Self
    {
        Bloodborne
        {
            process: Process::new("shadps4.exe"),
            set_event_flag_hook: None,
            event_flags: Arc::new(Mutex::new(Vec::new())),
        }
    }
}


impl Game for Bloodborne
{
    fn refresh(&mut self) -> Result<(), String> {
        if !self.process.is_attached()
        {
            self.process.refresh()?;

            #[cfg(target_arch = "x86_64")]
            {
                //TODO: setup proper AOB scan
                let set_event_flag_address= 0x9013CBCC0;
                let h = Hooker::new(set_event_flag_address, HookType::JmpBack(set_event_flag_hook_fn), CallbackOption::None, 0, HookFlags::empty());
                unsafe{ self.set_event_flag_hook = Some(h.hook().unwrap()) };
            }
        }

        return Ok(());
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

#[cfg(target_arch = "x86_64")]
unsafe extern "win64" fn set_event_flag_hook_fn(registers: *mut Registers, _:usize)
{
    let instance = App::get_instance();
    let app = instance.lock().unwrap();

    if let Some(bloodborne) = GameExt::get_game_ref::<Bloodborne>(app.game.deref())
    {
        let event_flag_id = unsafe{ (*registers).rsi as u32 };
        let value = unsafe{ (*registers).rdx as u8 };

        let mut guard = bloodborne.event_flags.lock().unwrap();
        guard.push(EventFlag::new(chrono::offset::Local::now(), event_flag_id, value != 0));
    }
}