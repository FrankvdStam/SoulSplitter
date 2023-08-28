#![feature(fs_try_exists)]

mod armoredcore6;
mod logger;
mod console;

use std::ffi::c_void;
use std::thread;
use mem_rs::prelude::Process;
use windows::Win32::Foundation::{BOOL, HINSTANCE};
use windows::Win32::System::SystemServices::{ DLL_PROCESS_ATTACH, DLL_PROCESS_DETACH};
use crate::armoredcore6::*;
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
    if cfg!(debug_assertions) {
        init_console();
        init_log();
    }

    let process_name = Process::get_current_process_name().unwrap();
    info!("process: {}", process_name);

    if process_name == "armoredcore6.exe"
    {
        unsafe { init_armoredcore6() };
    }
}