use winapi::shared::minwindef::{BOOL, DWORD, HINSTANCE, LPVOID, TRUE};
use winapi::um::winnt::{DLL_PROCESS_ATTACH, DLL_PROCESS_DETACH};
use std::{panic, thread};
use std::time::Duration;
use rust_memory;
use rust_memory::{Config, error, info, init_config, LevelFilter, unload, warn};
use rust_memory::append::console::ConsoleAppender;
use rust_memory::append::file::FileAppender;
use rust_memory::config::{Appender, Logger, Root};
use rust_memory::encode::pattern::PatternEncoder;
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
        //Alloc console, sets up stdout handles
        winapi::um::consoleapi::AllocConsole();

        //Setup logger
        let stdout = ConsoleAppender::builder()
            .encoder(Box::new(PatternEncoder::new("{d(%Y-%m-%d %H:%M:%S%.3f)} - {m}{n}")))
            .build();

        let requests = FileAppender::builder()
            .encoder(Box::new(PatternEncoder::new("{d(%Y-%m-%d %H:%M:%S%.3f)} - {m}{n}")))
            .build(r#"C:/temp/soulinjectee.log"#)
            .unwrap();

        let config = Config::builder()
            .appender(Appender::builder().build("stdout", Box::new(stdout)))
            .appender(Appender::builder().build("log_file", Box::new(requests)))
            .logger(Logger::builder()
                .build("cli_rust", LevelFilter::Trace))
            .logger(Logger::builder()
                .appender("log_file")
                .additive(false)
                .build("cli_rust::log_file", LevelFilter::Trace))
            .build(Root::builder().appender("stdout").appender("log_file").build(LevelFilter::Trace))
            .unwrap();

        let _handle = init_config(config).unwrap();

        //Redirect panics
        panic::set_hook(Box::new(|i| {
            error!("panic");
            error!("{}", i);
            //error!(target: "log_file", "panic");
            //error!(target: "log_file", "{}", i);
        }));


        //let handle = winapi::um::consoleapi::GetStdHandle();
        //winapi::um::consoleapi::ReadConsoleA(handle, )
        info!("Init");


        rust_memory::init();

        thread::spawn(main_loop);
    }

    if call_reason == DLL_PROCESS_DETACH
    {
        info!("Exiting");

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

        let command = read_command();
        if command.is_some()
        {
            let string = command.unwrap();
            let command_str = string.as_str();
            match command_str
            {
                "unload" =>
                {
                    info!("Attempting to unload");
                    unload();
                }
                _ => warn!("unknown command {}", command_str),
            }
        }
    }
}