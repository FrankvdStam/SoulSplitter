use std::time::Duration;
use ilhook::x64::Registers;
use crate::tests::x64::empty_registers;
use crate::tests::utils::*;



#[test]
pub fn migt_tests()
{
    //migt_test_stable_framerate((1f32/60f32) * 1000f32, 34099780);
    //migt_test_stable_framerate(16.99999f32, 34099780);


    let millis = 1000 * 60 * 60 * 10;
    //let millis = 1000;
    //let millis = 187176;

    migt_test_stable_framerate((1f32/60f32) * 1000f32, millis);
    migt_test_stable_framerate(16.99999f32, millis);
    migt_test_stable_framerate(16.1000f32, millis);



    //migt_test_stable_framerate((1f32/60f32) * 1000f32, 1000 * 60 * 60 * 10);
    //migt_test_stable_framerate(16.99999f32, 1000 * 60 * 60 * 10);
    //migt_test_stable_framerate(16.00001f32, 1000 * 60 * 60 * 10);
}

pub fn migt_test_stable_framerate(frame_delta: f32, total_duration_millis: u32)
{
    let target_duration = Duration::from_millis(total_duration_millis as u64);
    println!("testing MIGT with frame delta: {} target duration: {}", frame_delta, FormattableDuration(target_duration));

    let mut real_millis_passed = 0.0f32;
    let mut stock_millis_passed = 0;
    let mut eldenring_millis_passed = 0;
    let mut nightreign_millis_passed = 0;
    let mut cycles = 0;
    //let frame_delta = (1f32/60f32) * 1000f32;

    //run for 10 hours
    while (real_millis_passed.floor() as u32) < total_duration_millis
    //for x in 0..12
    {
        cycles = cycles + 1;
        real_millis_passed = real_millis_passed + frame_delta;

        stock_millis_passed = stock_millis_passed + single_cycle_stock_increment_igt(frame_delta);
        eldenring_millis_passed = eldenring_millis_passed + single_cycle_eldenring_increment_igt(frame_delta);
        //nightreign_millis_passed = nightreign_millis_passed + single_cycle_nightreign_increment_igt(frame_delta);

        if real_millis_passed.floor() as u32 > 1000
        {
            if eldenring_millis_passed < (real_millis_passed.floor() as u32 + 1000) && eldenring_millis_passed  > (real_millis_passed.floor() as u32 - 1000)
            {
                //in bounds
            }
            else
            {
                panic!("out of bounds {}", real_millis_passed);
            }
        }

    let expected_time_passed = Duration::from_millis((real_millis_passed  * 0.96f32) as u64);
    let real_time_passed = Duration::from_millis(real_millis_passed.round() as u64);
    let stock_igt_passed = Duration::from_millis(stock_millis_passed as u64);
    let eldenring_igt_passed = Duration::from_millis(eldenring_millis_passed as u64);
    //let nightreign_igt_passed = Duration::from_millis(nightreign_millis_passed as u64);

    println!("cycles: {}", cycles);
    println!("stock IGT passed       : {} millis: {}", FormattableDuration(stock_igt_passed), stock_igt_passed.as_millis());
    println!("real time passed       : {} millis: {}", FormattableDuration(real_time_passed), real_time_passed.as_millis());
    println!("expected corrected time: {} millis: {}", FormattableDuration(expected_time_passed), expected_time_passed.as_millis());
    println!("eldenring IGT passed   : {} millis: {}", FormattableDuration(eldenring_igt_passed), eldenring_igt_passed.as_millis());
    //println!("nightreign IGT passed  : {} millis: {}", FormattableDuration(nightreign_igt_passed), nightreign_igt_passed.as_millis());

}
}





///Runs a single cycle of stock IGT with a given frame delta
fn single_cycle_stock_increment_igt(frame_delta: f32) -> u32
{
    //not much point in fully emulating stock IGT behavior through registers and transmutes.
    return frame_delta.floor() as u32;
}

///Runs a single cycle of eldenring IGT with a given frame delta
fn single_cycle_eldenring_increment_igt(frame_delta: f32) -> u32
{
    unsafe
    {
        let mut registers = empty_registers();
        registers.xmm0 = std::mem::transmute::<f32, u32>(frame_delta / 1000f32) as u128;
        crate::games::eldenring::increment_igt_hook(&mut registers, 0);
        let result = std::mem::transmute::<u32, f32>(registers.xmm1 as u32);
        return result as u32;
    }
}

///Runs a single cycle of nightreign IGT with a given frame delta
fn single_cycle_nightreign_increment_igt(frame_delta: f32) -> u32
{
    unsafe
    {
        let mut registers = empty_registers();
        registers.xmm0 = std::mem::transmute::<f32, u32>(frame_delta) as u128;
        crate::games::nightreign::increment_igt_hook(&mut registers, 0);
        let result = std::mem::transmute::<u32, f32>(registers.xmm0 as u32);
        return result as u32;
    }
}