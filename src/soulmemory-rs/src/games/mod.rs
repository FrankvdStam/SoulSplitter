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
mod dark_souls_prepare_to_die_edition;
mod dark_souls_remastered;
mod dark_souls_2_vanilla;
mod dark_souls_2_scholar_of_the_first_sin;
mod dark_souls_3;
mod sekiro;
mod elden_ring;
mod armored_core_6;
mod mock_game;
pub mod dx_version;
mod game;
mod game_ext;


#[cfg(target_arch = "x86")]
mod ilhook
{
    #[allow(unused_imports)]
    pub use ilhook::x86::{CallbackOption, Hooker, HookFlags, HookPoint, HookType, Registers};
}

#[cfg(target_arch = "x86_64")]
mod ilhook
{
    pub use ilhook::x64::{CallbackOption, Hooker, HookFlags, HookPoint, HookType, Registers};
}



pub use game::Game;
pub use game_ext::GameExt;

pub use dark_souls_prepare_to_die_edition::DarkSoulsPrepareToDieEdition;
pub use dark_souls_remastered::DarkSoulsRemastered;
pub use dark_souls_2_vanilla::DarkSouls2Vanilla;
pub use dark_souls_2_scholar_of_the_first_sin::DarkSouls2ScholarOfTheFirstSin;
pub use dark_souls_3::DarkSouls3;
pub use sekiro::Sekiro;
pub use elden_ring::EldenRing;
pub use armored_core_6::ArmoredCore6;
pub use mock_game::MockGame;

pub type ChrDbgFlag = (u32, String, bool);

pub trait GetSetChrDbgFlags
{
    fn get_flags(&self) -> Vec<ChrDbgFlag>;
    fn set_flag(&self, flag: u32, value: bool);
}
