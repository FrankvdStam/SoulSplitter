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

use std::fmt;
use std::fmt::Display;

#[derive(Copy, Clone)]
pub struct Vector3f
{
    pub x: f32,
    pub y: f32,
    pub z: f32,
}

impl Display for Vector3f
{
    fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result
    {
        write!(f, "({}, {}, {})", self.x, self.y, self.z)
    }
}

impl Default for Vector3f
{
    fn default() -> Self
    {
        Vector3f{x: 0.0f32, y: 0.0f32 , z: 0.0f32}
    }
}

impl Vector3f
{
    pub fn new(x: f32, y: f32, z: f32) -> Self
    {
        Vector3f{ x, y, z}
    }
}