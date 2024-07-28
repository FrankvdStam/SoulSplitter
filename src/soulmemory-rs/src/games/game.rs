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
use crate::games::dx_version::DxVersion;
use crate::games::traits::buffered_event_flags::BufferedEventFlags;
use crate::games::traits::player_position::PlayerPosition;

pub trait Game
{
    fn refresh(&mut self) -> Result<(), String>;
    fn get_dx_version(&self) -> DxVersion;
    fn player_position(&mut self) -> Option<Box<&mut dyn PlayerPosition>>{ None }
    fn event_flags(&mut self) -> Option<Box<&mut dyn BufferedEventFlags>>{ None }
    fn as_any(&self) -> &dyn Any;
    fn as_any_mut(&mut self) -> &mut dyn Any;
}
