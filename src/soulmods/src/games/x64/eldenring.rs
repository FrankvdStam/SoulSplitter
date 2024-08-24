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
use crate::util::GLOBAL_VERSION;

static mut IGT_BUFFER: f32 = 0.0f32;
static mut IGT_HOOK: Option<HookPoint> = None;

#[allow(unused_assignments)]
pub fn init_eldenring()
{
    unsafe
    {
        info!("version: {}", GLOBAL_VERSION);

        let mut process = Process::new("eldenring.exe");
        process.refresh().unwrap();
        let fn_increment_igt_address = process.scan_abs("increment igt", "48 c7 44 24 20 fe ff ff ff 0f 29 74 24 40 0f 28 f0 48 8b 0d ? ? ? ? 0f 28 c8 f3 0f 59 0d ? ? ? ?", 35, Vec::new()).unwrap().get_base_address();

        info!("increment IGT at 0x{:x}", fn_increment_igt_address);

        unsafe extern "win64" fn increment_igt(registers: *mut Registers, _:usize)
        {
            let mut frame_delta = std::mem::transmute::<u32, f32>((*registers).xmm0 as u32);
            //convert to milliseconds
            frame_delta = frame_delta * 1000f32;
            frame_delta = frame_delta * 0.96f32; //scale to IGT

            //Rather than casting, like the game does, make the behavior explicit by flooring
            let mut floored_frame_delta = frame_delta.floor();
            let remainder = frame_delta - floored_frame_delta;
            IGT_BUFFER = IGT_BUFFER + remainder;

            if IGT_BUFFER > 1.0f32
            {
                IGT_BUFFER = IGT_BUFFER - 1f32;
                floored_frame_delta += 1f32;
            }
            
            (*registers).xmm1 = std::mem::transmute::<f32, u32>(floored_frame_delta) as u128;
        }

        IGT_HOOK = Some(Hooker::new(fn_increment_igt_address, HookType::JmpBack(increment_igt), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());
    }
}