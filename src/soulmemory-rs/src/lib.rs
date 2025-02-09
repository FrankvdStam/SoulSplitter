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

#![allow(static_mut_refs)]

mod util;
pub mod app;
pub mod games;
mod widgets;
mod tas;
mod render_hooks;

use std::time::Duration;
use std::ffi::c_void;
use std::{panic, thread};
use log::{error, info, LevelFilter};
use mem_rs::prelude::*;
use windows::Win32::Foundation::{BOOL, HINSTANCE};
use windows::Win32::System::SystemServices::{DLL_PROCESS_ATTACH, DLL_PROCESS_DETACH};
use crate::render_hooks::RenderHooks;


pub use app::App;

static mut HMODULE: HINSTANCE = HINSTANCE(std::ptr::null_mut());

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
        dispatched_dll_detach();
    }

    BOOL(1)
}



fn dispatched_dll_main()
{
    util::console::init_console();
    util::log::init_log(LevelFilter::Info);

    //Redirect panics
    panic::set_hook(Box::new(|i| {
        error!("panic");
        error!("{}", i);
    }));

    let process_name = Process::get_current_process_name().unwrap();
    info!("initializing, process: {}", process_name);
    unsafe{ App::init(&process_name, HMODULE) };

    info!("initializing render loop");
    RenderHooks::init();

    info!("starting main loop");
    loop
    {
        main_loop();
        thread::sleep(Duration::from_millis(16));
    }
}

fn dispatched_dll_detach()
{
    util::console::free_console();
}


fn main_loop()
{
    let instance = App::get_instance();
    let mut app = instance.lock().unwrap();

    match app.refresh()
    {
        Ok(()) => {}
        Err(e) => error!("{}", e),
    }
}
