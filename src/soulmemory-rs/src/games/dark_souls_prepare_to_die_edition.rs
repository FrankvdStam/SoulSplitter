// This file is part of the soulmemory-rs distribution (https://github.com/FrankvdStam/soulmemory-rs).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/soulmemory-rs/blob/main/LICENSE
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

use std::any::Any;
use std::ops::Deref;
use std::sync::{Arc, Mutex};
use log::info;
use mem_rs::pointer::Pointer;
use mem_rs::prelude::{Process, ReadWrite};
use ilhook::x86::{Hooker, HookType, Registers, CallbackOption, HookFlags, HookPoint};
use crate::App;
use crate::games::dx_version::DxVersion;
use crate::games::traits::buffered_event_flags::{BufferedEventFlags, EventFlag};
use crate::games::game::{Game};
use crate::games::game_ext::GameExt;
use crate::util::{get_stack_u32, get_stack_u8};

pub struct DarkSoulsPrepareToDieEdition
{
    process: Process,
    event_flag_man: Pointer,
    event_flags: Arc<Mutex<Vec<EventFlag>>>,
    set_event_flag_hook: Option<HookPoint>,
}

impl DarkSoulsPrepareToDieEdition
{
    pub fn new() -> Self
    {
        DarkSoulsPrepareToDieEdition
        {
            process: Process::new("darksouls.exe"),
            event_flag_man: Pointer::default(),
            event_flags: Arc::new(Mutex::new(Vec::new())),
            set_event_flag_hook: None,
        }
    }
}

impl BufferedEventFlags for DarkSoulsPrepareToDieEdition
{
    fn access_flag_storage(&self) -> &Arc<Mutex<Vec<EventFlag>>>
    {
        return &self.event_flags;
    }

    fn get_event_flag_state(&self, event_flag: u32) -> bool
    {
        let (offset, mask) = get_event_flag_offset(event_flag);
        let value = self.event_flag_man.read_u32_rel(Some(offset)) as usize;
        return (value & mask) != 0;
    }
}


impl Game for DarkSoulsPrepareToDieEdition
{
    fn refresh(&mut self) -> Result<(), String>
    {
        if !self.process.is_attached()
        {
            unsafe
            {
                self.process.refresh()?;
                self.event_flag_man = self.process.scan_abs("event flags", "56 8B F1 8B 46 1C 50 A1 ? ? ? ? 32 C9", 8, vec![0, 0, 0])?;
                let set_event_flag_address = self.process.scan_abs("set_event_flag", "80 b8 14 01 00 00 00 56 8b 74 24 08 74 ? 57 51 50", 0, Vec::new())?.get_base_address();

                let h = Hooker::new(set_event_flag_address, HookType::JmpBack(capture_the_flag), CallbackOption::None, 0, HookFlags::empty());
                self.set_event_flag_hook = Some(h.hook().unwrap());

                info!("event_flag_man base address: 0x{:x}", self.event_flag_man.get_base_address());
                info!("set event flag address     : 0x{:x}", set_event_flag_address);
            }
        }
        else
        {
            self.process.refresh()?;
        }
        Ok(())
    }
    fn get_dx_version(&self) -> DxVersion {
        DxVersion::Dx9
    }
    fn event_flags(&mut self) -> Option<Box<&mut dyn BufferedEventFlags>> { Some(Box::new(self)) }

    fn as_any(&self) -> &dyn Any
    {
        self
    }
    fn as_any_mut(&mut self) -> &mut dyn Any { self }
}

//Credit to JKAnderson for the event flag reading code, https://github.com/JKAnderson/DS-Gadget
//Implementing it this way over calling the read event flag function, because it is a custom calling convention
fn get_event_flag_group(group: &String) -> usize
{
    return match group.as_str()
    {
        "0" => 0x00000,
        "1" => 0x00500,
        "5" => 0x05F00,
        "6" => 0x0B900,
        "7" => 0x11300,
        _ => panic!("Invalid group {}", group),
    }
}

fn get_event_flag_area(area: &String) -> usize
{
    return match area.as_str()
    {
        "000" => 00,
        "100" => 01,
        "101" => 02,
        "102" => 03,
        "110" => 04,
        "120" => 05,
        "121" => 06,
        "130" => 07,
        "131" => 08,
        "132" => 09,
        "140" => 10,
        "141" => 11,
        "150" => 12,
        "151" => 13,
        "160" => 14,
        "170" => 15,
        "180" => 16,
        "181" => 17,
        _ => panic!("Invalid area {}", area),
    }
}

fn get_event_flag_offset(even_flag_id: u32) -> (usize, usize)
{
    let flag_str = format!("{:0>8}", even_flag_id);
    let group = flag_str[..1].to_string();
    let area = flag_str[1..4].to_string();
    let section_str = flag_str[4..5].to_string();
    let number_str = flag_str[5..].to_string();
    let section = section_str.parse::<usize>().unwrap();
    let number = number_str.parse::<usize>().unwrap();

    let mut offset = get_event_flag_group(&group);
    offset += get_event_flag_area(&area) * 0x500;
    offset += section * 128;
    offset += (number - (number % 32)) / 8;

    let mask = 0x80000000 >> (number % 32);
    return (offset, mask);
}

unsafe extern "cdecl" fn capture_the_flag(reg:*mut Registers, _:usize)
{
    let instance = App::get_instance();
    let app = instance.lock().unwrap();

    if let Some(ptde) = GameExt::get_game_ref::<DarkSoulsPrepareToDieEdition>(app.game.deref())
    {
        let value           = get_stack_u8((*reg).esp, 0x8);
        let event_flag_id   = get_stack_u32((*reg).esp, 0x4);

        let mut guard = ptde.event_flags.lock().unwrap();
        guard.push(EventFlag::new(chrono::offset::Local::now(), event_flag_id, value != 0));
    }
}
