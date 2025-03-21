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

use std::mem;
use std::sync::{Arc, Mutex};
use crate::darkscript3::sekiro_emedf::Emedf;
use crate::games::Sekiro;
use crate::games::traits::buffered_emevd_logger::{BufferedEmevdCall, BufferedEmevdLogger};

impl BufferedEmevdLogger for Sekiro
{
    fn get_emevd_buffer(&self) -> &Arc<Mutex<Vec<BufferedEmevdCall>>>{
        &self.emevd_buffer
    }

    fn get_game_emevd_definitions(&self) -> &Emedf
    {
        return &self.emedf;
    }
}