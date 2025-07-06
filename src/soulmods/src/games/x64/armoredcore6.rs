// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

use ilhook::x64::{Hooker, HookType, Registers, CallbackOption, HookFlags, HookPoint};
use mem_rs::prelude::*;
use log::info;

static mut IGT_FRAC: f32 = 0.0f32;
static mut IGT_HOOK: Option<HookPoint> = None;

#[allow(unused_assignments)]
pub fn init_armoredcore6()
{
    unsafe
    {
        let mut process = Process::new("armoredcore6.exe");
        process.refresh().unwrap();
        let fn_increment_igt_address = process.scan_abs("increment igt", "48 83 ec 58 48 c7 44 24 20 fe ff ff ff 0f 29 74 24 40 0f 28 f0", 0, Vec::new()).unwrap().get_base_address();

        info!("increment IGT at 0x{:x}", fn_increment_igt_address);
        IGT_HOOK = Some(Hooker::new(fn_increment_igt_address, HookType::JmpBack(increment_igt), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());
    }
}

unsafe extern "win64" fn increment_igt(registers: *mut Registers, _:usize)
{
    unsafe
    {
        let mut frame_delta = std::mem::transmute::<u32, f32>((*registers).xmm0 as u32);

        frame_delta = frame_delta * 0.96f32;

        let mut frame_delta_millis = frame_delta * 1000.0f32;

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
}