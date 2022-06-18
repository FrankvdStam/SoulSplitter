use chrono::Local;
use detour::static_detour;
use log::info;
use crate::scan_cache::{scan_absolute};


static_detour!{ static GetEventFlagHook: fn(u64, u32, bool) -> u64; }

fn log_event_flag(rdx: u64, edx: u32, r8d: bool) -> u64
{
    let result = GetEventFlagHook.call(rdx, edx, r8d);
    info!("get event flag {:x} {} {} {:x}", rdx, edx, r8d, result);
    return result;
}

pub fn init_get_event_flag_detour()
{
    unsafe
    {
        let address = scan_absolute("40 57 41 56 48 83 ec 28 80 b9 28 02 00 00 00 45 0f b6 f0 44 8b ca 48 8b f9 0f 84 89 01 00 00 85 d2 0f 88 81 01 00 00 b8 6b ca 5f 6b").unwrap();
        info!("get_event_flag address: 0x{:x}", address);

        let original_func: fn(u64, u32, bool) -> u64 = std::mem::transmute(address        as *const fn(u64, u32, bool) -> u64);
        let detour_func:   fn(u64, u32, bool) -> u64 = std::mem::transmute(log_event_flag as *const fn(u64, u32, bool) -> u64);

        GetEventFlagHook.initialize(original_func, detour_func).unwrap();

        info!("get_event_flag rust code address (for debugging): {:p}", get_event_flag as *const fn(u64, u32, bool) -> u64);
    }
}

#[no_mangle]
pub fn get_event_flag(rdx: u64, edx: u32, r8d: bool) -> u64
{
    unsafe
    {
        GetEventFlagHook.enable().unwrap();
        let result = GetEventFlagHook.call(rdx, edx, r8d);
        GetEventFlagHook.disable().unwrap();
        return result;
    }
}