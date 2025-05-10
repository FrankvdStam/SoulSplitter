use std::{ptr, slice};
use iced_x86::code_asm::CodeAssembler;
use ilhook::x64::{CallbackOption, HookFlags, HookPoint, HookType, Hooker, Registers};
use log::info;
use mem_rs::helpers::{scan, to_pattern};
use mem_rs::prelude::*;
use windows::Win32::System::Threading::GetCurrentProcess;
use crate::util::{Assembler, Memory};

static mut INCREMENT_IGT: Option<HookPoint> = None;

static mut IGT_BUFFER: f32 = 0.0f32;

//original size is 799, for safety incremented to 1000
const IGT_CODE_SIZE: usize = 1000;

pub fn ds3_init_migt(process: &Process)
{
    let modules = unsafe{ Process::get_process_modules(GetCurrentProcess()) };
    let module = match modules.iter().find(|i| i.name.to_lowercase() == "darksoulsiii.exe")
    {
        None => panic!("failed to find executable base address"),
        Some(module) => module
    };
    info!("executable base address: 0{:x}", module.base_address);
    
    //scan for relevant code
    let game_increment_igt_fn_address = process.scan_abs("igt_fn", "48 83 ec 68 48 c7 44 24 20 fe ff ff ff 0f 29 74 24 50", 0, Vec::new()).unwrap().get_base_address();
    let game_increment_igt_fn_address_end = process.scan_abs("igt_fn_end", "0f 28 74 24 50 44 0f 28 4c 24 40 48 83 c4 ? c3", 0, Vec::new()).unwrap().get_base_address();
    
    
    
    let game_increment_igt_callsite_address = process.scan_abs("call igt_fn", "85 ? 7f ? b2 ? 33 c9 e8 ? ? ? ? c6 83 ? ? ? ? ? f3 0f 10 47 ? e8", 25, Vec::new()).unwrap().get_base_address();
    
    info!("game_increment_igt_fn_address at 0x{:x}", game_increment_igt_fn_address);
    info!("game_increment_igt_fn_address_end at 0x{:x}", game_increment_igt_fn_address_end);
    info!("game_increment_igt_callsite_address 0x{:x}", game_increment_igt_callsite_address);

    //get the raw bytes of the IGT increment code, this function is protected by arxan
    let mut igt_code_slice: &[u8] = unsafe { slice::from_raw_parts(game_increment_igt_fn_address as *const u8, IGT_CODE_SIZE) };
    let code_end_offset = scan(igt_code_slice, &to_pattern("44 0f 28 4c 24 40 48 83 c4 ? c3")).unwrap() + 11;
    igt_code_slice = &igt_code_slice[0..code_end_offset];

    //offset for the migt hook, need this later
    let igt_hook_offset = scan(igt_code_slice, &to_pattern("f3 48 0f 2c c0")).unwrap();
    
    let (instructions, required_byte_size) = Assembler::disassemble_x64(igt_code_slice, game_increment_igt_fn_address as u64, false);
    info!("disassembled: {}", instructions.len());
    
    //required size is now known, need to allocate first to obtain a new RIP address
    let replaced_igt_func = Memory::allocate_near_target(module.base_address, 1_000_000_000usize, required_byte_size).unwrap();

    //re-assemble instructions with new RIP
    let reassembled_igt_code_buffer = Assembler::reassemble_x64(&instructions, replaced_igt_func as u64);
    
    info!("reassembled code size: {}", reassembled_igt_code_buffer.len());
    info!("writing to: 0{:x?}", replaced_igt_func);
    for i in 0..reassembled_igt_code_buffer.len()
    {
        unsafe { ptr::write_volatile((replaced_igt_func + i) as *mut u8, reassembled_igt_code_buffer[i]) };
    }

    let mut a = CodeAssembler::new(64).unwrap();
    a.call(replaced_igt_func as u64).unwrap();

    let result = a.assemble(game_increment_igt_callsite_address as u64).unwrap();
    info!("assembled call instr: {:x?}", result);

    //patch the callsite
    for  i in 0..result.len()
    {
        unsafe {  ptr::write_volatile((game_increment_igt_callsite_address + i) as *mut u8, result[i]) };
    }

    //now hook the replaced function
    unsafe { INCREMENT_IGT = Some(Hooker::new(replaced_igt_func + igt_hook_offset, HookType::JmpBack(increment_igt_hook), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap()) };
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
    //info!("frame delta: {} igt buffer: {} corrected frame delta: {}", frame_delta, IGT_BUFFER, corrected_frame_delta);
}