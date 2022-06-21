#![feature(path_try_exists)]

use winapi::shared::minwindef::{BOOL, DWORD, HINSTANCE, LPVOID, TRUE};
use winapi::um::winnt::{DLL_PROCESS_ATTACH, DLL_PROCESS_DETACH};
use std::{fs, panic, thread};
use std::time::Duration;
use soulmemory_rs;
use soulmemory_rs::{Config, darksouls3, error, info, init_config, init_state, LevelFilter, serde_json, set_event_flag_exclusion, set_event_flag_log_mode};
use soulmemory_rs::append::console::ConsoleAppender;
use soulmemory_rs::append::file::FileAppender;
use soulmemory_rs::config::{Appender, Logger, Root};
use soulmemory_rs::encode::pattern::PatternEncoder;
use soulmemory_rs::websocket::{Message, read_command_str};

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
        init_state();

        //Alloc console, sets up stdout handles
        winapi::um::consoleapi::AllocConsole();

        //Start with a fresh logfile
        match fs::try_exists(r#"C:/temp/soulinjectee.log"#)
        {
            Ok(exists) =>
            {
                if exists
                {
                    fs::remove_file(r#"C:/temp/soulinjectee.log"#).unwrap();
                }
            }
            Err(_) => {}
        }

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
                .build("cli-rs", LevelFilter::Info))
            .logger(Logger::builder()
                .appender("log_file")
                .additive(false)
                .build("cli-rs::log_file", LevelFilter::Info))
            .build(Root::builder().appender("stdout").appender("log_file").build(LevelFilter::Info))
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


        soulmemory_rs::init();

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

        let command_str = read_command_str();
        if command_str.is_some()
        {
            let string = command_str.unwrap();
            let command_str = string.as_str();

            let result = serde_json::from_str::<Message>(command_str);
            match result
            {
                Ok(message) =>
                {
                    let message_type = message.MessageType.as_str();
                    match message_type
                    {
                        "unload" =>
                        {
                            info!("Attempting to unload");
                            soulmemory_rs::unload();
                        }

                        "DarkSouls3ReadEventFlagMessage" =>
                        {
                            let dark_souls3read_event_flag_message = message.DarkSouls3ReadEventFlagMessage.unwrap();
                            let result = darksouls3::get_event_flag
                            (
                                dark_souls3read_event_flag_message.SprjEventFlagManager,
                                dark_souls3read_event_flag_message.EventFlagId,
                                dark_souls3read_event_flag_message.State
                            );
                            info!("get_event_flag result: {:x}", result);
                        },

                        "EventFlagSetLogMode" =>
                        {
                            set_event_flag_log_mode(message.EventFlagLogMode);
                        }

                        "EventFlagSetExclusions" =>
                        {
                            set_event_flag_exclusion(message.EventFlags);
                        },

                        _ => info!("unsupported message type {}", message_type),
                    }
                }
                Err(_) => info!("Failed to parse: {}", command_str),
            }
        }
    }
}