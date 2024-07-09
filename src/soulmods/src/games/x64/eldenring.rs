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

static mut IGT_BUFFER: f32 = 0.0f32;
static mut IGT_HOOK: Option<HookPoint> = None;

#[allow(unused_assignments)]
pub fn init_eldenring()
{
    unsafe
    {
        let mut process = Process::new("eldenring.exe");
        process.refresh().unwrap();
        let fn_increment_igt_address = process.scan_abs("increment igt", "48 c7 44 24 20 fe ff ff ff 0f 29 74 24 40 0f 28 f0 48 8b 0d ? ? ? ? 0f 28 c8 f3 0f 59 0d ? ? ? ?", 35, Vec::new()).unwrap().get_base_address();

        info!("increment IGT at 0x{:x}", fn_increment_igt_address);

        unsafe extern "win64" fn increment_igt(registers: *mut Registers, _:usize)
        {
            let mut frame_delta = std::mem::transmute::<u32, f32>((*registers).xmm0 as u32);
            //convert to milliseconds
            frame_delta = frame_delta * 1000f32;
            //info!("frame delta: {}", frame_delta);

            frame_delta = frame_delta * 0.96f32;
            //info!("frame delta scaled: {}", frame_delta);

            //Rather than casting, like the game does, make the behavior explicit by flooring
            let mut floored_frame_delta = frame_delta.floor();
            //info!("floored frame delta: {}", floored_frame_delta);

            let remainder = frame_delta - floored_frame_delta;
            //info!("remainder: {}", remainder);

            IGT_BUFFER = IGT_BUFFER + remainder;
            //info!("IGT_BUFFER: {}", IGT_BUFFER);

            if IGT_BUFFER > 1.0f32
            {
                //info!("reduced {} {}", IGT_FRAC, frame_delta_millis);
                IGT_BUFFER = IGT_BUFFER - 1f32;
                floored_frame_delta += 1f32;
                //info!("subtract 1 from IGT buffer: {} {}", IGT_BUFFER, floored_frame_delta);

            }

            //convert back to seconds
            floored_frame_delta = floored_frame_delta / 1000f32;
            //info!("floored_frame_delta seconds: {}", floored_frame_delta);
            (*registers).xmm0 = std::mem::transmute::<f32, u32>(floored_frame_delta) as u128;


            /*
            let mut frame_delta_millis = frame_delta  * 1000.0f32;

            let frac = frame_delta_millis - frame_delta_millis.floor();
            IGT_BUFFER = IGT_BUFFER + frac;
            if IGT_BUFFER > 1.0f32
            {
                //info!("reduced {} {}", IGT_FRAC, frame_delta_millis);
                IGT_BUFFER = IGT_BUFFER - 1.0f32;
                frame_delta_millis += 1.0f32;
            }

            frame_delta_millis = frame_delta_millis / 1000.0f32;
            (*registers).xmm0 = std::mem::transmute::<f32, u32>(floored_frame_delta) as u128;
            //info!("fd: {} altered: {} frac: {} glob_frac: {}", frame_delta, frame_delta_millis, frac, IGT_FRAC);



*/

            //var igtFixCode = new List<byte>(){
            //0x53,                        //push   rbx
            //0x48, 0xBB                   //movabs rbx, frac address
            //};
            //igtFixCode.AddRange(BitConverter.GetBytes((long)frac));
            //
            //igtFixCode.AddRange(new byte[]
            //{
            //0x51,                        //push   rcx
            //0x48, 0xb9,                  //movabs rcx, scale address
            //});
            //igtFixCode.AddRange(BitConverter.GetBytes((long)scale));
            //igtFixCode.AddRange(new byte[]
            //{
            //0x44, 0x0f, 0x10, 0x39,       ///movups    xmm15, XMMWORD PTR [rcx]   ; read scale value
            //0xF3, 0x41, 0x0F, 0x59, 0xCF, ///mulss     xmm1,  xmm15               ; multiply frame delta by scale
            //0x44, 0x0F, 0x10, 0xF1,       ///movups    xmm14, xmm1                ; frame time to double
            //0xF3, 0x45, 0x0F, 0x5A, 0xF6, ///cvtss2sd  xmm14, xmm14               ;
            //0xF2, 0x49, 0x0F, 0x2C, 0xC6, ///cvttsd2si rax,   xmm14               ; cast scaled frametime to int
            //0xF2, 0x4C, 0x0F, 0x2A, 0xF8, ///cvtsi2sd  xmm15, rax                 ; cast int frametime to double
            //0xF2, 0x45, 0x0F, 0x5C, 0xF7, ///subsd     xmm14, xmm15               ; subtract int frametime from double frametime -> only the fraction remains
            //0x66, 0x44, 0x0F, 0x10, 0x3B, ///movupd    xmm15, [rbx]               ; load previous fraction
            //0xF2, 0x45, 0x0F, 0x58, 0xFE, ///addsd     xmm15, xmm14               ; add fraction
            //0x66, 0x44, 0x0F, 0x11, 0x3B, ///movupd    [rbx], xmm15               ; store new fraction
            //0xF2, 0x49, 0x0F, 0x2C, 0xC7, ///cvttsd2si rax,   xmm15               ; cast fraction to int
            //0x48, 0x85, 0xC0,             ///test      rax,   rax                 ; if fraction is 1 or bigger
            //0x74, 0x1D,                   ///jz        +1D                        ;
            //0x90, 0x90, 0x90, 0x90,       ///nop                                  ;
            //0xF2, 0x4C, 0x0F, 0x2A, 0xF0, ///cvtsi2sd  xmm14, rax                 ; convert fraction back to double (will always be 1)
            //0xF2, 0x45, 0x0F, 0x5C, 0xFE, ///subsd     xmm15, xmm14               ; remove from fraction
            //0x66, 0x44, 0x0F, 0x11, 0x3B, ///movupd    [rbx], xmm15               ; store remainder of fraction
            //0xF2, 0x45, 0x0F, 0x5A, 0xF6, ///cvtsd2ss  xmm14, xmm14               ; convert fraction from double to single
            //0xF3, 0x41, 0x0F, 0x58, 0xCE, ///addss     xmm1, xmm14                ; add fraction to frame delta
            /////jz landing                           ; jz lands on the next line
            //0x45, 0x0F, 0x57, 0xF6,       ///xorps     xmm14, xmm14               ; zero xmm14
            //0x45, 0x0F, 0x57, 0xFF,       ///xorps     xmm15, xmm15               ; zero xmm15
            //0x59,                         ///pop rcx                              ;
            //0x5B,                         ///pop rbx                              ;
            //0xF3, 0x48, 0x0F, 0x2C, 0xC1, ///cvttss2si rax,xmm1                   ; cast unscaled frame delta to int in rax (eax will be added to igt)
            //0xE9                          ///jmp return igtFixEntryPoint +5
            //});




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
}
