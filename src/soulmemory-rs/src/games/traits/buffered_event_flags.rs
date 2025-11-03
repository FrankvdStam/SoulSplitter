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

use std::{fmt, mem};
use std::fmt::Display;
use std::sync::{Arc, Mutex};
use chrono::{DateTime, Local};

#[derive(Clone, Copy)]
pub enum EventFlagValue
{
    State(bool),
    Quantity(i32)
}

#[derive(Clone, Copy)]
pub struct EventFlag
{
    pub time: DateTime<Local>,
    pub flag: u32,
    pub value: EventFlagValue,
}

impl Display for EventFlagValue
{
    fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result
    {
        match self
        {
            EventFlagValue::State(state) => write!(f, "{}", state),
            EventFlagValue::Quantity(quantity) => write!(f, "{}", quantity),
        }
    }
}

impl Display for EventFlag
{
    fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
        write!(f, "{} - {: >10} - {}", self.time.format("%Y-%m-%d %H:%M:%S%.3f"), self.flag, self.value)
    }
}

impl EventFlag
{
    pub fn from_state(time: DateTime<Local>, flag: u32, state: bool) -> Self
    {
        EventFlag
        {
            time,
            flag,
            value: EventFlagValue::State(state),
        }
    }

    pub fn from_quantity(time: DateTime<Local>, flag: u32, quantity: i32) -> Self
    {
        EventFlag
        {
            time,
            flag,
            value: EventFlagValue::Quantity(quantity),
        }
    }
}

pub trait BufferedEventFlags
{
    fn access_flag_storage(&self) -> &Arc<Mutex<Vec<EventFlag>>>;
    fn get_event_flag_state(&self, event_flag: u32) -> bool;

    fn get_buffered_flags(&mut self) -> Vec<EventFlag>
    {
        let mut event_flags = self.access_flag_storage().lock().unwrap();
        mem::replace(&mut event_flags, Vec::new())
    }
}