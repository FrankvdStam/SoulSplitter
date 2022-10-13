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
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;
using SoulSplitter.Splitters;
using SoulSplitter.UI;
using SoulSplitter.UI.Generic;
using System.Windows.Threading;

namespace SoulSplitter
{
    public class SoulComponent : IComponent
    {
        public const string Name = "SoulSplitter";

        public IDictionary<string, Action> ContextMenuControls => null;

        private LiveSplitState _liveSplitState;
        private ISplitter _splitter = null;
        private Game? _selectedGame = null;

        private ISplitter _currentSplitter;

        public SoulComponent(LiveSplitState state = null)
        {
            _liveSplitState = state;
            SelectGameFromLiveSplitState(_liveSplitState);
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                try
                {
                    try
                    {
                        UpdateSplitter(MainControlFormsWrapper.MainViewModel, state);
                    }
                    catch(Exception ex)
                    {
                        Logger.Log("Updating splitter failed", ex);
                    }

                    _liveSplitState = state;

                    if (_splitter.Exception != null)
                    {
                        MainControlFormsWrapper.MainViewModel.Error = _splitter.Exception.Message;
                    }
                    else
                    {
                        MainControlFormsWrapper.MainViewModel.Error = "";
                    }
                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    MainControlFormsWrapper.MainViewModel.Error = e.Message;
                }
            });
        }

        private void UpdateSplitter(MainViewModel mainViewModel, LiveSplitState state)
        {
            //Detect game change, initialize the correct splitter
            if (!_selectedGame.HasValue || _selectedGame != mainViewModel.SelectedGame)
            {
                //the splitter listens to livesplit events. Need to dispose to properly clean up and to make sure no elden ring events trigger in dark souls 3
                if (_splitter != null)
                {
                    _splitter.Dispose();
                    _splitter = null;
                }

                _selectedGame = mainViewModel.SelectedGame;
                switch (mainViewModel.SelectedGame)
                {
                    case Game.DarkSouls1:
                        _splitter = new DarkSouls1Splitter(state);
                        break;

                    case Game.DarkSouls2:
                        _splitter = new DarkSouls2Splitter(state);
                        break;

                    case Game.DarkSouls3:
                        _splitter = new DarkSouls3Splitter(state);
                        break;

                    case Game.Sekiro:
                        _splitter = new SekiroSplitter(state);
                        break;

                    case Game.EldenRing:
                        _splitter = new EldenRingSplitter(state);
                        break;
                }
            }

            //Update splitter instance with correct VM
            switch (_selectedGame)
            {
                default:
                    throw new NotImplementedException($"{_selectedGame}");

                case Game.DarkSouls1:
                    _splitter.Update(mainViewModel.DarkSouls1ViewModel);
                    break;

                case Game.DarkSouls2:
                    _splitter.Update(mainViewModel.DarkSouls2ViewModel);
                    break;

                case Game.DarkSouls3:
                    _splitter.Update(mainViewModel.DarkSouls3ViewModel);
                    break;

                case Game.Sekiro:
                    _splitter.Update(mainViewModel.SekiroViewModel);
                    break;
                
                case Game.EldenRing:
                    _splitter.Update(mainViewModel.EldenRingViewModel);
                    break;
            }
        }

        #region drawing ===================================================================================================================

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
        }

        public string ComponentName => Name;
        public float HorizontalWidth { get; private set; } = 0;
        public float MinimumHeight { get; private set; } = 0;
        public float VerticalHeight { get; private set; } = 0;
        public float MinimumWidth { get; private set; } = 0;
        public float PaddingTop => 0;
        public float PaddingBottom => 0;
        public float PaddingLeft => 0;
        public float PaddingRight => 0;
        public void Dispose() { }
        #endregion

        #region Xml settings ==============================================================================================================
        public XmlNode GetSettings(XmlDocument document)
        {
            XmlElement root = document.CreateElement("Settings");
            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                var xml = MainControlFormsWrapper.MainViewModel.Serialize();
                XmlDocumentFragment fragment = document.CreateDocumentFragment();
                fragment.InnerXml = xml;
                root.AppendChild(fragment);
            });
            return root;
        }

        public void SetSettings(XmlNode settings)
        {
            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                try
                {
                    try
                    {
                        Migrations.Migrate(settings);
                    }
                    catch { /* Ignored */ }

                    var vm = MainViewModel.Deserialize(settings.InnerXml);
                    if (vm != null)
                    {
                        MainControlFormsWrapper.MainViewModel = vm;
                    }
                }
                catch
                {
                    MainControlFormsWrapper.MainViewModel = new MainViewModel();
                    SelectGameFromLiveSplitState(_liveSplitState);
                }
            });
        }

        public MainControlFormsWrapper MainControlFormsWrapper = new MainControlFormsWrapper();
        public System.Windows.Forms.Control GetSettingsControl(LayoutMode mode)
        {
            return MainControlFormsWrapper;
        }


        private void SelectGameFromLiveSplitState(LiveSplitState s)
        {
            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                if (!string.IsNullOrWhiteSpace(s?.Run?.GameName))
                {
                    var name = s.Run.GameName.ToLower().Replace(" ", "");
                    switch (name)
                    {
                        case "darksouls":
                        case "darksoulsremastered":
                            MainControlFormsWrapper.MainViewModel.SelectedGame = Game.DarkSouls1;
                            break;

                        case "darksoulsii":
                            MainControlFormsWrapper.MainViewModel.SelectedGame = Game.DarkSouls2;
                            break;

                        case "darksoulsiii":
                            MainControlFormsWrapper.MainViewModel.SelectedGame = Game.DarkSouls3;
                            break;

                        case "sekiro":
                        case "sekiro:shadowsdietwice":
                            MainControlFormsWrapper.MainViewModel.SelectedGame = Game.Sekiro;
                            break;

                        case "eldenring":
                            MainControlFormsWrapper.MainViewModel.SelectedGame = Game.EldenRing;
                            break;
                    }
                }
            });
        }

        #endregion
    }
}
