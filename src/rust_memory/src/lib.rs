#![feature(naked_functions)]
#![feature(const_mut_refs)]
#![feature(once_cell)]
#![feature(core_intrinsics)]

mod native;
mod memory;

pub mod eldenring;
pub mod darksouls2;
pub mod websocket;

pub use log::*;
pub use log4rs::*;

use std::thread;
use std::time::Duration;
use winapi::shared::minwindef::PROC;
pub use crate::memory::*;
pub use crate::native::*;
pub use crate::eldenring::*;
use crate::processes::Process;
use crate::scan_cache::{init_scan_cache};
use crate::websocket::{init_websocket_server, kill_websocket_server};

static mut PROCESS: Option<Process> = None;

pub fn init()
{
     unsafe
     {
          init_websocket_server();

          PROCESS = Some(Process::get_current_process().unwrap());
          let process = PROCESS.as_ref().unwrap();

          let temp = process.name.to_lowercase();
          let process_name = temp.as_str();
          info!("init scan cache for {}", process_name);
          init_scan_cache(String::from(process_name));

          match process_name
          {
               "eldenring.exe" =>
               {

                    eldenring::init_event_flag_detour();
               },
               "darksoulsii.exe" =>
               {
                    darksouls2::init_event_flag_detour();
                    darksouls2::init_unlock_bonfire_detour();
                    darksouls2::init_event_guide_flag_detour();
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
               "eldenring.exe" =>
               {

                    eldenring::disable_event_flag_detour();
               },
               "darksoulsii.exe" =>
               {
                    darksouls2::disable_event_flag_detour();
                    darksouls2::disable_unlock_bonfire_detour();
                    darksouls2::disable_event_guide_flag_detour();
               },
               _ => error!("unsupported process: {}", process_name),
          }


          process.load_modules();
          for m in &process.modules
          {
               if m.name == "soulinjectee.dll"
               {
                    m.unload(process);
               }
          }
     }
}






extern "C"
{
     pub fn update_igt_detour(fd4ptr: usize, frame_delta: f32);
}

#[used] #[no_mangle]
static USED_UPDATE_IGT_DETOUR: unsafe extern "C" fn(usize, f32) = update_igt_detour;