use ilhook::x64::{Hooker, HookType, Registers, CallbackOption, HookFlags, HookPoint};
use mem_rs::prelude::*;
use log::info;

static mut IGT_FRAC: f32 = 0.0f32;
static mut IGT_HOOK: Option<HookPoint> = None;

#[allow(unused_assignments)]
pub unsafe fn init_armoredcore6()
{
    let mut process = Process::new("armoredcore6.exe");
    process.refresh().unwrap();
    let fn_increment_igt_address = process.scan_abs("increment igt", "48 83 ec 58 48 c7 44 24 20 fe ff ff ff 0f 29 74 24 40 0f 28 f0", 0, Vec::new()).unwrap().get_base_address();

    info!("increment IGT at 0x{:x}", fn_increment_igt_address);

    unsafe extern "win64" fn increment_igt(registers: *mut Registers, _:usize)
    {
        let mut frame_delta = std::mem::transmute::<u32, f32>((*registers).xmm0 as u32);
        frame_delta = frame_delta * 0.96f32;

        let mut frame_delta_millis = frame_delta  * 1000.0f32;

        let frac = frame_delta_millis - frame_delta_millis.floor();
        IGT_FRAC = IGT_FRAC + frac;
        if IGT_FRAC > 1.0f32
        {
            //info!("reduced {} {}", IGT_FRAC, frame_delta_millis);
            IGT_FRAC = IGT_FRAC - 1.0f32;
            frame_delta_millis += 1.0f32;
        }

        frame_delta_millis = frame_delta_millis / 1000.0f32;
        (*registers).xmm0 = std::mem::transmute::<f32, u32>(frame_delta_millis) as u128;
        //info!("fd: {} altered: {} frac: {} glob_frac: {}", frame_delta, frame_delta_millis, frac, IGT_FRAC);
    }

    //This hooker lib will remove the hooks by itself when it's objects go out of scope. Need to keep this object alive so that the hook stays alive.
    IGT_HOOK = Some(Hooker::new(fn_increment_igt_address, HookType::JmpBack(increment_igt), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());




    //unsafe {
    //    STATIC_DETOUR_INCREMENT_IGT.initialize(mem::transmute(fn_increment_igt_address), move |mut frame_delta: f32|
    //    {
    //        frame_delta = frame_delta * 0.96f32;
    //        let frac = frame_delta - frame_delta.floor();
    //        IGT_FRAC = IGT_FRAC + frac;
    //        if IGT_FRAC > 1.0f32
    //        {
    //            IGT_FRAC = IGT_FRAC - 1.0f32;
    //            frame_delta += 1.0f32;
    //        }
    //    }).unwrap().enable().unwrap();
    //}
}
