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

mod buffered_event_flags;

use std::any::Any;
use std::mem;
use std::ops::Deref;
use std::sync::{Arc, Mutex};
use ilhook::x64::{CallbackOption, Hooker, HookFlags, HookPoint, HookType, Registers};
use log::info;
use mem_rs::pointer::Pointer;
use mem_rs::prelude::Process;
use crate::App;
use crate::games::dx_version::DxVersion;
use crate::games::{Game, GameExt};
use crate::games::traits::buffered_event_flags::{BufferedEventFlags, EventFlag};

#[cfg(target_arch = "x86")]//This version exists only to make things compile easily for x86
type FnGetEventFlag = unsafe extern "thiscall" fn(event_flag_man: u64, event_flag: u32) -> u8;

#[cfg(target_arch = "x86_64")]
type FnGetEventFlag = unsafe extern "win64" fn(event_flag_man: u64, event_flag: u32) -> u8;

pub struct DarkSouls2ScholarOfTheFirstSin
{
    process: Process,

    event_flag_man: Pointer,
    event_flags: Arc<Mutex<Vec<EventFlag>>>,
    set_event_flag_hook: Option<HookPoint>,
    fn_get_event_flag: FnGetEventFlag,
}

impl DarkSouls2ScholarOfTheFirstSin
{
    pub fn new() -> Self
    {
        #[cfg(target_arch = "x86")]//This version exists only to make things compile easily for x86
        unsafe extern "thiscall" fn empty(_: u64, _: u32) -> u8 { 0 }

        #[cfg(target_arch = "x86_64")]
        unsafe extern "win64" fn empty(_: u64, _: u32) -> u8 { 0 }

        DarkSouls2ScholarOfTheFirstSin
        {
            process: Process::new("darksoulsii.exe"),

            event_flag_man: Default::default(),
            event_flags: Arc::new(Mutex::new(vec![])),
            set_event_flag_hook: None,
            fn_get_event_flag: empty,
        }
    }
}

impl Game for DarkSouls2ScholarOfTheFirstSin
{
    fn refresh(&mut self) -> Result<(), String>
    {
        if !self.process.is_attached()
        {
            unsafe
            {
                self.process.refresh()?;
                self.event_flag_man = self.process.scan_rel("GameDataMan" , "48 8b 35 ? ? ? ? 48 8b e9 48 85 f6", 3, 7, vec![0, 0x70, 0x20])?;
                let get_event_flag_address = self.process.scan_abs("get_event_flag" , "44 8b d2 b8 ? ? ? ? f7 e2 44 8b ca", 0,  Vec::new())?.get_base_address();
                let set_event_flag_address = self.process.scan_abs("set_event_flag" , "48 89 74 24 10 57 48 83 ec 20 8b fa 45 0f b6 d8", 0,  Vec::new())?.get_base_address();

                self.fn_get_event_flag = mem::transmute(get_event_flag_address);

                #[cfg(target_arch = "x86_64")]
                {
                    let h = Hooker::new(set_event_flag_address, HookType::JmpBack(crate::games::dark_souls_2_scholar_of_the_first_sin::read_event_flag_hook_fn), CallbackOption::None, 0, HookFlags::empty());
                    self.set_event_flag_hook = Some(h.hook().unwrap());
                }

                info!("event_flag_man base address: 0x{:x}", self.event_flag_man.get_base_address());
                info!("get event flag address     : 0x{:x}", get_event_flag_address);
                info!("set event flag address     : 0x{:x}", set_event_flag_address);
            }
        }
        else
        {
            self.process.refresh()?;
        }
        Ok(())
    }

    fn get_dx_version(&self) -> DxVersion { DxVersion::Dx11 }

    fn event_flags(&mut self) -> Option<Box<&mut dyn BufferedEventFlags>> { Some(Box::new(self)) }

    fn as_any(&self) -> &dyn Any { self }

    fn as_any_mut(&mut self) -> &mut dyn Any { self }
}

#[cfg(target_arch = "x86_64")]
unsafe extern "win64" fn read_event_flag_hook_fn(registers: *mut Registers, _:usize)
{
    let instance = App::get_instance();
    let app = instance.lock().unwrap();

    if let Some(scholar) = GameExt::get_game_ref::<DarkSouls2ScholarOfTheFirstSin>(app.game.deref())
    {
        let event_flag_id = (*registers).rdx as u32;
        let value = (*registers).r8 as u8;

        let mut guard = scholar.event_flags.lock().unwrap();
        guard.push(EventFlag::new(chrono::offset::Local::now(), event_flag_id, value != 0));
    }
}