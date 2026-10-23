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

use windows::Win32::System::Console::{AllocConsole, FreeConsole, GetConsoleWindow};


pub fn init_console()
{
    //bloodborne will already have a console attached via shadps4
    let hwnd = unsafe{ GetConsoleWindow() };
    if hwnd.is_invalid()
    {
        unsafe{ AllocConsole().unwrap() };
    }    
}

#[allow(dead_code)]
pub fn free_console()
{
    unsafe{ FreeConsole().unwrap() };
}