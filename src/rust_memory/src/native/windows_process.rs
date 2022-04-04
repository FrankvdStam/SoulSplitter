use winapi::um::memoryapi::{ReadProcessMemory, WriteProcessMemory};
use winapi::um::processthreadsapi::OpenProcess;
use winapi::um::winnt::{PROCESS_VM_READ, PROCESS_QUERY_INFORMATION, PROCESS_VM_WRITE, CHAR};
use winapi::um::tlhelp32::{CreateToolhelp32Snapshot, Module32First, Module32Next, MODULEENTRY32, TH32CS_SNAPMODULE};

use sysinfo::{Pid, PidExt, System, SystemExt, ProcessExt, RefreshKind, ProcessRefreshKind};

use std::ffi::{c_void, CStr};
use std::mem::{MaybeUninit, size_of};
use winapi::shared::minwindef::DWORD;
use winapi::um::handleapi::{CloseHandle, INVALID_HANDLE_VALUE};

use crate::native::process::Process;

pub struct WindowsProcess
{
    process_names: Vec<String>,
    system_info: System,

    base_address: Option<i64>,
    pid: Option<usize>,
    handle: Option<*mut c_void>,
}

impl WindowsProcess
{
    ///Create a new windows specific instance
    pub fn new(process_names: Vec<String>) -> Self
    {
        let mut process = WindowsProcess
        {
            process_names,
            system_info: System::new_with_specifics(RefreshKind::new().with_processes(ProcessRefreshKind::everything())),

            base_address: None,
            pid: None,
            handle: None,
        };

        process.refresh();

        return process;
    }
}


impl Process for WindowsProcess
{
    ///Refresh the windows specific instance - deals with re-attaching to the correct process
    fn refresh(&mut self)
    {
        if let Some(pid) = self.pid
        {
            if self.system_info.refresh_process_specifics(Pid::from(pid), ProcessRefreshKind::everything())
            {
                if self.system_info.process(Pid::from(pid)).is_none()
                {
                    self.pid = None;
                    self.handle = None;
                    self.base_address = None;
                }
            }
            else
            {
                self.pid = None;
                self.handle = None;
                self.base_address = None;
            }
        }
        else
        {
            self.system_info.refresh_processes();
            match self.system_info.processes().iter().find_map(|(_, val)| if self.process_names.contains(&String::from(val.name())) {Some(val)} else { None})
            {
                Some(p) =>
                {
                    self.pid = Some(p.pid().as_u32() as usize);
                    self.handle = unsafe { Some(OpenProcess(PROCESS_VM_READ | PROCESS_VM_WRITE | PROCESS_QUERY_INFORMATION, 0, p.pid().as_u32())) };
                }
                None => return,
            };
        }
    }

    fn read_memory(&self, address: i64, buffer: &mut [u8]) -> bool
    {
        if self.handle.is_none()
        {
            return false;
        }

        let mut read_bytes = 0;
        let result = unsafe { ReadProcessMemory(self.handle.expect("Process handle is none"), address as *mut c_void, buffer.as_mut_ptr() as *mut c_void, buffer.len(), &mut read_bytes) };
        return result != 0 && read_bytes == buffer.len();
    }

    fn write_memory(&self, address: i64, buffer: &[u8]) -> bool
    {
        if self.handle.is_none()
        {
            return false;
        }

        let mut wrote_bytes = 0;
        let result = unsafe { WriteProcessMemory(self.handle.expect("Process handle is none"), address as *mut c_void, buffer.as_ptr() as *mut c_void, buffer.len(), &mut wrote_bytes) };
        return result != 0 && wrote_bytes == buffer.len();
    }


    fn get_code(&mut self) -> Vec<u8>
    {
        if self.pid.is_some()
        {
            let mut module_size = 0;
            let mut base_address = 0;

            if get_module(self.pid.expect("pid none"), &self.process_names, &mut module_size, &mut base_address)
            {
                self.base_address = Some(base_address);
                let mut buffer: Vec<u8> = vec![0; module_size as usize];
                self.read_memory(base_address, buffer.as_mut_slice());
                return buffer;
            }
        }
        return Vec::new();
    }

    fn get_base_address(&self) -> i64
    {
        if let Some(a) = self.base_address
        {
            return a;
        }
        return 0;
    }
}


fn get_module(pid: usize, module_names: &Vec<String>, module_size: &mut i64, base_address: &mut i64) -> bool
{
    unsafe
    {
        let mut module_entry = MaybeUninit::<MODULEENTRY32>::uninit();
        module_entry.assume_init().dwSize = size_of::<MODULEENTRY32>() as u32;

        let handle_snap = CreateToolhelp32Snapshot(TH32CS_SNAPMODULE, pid as DWORD);
        Module32First(handle_snap, module_entry.as_mut_ptr() as *mut _);
        if handle_snap == INVALID_HANDLE_VALUE
        {
            CloseHandle(handle_snap);
            return false
        }

        loop
        {
            let str = char_array_to_string(&module_entry.assume_init().szModule);

            if module_names.contains(&str)
            {
                *module_size  = module_entry.assume_init().modBaseSize as i64;
                *base_address = module_entry.assume_init().modBaseAddr as i64;
                return true;
            }

            let next_result = Module32Next(handle_snap, module_entry.as_mut_ptr() as *mut _);
            if next_result != 1
            {
                CloseHandle(handle_snap);
                break;
            }
        }
        return false;
    }
}

unsafe fn str_from_null_terminated_utf8(s: &[u8]) -> &str {
    CStr::from_ptr(s.as_ptr() as *const _).to_str().unwrap()
}

fn str_from_null_terminated_utf8_safe(s: &[u8]) -> &str {
    if s.iter().any(|&x| x == 0) {
        unsafe { str_from_null_terminated_utf8(s) }
    } else {
        std::str::from_utf8(s).unwrap()
    }
}

unsafe fn char_array_to_string(char_array: &[CHAR]) -> String {
    let data: Vec<u8> = char_array.iter().map(|&c| c as u8).collect();
    let data = str_from_null_terminated_utf8_safe(&data);
    data.to_ascii_lowercase()
}


#[cfg(test)]
mod tests {
    use crate::native::windows_process::WindowsProcess;
    use crate::native::process::Process;

    #[test]
    pub fn testy()
    {
    }
}
