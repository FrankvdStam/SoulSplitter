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

namespace SoulMemory.Enums;

public enum Game
{
    [TimingTypes(TimingType.Immediate, TimingType.OnLoading, TimingType.OnWarp)]
    [SplitTypes(SplitType.Boss, SplitType.Attribute, SplitType.Bonfire, SplitType.Item, SplitType.Position, SplitType.KnownFlag, SplitType.Flag)]
    DarkSouls1 = 0,

    [TimingTypes(TimingType.Immediate, TimingType.OnLoading)]
    [SplitTypes(SplitType.Position, SplitType.Boss, SplitType.Attribute, SplitType.Flag)]
    DarkSouls2 = 1,

    [TimingTypes(TimingType.Immediate, TimingType.OnLoading)]
    [SplitTypes(SplitType.Boss, SplitType.Bonfire, SplitType.ItemPickup, SplitType.Attribute, SplitType.Flag, SplitType.Position)]
    DarkSouls3 = 2,

    [TimingTypes(TimingType.Immediate, TimingType.OnLoading)]
    [SplitTypes(SplitType.Boss, SplitType.Bonfire, SplitType.Position, SplitType.Flag, SplitType.Attribute)]
    Sekiro = 3,

    [TimingTypes(TimingType.Immediate, TimingType.OnLoading, TimingType.OnBlackscreen)]
    [SplitTypes(SplitType.Boss, SplitType.Bonfire, SplitType.ItemPickup, SplitType.KnownFlag, SplitType.Position, SplitType.Flag)]
    EldenRing = 4,

    [TimingTypes(TimingType.Immediate, TimingType.OnLoading)]
    [SplitTypes(SplitType.Flag)]
    ArmoredCore6 = 5,
}

