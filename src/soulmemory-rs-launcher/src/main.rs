// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

use std::env;
use mem_rs::prelude::Process;

fn get_arg(args: &Vec<String>, arg: &str) -> String
{
    let result = args.iter().find(|i| i.starts_with(arg)).expect(format!("--{arg} can't be empty").as_str());
    let split = result.split('=').collect::<Vec<&str>>();
    return String::from(split[1]);
}

//run --bin soulmemory-rs-launcher --target i686-pc-windows-msvc -- --processname=darksouls --dllpath="C:\projects\Dark souls\SoulSplitter\src\cli\bin\x64\Debug\net481\soulmemory_rs_x86.dll"
//run --bin soulmemory-rs-launcher --target x86_64-pc-windows-msvc -- --processname=eldenring --dllpath="C:\projects\Dark souls\SoulSplitter\src\cli\bin\x64\Debug\net481\soulmemory_rs_x64.dll"
fn main()
{
    let args: Vec<String> = env::args().collect();
    dbg!(&args);

    let process_name = get_arg(&args, "--processname");
    dbg!(&process_name);

    let dll_path = get_arg(&args, "--dllpath");
    dbg!(&dll_path);

    if let Some(process) = Process::get_running_process_names().iter().find(|p_name| p_name.to_lowercase() == process_name.to_lowercase() + ".exe")
    {
        let mut p = Process::new(process.to_lowercase().as_str());
        p.refresh().unwrap();
        p.inject_dll(dll_path.as_str()).unwrap();
    }
    else
    {
        println!("No supported process found");
    }
}
