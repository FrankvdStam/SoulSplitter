#![allow(unreachable_code)]
#![allow(dead_code)]
#![allow(unused_imports)]


use std::fs;
use std::path::{Path, PathBuf};
use detour::GenericDetour;

use rust_memory::pattern_scanner::{scan, to_pattern};
use rust_memory::pointer::Pointer;
use rust_memory::processes::Process;
use rust_memory::scan_cache::scan_absolute;
use rust_memory::websocket::{init_websocket_server, read_command_str, write_command};

fn main()
{
    let exe_path = std::env::current_exe().unwrap().as_path().to_owned();
    let dir = Path::parent(&exe_path).unwrap().join("soulinjectee.dll");
    let dll_path = fs::canonicalize(dir).unwrap().to_str().unwrap().to_owned();

    let processes = Process::get_active_processes();
    for mut p in processes
    {
        let process_name = p.name.to_lowercase();
        let games = vec!
        {
            "darksoulsremastered.exe",
            "darksoulsii.exe",
            "darksoulsiii.exe",
            "sekiro.exe",
            "eldenring.exe",
        };

        if games.contains(&process_name.as_str())
        {
            p.inject_dll(&dll_path);
        }
    }
}



fn testy()
{
    //scan_absolute();
    return;

    let elden_ring_names = vec![String::from("eldenring.exe"), String::from("start_protected_game.exe")];
    let mut process = rust_memory::create_process(elden_ring_names);

    let code = process.get_code();


    //let address = scan(&code, &to_pattern("44 8b 41 1c 44 8b da 33 d2 41 8b c3 41 f7 f0 4c 8b d1 45 33 c9 44 0f af c0 45 2b d8 4c 8b 41 38 49 8b d0 49 8b 48 08 44 38 49 19")));

    //println!("{:#08x?}", scan(&code, &to_pattern("48 8b 05 ? ? ? ? 4c 8b 40 08 4d 85 c0 74 0d 45 0f b6 80 be 00 00 00 e9 13 00 00 00")));
    //println!("{:#08x?}", scan(&code, &to_pattern("48 8b 05 ? ? ? ? 48 89 98 70 84 01 00 4c 89 ab 74 06 00 00 4c 89 ab 7c 06 00 00 44 88 ab 84 06 00 00 41 83 7f 4c 00")));
    println!("{:#08x?}", scan(&code, &to_pattern("48 8b 0d ? ? ? ? 48 8b 53 08 48 8b 92 d8 00 00 00 48 83 c4 20 5b")));
    //println!("{:#08x?}", scan(&code, &to_pattern("48 c7 44 24 20 fe ff ff ff 0f 29 74 24 40 0f 28 f0 48 8b 0d ? ? ? ? 0f 28 c8 f3 0f 59 0d ? ? ? ?")));
    //println!("{:#08x?}", scan(&code, &to_pattern("48 8b c4 55 57 41 56 48 8d 68 b8 48 81 ec 30 01 00 00 48 c7 44 24 40 fe ff ff ff 48 89 58 18 48 89 70 20")));

    let base = process.get_base_address();
    let ptr = Pointer::new(process, base + scan(&code, &to_pattern("48 8b 0d ? ? ? ? 48 8b 53 08 48 8b 92 d8 00 00 00 48 83 c4 20 5b")).unwrap(), vec![0x0], true);

    println!("{}", base);
    println!("{}", ptr);
    println!("{}", ptr.read_u8(Some(1832)));

    return;
    loop
    {
        process.refresh();
        println!("{}", process.read_i32(0x7FF47B6C0200));
    }
}

