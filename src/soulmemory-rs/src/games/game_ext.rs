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

use crate::games::game::Game;

pub struct GameExt;

impl GameExt
{
    pub fn get_game_ref<T: 'static>(game: &dyn Game) -> Option<&T>
    {
        return game.as_any().downcast_ref::<T>();
    }

    pub fn get_game_mut<T: 'static>(game: &mut dyn Game) -> Option<&mut T>
    {
        return game.as_any_mut().downcast_mut::<T>();
    }
}