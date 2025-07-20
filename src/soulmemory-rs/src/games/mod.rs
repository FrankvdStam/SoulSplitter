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
pub mod dark_souls_prepare_to_die_edition;
#[cfg(target_arch = "x86")]
pub mod dark_souls_2_vanilla;

#[cfg(target_arch = "x86_64")]
pub mod dark_souls_remastered;
#[cfg(target_arch = "x86_64")]
pub mod dark_souls_2_scholar_of_the_first_sin;
#[cfg(target_arch = "x86_64")]
pub mod darksouls3;
#[cfg(target_arch = "x86_64")]
pub mod sekiro;
#[cfg(target_arch = "x86_64")]
pub mod elden_ring;
#[cfg(target_arch = "x86_64")]
pub mod armored_core_6;
#[cfg(target_arch = "x86_64")]
pub mod bloodborne;
#[cfg(target_arch = "x86_64")]
pub mod nightreign;



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
pub use mock_game::MockGame;

#[cfg(target_arch = "x86")]
pub use dark_souls_prepare_to_die_edition::DarkSoulsPrepareToDieEdition;
#[cfg(target_arch = "x86")]
pub use dark_souls_2_vanilla::DarkSouls2Vanilla;


#[cfg(target_arch = "x86_64")]
pub use dark_souls_remastered::DarkSoulsRemastered;
#[cfg(target_arch = "x86_64")]
pub use dark_souls_2_scholar_of_the_first_sin::DarkSouls2ScholarOfTheFirstSin;
#[cfg(target_arch = "x86_64")]
pub use darksouls3::DarkSouls3;
#[cfg(target_arch = "x86_64")]
pub use sekiro::Sekiro;
#[cfg(target_arch = "x86_64")]
pub use elden_ring::EldenRing;
#[cfg(target_arch = "x86_64")]
pub use armored_core_6::ArmoredCore6;
#[cfg(target_arch = "x86_64")]
pub use bloodborne::Bloodborne;
#[cfg(target_arch = "x86_64")]
pub use nightreign::Nightreign;

pub type ChrDbgFlag = (u32, String, bool);

pub trait GetSetChrDbgFlags
{
    fn get_flags(&self) -> Vec<ChrDbgFlag>;
    fn set_flag(&self, flag: u32, value: bool);
}
