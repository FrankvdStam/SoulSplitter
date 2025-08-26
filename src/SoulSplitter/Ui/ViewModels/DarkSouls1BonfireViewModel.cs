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

using System;
using SoulMemory.Games.DarkSouls1;

namespace SoulSplitter.Ui.ViewModels
{
    public class DarkSouls1BonfireViewModel : NotifyPropertyChanged, ICloneable
    {
        public object Clone()
        {
            return new DarkSouls1BonfireViewModel
            {
                Bonfire = Bonfire,
                BonfireState = BonfireState
            };
        }
        
        public Bonfire Bonfire
        {
            get => _bonfire;
            set => SetField(ref _bonfire, value);
        }
        private Bonfire _bonfire;

        public BonfireState BonfireState
        {
            get => _bonfireState;
            set => SetField(ref _bonfireState, value);
        }
        private BonfireState _bonfireState;
    }
}
