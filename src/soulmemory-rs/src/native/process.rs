
pub trait Process
{
    fn refresh(&mut self);
    fn read_memory(&self, address: usize, buffer: &mut [u8])-> bool;
    fn write_memory(&self, address: usize, buffer: &[u8]) -> bool;

    fn get_name(&self) -> String;
    fn get_code(&mut self) -> &Vec<u8>;
    fn get_base_address(&self) -> usize;

    fn inject_dll(&mut self, path: &str);
    fn unload_module(&mut self, module_name: String);

    ///Read an i32 from the given address
    fn read_i32(&self, address: usize) -> i32
    {
        let mut buffer = [0; 4];
        self.read_memory(address, &mut buffer);
        return i32::from_ne_bytes(buffer);
    }

    ///Read an i64 from the given address
    fn read_i64(&self, address: usize) -> i64
    {
        let mut buffer = [0; 8];
        self.read_memory(address, &mut buffer);
        return i64::from_ne_bytes(buffer);
    }

    ///Read an u8 from the given address
    fn read_u8(&self, address: usize) -> u8
    {
        let mut buffer = [0; 1];
        self.read_memory(address, &mut buffer);
        return buffer[0];
    }

    ///Read an u32 from the given address
    fn read_u32(&self, address: usize) -> u32
    {
        let mut buffer = [0; 4];
        self.read_memory(address, &mut buffer);
        return u32::from_ne_bytes(buffer);
    }

    ///Read an u64 from the given address
    fn read_u64(&self, address: usize) -> u64
    {
        let mut buffer = [0; 8];
        self.read_memory(address, &mut buffer);
        return u64::from_ne_bytes(buffer);
    }

    ///Read an f32 from the given address
    fn read_f32(&self, address: usize) -> f32
    {
        let mut buffer = [0; 4];
        self.read_memory(address, &mut buffer);
        return f32::from_ne_bytes(buffer);
    }

    ///Read an f64 from the given address
    fn read_f64(&self, address: usize) -> f64
    {
        let mut buffer = [0; 8];
        self.read_memory(address, &mut buffer);
        return f64::from_ne_bytes(buffer);
    }

    ///Read a bool from the given address
    fn read_bool(&self, address: usize) -> bool
    {
        let mut buffer = [0; 1];
        self.read_memory(address, &mut buffer);
        return buffer[0] != 0;
    }
}