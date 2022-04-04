#![allow(dead_code)]

use crate::native::process::Process;

pub struct Pointer
{
    process: Box<dyn Process>,
    base_address: i64,
    offsets: Vec<i64>,
    is_64_bit: bool,
}


impl std::fmt::Display for Pointer {
    fn fmt(&self, f: &mut std::fmt::Formatter) -> std::fmt::Result
    {
        let mut str = Some(String::new());
        self.resolve_offsets(&self.offsets, &mut str);
        write!(f, "{}", str.unwrap())
    }
}


impl Pointer
{
    pub fn new(process: Box<dyn Process>, base_address: i64, offsets: Vec<i64>, is_64_bit: bool) -> Self
    {
        Pointer
        {
            process,
            base_address,
            offsets,
            is_64_bit,
        }
    }



    fn resolve_offsets(&self, offsets: &Vec<i64>, pointer_path: &mut Option<String>) -> i64
    {
        if let Some(p) = pointer_path { p.push_str(format!(" {:#08x?}", self.base_address).as_str()); }
        let mut ptr = self.base_address;

        for i in 0..offsets.len()
        {
            let offset = offsets[i];
            let address = ptr + offset;

            //Create a copy for debug output
            let debug_copy = ptr;

            //if not the last offset
            if i + 1 < offsets.len()
            {
                ptr = match self.is_64_bit
                {
                    true  => self.process.read_i64(address),
                    false => self.process.read_i32(address) as i64,
                };

                if let Some(ref mut p) = pointer_path { p.push_str(format!("\r\n[{:#08x?} + {:#08x?}]: {:#08x?}", debug_copy, offset, ptr).as_str()); }

                if ptr == 0
                {
                    return 0;
                }
            }
            else
            {
                ptr = address;
                if let Some(ref mut p) = pointer_path { p.push_str(format!("\r\n {:#08x?} + {:#08x?}: {:#08x?}", debug_copy, offset, ptr).as_str()); }
            }
        }
        return ptr;
    }


    //read/write ====================================================================================================================================================
    ///Read an i32 from the given address
    pub fn read_i32(&self, offset: Option<i64>) -> i32
    {
        let mut offsets_copy = self.offsets.clone();
        if let Some(o) = offset { offsets_copy.push(o); }
        let address = self.resolve_offsets(&offsets_copy, &mut None);
        return self.process.read_i32(address);
    }

    ///Read an i64 from the given address
    pub fn read_i64(&self, offset: Option<i64>) -> i64
    {
        let mut offsets_copy = self.offsets.clone();
        if let Some(o) = offset { offsets_copy.push(o); }
        let address = self.resolve_offsets(&offsets_copy, &mut None);
        return self.process.read_i64(address);
    }

    ///Read an u8 from the given address
    pub fn read_u8(&self, offset: Option<i64>) -> u8
    {
        let mut offsets_copy = self.offsets.clone();
        if let Some(o) = offset { offsets_copy.push(o); }
        let address = self.resolve_offsets(&offsets_copy, &mut None);
        return self.process.read_u8(address);
    }

    ///Read an u32 from the given address
    pub fn read_u32(&self, offset: Option<i64>) -> u32
    {
        let mut offsets_copy = self.offsets.clone();
        if let Some(o) = offset { offsets_copy.push(o); }
        let address = self.resolve_offsets(&offsets_copy, &mut None);
        return self.process.read_u32(address);
    }

    ///Read an u64 from the given address
    pub fn read_u64(&self, offset: Option<i64>) -> u64
    {
        let mut offsets_copy = self.offsets.clone();
        if let Some(o) = offset { offsets_copy.push(o); }
        let address = self.resolve_offsets(&offsets_copy, &mut None);
        return self.process.read_u64(address);
    }

    ///Read an f32 from the given address
    pub fn read_f32(&self, offset: Option<i64>) -> f32
    {
        let mut offsets_copy = self.offsets.clone();
        if let Some(o) = offset { offsets_copy.push(o); }
        let address = self.resolve_offsets(&offsets_copy, &mut None);
        return self.process.read_f32(address);
    }

    ///Read an f64 from the given address
    pub fn read_f64(&self, offset: Option<i64>) -> f64
    {
        let mut offsets_copy = self.offsets.clone();
        if let Some(o) = offset { offsets_copy.push(o); }
        let address = self.resolve_offsets(&offsets_copy, &mut None);
        return self.process.read_f64(address);
    }

    ///Read a bool from the given address
    pub fn read_bool(&self, offset: Option<i64>) -> bool
    {
        let mut offsets_copy = self.offsets.clone();
        if let Some(o) = offset { offsets_copy.push(o); }
        let address = self.resolve_offsets(&offsets_copy, &mut None);
        return self.process.read_bool(address);
    }

}
