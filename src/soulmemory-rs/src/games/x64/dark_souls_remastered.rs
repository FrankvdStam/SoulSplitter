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


use std::{mem};
use std::any::Any;
use std::ops::Deref;
use std::sync::{Arc, Mutex};
use ilhook::x64::HookPoint;
use log::info;
use mem_rs::prelude::*;
use windows::Win32::UI::Input::XboxController::XINPUT_STATE;
use crate::App;
use crate::games::dx_version::DxVersion;
use crate::games::game::Game;
use crate::games::GameExt;
use crate::games::ilhook::*;
use crate::tas::tas::{get_xinput_get_state_fn_address, tas_ai_toggle, XInputGetState};
use crate::tas::toggle_mode::ToggleMode;
use crate::games::traits::buffered_event_flags::{BufferedEventFlags, EventFlag, FnGetEventFlag};

pub struct DarkSoulsRemastered
{
    process: Process,

    ai_timer: Pointer,
    game_data_man: Pointer,

    event_flag_man: Pointer,
    fn_get_event_flag: FnGetEventFlag,
    event_flags: Arc<Mutex<Vec<EventFlag>>>,

    set_event_flag_hook: Option<HookPoint>,
    xinput_get_state_hook: Option<HookPoint>,

    pub ai_timer_toggle_threshold: f32,
    pub ai_timer_toggle_mode: ToggleMode,
}

impl DarkSoulsRemastered
{
    pub fn new() -> Self
    {
        DarkSoulsRemastered
        {
            process: Process::new_with_memory_type("DarkSoulsRemastered.exe", MemoryType::Direct),

            ai_timer: Pointer::default(),
            game_data_man: Pointer::default(),

            event_flag_man: Pointer::default(),
            fn_get_event_flag: |_,_|{return 0},
            event_flags: Arc::new(Mutex::new(Vec::new())),

            set_event_flag_hook: None,
            xinput_get_state_hook: None,

            ai_timer_toggle_threshold: 4.8f32,
            ai_timer_toggle_mode: ToggleMode::None,
        }
    }

    pub fn get_in_game_time_milliseconds(&self) -> u32
    {
        return self.game_data_man.read_u32_rel(Some(0xa4));
    }

    pub fn get_ai_timer_value(&self) -> f32
    {
        self.ai_timer.read_f32_rel(Some(0x24))
    }
}

impl BufferedEventFlags for DarkSoulsRemastered
{
    fn access_flag_storage(&self) -> &Arc<Mutex<Vec<EventFlag>>>
    {
        return &self.event_flags;
    }
    fn get_event_flag_state(&self, event_flag: u32) -> bool
    {
        let event_flag_man_address = self.event_flag_man.read_u32_rel(None) as u64; //Bit memes because DSR is 64bit, compiled with 32bit wide pointers
        let result = (self.fn_get_event_flag)(event_flag_man_address, event_flag);
        return result == 1;
    }
}

impl Game for DarkSoulsRemastered
{
    fn refresh(&mut self) -> Result<(), String>
    {
        if !self.process.is_attached()
        {
            unsafe
            {
                self.process.refresh()?;
                self.game_data_man  = self.process.scan_rel("GameDataMan", "48 8b 05 ? ? ? ? 48 8b 50 10 48 89 54 24 60", 3, 7, vec![0])?;
                self.ai_timer       = self.process.scan_rel("ai timer", "48 8b 0d ? ? ? ? 48 85 c9 74 0e 48 83 c1 28", 3, 7, vec![0])?;
                self.event_flag_man = self.process.scan_rel("event flags", "48 8B 0D ? ? ? ? 99 33 C2 45 33 C0 2B C2 8D 50 F6", 3, 7, vec![0])?;

                let set_event_flag_address = self.process.scan_abs("set_event_flag", "48 89 5c 24 08 57 48 83 ec 20 80 b9 24 02 00 00 00 41 0f b6 f8", 0, Vec::new())?.get_base_address();
                let get_event_flag_address = self.process.scan_abs("get_event_flag", "40 53 48 83 ec 20 80 b9 24 02 00 00 00 8b da 74 4d", 0, Vec::new())?.get_base_address();
                self.fn_get_event_flag = mem::transmute(get_event_flag_address);

                #[cfg(target_arch = "x86_64")]
                {
                    let h = Hooker::new(set_event_flag_address, HookType::JmpBack(set_event_flag_hook_fn), CallbackOption::None, 0, HookFlags::empty());
                    self.set_event_flag_hook = Some(h.hook().unwrap());

                    let h = Hooker::new(get_xinput_get_state_fn_address() as usize, HookType::Retn(xinput_get_state_hook_fn), CallbackOption::None, 0, HookFlags::empty());
                    self.xinput_get_state_hook = Some(h.hook().unwrap());
                }

                info!("game_data_man base address : 0x{:x}", self.game_data_man.get_base_address());
                info!("ai_timer base address      : 0x{:x}", self.ai_timer.get_base_address());
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
        DxVersion::Dx11
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

    if let Some(vanilla) = GameExt::get_game_ref::<DarkSoulsRemastered>(app.game.deref())
    {
        let event_flag_id = unsafe{ (*registers).rdx as u32 };
        let value = unsafe{ (*registers).r8 as u8 };

        let mut guard = vanilla.event_flags.lock().unwrap();
        guard.push(EventFlag::new(chrono::offset::Local::now(), event_flag_id, value != 0));
    }
}

#[cfg(target_arch = "x86_64")]
unsafe extern "win64" fn xinput_get_state_hook_fn(registers: *mut Registers, ori_func_ptr: usize, _: usize) -> usize
{
    let original_func: XInputGetState = unsafe{ mem::transmute(ori_func_ptr) };

    let instance = App::get_instance();
    let app = instance.lock().unwrap();

    if let Some(dsr) = GameExt::get_game_ref::<DarkSoulsRemastered>(app.game.deref())
    {
        let dw_user_index = unsafe{ (*registers).rcx as u32};
        let p_state = unsafe{ (*registers).rdx as *mut XINPUT_STATE};

        let res = unsafe{ original_func(dw_user_index, p_state) };
        tas_ai_toggle(dsr.ai_timer_toggle_mode, dsr.get_ai_timer_value(), dsr.ai_timer_toggle_threshold, p_state);
        return res as usize;
    }
    panic!("Failed to resolve DSR");
}