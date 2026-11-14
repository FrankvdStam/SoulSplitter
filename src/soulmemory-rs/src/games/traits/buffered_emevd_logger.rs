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
use crate::darkscript3::emevd_definition::EmevdDefinition;

pub struct BufferedEmevdCall
{
    pub time: DateTime<Local>,
    pub event_id: u32,
    pub group: u32,
    pub type_: u32,
    pub log: String,
}

impl BufferedEmevdCall
{
    pub fn new(time: DateTime<Local>, event_id: u32, group: u32, type_: u32, log: String) -> Self
    {
        BufferedEmevdCall
        {
            time,
            event_id,
            group,
            type_,
            log
        }
    }
}

impl Display for BufferedEmevdCall
{
    fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
        write!(f, "{} - {: >10} - {}", self.time.format("%Y-%m-%d %H:%M:%S%.3f"), self.group, self.type_)
    }
}

pub trait BufferedEmevdLogger
{
    fn get_emevd_buffer(&self) -> &Arc<Mutex<Vec<BufferedEmevdCall>>>;

    fn get_buffered_emevd_calls(&mut self) -> Vec<BufferedEmevdCall>
    {
        let mut state = self.get_emevd_buffer().lock().unwrap();
        let buffer = mem::replace(&mut *state, Vec::new());
        return buffer;
    }

    fn get_game_emevd_definitions(&self) -> &EmevdDefinition;
}