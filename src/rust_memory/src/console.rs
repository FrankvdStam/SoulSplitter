use std::ptr;
use winapi::shared::minwindef::{DWORD, LPVOID};
use winapi::shared::ntdef::NULL;
use winapi::um::consoleapi::AllocConsole;
use winapi::um::consoleapi::ReadConsoleA;
use winapi::um::processenv::GetStdHandle;
use winapi::um::winbase::STD_INPUT_HANDLE;

pub fn console_test()
{
    unsafe
    {
        AllocConsole();
        let handle = GetStdHandle(STD_INPUT_HANDLE);

        loop
        {
            let mut buffer = vec![0u8; 1024];
            let mut read = 0;
            ReadConsoleA(handle, buffer.as_mut_ptr() as LPVOID, buffer.len() as DWORD, &mut read, ptr::null_mut());

            if read > 0
            {
                let str = String::from_utf8(buffer).unwrap();
                println!("read: {}", str);
            }


        }

    }
}