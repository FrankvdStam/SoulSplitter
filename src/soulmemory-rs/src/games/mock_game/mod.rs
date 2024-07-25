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

use std::any::Any;
use std::sync::{Arc, Mutex};
use rand::random;
use crate::games::game::Game;
use crate::games::dx_version::DxVersion;
use crate::games::traits::buffered_event_flags::BufferedEventFlags;
use crate::games::traits::buffered_event_flags::EventFlag;

pub mod buffered_event_flags;

pub struct MockGame
{
    event_flags: Arc<Mutex<Vec<EventFlag>>>,
}

impl MockGame
{
    pub fn new() -> Self
    {
        let mut vec = Vec::new();
        for _ in 0..200
        {
            vec.push(EventFlag::new(chrono::offset::Local::now(), random::<u32>(), random::<u32>() % 2 == 0));
        }


        MockGame
        {
            event_flags: Arc::new(Mutex::new(vec)),
        }
    }

    pub fn raise_event_flag(&self, flag: u32, state: bool)
    {
        let event_flag = EventFlag::new(chrono::offset::Local::now(), flag, state);
        let mut guard = self.access_flag_storage().lock().unwrap();
        guard.push(event_flag);
    }
}

impl Game for MockGame
{
    fn refresh(&mut self) -> Result<(), String>
    {
        Ok(())
    }

    fn get_dx_version(&self) -> DxVersion {
        todo!()
    }

    fn event_flags(&mut self) -> Option<Box<&mut dyn BufferedEventFlags>> { Some(Box::new(self)) }

    fn as_any(&self) -> &dyn Any
    {
        self
    }
    fn as_any_mut(&mut self) -> &mut dyn Any { self }
}

