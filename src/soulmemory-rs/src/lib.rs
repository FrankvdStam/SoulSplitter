#![feature(naked_functions)]
#![feature(const_mut_refs)]
#![feature(once_cell)]
#![feature(core_intrinsics)]
#![allow(unused_imports)]

mod native;
mod memory;

pub mod darksoulsremastered;
pub use darksoulsremastered::*;

pub mod darksouls2vanilla;
pub use darksouls2vanilla::*;

pub mod darksouls2scholar;
pub use darksouls2scholar::*;

pub mod darksouls3;
pub use darksouls3::*;

pub mod sekiro;
pub use sekiro::*;

pub mod eldenring;
pub use eldenring::*;

pub mod websocket;
pub mod state;

pub mod tas;
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
use crate::processes::Process;
use crate::scan_cache::{init_scan_cache};
use crate::websocket::*;

pub use serde_json;

static mut PROCESS: Option<Process> = None;

pub fn init()
{
     unsafe
     {
          init_websocket_server();
          hook_xinput();


          PROCESS = Some(Process::get_current_process().unwrap());
          let process = PROCESS.as_ref().unwrap();

          let temp = process.name.to_lowercase();
          let process_name = temp.as_str();
          info!("init scan cache for {}", process_name);
          init_scan_cache(String::from(process_name));

          match process_name
          {
               "darksoulsremastered.exe" =>
               {
                    darksoulsremastered::init_event_flag_detour();
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
          let temp = process.name.to_lowercase();
          let process_name = temp.as_str();

          //Need to disable all detours before unloading, otherwise Elden Ring will jump to unloaded code.
          match process_name
          {
               "darksoulsremastered.exe" =>
               {
                    darksoulsremastered::disable_event_flag_detour();
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


          process.load_modules();
          for m in &process.modules
          {
               if m.name == "soulinjectee.dll"
               {
                    m.unload();
               }
          }
     }
}