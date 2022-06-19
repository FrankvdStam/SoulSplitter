use chrono::Local;
use detour::static_detour;
use log::info;
use crate::scan_cache::{scan_absolute};
use crate::state::is_event_flag_excluded;


static_detour!{ static SetEventFlagHook: fn(u64, u32, u8, u8); }


fn log_event_flag(rdx: u64, edx: u32, r8d: u8, r9b: u8)
{
    if !is_event_flag_excluded(edx)
    {
        info!("set event flag {} {}", edx, r8d);
    }
    SetEventFlagHook.call(rdx, edx, r8d, r9b);
}

pub fn init_event_flag_detour()
{
    unsafe
    {
        let address = scan_absolute("48 89 5c 24 08 57 48 83 ec 20 80 b9 24 02 00 00 00").unwrap();
        info!("set_event_flag address: 0x{:x}", address);

        let original_func: fn(u64, u32, u8, u8) = std::mem::transmute(address        as *const fn(u64, u32, u8, u8));
        let detour_func:   fn(u64, u32, u8, u8) = std::mem::transmute(log_event_flag as *const fn(u64, u32, u8, u8));

        SetEventFlagHook.initialize(original_func, detour_func).unwrap().enable().unwrap();
        info!("set_event_flag enabled: {}", SetEventFlagHook.is_enabled());
    }
}

pub fn disable_event_flag_detour()
{
    unsafe { SetEventFlagHook.disable().unwrap() };
}