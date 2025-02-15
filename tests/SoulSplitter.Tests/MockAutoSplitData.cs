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

using SoulSplitter.Tests.UI;
using SoulSplitter.UI.DarkSouls3;
using SoulSplitter.UI.Generic;
using SoulSplitter.UI.Sekiro;
using System.Collections.Generic;

namespace SoulSplitter.Tests
{
    public static class MockAutoSplitData
    {
        public static IEnumerable<(GameType GameType, AddSplit AddSplit, TimingType TimingType, SplitType SplitType, object Split)> TestCases
        {
            get
            {
                AddSplit addDarkSouls1Split = AddDarkSouls1Split;
                AddSplit addDarkSouls3Split = AddDarkSouls3Split;
                AddSplit addSekiroSplit = AddSekiroSplit;

                //Dark Souls 1 ====================================================================================================================================================================================
                yield return (GameType.DarkSouls1, addDarkSouls1Split, TimingType.Immediate, SplitType.Boss, SoulMemory.DarkSouls1.Boss.AsylumDemon);
                yield return (GameType.DarkSouls1, addDarkSouls1Split, TimingType.OnLoading, SplitType.Boss, SoulMemory.DarkSouls1.Boss.FourKings);
                yield return (GameType.DarkSouls1, addDarkSouls1Split, TimingType.OnWarp,    SplitType.Boss, SoulMemory.DarkSouls1.Boss.GreatGreyWolfSif);

                yield return (GameType.DarkSouls1, addDarkSouls1Split, TimingType.OnWarp,    SplitType.Flag, new FlagDescription { Flag = 248157 });

                yield return (GameType.DarkSouls1, addDarkSouls1Split, TimingType.OnLoading, SplitType.Bonfire, new Splits.DarkSouls1.BonfireState { Bonfire = SoulMemory.DarkSouls1.Bonfire.AnorLondo, State = SoulMemory.DarkSouls1.BonfireState.Kindled2 });
                yield return (GameType.DarkSouls1, addDarkSouls1Split, TimingType.Immediate, SplitType.Bonfire, new Splits.DarkSouls1.BonfireState { Bonfire = SoulMemory.DarkSouls1.Bonfire.AshLakeDragon, State = SoulMemory.DarkSouls1.BonfireState.Unlocked });

                yield return (GameType.DarkSouls1, addDarkSouls1Split, TimingType.OnLoading, SplitType.Position, new VectorSize() { Position = new SoulMemory.Vector3f(100,200,-300), Size = 10 });

                yield return (GameType.DarkSouls1, addDarkSouls1Split, TimingType.OnWarp,    SplitType.Attribute, new Splits.DarkSouls1.Attribute { AttributeType = SoulMemory.DarkSouls1.Attribute.Dexterity, Level = 10 });

                //Dark Souls 3 ====================================================================================================================================================================================
                yield return (GameType.DarkSouls3, addDarkSouls3Split, TimingType.Immediate, SplitType.Boss, SoulMemory.DarkSouls3.Boss.AbyssWatchers);
                yield return (GameType.DarkSouls3, addDarkSouls3Split, TimingType.OnLoading, SplitType.Boss, SoulMemory.DarkSouls3.Boss.IudexGundyr);
                yield return (GameType.DarkSouls3, addDarkSouls3Split, TimingType.OnLoading, SplitType.Boss, SoulMemory.DarkSouls3.Boss.SlaveKnightGael);

                yield return (GameType.DarkSouls3, addDarkSouls3Split, TimingType.Immediate, SplitType.Flag, new FlagDescription { Flag = 248157 });

                yield return (GameType.DarkSouls3, addDarkSouls3Split, TimingType.OnLoading, SplitType.Bonfire, SoulMemory.DarkSouls3.Bonfire.DarkeaterMidir);
                yield return (GameType.DarkSouls3, addDarkSouls3Split, TimingType.Immediate, SplitType.Bonfire, SoulMemory.DarkSouls3.Bonfire.FarronKeep);

                yield return (GameType.DarkSouls3, addDarkSouls3Split, TimingType.OnLoading, SplitType.Position, new VectorSize() { Position = new SoulMemory.Vector3f(100, 200, -300), Size = 10 });

                yield return (GameType.DarkSouls3, addDarkSouls3Split, TimingType.Immediate, SplitType.Attribute, new Splits.DarkSouls3.Attribute { AttributeType = SoulMemory.DarkSouls3.Attribute.Dexterity, Level = 10 });

                yield return (GameType.DarkSouls3, addDarkSouls3Split, TimingType.Immediate, SplitType.ItemPickup, SoulMemory.DarkSouls3.ItemPickup.BlackHandKamuiOnikiriandUbadachi);

                //Sekiro ====================================================================================================================================================================================
                yield return (GameType.Sekiro,     addSekiroSplit,     TimingType.Immediate, SplitType.Boss, SoulMemory.Sekiro.Boss.EmmaTheGentleBlade);
                yield return (GameType.Sekiro,     addSekiroSplit,     TimingType.OnLoading, SplitType.Boss, SoulMemory.Sekiro.Boss.LadyButterfly);

                yield return (GameType.Sekiro,     addSekiroSplit,     TimingType.Immediate, SplitType.Bonfire, SoulMemory.Sekiro.Idol.AshinaCastleFortress);
                yield return (GameType.Sekiro,     addSekiroSplit,     TimingType.OnLoading, SplitType.Bonfire, SoulMemory.Sekiro.Idol.AshinaOutskirts);

                yield return (GameType.Sekiro,     addSekiroSplit,     TimingType.OnLoading, SplitType.Position, new VectorSize() { Position = new SoulMemory.Vector3f(100, 200, -300), Size = 10 });

                yield return (GameType.Sekiro,     addSekiroSplit,     TimingType.Immediate, SplitType.Flag, new FlagDescription { Flag = 248157 });
            }
        }

        #region Game specific logic
        public delegate void AddSplit(object viewModel, TimingType timingType, SplitType splitType, object split);

        private static void AddDarkSouls1Split(object viewModel, TimingType timingType, SplitType splitType, object split)
        {
            var darkSouls1ViewModel = (SoulSplitter.UI.DarkSouls1.DarkSouls1ViewModel)viewModel;
            darkSouls1ViewModel.NewSplitTimingType = timingType;
            darkSouls1ViewModel.NewSplitType = splitType;

            switch (splitType)
            {
                case SplitType.Position:
                    darkSouls1ViewModel.Position = (VectorSize)split;
                    break;

                case SplitType.Flag:
                    darkSouls1ViewModel.FlagDescription = (FlagDescription)split;
                    break;

                case SplitType.Bonfire:
                    darkSouls1ViewModel.NewSplitBonfireState = (Splits.DarkSouls1.BonfireState)split;
                    break;

                default:
                    darkSouls1ViewModel.NewSplitValue = split;
                    break;
            }

            darkSouls1ViewModel.AddSplitCommand.Execute(null);
        }

        private static void AddDarkSouls3Split(object viewModel, TimingType timingType, SplitType splitType, object split)
        {
            var darkSouls3ViewModel = (DarkSouls3ViewModel)viewModel;
            darkSouls3ViewModel.NewSplitTimingType = timingType;
            darkSouls3ViewModel.NewSplitType = splitType;

            switch (splitType)
            {
                case SplitType.Position:
                    darkSouls3ViewModel.Position = (VectorSize)split;
                    break;

                case SplitType.Flag:
                    darkSouls3ViewModel.FlagDescription = (FlagDescription)split;
                    break;

                default:
                    darkSouls3ViewModel.NewSplitValue = split;
                    break;
            }

            darkSouls3ViewModel.AddSplitCommand.Execute(null);
        }

        private static void AddSekiroSplit(object viewModel, TimingType timingType, SplitType splitType, object split)
        {
            var sekiroViewModel = (SekiroViewModel)viewModel;
            sekiroViewModel.NewSplitTimingType = timingType;
            sekiroViewModel.NewSplitType = splitType;

            switch (splitType)
            {
                default:
                    sekiroViewModel.NewSplitValue = split;
                    break;

                case SplitType.Position:
                    sekiroViewModel.Position = (VectorSize)split;
                    break;

                case SplitType.Flag:
                    sekiroViewModel.FlagDescription = (FlagDescription)split;
                    break;
            }

            sekiroViewModel.AddSplitCommand.Execute(null);
        }

        #endregion
    }
}
