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

pub mod traits;

pub mod dx_version;
pub mod game;
pub mod game_ext;
pub mod mock_game;


#[cfg(target_arch = "x86")]
mod x86;

#[cfg(target_arch = "x86")]
pub use
{
    crate::games::x86::dark_souls_prepare_to_die_edition::*,
    crate::games::x86::dark_souls_2_vanilla::*,
};

#[cfg(target_arch = "x86_64")]
mod x64;

#[cfg(target_arch = "x86_64")]
pub use
{
    crate::games::x64::dark_souls_remastered::*,
    crate::games::x64::armored_core_6::*,
    crate::games::x64::dark_souls_2_scholar_of_the_first_sin::*,
    crate::games::x64::darksouls3::*,
    crate::games::x64::elden_ring::*,
    crate::games::x64::sekiro::*,
    crate::games::x64::bloodborne::*,
    crate::games::x64::nightreign::*,
};


#[cfg(target_arch = "x86_64")]
mod ilhook
{
    pub use ilhook::x64::{CallbackOption, HookFlags, HookPoint, HookType, Hooker, Registers};
}

pub use game::Game;
pub use game_ext::GameExt;
pub use mock_game::MockGame;


pub type ChrDbgFlag = (u32, String, bool);

pub trait GetSetChrDbgFlags
{
    fn get_flags(&self) -> Vec<ChrDbgFlag>;
    fn set_flag(&self, flag: u32, value: bool);
}
