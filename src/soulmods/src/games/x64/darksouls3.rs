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

#[allow(dead_code)]

use mem_rs::prelude::*;
use std::{ptr, thread, time::Duration};
use std::ffi::c_void;
use std::slice;
use iced_x86::{Decoder, DecoderOptions, FlowControl, Formatter, Instruction, IntelFormatter, InstructionBlock, BlockEncoder, BlockEncoderOptions};
use ilhook::x64::{Hooker, HookType, Registers, CallbackOption, HookFlags, HookPoint};
use iced_x86::code_asm::*;

use log::info;
use mem_rs::helpers::{scan, to_pattern};
use windows::Win32::Foundation::GetLastError;
use windows::Win32::System::Memory::{MEM_COMMIT, MEM_FREE, MEM_RESERVE, MEMORY_BASIC_INFORMATION, PAGE_EXECUTE_READWRITE, VirtualAlloc, VirtualQuery};
use windows::Win32::System::SystemInformation::{GetSystemInfo, SYSTEM_INFO};
use windows::Win32::System::Threading::GetCurrentProcess;

use crate::util::{allocate_near_target, GLOBAL_VERSION};

static mut FPS_HOOK: Option<HookPoint> = None;
static mut FPS_HISTORY_HOOK: Option<HookPoint> = None;
static mut FPS_CUSTOM_LIMIT_HOOK: Option<HookPoint> = None;
static mut FRAME_ADVANCE_HOOK: Option<HookPoint> = None;
static mut INCREMENT_IGT: Option<HookPoint> = None;

static mut IGT_BUFFER: f32 = 0.0f32;

#[no_mangle]
#[used]
pub static mut DS3_FPS_PATCH_ENABLED: bool = false;

#[no_mangle]
#[used]
pub static mut DS3_FPS_CUSTOM_LIMIT: f32 = 0.0f32;

#[no_mangle]
#[used]
pub static mut DS3_FRAME_ADVANCE_ENABLED: bool = false;

#[no_mangle]
#[used]
pub static mut DS3_FRAME_RUNNING: bool = false;

//original size is 799, for safety incremented to 1000
const IGT_CODE_SIZE: usize = 1000;

#[allow(unused_assignments)]
pub fn init_darksouls3()
{
    unsafe
    {
        info!("version: {}", GLOBAL_VERSION);
        
        // Get DS3 process
        let mut process = Process::new("darksoulsiii.exe");
        process.refresh().unwrap();

        //create copy of arxan protected function
        let fn_increment_igt_function_address = process.scan_abs("igt_fn", "48 83 ec 68 48 c7 44 24 20 fe ff ff ff 0f 29 74 24 50", 0, Vec::new()).unwrap().get_base_address();
        info!("increment_igt_function at 0x{:x}", fn_increment_igt_function_address);

        let call_increment_igt = process.scan_abs("call igt_fn", "85 ? 7f ? b2 ? 33 c9 e8 ? ? ? ? c6 83 ? ? ? ? ? f3 0f 10 47 ? e8", 25, Vec::new()).unwrap().get_base_address();
        info!("call igt function at 0x{:x}", call_increment_igt);

        let igt_code_slice: &[u8] = slice::from_raw_parts(fn_increment_igt_function_address as *const u8, IGT_CODE_SIZE);
        let igt_hook_offset = scan(igt_code_slice, &to_pattern("f3 48 0f 2c c0")).unwrap();


        //let mut igt_function_bytes: [u8; IGT_CODE_SIZE] = [0; IGT_CODE_SIZE];
        //igt_function_bytes.clone_from_slice(igt_code_slice);

        let mut decoder = Decoder::with_ip(64, &igt_code_slice, fn_increment_igt_function_address as u64, DecoderOptions::NONE);

        let mut formatter = IntelFormatter::new();
        let mut output = String::new();
        let mut required_byte_size: usize = 0;
        let mut orig_instructions: Vec<Instruction> = Vec::new();
        for instr in &mut decoder
        {
            output.clear();
            formatter.format(&instr, &mut output);
            info!("{}", output);

            required_byte_size += instr.len();
            orig_instructions.push(instr);

            match instr.flow_control() {
                FlowControl::Return => break,
                _ => {}
            };
        }
        println!("disassembled instructions size: {}", orig_instructions.len());

        let modules = Process::get_process_modules(GetCurrentProcess());
        let module = match modules.iter().find(|i| i.name.to_lowercase() == "darksoulsiii.exe")
        {
            None => panic!("failed to find executable base address"),
            Some(module) => module
        };

        info!("executable base address: 0{:x}", module.base_address);


        let replaced_igt_func = allocate_near_target(module.base_address, 1_000_000_000usize, required_byte_size).unwrap();




        let block = InstructionBlock::new(&orig_instructions, replaced_igt_func as u64);
        // This method can also encode more than one block but that's rarely needed, see above comment.
        let result = match BlockEncoder::encode(decoder.bitness(), block, BlockEncoderOptions::NONE) {
            Err(err) => panic!("{}", err),
            Ok(result) => result,
        };


        println!("code buffer: {:x?}", result.code_buffer);
        println!("writing to: {:x?}", replaced_igt_func);
        for i in 0..result.code_buffer.len()
        {
            ptr::write_volatile((replaced_igt_func + i) as *mut u8, result.code_buffer[i]);
        }

        let mut a = CodeAssembler::new(64).unwrap();
        a.call(replaced_igt_func as u64).unwrap();

        let result = a.assemble(call_increment_igt as u64).unwrap();
        println!("assembled call instr: {:x?}", result);

        //patch the callsite
        for  i in 0..result.len()
        {
            ptr::write_volatile((call_increment_igt + i) as *mut u8, result[i]);
        }

        //now hook the replaced function
        INCREMENT_IGT = Some(Hooker::new(replaced_igt_func + igt_hook_offset, HookType::JmpBack(increment_igt_hook), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());




//        // Formatters: Masm*, Nasm*, Gas* (AT&T) and Intel* (XED).
//        // For fastest code, see `SpecializedFormatter` which is ~3.3x faster. Use it if formatting
//        // speed is more important than being able to re-assemble formatted instructions.
//
//
//        // Change some options, there are many more
//        formatter.options_mut().set_digit_separator("`");
//        formatter.options_mut().set_first_operand_char_index(10);
//
//        // String implements FormatterOutput
//        let mut output = String::new();
//
//        // Initialize this outside the loop because decode_out() writes to every field
//        let mut instruction = Instruction::default();
//
//
//        const HEXBYTES_COLUMN_BYTE_LENGTH: usize = 10;
//
//        // The decoder also implements Iterator/IntoIterator so you could use a for loop:
//        //      for instruction in &mut decoder { /* ... */ }
//        // or collect():
//        //      let instructions: Vec<_> = decoder.into_iter().collect();
//        // but can_decode()/decode_out() is a little faster:
//        while decoder.can_decode() {
//            // There's also a decode() method that returns an instruction but that also
//            // means it copies an instruction (40 bytes):
//            //     instruction = decoder.decode();
//            decoder.decode_out(&mut instruction);
//
//            // Format the instruction ("disassemble" it)
//            output.clear();
//            formatter.format(&instruction, &mut output);
//
//            // Eg. "00007FFAC46ACDB2 488DAC2400FFFFFF     lea       rbp,[rsp-100h]"
//            print!("{:016X} ", instruction.ip());
//            let start_index = (instruction.ip() - increment_igt_function_copy_address as u64) as usize;
//            let instr_bytes = &igt_function_bytes[start_index..start_index + instruction.len()];
//            for b in instr_bytes.iter() {
//                print!("{:02X}", b);
//            }
//            if instr_bytes.len() < HEXBYTES_COLUMN_BYTE_LENGTH {
//                for _ in 0..HEXBYTES_COLUMN_BYTE_LENGTH - instr_bytes.len() {
//                    print!("  ");
//                }
//            }
//            println!(" {}", output);
//        }
















        //for n in 0..IGT_CODE_SIZE
        //{
        //    let byte = std::ptr::read_volatile(fn_increment_igt_function_address + n);
        //    std::ptr::write_volatile(&increment_igt_func_copy + , timestamp_previous);
        //}
//


        //let fn_increment_igt_address = process.scan_abs("igt", "f3 48 0f 2c c0 01 81 ? 00 00 00 48 8b 05 ? ? ? ? 81 b8 ? 00 00 00 18 a0 93 d6", 0, Vec::new()).unwrap().get_base_address();
        //info!("increment IGT at 0x{:x}", fn_increment_igt_address);
        //INCREMENT_IGT = Some(Hooker::new(fn_increment_igt_address, HookType::JmpBack(increment_igt_hook), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());

        // AoB scan for FPS patch
        let fn_fps_address = process.scan_abs("fps", "f3 0f 58 93 64 02 00 00 41 0f 2f d4", 0, Vec::new()).unwrap().get_base_address();
        info!("FPS at 0x{:x}", fn_fps_address);

        // Enable FPS patch
        FPS_HOOK = Some(Hooker::new(fn_fps_address, HookType::JmpBack(fps), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());


        // AoB scan for FPS history patch
        let fn_fps_history_address = process.scan_abs("fps history", "48 89 04 cb 0f b6 83 78 02 00 00", 0, Vec::new()).unwrap().get_base_address();
        info!("FPS history at 0x{:x}", fn_fps_history_address);

        // Enable FPS history patch
        FPS_HISTORY_HOOK = Some(Hooker::new(fn_fps_history_address, HookType::JmpBack(fps_history), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());


        // AoB scan for FPS custom limit patch
        let fn_fps_custom_limit_address = process.scan_abs("fps custom limit", "f3 44 0f 10 2d ? ? ? ? 44 38 a3 58 03 00 00", 0, Vec::new()).unwrap().get_base_address();
        info!("FPS custom limit at 0x{:x}", fn_fps_custom_limit_address);

        // Enable FPS custom limit patch
        FPS_CUSTOM_LIMIT_HOOK = Some(Hooker::new(fn_fps_custom_limit_address, HookType::JmpBack(fps_custom_limit), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());


        // AoB scan for frame advance patch
        let fn_frame_advance_address = process.scan_abs("frame_advance", "e8 ? ? ? ? 84 c0 74 41 90 48", 10, Vec::new()).unwrap().get_base_address();
        info!("Frame advance at 0x{:x}", fn_frame_advance_address);

        // Enable frame advance patch
        FRAME_ADVANCE_HOOK = Some(Hooker::new(fn_frame_advance_address, HookType::JmpBack(frame_advance), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());
    }
}

unsafe extern "win64" fn increment_igt_hook(registers: *mut Registers, _:usize)
{
    let frame_delta = std::mem::transmute::<u32, f32>((*registers).xmm0 as u32);
    let mut corrected_frame_delta = frame_delta;

    //Rather than casting, like the game does, make the behavior explicit by flooring
    let floored_frame_delta = frame_delta.floor();
    let remainder = frame_delta - floored_frame_delta;
    IGT_BUFFER = IGT_BUFFER + remainder;

    if IGT_BUFFER > 1.0f32
    {
        IGT_BUFFER = IGT_BUFFER - 1f32;
        corrected_frame_delta += 1f32;
    }

    (*registers).xmm0 = std::mem::transmute::<f32, u32>(corrected_frame_delta) as u128;
    info!("frame delta: {} igt buffer: {} corrected frame delta: {}", frame_delta, IGT_BUFFER, corrected_frame_delta);
}

// FPS patch
// Sets the calculated frame delta to always be the target frame delta.
// It also sets the previous frames timestamp to be the current one minus the target frame delta.
// This makes it so the game always behaves as if it's running at the FPS limit, with slowdowns if the PC can't keep up.
// A second patch, "FPS history" below, is required in addition to this one to ensure accuracy.
unsafe extern "win64" fn fps(registers: *mut Registers, _:usize)
{
    if DS3_FPS_PATCH_ENABLED
    {
        let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

        let ptr_target_frame_delta = ptr_flipper.offset(0x18) as *mut f32; // Target frame delta - Set in a switch/case at the start
        let ptr_timestamp_previous = ptr_flipper.offset(0x20) as *mut u64; // Previous frames timestamp
        let ptr_timestamp_current = ptr_flipper.offset(0x28) as *mut u64; // Current frames timestamp
        let ptr_frame_delta = ptr_flipper.offset(0x264) as *mut f32; // Current frames frame delta
        let ptr_frame_delta_copy = ptr_flipper.offset(0x2b8) as *mut f32; // Current frames frame delta - Copy that's assigned differently than in ER, so we assign it manually too

        // Read target frame data, the current timestamp and then calculate the timestamp diff at stable FPS
        let target_frame_delta = std::ptr::read_volatile(ptr_target_frame_delta);
        let timestamp_current = std::ptr::read_volatile(ptr_timestamp_current);
        let timestamp_diff = (target_frame_delta * 10000000.0) as i32;

        // Calculate the previous timestamp, as well as the frame delta
        let timestamp_previous = timestamp_current - (timestamp_diff as u64);
        let frame_delta = (timestamp_diff as f32) / 10000000.0;

        // Write values back
        std::ptr::write_volatile(ptr_timestamp_previous, timestamp_previous);
        std::ptr::write_volatile(ptr_frame_delta, frame_delta);
        std::ptr::write_volatile(ptr_frame_delta_copy, frame_delta);
    }
}


// FPS history patch
// Similar to the FPS patch, this sets the difference between the previous and current frames timestamps to the target frame delta.
// This gets stored in an array with 32 elements, possibly for calculating FPS averages.
unsafe extern "win64" fn fps_history(registers: *mut Registers, _:usize)
{
    if DS3_FPS_PATCH_ENABLED
    {
        let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

        let ptr_target_frame_delta = ptr_flipper.offset(0x18) as *mut f32; // Target frame delta - Set in a switch/case at the start

        // Read the target frame delta and write back the calculated frame delta timestamp
        let target_frame_delta = std::ptr::read_volatile(ptr_target_frame_delta);
        (*registers).rax = (target_frame_delta * 10000000.0) as u64;
    }
}

// FPS custom limit patch
// This patch adjusts the target frame delta based on a custom set FPS limit.
// It is only active while the FPS patch is enabled too, and uses the default value if it's set to 0 or less.
// This does not allow you to go above the stock FPS limit. It is purely a QoL patch to improve glitch consistency, not an FPS unlocker.
unsafe extern "win64" fn fps_custom_limit(registers: *mut Registers, _:usize)
{
    if DS3_FPS_PATCH_ENABLED && DS3_FPS_CUSTOM_LIMIT > 0.0f32
    {
        let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

        let ptr_target_frame_delta = ptr_flipper.offset(0x18) as *mut f32; // Target frame delta - Set in a switch/case at the start

        // Read the stock target frame delta and calculate the custom target frame delta
        let target_frame_delta = std::ptr::read_volatile(ptr_target_frame_delta);
        let custom_target_frame_delta = 1.0f32 / DS3_FPS_CUSTOM_LIMIT;

        // Make sure the custom target frame delta is higher than the stock one, in order to avoid going above the stock FPS limit
        if custom_target_frame_delta > target_frame_delta
        {
            // Write values back
            std::ptr::write_volatile(ptr_target_frame_delta, custom_target_frame_delta);
        }
    }
}

// Frame advance patch
unsafe extern "win64" fn frame_advance(_registers: *mut Registers, _:usize)
{
    if DS3_FRAME_ADVANCE_ENABLED
    {
        DS3_FRAME_RUNNING = false;

        while !DS3_FRAME_RUNNING && DS3_FRAME_ADVANCE_ENABLED {
            thread::sleep(Duration::from_micros(10));
        }
    }
}