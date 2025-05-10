use iced_x86::{BlockEncoder, BlockEncoderOptions, Decoder, DecoderOptions, Formatter, Instruction, InstructionBlock, IntelFormatter};
use log::info;

pub struct Assembler{}

impl Assembler
{
    ///Copy and relocate a function with a single caller to avoid arxan anti-tamper from removing code hooks
    pub fn copy_relocate_fn_with_single_caller_x64(address: u64, size: u64, callsite_address: u64)
    {
        
        
        
        
        todo!();
    }
    
    pub fn disassemble_x64(data: &[u8], rip: u64, debug_info: bool) -> (Vec<Instruction>, usize)
    {
        let mut decoder = Decoder::with_ip(64, data, rip as u64, DecoderOptions::NONE);

        let mut formatter = IntelFormatter::new();
        let mut output = String::new();
        let mut size: usize = 0;
        let mut instructions: Vec<Instruction> = Vec::new();

        for instr in &mut decoder
        {
            if debug_info
            {
                output.clear();
                formatter.format(&instr, &mut output);
                info!("{}", output);
            }

            size += instr.len();
            instructions.push(instr);
        }
        return (instructions, size);
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


