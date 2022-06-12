use chrono::Local;
use detour::static_detour;
use log::info;
use crate::scan_cache::{scan_absolute};


static_detour!{ static SetEventFlagHook: fn(u64, u32, u8, u8); }

static IGNORED_FLAGS: [u32; 15] = [
    4200,
    2000,
    2001,
    2010,
    2011,
    2020,
    2021,
    2022,
    2030,
    2051,
    2052,
    13415841,
    13705543,
    15105310,
    15105311,
];

fn log_event_flag(rdx: u64, edx: u32, r8d: u8, r9b: u8)
{
    if !IGNORED_FLAGS.contains(&edx)
    {
        info!("set event flag {} {}", edx, r8d);
    }
    SetEventFlagHook.call(rdx, edx, r8d, r9b);
}

pub fn init_event_flag_detour()
{
    unsafe
    {
        let address = scan_absolute("40 55 57 41 54 41 57 48 83 ec 58 80 b9 28 02 00 00 00 45 0f b6 f9 45 0f b6 e0 8b ea 48 8b f9").unwrap();
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