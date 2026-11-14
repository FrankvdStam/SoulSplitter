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

use mem_rs::prelude::ReadWrite;
use crate::games::Sekiro;
use crate::games::traits::player_position::PlayerPosition;
use crate::util::vector3f::Vector3f;

impl PlayerPosition for Sekiro
{
    fn get_position(&self) -> Vector3f
    {
        if !self.process.is_attached()
        {
            return Vector3f::default();
        }

        let x = self.position.read_f32_rel(Some(0x80));
        let y = self.position.read_f32_rel(Some(0x84));
        let z = self.position.read_f32_rel(Some(0x88));

        return Vector3f::new(x, y, z);
    }

    fn set_position(&self, position: &Vector3f)
    {
        self.position.write_f32_rel(Some(0x80), position.x);
        self.position.write_f32_rel(Some(0x84), position.y);
        self.position.write_f32_rel(Some(0x88), position.z);
    }
}