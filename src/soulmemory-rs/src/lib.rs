#![feature(naked_functions)]
#![feature(const_mut_refs)]
#![feature(once_cell)]
#![feature(core_intrinsics)]
#![allow(unused_imports)]

extern crate core;

mod native;
mod memory;
pub mod darksoulsremastered;
pub mod darksouls2vanilla;
pub mod darksouls2scholar;
pub mod darksouls3;
pub mod sekiro;
pub mod eldenring;
pub mod websocket;
pub mod state;
pub mod tas;
mod util;

pub use eldenring::*;
pub use sekiro::*;

pub use darksoulsremastered::*;
pub use darksouls2vanilla::*;
pub use darksouls2scholar::*;
pub use darksouls3::*;
pub use tas::*;

pub use state::init_state;
pub use state::set_event_flag_log_mode;
pub use state::set_event_flag_exclusion;

pub use log::*;
pub use log4rs::*;

use std::thread;
use std::time::Duration;
use winapi::shared::minwindef::PROC;
pub use crate::memory::*;
pub use crate::native::*;
use crate::scan_cache::{init_scan_cache};
use crate::websocket::*;

pub use serde_json;
use crate::process::Process;

static mut PROCESS: Option<Box<dyn Process>> = None;

pub fn init()
{

     unsafe
     {
          init_websocket_server();
          hook_xinput();

          match get_current_process()
          {
               Ok(p) => PROCESS = Some(p),
               _ => info!("Failed to get current process")
          }

          let process = PROCESS.as_ref().unwrap();

          let temp = process.get_name().to_lowercase();
          let process_name = temp.as_str();
          info!("init scan cache for {}", process_name);
          init_scan_cache(String::from(process_name));

          match process_name
          {
               "darksoulsremastered.exe" =>
               {
                    darksoulsremastered::init_event_flag_detour();
               }
               "darksouls.exe" =>
               {

               }
               "darksoulsii.exe" =>
               {
                    if cfg!(target_pointer_width = "64")
                    {
                         darksouls2scholar::init_event_flag_detour();
                    }
                    else
                    {
                         darksouls2vanilla::init_event_flag_detour();
                    }
               },
               "darksoulsiii.exe" =>
               {
                    darksouls3::init_event_flag_detour();
                    darksouls3::init_get_event_flag_detour();
               },
               "sekiro.exe" =>
               {
                    sekiro::init_event_flag_detour();
               }
               "eldenring.exe" =>
               {
                    eldenring::init_event_flag_detour();
               },
               _ => error!("unsupported process: {}", process_name),
          }
     }
}

pub fn unload()
{
     unsafe
     {
          kill_websocket_server();

          let process = PROCESS.as_mut().unwrap();
          let temp = process.get_name().to_lowercase();
          let process_name = temp.as_str();

          //Need to disable all detours before unloading, otherwise Elden Ring will jump to unloaded code.
          match process_name
          {
               "darksoulsremastered.exe" =>
               {
                    darksoulsremastered::disable_event_flag_detour();
               }
               "darksouls.exe" =>
               {

               }
               "darksoulsii.exe" =>
               {
                    if cfg!(target_pointer_width = "64")
                    {
                         darksouls2scholar::disable_event_flag_detour();
                    }
                    else
                    {
                         darksouls2vanilla::disable_event_flag_detour();
                    }
               },
               "darksoulsiii.exe" =>
               {
                    darksouls3::disable_event_flag_detour();
               },
               "sekiro.exe" =>
               {
                    sekiro::disable_event_flag_detour();
               }
               "eldenring.exe" =>
               {
                    eldenring::disable_event_flag_detour();
               },
               _ => error!("unsupported process: {}", process_name),
          }

          process.unload_module(String::from("soulinjectee.dll"));
     }
}