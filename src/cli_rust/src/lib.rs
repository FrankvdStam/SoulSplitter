use winapi::shared::minwindef::{BOOL, DWORD, HINSTANCE, LPVOID, TRUE};
use winapi::um::winnt::{DLL_PROCESS_ATTACH, DLL_PROCESS_DETACH};
use std::{panic, thread};
use std::time::Duration;
use rust_memory;
use rust_memory::unload;
use rust_memory::websocket::{read_command};

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

        //let handle = winapi::um::consoleapi::GetStdHandle();
        //winapi::um::consoleapi::ReadConsoleA(handle, )
        println!("Init");


        rust_memory::init();

        thread::spawn(main_loop);
    }

    if call_reason == DLL_PROCESS_DETACH
    {
        println!("Exiting");

        //exit active detours
        //detours::exit();

        //close console
        winapi::um::wincon::FreeConsole();
    }
    TRUE
}

fn main_loop()
{
    loop
    {
        thread::sleep(Duration::from_millis(100));
        println!("loop");

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
                    unload();
                }
                _ => println!("unknown command {}", command_str),
            }
        }
    }
}