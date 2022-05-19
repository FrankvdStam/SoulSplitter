use winapi::shared::minwindef::{BOOL, DWORD, HINSTANCE, LPVOID, TRUE};
use winapi::um::winnt::{DLL_PROCESS_ATTACH, DLL_PROCESS_DETACH};
use std::panic;
use rust_memory;

#[no_mangle]
#[allow(non_snake_case)]
pub unsafe extern "system" fn DllMain(
    _module: HINSTANCE,
    call_reason: DWORD,
    _reserved: LPVOID,
) -> BOOL
{
    if call_reason == DLL_PROCESS_ATTACH
    {
        winapi::um::consoleapi::AllocConsole();
        println!("Init");

        //Redirect panics
        panic::set_hook(Box::new(|i| {
            println!("panic");
            println!("{}", i);
        }));

        rust_memory::init();
    }

    if call_reason == DLL_PROCESS_DETACH
    {
        println!("Exit");

        //exit active detours
        //detours::exit();

        //close console
        winapi::um::wincon::FreeConsole();
    }
    TRUE
}