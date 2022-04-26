use std::mem::{size_of};
use std::ffi::{c_void};
use winapi::shared::minwindef::{HINSTANCE, HMODULE, MAX_PATH};
use winapi::shared::ntdef::{NULL};
use winapi::um::processthreadsapi::GetCurrentProcess;
use winapi::um::psapi::{EnumProcessModules, GetModuleFileNameExA, GetModuleInformation, MODULEINFO};
use crate::pattern_scanner::{scan, to_pattern};

fn init_scan_cache()
{
    unsafe
    {
        let process_id = GetCurrentProcess();

        //Get amount of hmodules in current process
        let mut required_size: u32 = 0;
        EnumProcessModules(process_id, 0 as *mut HMODULE, 0, &mut required_size);
        let size = (required_size / size_of::<HINSTANCE>() as u32) as u32;

        //Get modules
        let mut modules: Vec<HINSTANCE> = vec![NULL as HINSTANCE; size as usize];
        EnumProcessModules(process_id, modules.as_mut_ptr(), required_size.clone(), &mut required_size);

        for i in 0..modules.len()
        {
            let mut mod_name = [0; MAX_PATH];

            if GetModuleFileNameExA(process_id, modules[i as usize], mod_name.as_mut_ptr(), MAX_PATH as u32) != 0
            {
                let len  = mod_name.iter().position(|&r| r == 0).unwrap();
                let name = String::from_utf8(mod_name[0..len].iter().map(|&c| c as u8).collect()).unwrap();

                if name.ends_with("eldenring.exe")
                {
                    let mut info: MODULEINFO = MODULEINFO
                    {
                        lpBaseOfDll: 0 as *mut c_void,
                        SizeOfImage: 0,
                        EntryPoint: 0 as *mut c_void,
                    };

                    if GetModuleInformation(process_id, modules[i as usize], &mut info, size_of::<MODULEINFO>() as u32) == 1
                    {
                        println!("{}", name);

                        let module_base = info.lpBaseOfDll as usize;
                        let module_size = info.SizeOfImage as usize;

                        println!("0x{:x}", module_base);
                        println!("{}", module_size);

                        let result: Vec<u8> = Vec::from_raw_parts(module_base as *mut u8, module_size, module_size);
                        println!("pattern scan cache size: {}", result.len());

                        MODULE_BASE = module_base;
                        MODULE_SIZE = module_size;
                        MODULE_BYTES = result;
                        MODULE_INIT = true;
                    }
                }
            }
        }
    }
}

static mut MODULE_INIT: bool = false;
static mut MODULE_BASE: usize = 0;
static mut MODULE_SIZE: usize = 0;
static mut MODULE_BYTES: Vec<u8> = Vec::new();

pub fn scan_absolute(str: &str) -> Result<usize, ()>
{
    unsafe
    {
        if !MODULE_INIT
        {
            init_scan_cache();
            if !MODULE_INIT
            {
                return Err(());
            }
        }

        let scan_result = scan(&MODULE_BYTES, &to_pattern(str));
        if scan_result.is_some()
        {
            return Ok(MODULE_BASE + scan_result.unwrap());
        }
        return Err(());
    }
}