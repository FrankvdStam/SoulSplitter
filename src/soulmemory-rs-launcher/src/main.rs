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

use mem_rs::prelude::Process;

#[cfg(target_pointer_width = "64")]
const X64: bool = true;

#[cfg(target_pointer_width = "32")]
const X64: bool = false;

fn main()
{
    let games = vec!
    {
        String::from("darksoulsremastered.exe"),
        String::from("darksouls.exe"),
        String::from("darksoulsii.exe"),
        String::from("darksoulsiii.exe"),
        String::from("sekiro.exe"),
        String::from("eldenring.exe"),
        String::from("armoredcore6.exe"),
    };

    let mut exe_path = std::env::current_exe().unwrap();
    exe_path.pop();
    let mut dll_path = exe_path.to_str().unwrap().replace(r#"\\?\"#, "");
    dll_path.push_str("\\soulmemory_rs.dll");

    if let Some(process) = Process::get_running_process_names().iter().find(|p_name| games.contains(&p_name.to_lowercase()))
    {
        if X64
        {
            match process.to_lowercase().as_str()
            {
                "darksoulsremastered.exe" |
                "darksoulsii.exe" |
                "darksoulsiii.exe" |
                "sekiro.exe" |
                "eldenring.exe" |
                "armoredcore6.exe" =>
                {
                    let mut p = Process::new(process.to_lowercase().as_str());
                    p.refresh().unwrap();
                    p.inject_dll(dll_path.as_str()).unwrap();
                }
                _ => println!("unsupported process"),
            }
        }
        else
        {
            match process.to_lowercase().as_str()
            {
                "darksouls.exe" | "darksoulsii.exe" =>
                {
                    let mut p = Process::new(process.to_lowercase().as_str());
                    p.refresh().unwrap();
                    p.inject_dll(dll_path.as_str()).unwrap();
                },
                _ => println!("unsupported process"),
            }
        }
    }
    else
    {
        println!("No supported process found");
    }
}
