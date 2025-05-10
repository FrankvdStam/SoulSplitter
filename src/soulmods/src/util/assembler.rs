use std::ptr;
use iced_x86::{BlockEncoder, BlockEncoderOptions, Decoder, DecoderOptions, Formatter, Instruction, InstructionBlock, IntelFormatter};
use iced_x86::code_asm::CodeAssembler;
use log::info;
use crate::util::Memory;

pub struct Assembler{}

impl Assembler
{
    ///Copy and relocate a function with a single caller to avoid arxan anti-tamper from removing code hooks
    pub fn copy_relocate_fn_with_single_caller_x64(data: &[u8], rip: u64, callsite_address: u64, debug_info: bool) -> usize
    {
        //disassemble original bytes
        let instructions = Assembler::disassemble_x64(data, rip, debug_info);
        
        //allocate near the callsite, technically should be the address of the original code but the callsite probably will be close enough. The range can also be increment in case of problems
        let replacement_function_address = Memory::allocate_near_target(callsite_address as usize, 1_000_000_000usize, data.len()).unwrap();
        
        //reassemble instructions with a new RIP value
        let reassembled = Assembler::reassemble_x64(&instructions, replacement_function_address as u64);

        //write replacement function to memory
        for  i in 0..reassembled.len()
        {
            unsafe {  ptr::write_volatile((replacement_function_address + i) as *mut u8, reassembled[i]) };
        }

        //assemble a patched call instruction for the callsite
        let mut a = CodeAssembler::new(64).unwrap();
        a.call(replacement_function_address as u64).unwrap();
        let assembled_call = a.assemble(callsite_address as u64).unwrap();

        //patch the callsite
        for  i in 0..assembled_call.len()
        {
            unsafe {  ptr::write_volatile((callsite_address as usize + i) as *mut u8, assembled_call[i]) };
        }
        
        return replacement_function_address;
    }
    
    pub fn disassemble_x64(data: &[u8], rip: u64, debug_info: bool) -> Vec<Instruction>
    {
        let mut decoder = Decoder::with_ip(64, data, rip as u64, DecoderOptions::NONE);

        let mut formatter = IntelFormatter::new();
        let mut output = String::new();
        let mut instructions: Vec<Instruction> = Vec::new();

        for instr in &mut decoder
        {
            if debug_info
            {
                output.clear();
                formatter.format(&instr, &mut output);
                info!("{}", output);
            }
            instructions.push(instr);
        }
        return instructions;
    }
    
    pub fn reassemble_x64(instructions: &Vec<Instruction>, rip: u64) -> Vec<u8>
    {
        let block = InstructionBlock::new(&instructions, rip as u64);
        // This method can also encode more than one block but that's rarely needed, see above comment.
        let result = match BlockEncoder::encode(64, block, BlockEncoderOptions::NONE) {
            Err(err) => panic!("{}", err),
            Ok(result) => result,
        };
        return result.code_buffer;        
    }
}


