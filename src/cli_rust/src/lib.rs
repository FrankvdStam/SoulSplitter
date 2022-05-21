use winapi::shared::minwindef::{BOOL, DWORD, HINSTANCE, LPVOID, TRUE};
use winapi::um::winnt::{DLL_PROCESS_ATTACH, DLL_PROCESS_DETACH};
use std::{panic, thread};
use rust_memory;
use rust_memory::websocket::{init_websocket_server, read_command};

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
        //Redirect panics
        panic::set_hook(Box::new(|i| {
            println!("panic");
            println!("{}", i);
        }));

        winapi::um::consoleapi::AllocConsole();

        init_websocket_server();
        //let handle = winapi::um::consoleapi::GetStdHandle();
        //winapi::um::consoleapi::ReadConsoleA(handle, )
        println!("Init");


        rust_memory::init();

        thread::spawn(main_loop);
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

fn main_loop()
{
    let command = read_command();
    if command.is_some()
    {
        let string = command.unwrap();
        let command_str = string.as_str();
        match command_str
        {
            "unload" =>
            {
                println!("Attempting to unload");
            }
            _ => println!("unknown command {}", command_str),
        }
    }
}