use std::slice;
use chrono::prelude::*;
use detour::static_detour;
use log::info;
use crate::scan_cache::{scan_absolute};

static_detour!{ static UnlockBonfire: fn(u64, u64); }

//static mut FLAGS: Vec<u32> = Vec::new();

fn log_unlock_bonfire(event_point_manager: u64, warp_struct: u64)
{
    unsafe
        {
            //Only log flags once to cleanup the output a bit
            //if !FLAGS.contains(&edx)
            //{

            let slice = slice::from_raw_parts(warp_struct as *mut i32, 3);
            let mut vec = vec![0i32; 3];
            vec.copy_from_slice(slice);

            info!("bonfire unlocked {} {}", vec[0], vec[2]);
            //    FLAGS.push(edx);
            //}
        }
    //This calls the original function without detouring, to repair the event flag system.
    UnlockBonfire.call(event_point_manager, warp_struct);
}

pub fn init_unlock_bonfire_detour()
{
    unsafe
    {
        let address = scan_absolute("48 89 5c 24 10 57 48 83 ec 60 83 7a 04 01 48 8b da 48 8b f9 75 66 81 7a 08 a0 f0 19 00 75 5d").unwrap();

        info!("unlock bonfire address: 0x{:x}", address);

        let original_func: fn(u64, u64) = std::mem::transmute(address            as *const fn(u64, u64));
        let detour_func:   fn(u64, u64) = std::mem::transmute(log_unlock_bonfire as *const fn(u64, u64));

        UnlockBonfire.initialize(original_func, detour_func).unwrap().enable().unwrap();
        info!("unlock bonfire enabled: {}", UnlockBonfire.is_enabled());
    }
}


pub fn disable_unlock_bonfire_detour()
{
    unsafe { UnlockBonfire.disable() };
}




