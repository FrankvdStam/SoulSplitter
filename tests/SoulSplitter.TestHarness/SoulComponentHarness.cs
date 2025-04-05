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

using LiveSplit.Model;
using LiveSplit.Options;
using LiveSplit.UI;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoulMemory.DarkSouls1;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.TestHarness
{
    public class SoulComponentHarness
    {
        public static SoulComponentHarness Create()
        {
            var form = new Form();
            var run = new Mock<IRun>();
            var layout = new Mock<ILayout>();
            var layoutSettings = new LiveSplit.Options.LayoutSettings();
            var settings = new Mock<ISettings>();
            var liveSplitState = new LiveSplitState(run.Object, form, layout.Object, layoutSettings, settings.Object);
            var soulComponent = new SoulComponent(liveSplitState);
            return new SoulComponentHarness(soulComponent, form, run, layoutSettings, settings, liveSplitState);
        }

        public SoulComponentHarness
        (
            SoulComponent soulComponent, 
            Form form, 
            Mock<IRun> run, 
            LiveSplit.Options.LayoutSettings layoutSettings, 
            Mock<ISettings> settings, 
            LiveSplitState liveSplitState
            )
        {
            SoulComponent = soulComponent;
            Form = form;
            Run = run;
            LayoutSettings = layoutSettings;
            Settings = settings;
            LiveSplitState = liveSplitState;
        }

        public SoulComponent SoulComponent { get; }
        public Form Form { get; }
        public Mock<IRun> Run { get; }
        public LiveSplit.Options.LayoutSettings LayoutSettings { get; }
        public Mock<ISettings> Settings { get; }
        public LiveSplitState LiveSplitState { get; }

        public void SelectGame(Game game, object gameMock)
        {
            SoulComponent.MainWindow.MainViewModel.SelectedGame = game;
            Update(); //Populate ISplitter
            var splitter = SoulComponent.GetSplitter()!;
            splitter.SetGameObject(gameMock); 
        }
        
        public void Update()
        {
            var invalidator = new Mock<IInvalidator>();
            SoulComponent.Update(invalidator.Object, LiveSplitState, 0, 0, LayoutMode.Horizontal);
        }

        public void SetIgt(int milliseconds)
        {
            var splitter = SoulComponent.GetSplitter()!;
            var game = splitter.GetGameObject();

            if (game is Mock mock)
            {

            }
        }
    }
}
