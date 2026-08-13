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


pub(crate) mod log;
pub(crate) mod console;
pub(crate) mod server;
pub mod vector3f;

#[unsafe(no_mangle)]
#[used]
pub static SOULMEMORY_RS_VERSION: &'static str = env!("VERSION");
pub const WINDOW_TITLE_STR: &'static str = concat!("soulmemory-rs ", env!("VERSION"));


#[allow(dead_code)]
pub unsafe fn get_stack_u32(esp: u32, offset: usize) -> u32
{
    unsafe { *((esp as usize + offset) as *mut u32) }
}

#[allow(dead_code)]
pub unsafe fn get_stack_u8(esp: u32, offset: usize) -> u8
{
    unsafe {  *((esp as usize + offset) as *mut u8) }
}
