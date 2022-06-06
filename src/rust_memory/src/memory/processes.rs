use std::ffi::c_void;
use std::intrinsics::size_of;
use std::path::Path;
use std::slice;
use log::info;
use winapi::ctypes::c_char;
use winapi::shared::minwindef::{DWORD, FALSE, HINSTANCE, HMODULE, LPCVOID, LPDWORD, LPVOID, MAX_PATH};
use winapi::shared::ntdef::NULL;
use winapi::um::memoryapi::{VirtualAllocEx, VirtualFreeEx, WriteProcessMemory};
use winapi::um::processthreadsapi::{CreateRemoteThread, GetCurrentProcess, GetCurrentProcessId, OpenProcess};
use winapi::um::psapi::{EnumProcesses, EnumProcessModules, GetModuleFileNameExA, GetModuleInformation, MODULEINFO};
use winapi::um::winnt;
use winapi::um::winnt::{HANDLE, LPCSTR, MEM_COMMIT, MEM_RELEASE, MEM_RESERVE, PAGE_READWRITE};
use winapi::um::libloaderapi::GetProcAddress;
use winapi::um::libloaderapi::GetModuleHandleA;
use winapi::um::minwinbase::{LPSECURITY_ATTRIBUTES, PTHREAD_START_ROUTINE};
use winapi::um::synchapi::WaitForSingleObject;
use winapi::um::libloaderapi::FreeLibrary;
use winapi::um::libloaderapi::FreeLibraryAndExitThread;


pub struct Process
{
    pub id: usize,
    pub handle: usize,
    pub path: String,
    pub name: String,

    pub main_module: Option<ProcessModule>,
    pub modules: Vec<ProcessModule>,
}

pub struct ProcessModule
{
    pub id: usize,
    pub path: String,
    pub name: String,

    pub base: usize,
    pub size: usize,

    pub memory_dump: Vec<u8>,
}

impl Process
{
    pub fn get_active_processes() -> Vec<Process>
    {
        unsafe
        {
            let mut result = Vec::new();

            let mut process_ids = [0u32; 2048];
            //let mut process_ids = Vec::<u32>::with_capacity(2048);
            let mut out_size = 0;
            if EnumProcesses(process_ids.as_mut_ptr(), (process_ids.len() * size_of::<u32>()) as u32, &mut out_size) == FALSE
            {
                return result;
            }

            let count = out_size as usize / std::mem::size_of::<u32>();
            for i in 0..count
            {
                let pid = process_ids[i];

                let mut mod_name = [0; MAX_PATH];

                let handle = OpenProcess(
                    winnt::PROCESS_QUERY_INFORMATION
                    | winnt::PROCESS_VM_READ
                    | winnt::PROCESS_VM_WRITE
                    | winnt::PROCESS_VM_OPERATION,
                    FALSE,
                    pid,
                );

                if GetModuleFileNameExA(handle, 0 as HMODULE, mod_name.as_mut_ptr(), MAX_PATH as u32) != 0
                {
                    let len  = mod_name.iter().position(|&r| r == 0).unwrap();
                    let path = String::from_utf8(mod_name[0..len].iter().map(|&c| c as u8).collect()).unwrap();
                    let filename = String::from(Path::new(&path).file_name().unwrap().to_str().unwrap());
                    result.push(Process::new(pid as usize, handle as usize, path, filename));
                }
            }

            return result;
        }
    }

    pub fn get_current_process() -> Result<Self, ()>
    {
        unsafe
        {
            let process_id = GetCurrentProcessId();
            let handle = GetCurrentProcess();

            //let handle = OpenProcess(
            //    winnt::PROCESS_QUERY_INFORMATION
            //        | winnt::PROCESS_VM_READ
            //        | winnt::PROCESS_VM_WRITE
            //        | winnt::PROCESS_VM_OPERATION,
            //    FALSE,
            //    process_id as DWORD
            //);

            let mut mod_name = [0; MAX_PATH];
            if GetModuleFileNameExA(handle, 0 as HMODULE, mod_name.as_mut_ptr(), MAX_PATH as u32) != 0
            {
                let len  = mod_name.iter().position(|&r| r == 0).unwrap();
                let path = String::from_utf8(mod_name[0..len].iter().map(|&c| c as u8).collect()).unwrap();
                let filename = String::from(Path::new(&path).file_name().unwrap().to_str().unwrap());
                return Ok(Process::new(process_id as usize, handle as usize, path, filename));
            }
            Err(())
        }
    }

    pub fn new(id: usize, handle: usize, path: String, name: String) -> Self { Process { id, handle, path, name, main_module: None, modules: Vec::new() } }

    pub fn load_modules(&mut self)
    {
        self.modules = ProcessModule::get_process_modules(self);
        self.main_module = Some(self.modules[0].clone());
    }

    pub fn inject_dll(&mut self, path: &str)
    {
        unsafe
        {
            //First check if the module is already loaded. If that is the case, unload it first.
            let file_name = Path::new(&path).file_name().unwrap().to_os_string().into_string().unwrap();
            self.load_modules();
            for module in &self.modules
            {
                if module.name == file_name
                {
                    module.unload();
                }
            }

            let path_null = path.clone().to_owned() + "\0";

            //Allocate memory for a path to the DLL to inject and write the path to it.
            let strlen_bytes = (path_null.len() + 1) * size_of::<c_char>();
            let dll_path_ptr = VirtualAllocEx(self.handle as HANDLE, 0 as LPVOID, strlen_bytes, MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);
            let mut bytes_written = 0;
            let bytes = path_null.as_bytes();
            WriteProcessMemory(self.handle as HANDLE, dll_path_ptr, bytes.as_ptr() as LPCVOID, strlen_bytes, &mut bytes_written);

            let module_name = "kernel32.dll\0".as_bytes();
            let load_library_a = "LoadLibraryA\0".as_bytes();
            let load_library_a_address = GetProcAddress(GetModuleHandleA(module_name.as_ptr() as LPCSTR), load_library_a.as_ptr() as LPCSTR);

            let pthread_start_routine: PTHREAD_START_ROUTINE = std::mem::transmute(load_library_a_address as *const PTHREAD_START_ROUTINE);

            let thread = CreateRemoteThread(self.handle as HANDLE, 0 as LPSECURITY_ATTRIBUTES, 0, pthread_start_routine, dll_path_ptr, 0, 0 as LPDWORD);
            let result = WaitForSingleObject(thread, 10000);
            info!("res {}", result);

            VirtualFreeEx(self.handle as HANDLE, dll_path_ptr, 0, MEM_RELEASE);
        }
    }
}

impl ProcessModule
{
    pub fn new(id: usize, path: String, name: String, base: usize, size: usize) -> Self { ProcessModule { id, path, name, base, size, memory_dump: Vec::new() } }

    pub fn memory_dump(&mut self)
    {
        unsafe
        {
            let slice = slice::from_raw_parts(self.base as *mut u8, self.size);
            let mut vec = vec![0u8; self.size];
            vec.copy_from_slice(slice);
            self.memory_dump = vec;
        }
    }

    pub fn get_process_modules(process: &mut Process) -> Vec<ProcessModule>
    {
        unsafe
        {
            let mut result = Vec::new();

            let process_handle = process.handle as HANDLE;

            //Get amount of hmodules in current process
            let mut required_size: u32 = 0;
            EnumProcessModules(process_handle, 0 as *mut HMODULE, 0, &mut required_size);
            let size = (required_size / size_of::<HINSTANCE>() as u32) as u32;

            //Get modules
            let mut modules: Vec<HINSTANCE> = vec![NULL as HINSTANCE; size as usize];
            EnumProcessModules(process_handle, modules.as_mut_ptr(), required_size.clone(), &mut required_size);

            for i in 0..modules.len()
            {
                let mut mod_name = [0; MAX_PATH];

                if GetModuleFileNameExA(process_handle, modules[i as usize], mod_name.as_mut_ptr(), MAX_PATH as u32) != 0
                {
                    let len  = mod_name.iter().position(|&r| r == 0).unwrap();
                    let file_path = String::from_utf8(mod_name[0..len].iter().map(|&c| c as u8).collect()).unwrap();
                    let file_name = Path::new(&file_path).file_name().unwrap().to_os_string().into_string().unwrap();

                    let mut info: MODULEINFO = MODULEINFO
                    {
                        lpBaseOfDll: 0 as *mut c_void,
                        SizeOfImage: 0,
                        EntryPoint: 0 as *mut c_void,
                    };

                    if GetModuleInformation(process_handle, modules[i as usize], &mut info, size_of::<MODULEINFO>() as u32) == 1
                    {
                        let module_base = info.lpBaseOfDll as usize;
                        let module_size = info.SizeOfImage as usize;

                        result.push(ProcessModule::new(modules[i as usize] as usize, file_path, file_name, module_base, module_size));
                    }
                }
            }
            return result;
        }
    }

    pub fn unload(&self)
    {
        unsafe
        {
            FreeLibraryAndExitThread(self.id as HINSTANCE, 0);
        };
    }
}

impl Clone for ProcessModule
{
    fn clone(&self) -> Self  { ProcessModule::new(self.id, self.path.clone(), self.name.clone(), self.base, self.size) }
}