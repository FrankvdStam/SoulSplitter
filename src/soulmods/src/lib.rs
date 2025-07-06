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
mod util;

use std::ffi::c_void;
use std::{env, thread};
use mem_rs::prelude::Process;
use windows::Win32::Foundation::{HINSTANCE};
use windows::Win32::System::SystemServices::{ DLL_PROCESS_ATTACH, DLL_PROCESS_DETACH};

use crate::console::init_console;
use crate::logger::init_log;
use log::info;
use windows::core::BOOL;
use crate::util::{GLOBAL_HMODULE, GLOBAL_VERSION, Version, SOULMODS_VERSION};



#[unsafe(no_mangle)]
#[allow(non_snake_case)]
pub unsafe extern "system" fn DllMain(
    module: HINSTANCE,
    call_reason: u32,
    _reserved: c_void,
) -> BOOL
{
    unsafe
    {
        if call_reason == DLL_PROCESS_ATTACH
        {
            GLOBAL_HMODULE = module;
            GLOBAL_VERSION = Version::from_file_version_info(env::current_exe().unwrap());
            thread::spawn(dispatched_dll_main);
        }

        if call_reason == DLL_PROCESS_DETACH
        {
        }

        BOOL(1)
    }
}

fn dispatched_dll_main()
{
    if cfg!(debug_assertions)
    {
        init_console();
        init_log();
    }

    let process_name = Process::get_current_process_name().unwrap();
    info!("soulmods version {}", SOULMODS_VERSION);
    info!("process: {}", process_name);

    #[cfg(target_arch = "x86_64")]
    match process_name.to_lowercase().as_str()
    {
        "armoredcore6.exe" => init_armoredcore6(),
        "darksoulsii.exe" => init_scholar(),
        "darksoulsiii.exe" => init_darksouls3(),
        "eldenring.exe" => init_eldenring(),
        "sekiro.exe" => init_sekiro(),
        "shadps4.exe" => init_bloodborne(),
        "nightreign.exe" => init_nightreign(),
        _ => info!("no supported process found")
    }
}