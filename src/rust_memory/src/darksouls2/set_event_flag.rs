use chrono::Local;
use detour::static_detour;
use crate::scan_cache::{MODULE_BASE, scan_absolute};


static_detour!{ static SetEventFlagHook: fn(u64, u32, u8); }

//static mut FLAGS: Vec<u32> = Vec::new();

fn log_event_flag(rdx: u64, edx: u32, r8d: u8)
{
    unsafe
        {
            //Only log flags once to cleanup the output a bit
            //if !FLAGS.contains(&edx)
            //{
            println!("{} generic flag {} {}", Local::now().format("%H:%M:%S%.3f"), edx, r8d);
            //    FLAGS.push(edx);
            //}
        }
    //This calls the original function without detouring, to repair the event flag system.
    SetEventFlagHook.call(rdx, edx, r8d);
}

pub fn init_event_flag_detour()
{
    unsafe
        {
            //For some reason, the code we're after exists twice when the game is running...
            //Gota figure that out later
            //let address = MODULE_BASE + 0x46D870;

            //let address = scan_absolute("48 89 5c 24 08 48 89 74 24 10 57 48 83 ec 20").unwrap();
            let address = scan_absolute("48 89 74 24 10 57 48 83 ec 20 8b fa 45 0f b6 d8 b8 59 17 b7 d1 44 8b d7").unwrap();
            println!("set_event_flag address: 0x{:x}", address);

            let original_func: fn(u64, u32, u8) = std::mem::transmute(address        as *const fn(u64, u32, u8));
            let detour_func:   fn(u64, u32, u8) = std::mem::transmute(log_event_flag as *const fn(u64, u32, u8));

            SetEventFlagHook.initialize(original_func, detour_func).unwrap().enable().unwrap();
            println!("set_event_flag enabled: {}", SetEventFlagHook.is_enabled());
        }
}