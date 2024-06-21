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

#[allow(unused_imports)]
use crate::games::*;
mod logger;
mod console;
mod games;

use std::ffi::c_void;
use std::thread;
use mem_rs::prelude::Process;
use windows::Win32::Foundation::{BOOL, HINSTANCE};
use windows::Win32::System::SystemServices::{ DLL_PROCESS_ATTACH, DLL_PROCESS_DETACH};

use crate::console::init_console;
use crate::logger::init_log;
use log::info;

static mut HMODULE: HINSTANCE = HINSTANCE(0);

#[no_mangle]
#[allow(non_snake_case)]
pub unsafe extern "system" fn DllMain(
    module: HINSTANCE,
    call_reason: u32,
    _reserved: c_void,
) -> BOOL
{
    if call_reason == DLL_PROCESS_ATTACH
    {
        HMODULE = module;
        thread::spawn(dispatched_dll_main);
    }

    if call_reason == DLL_PROCESS_DETACH
    {
    }

    BOOL(1)
}

fn dispatched_dll_main()
{
    if cfg!(debug_assertions)
    {
        init_console();
        init_log();
    }

    let process_name = Process::get_current_process_name().unwrap();
    info!("process: {}", process_name);

    #[cfg(target_arch = "x86_64")]
    match process_name.to_lowercase().as_str()
    {
        "armoredcore6.exe" => init_armoredcore6(),
        "darksoulsii.exe" => init_scholar(),
        "eldenring.exe" => init_eldenring(),
        _ => info!("no supported process found")
    }

}