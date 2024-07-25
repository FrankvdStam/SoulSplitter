// This file is part of the soulmemory-rs distribution (https://github.com/FrankvdStam/soulmemory-rs).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/soulmemory-rs/blob/main/LICENSE
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

use std::ffi::c_void;
use ::log::info;
use windows::Win32::Foundation::HINSTANCE;
use windows::Win32::UI::Input::XboxController::XINPUT_STATE;
use crate::tas::toggle_mode::ToggleMode;


//TODO: convert these to windows-rs
#[link(name = "kernel32")]
extern "stdcall" {
    //fn LoadLibraryA(lp_proc_name: *const u8) -> HMODULE;
    fn GetProcAddress(h_module: *const c_void, lp_proc_name: *const u8) -> *const c_void;
    fn GetModuleHandleA(lp_module_name: *const u8) -> HINSTANCE;
}


pub type XInputGetState = unsafe extern "system" fn(dw_user_index: u32, p_state: *mut XINPUT_STATE) -> u32;


pub fn tas_ai_toggle(toggle_mode: ToggleMode, timer_value: f32, timer_threshold: f32, xinput_state: *mut XINPUT_STATE)
{
    if timer_value > timer_threshold
    {
        if toggle_mode == ToggleMode::Right
        {
            unsafe{ (*xinput_state).Gamepad.wButtons.0 |= 0x0008; }//d-pad right
        }

        if toggle_mode == ToggleMode::Left
        {
            unsafe{ (*xinput_state).Gamepad.wButtons.0 |= 0x0004; }//d-pad left
        }
    }
}



pub fn get_xinput_get_state_fn_address() -> u64
{
    unsafe
    {
        let xinput_versions =
        [
            "xinput1_3.dll\0",
            "xinput1_4.dll\0",
            "xinput9_1_0.dll\0",
        ];

        for xinput_version in xinput_versions
        {
            let hmodule = GetModuleHandleA(xinput_version.as_ptr());
            if hmodule != HINSTANCE(std::ptr::null_mut())
            {
                let address = GetProcAddress(hmodule.0 as *const c_void, "XInputGetState\0".as_ptr());
                info!("{} address 0x{:x}", xinput_version, address as u64);
                return address as u64;
            }
        }
    }
    panic!("Failed to get XInputGetState address");
}