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

#[allow(static_mut_refs)]

#[cfg(target_arch = "x86_64")]
mod x64;

#[cfg(target_arch = "x86_64")]
pub use
{
    crate::games::x64::armoredcore6::init_armoredcore6,
    crate::games::x64::darksouls2scholarofthefirstsin::init_scholar,
    crate::games::x64::darksouls3::init_darksouls3,
    crate::games::x64::eldenring::init_eldenring,
    crate::games::x64::sekiro::init_sekiro,
};
