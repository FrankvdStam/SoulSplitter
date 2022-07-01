use chrono::Local;
use detour::static_detour;
use log::info;
use crate::scan_cache::{scan_absolute};


static_detour!{ static SetEventFlagHook: unsafe extern "C" fn(u32, u32); }
type FnSetEventFlag = unsafe extern "C" fn(u32, u32);




//static mut FLAGS: Vec<u32> = Vec::new();

fn log_event_flag(flag: u32, state: u32)
{
    unsafe{
        info!("generic flag {} {}", flag, state);
        SetEventFlagHook.call(flag, state);
    }

    //return
}

pub fn init_event_flag_detour()
{
    unsafe
    {
        //Actual write event flag function
        //let address = scan_absolute("55 8b ec 83 ec 08 53 56 8b 75 08 b8 59 17 b7 d1").unwrap();

        let address = scan_absolute("55 8b ec a1 ? ? ? ? 56 8b f1 8b 88 cc 0c 00 00 57 8b 7d 08 85 c9").unwrap();
        info!("set_event_flag address: 0x{:x}", address);

        let original_func: FnSetEventFlag = std::mem::transmute(address);

        SetEventFlagHook.initialize(original_func, log_event_flag).unwrap().enable().unwrap();
        info!("set_event_flag enabled: {}", SetEventFlagHook.is_enabled());
    }
}

pub fn disable_event_flag_detour()
{
    unsafe { SetEventFlagHook.disable().unwrap() };
}