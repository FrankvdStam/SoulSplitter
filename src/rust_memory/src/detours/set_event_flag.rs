use chrono::prelude::*;
use detour::GenericDetour;
use crate::scan_cache::scan_absolute;

type SetEventFlagFn = fn(rcx: u64, edx: u32, r8d: i32);

static mut SET_EVENT_FLAG_HOOK: Option<GenericDetour::<SetEventFlagFn>> = None;
pub fn init_event_flag_detour()
{
    unsafe
    {
        let address = scan_absolute("48 89 5c 24 08 44 8b 49 1c 44 8b d2 33 d2 41 8b c2 41 f7 f1 41 8b d8 4c 8b d9").unwrap();
        println!("set_event_flag address: 0x{:x}", address);

        let original_func: SetEventFlagFn = std::mem::transmute(address as *const SetEventFlagFn);
        let hook = GenericDetour::<SetEventFlagFn>::new(original_func, set_event_flag_detour).unwrap();
        SET_EVENT_FLAG_HOOK = Some(hook);
        SET_EVENT_FLAG_HOOK.as_mut().unwrap().enable().unwrap();
        println!("event flag detour enabled: {}", SET_EVENT_FLAG_HOOK.as_ref().unwrap().is_enabled());
    }
}

pub fn disable_event_flag_detour()
{
    unsafe
    {
        if SET_EVENT_FLAG_HOOK.is_some() && SET_EVENT_FLAG_HOOK.as_ref().unwrap().is_enabled()
        {
            SET_EVENT_FLAG_HOOK.as_mut().unwrap().disable().unwrap();
        }
    }
}


#[no_mangle]
fn set_event_flag_detour(_rdx: u64, edx: u32, r8d: i32)
{
    println!("{} {} {}", Local::now().format("%H:%M:%S%.3f"), edx, r8d);
}
