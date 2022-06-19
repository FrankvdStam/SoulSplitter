use chrono::Local;
use detour::static_detour;
use log::info;
use crate::scan_cache::{scan_absolute};
use crate::state::is_event_flag_excluded;


static_detour!{ static SetEventFlagHook: fn(u64, u32, u8, i32); }

fn log_event_flag(rdx: u64, edx: u32, r8d: u8, r9b: i32)
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
            let address = scan_absolute("40 55 41 54 41 55 41 56 48 83 ec 58 80 b9 28 02 00 00 00 45 0f b6 e1 45 0f b6 e8 44 8b f2 48 8b e9").unwrap();
            info!("set_event_flag address: 0x{:x}", address);

            let original_func: fn(u64, u32, u8, i32) = std::mem::transmute(address        as *const fn(u64, u32, u8, i32));
            let detour_func:   fn(u64, u32, u8, i32) = std::mem::transmute(log_event_flag as *const fn(u64, u32, u8, i32));

            SetEventFlagHook.initialize(original_func, detour_func).unwrap().enable().unwrap();
            info!("set_event_flag enabled: {}", SetEventFlagHook.is_enabled());
        }
}

pub fn disable_event_flag_detour()
{
    unsafe { SetEventFlagHook.disable().unwrap() };
}