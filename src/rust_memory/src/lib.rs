#![feature(naked_functions)]
#![feature(const_mut_refs)]
#![feature(once_cell)]

mod native;
mod memory;

pub mod eldenring;
pub mod darksouls2;

pub use crate::memory::*;
pub use crate::native::*;
pub use crate::eldenring::*;
use crate::scan_cache::{get_process_name, init_scan_cache};

pub fn init()
{
     //Find out what game is running
     let process_name = get_process_name();
     match process_name
     {
          Ok(name) =>
          {
               match name.to_lowercase().as_str()
               {
                    "eldenring.exe" =>
                    {
                         init_scan_cache(name);
                         eldenring::init_event_flag_detour();
                    },
                    "darksoulsii.exe" =>
                    {
                         init_scan_cache(name);
                         darksouls2::init_event_flag_detour();
                         darksouls2::init_unlock_bonfire_detour();
                    },
                    _ => println!("unsupported process: {}", name),
               }
          }
          Err(_) =>
          {
               println!("Failed to get process name");
          }
     }
}







extern "C"
{
     pub fn update_igt_detour(fd4ptr: usize, frame_delta: f32);
}

#[used] #[no_mangle]
static USED_UPDATE_IGT_DETOUR: unsafe extern "C" fn(usize, f32) = update_igt_detour;