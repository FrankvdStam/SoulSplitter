use std::time::Duration;
use crate::tests::x64::empty_registers;
use crate::tests::utils::*;
use rand::prelude::*;

//==============================================================================================================================
//single frame calculation for games

fn reset_igt_buffers()
{
    unsafe
    {
        crate::games::darksouls3::IGT_BUFFER = 0.0f32;
        crate::games::sekiro::IGT_BUFFER = 0.0f32;
        crate::games::eldenring::IGT_BUFFER = 0.0f32;
        crate::games::nightreign::IGT_BUFFER = 0.0f32;
        crate::games::bloodborne::IGT_BUFFER = 0.0f32;
    }
}

///Runs a single cycle of stock IGT with a given frame delta
fn single_frame_stock_increment_igt(frame_delta: f32) -> u32
{
    return frame_delta.floor() as u32;
}

///Runs a single cycle of dark souls 3 IGT with a given frame delta
fn single_frame_darksouls3_increment_igt(frame_delta: f32) -> u32
{
    let mut registers = empty_registers();
    registers.xmm0 = f32::to_bits(frame_delta) as u128;
    unsafe{ crate::games::darksouls3::increment_igt_hook(&mut registers, 0) };
    let result = f32::from_bits(registers.xmm0 as u32);
    return result as u32;
}

///Runs a single cycle of sekiro IGT with a given frame delta
fn single_frame_sekiro_increment_igt(frame_delta: f32) -> u32
{
    let mut registers = empty_registers();
    registers.xmm0 = f32::to_bits(frame_delta) as u128;
    unsafe{ crate::games::sekiro::increment_igt_hook(&mut registers, 0) };
    let result = f32::from_bits(registers.xmm0 as u32);
    return result as u32;
}


///Runs a single cycle of eldenring IGT with a given frame delta
fn single_frame_eldenring_increment_igt(frame_delta: f32) -> u32
{
    let mut registers = empty_registers();
    registers.xmm0 = f32::to_bits(frame_delta / 1000f32) as u128;
    unsafe{ crate::games::eldenring::increment_igt_hook(&mut registers, 0) };
    let result = f32::from_bits(registers.xmm1 as u32);
    return result as u32;
}

///Runs a single cycle of nightreign IGT with a given frame delta
fn single_frame_nightreign_increment_igt(frame_delta: f32) -> u32
{
    let mut registers = empty_registers();
    registers.xmm0 = f32::to_bits(frame_delta) as u128;
    unsafe{ crate::games::nightreign::increment_igt_hook(&mut registers, 0) };
    let result = f32::from_bits(registers.xmm0 as u32);
    return result as u32;
}

///Runs a single cycle of dark souls 3 IGT with a given frame delta
fn single_frame_bloodborne_increment_igt(frame_delta: f32) -> u32
{
    let mut registers = empty_registers();
    registers.xmm0 = f32::to_bits(frame_delta) as u128;
    unsafe{ crate::games::bloodborne::increment_igt_hook(&mut registers, 0) };
    let result = f32::from_bits(registers.xmm0 as u32);
    return result as u32;
}


struct TimeState
{
    real_time_ms: f64,
    stock_igt_ms: u32,
    dark_souls_3_migt_ms: u32,
    sekiro_migt_ms: u32,
    bloodborne_migt_ms: u32,
    elden_ring_migt_ms: u32,
    nightreign_migt_ms: u32,
}

impl TimeState
{
    fn new() -> Self
    {
        TimeState
        {
            real_time_ms: 0.0f64,
            stock_igt_ms: 0,
            dark_souls_3_migt_ms: 0,
            sekiro_migt_ms: 0,
            elden_ring_migt_ms: 0,
            nightreign_migt_ms: 0,
            bloodborne_migt_ms: 0,
        }
    }

    fn print(&self)
    {
        let duration_real_time = Duration::from_millis(self.real_time_ms as u64);
        let duration_real_time_scaled = Duration::from_millis((self.real_time_ms * 0.96f64).floor() as u64);

        let duration_stock_igt = Duration::from_millis(self.stock_igt_ms as u64);
        let duration_difference_stock_igt = duration_stock_igt.abs_diff(duration_real_time_scaled);

        let duration_dark_souls_3 = Duration::from_millis(self.dark_souls_3_migt_ms as u64);
        let duration_difference_dark_souls_3 = duration_dark_souls_3.abs_diff(duration_real_time_scaled);


        let duration_elden_ring = Duration::from_millis(self.elden_ring_migt_ms as u64);
        let duration_difference_elden_ring = duration_elden_ring.abs_diff(duration_real_time_scaled);

        let duration_nightreign = Duration::from_millis(self.nightreign_migt_ms as u64);
        let duration_difference_nightreign = duration_nightreign.abs_diff(duration_real_time_scaled);

        let duration_bloodborne = Duration::from_millis(self.bloodborne_migt_ms as u64);
        let duration_difference_bloodborne = duration_bloodborne.abs_diff(duration_real_time_scaled);

        let duration_sekiro = Duration::from_millis(self.sekiro_migt_ms as u64);
        let duration_difference_sekiro = duration_sekiro.abs_diff(duration_real_time);


        println!("==== raw milliseconds ====");
        println!("real time                     : {}", self.real_time_ms);
        println!("real time scaled              : {}", self.real_time_ms * 0.96f64);
        println!("stock IGT                     : {}", self.stock_igt_ms);
        println!("dark souls 3 MIGT             : {}", self.dark_souls_3_migt_ms);
        println!("elden ring MIGT               : {}", self.elden_ring_migt_ms);
        println!("nightreign MIGT               : {}", self.nightreign_migt_ms);
        println!("bloodborne MIGT               : {}", self.bloodborne_migt_ms);
        println!("sekiro MIGT                   : {}", self.sekiro_migt_ms);
        println!();
        println!("==== timestamp, absolute difference with real time scaled ====");
        println!("real time                     : {}", FormattableDuration(duration_real_time));
        println!("real time scaled              : {}", FormattableDuration(duration_real_time_scaled));
        println!("stock IGT                     : {} - {}", FormattableDuration(duration_stock_igt), FormattableDuration(duration_difference_stock_igt));
        println!("dark souls 3 MIGT             : {} - {}", FormattableDuration(duration_dark_souls_3), FormattableDuration(duration_difference_dark_souls_3));
        println!("elden ring MIGT               : {} - {}", FormattableDuration(duration_elden_ring),  FormattableDuration(duration_difference_elden_ring));
        println!("nightreign MIGT               : {} - {}", FormattableDuration(duration_nightreign), FormattableDuration(duration_difference_nightreign));
        println!("bloodborne MIGT               : {} - {}", FormattableDuration(duration_bloodborne), FormattableDuration(duration_difference_bloodborne));
        println!("sekiro MIGT                   : {} - {}", FormattableDuration(duration_sekiro), FormattableDuration(duration_difference_sekiro));
    }
}

///calculates a single cycle for all available games/time values
fn single_cycle_increment_values(time_state: &mut TimeState, frame_delta: f64)
{
    let frame_delta_f32 = frame_delta as f32;

    time_state.real_time_ms = time_state.real_time_ms + frame_delta;
    time_state.stock_igt_ms = time_state.stock_igt_ms + single_frame_stock_increment_igt(frame_delta_f32);
    time_state.dark_souls_3_migt_ms = time_state.dark_souls_3_migt_ms + single_frame_darksouls3_increment_igt(frame_delta_f32);
    time_state.sekiro_migt_ms = time_state.sekiro_migt_ms + single_frame_sekiro_increment_igt(frame_delta_f32);
    time_state.elden_ring_migt_ms = time_state.elden_ring_migt_ms + single_frame_eldenring_increment_igt(frame_delta_f32);
    time_state.nightreign_migt_ms = time_state.nightreign_migt_ms + single_frame_nightreign_increment_igt(frame_delta_f32);
    time_state.bloodborne_migt_ms = time_state.bloodborne_migt_ms + single_frame_bloodborne_increment_igt(frame_delta_f32);
}

//==============================================================================================================================

#[test]
pub fn stable_framerate_migt_test()
{
    reset_igt_buffers();

    //60 frames p/s, 60 seconds, 60 minutes, for 10 hours
    let total_time_ms = 1000 * 60 * 60 * 10;

    //let frame_delta_f64 = 1f64/60f64;
    let frame_delta_f64 = 1f64/60f64 * 1000f64;

    //calculated amount of frames that will be rendered at this framerate
    let total_frames = total_time_ms as f64 / frame_delta_f64;

    //expected time from a pure calculation, without accumulating floating point errors
    let calculated_total_time = total_frames as f64 * frame_delta_f64;
    let calculated_total_time_with_scaling = calculated_total_time * 0.96f64;

    let mut time_state = TimeState::new();

    for _ in 0..total_frames as usize
    {
        single_cycle_increment_values(&mut time_state, frame_delta_f64);
    }

    println!("frames: {}", total_frames);
    println!("calculated total time         : {}", calculated_total_time);
    println!("calculated total time scaled  : {}", calculated_total_time_with_scaling);
    time_state.print();
    println!();

    let tolerance = 7 * 1000u32;
    let real_time_scaled_ms = (time_state.real_time_ms * 0.96f64).floor() as u32;
    let expected_range_real_time_scaled_ms = real_time_scaled_ms - tolerance..real_time_scaled_ms + tolerance;
    let expected_range_real_time_ms = time_state.real_time_ms.floor() as u32 - tolerance..time_state.real_time_ms.floor() as u32 + tolerance;

    assert!(expected_range_real_time_scaled_ms.contains(&time_state.dark_souls_3_migt_ms));
    assert!(expected_range_real_time_scaled_ms.contains(&time_state.elden_ring_migt_ms));
    assert!(expected_range_real_time_scaled_ms.contains(&time_state.nightreign_migt_ms));
    assert!(expected_range_real_time_scaled_ms.contains(&time_state.bloodborne_migt_ms));
    assert!(expected_range_real_time_ms.contains(&time_state.sekiro_migt_ms));
}

#[test]
pub fn extremely_unstable_framerate_migt_test()
{
    reset_igt_buffers();

    let mut rng = rand::rng();

    //60 frames p/s, 60 seconds, 60 minutes, for 10 hours
    let total_time_ms = 1000 * 60 * 60 * 10;

    let mut total_frames = 0;
    let mut time_state = TimeState::new();

    while time_state.real_time_ms < total_time_ms as f64
    {
        let frame_delta_f64 = rng.random_range(30.0f64..=60.0f64);
        single_cycle_increment_values(&mut time_state, frame_delta_f64);
        total_frames = total_frames + 1;
    }

    println!("frames              : {}", total_frames);
    println!();
    time_state.print();
    println!();

    let tolerance = 30 * 1000u32;
    let real_time_scaled_ms = (time_state.real_time_ms * 0.96f64).floor() as u32;
    let expected_range_real_time_scaled_ms = real_time_scaled_ms - tolerance..real_time_scaled_ms + tolerance;
    let expected_range_real_time_ms = time_state.real_time_ms.floor() as u32 - tolerance..time_state.real_time_ms.floor() as u32 + tolerance;

    assert!(expected_range_real_time_scaled_ms.contains(&time_state.dark_souls_3_migt_ms));
    assert!(expected_range_real_time_scaled_ms.contains(&time_state.elden_ring_migt_ms));
    assert!(expected_range_real_time_scaled_ms.contains(&time_state.nightreign_migt_ms));
    assert!(expected_range_real_time_scaled_ms.contains(&time_state.bloodborne_migt_ms));
    assert!(expected_range_real_time_ms.contains(&time_state.sekiro_migt_ms));
}