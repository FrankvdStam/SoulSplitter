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



use std::{ptr, thread, time::Duration, mem, ffi::c_void};

use ilhook::x86::{Hooker, HookType, Registers, CallbackOption, HookFlags, HookPoint};
use mem_rs::prelude::*;
use mem_rs::helpers::*;

use log::info;

use windows::Win32::UI::Input::XboxController::*;

use crate::util::GLOBAL_VERSION;


static mut FRAME_ADVANCE_HOOK: Option<HookPoint> = None;
static mut XINPUT_HOOK: Option<HookPoint> = None;

#[unsafe(no_mangle)]
#[used]
pub static mut DS1_FRAME_ADVANCE_ENABLED: bool = false;

#[unsafe(no_mangle)]
#[used]
pub static mut DS1_FRAME_RUNNING: bool = false;

#[unsafe(no_mangle)]
#[used]
pub static mut DS1_XINPUT_PATCH_ENABLED: bool = false;

#[unsafe(no_mangle)]
#[used]
pub static mut DS1_XINPUT_STATE: XINPUT_STATE = XINPUT_STATE {
    dwPacketNumber: 0,
    Gamepad: XINPUT_GAMEPAD {
        wButtons: XINPUT_GAMEPAD_BUTTON_FLAGS(0),
        bLeftTrigger: 0,
        bRightTrigger: 0,
        sThumbLX: 0,
        sThumbLY: 0,
        sThumbRX: 0,
        sThumbRY: 0,
    }
};

pub type XInputGetState = unsafe extern "system" fn(dw_user_index: u32, p_state: *mut XINPUT_STATE) -> u32;


#[allow(unused_assignments)]
pub fn init_darksouls1()
{
    unsafe
    {
        info!("version: {}", GLOBAL_VERSION);
        
        // Get DS1 process
        // TODO: Handle DATA.exe
        let mut process = Process::new_with_memory_type("DARKSOULS.exe", MemoryType::Direct);
        process.refresh().unwrap();


        // AoB scan for frame advance patch
        let fn_frame_advance_address = process.scan_abs("frame_advance", "e8 ? ? ? ? 84 c0 74 07 83 7c 24", 0, Vec::new()).unwrap().get_base_address();
        info!("Frame advance at 0x{:x}", fn_frame_advance_address);

        // Enable frame advance patch
        FRAME_ADVANCE_HOOK = Some(Hooker::new(fn_frame_advance_address, HookType::JmpBack(frame_advance), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());


        // Find XInputGetState function in XINPUT1_3.dll
        let xinput_module = process.get_modules().iter().find(|m| m.name == "XINPUT1_3.dll").cloned().expect("Couldn't find XINPUT1_3.dll");
        let xinput_fn_addr = xinput_module.get_exports().iter().find(|e| e.0 == "XInputGetState").expect("Couldn't find XInputGetState").1;
        info!("XInputGetState at 0x{:x}", xinput_fn_addr);


        // BROKEN, POSSIBLY REGISTERS ??

        // Hook XInputGetState
        XINPUT_HOOK = Some(Hooker::new(xinput_fn_addr, HookType::Retn(8, xinput_fn), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());
    }
}


// Frame advance patch
unsafe extern "cdecl" fn frame_advance(_registers: *mut Registers, _:usize)
{
    unsafe
    {
        if DS1_FRAME_ADVANCE_ENABLED
        {
            DS1_FRAME_RUNNING = false;

            while !DS1_FRAME_RUNNING && DS1_FRAME_ADVANCE_ENABLED {
                thread::sleep(Duration::from_micros(10));
            }
        }
    }
}


pub unsafe extern "cdecl" fn xinput_fn(registers: *mut Registers, orig_func_ptr: usize, _: usize) -> usize {
    
    let dw_user_index = (*registers).eax as u32;
    let p_state = (*registers).ecx as *mut XINPUT_STATE;

    // For some reason, the game calls this function with garbage data once per second and a huge dw_user_index
    // As a dirty workaround, just check if dw_user_index is massive and then just not run the patch
    if !DS1_XINPUT_PATCH_ENABLED || dw_user_index > 999 {
        let orig_func: XInputGetState = mem::transmute(orig_func_ptr);
        return orig_func(dw_user_index, p_state) as usize;
    }

    (*p_state) = DS1_XINPUT_STATE;

    // ERROR_SUCCESS = 0x0
    // ERROR_DEVICE_NOT_CONNECTED = 0x48F
    return 0x0;
}