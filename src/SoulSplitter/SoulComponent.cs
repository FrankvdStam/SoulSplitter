using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using SoulSplitter.Splitters;
using SoulSplitter.UI;

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

            if(!string.IsNullOrWhiteSpace(_liveSplitState?.Run?.GameName))
            {
                var name = _liveSplitState.Run.GameName.ToLower().Replace(" ", "");
                switch (name)
                {
                    case "darksoulsii":
                        MainControlFormsWrapper.MainViewModel.SelectedGame = Game.DarkSouls2;
                        break;

                    case "darksoulsiii":
                        MainControlFormsWrapper.MainViewModel.SelectedGame = Game.DarkSouls3;
                        break;

                    case "sekiro:shadowsdietwice":
                        MainControlFormsWrapper.MainViewModel.SelectedGame = Game.Sekiro;
                        break;

                    case "eldenring":
                        MainControlFormsWrapper.MainViewModel.SelectedGame = Game.EldenRing;
                        break;
                }
            }
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            try
            {
                var viewModel = MainControlFormsWrapper.MainViewModel;
                UpdateSplitter(viewModel, state);

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
                MainControlFormsWrapper.MainViewModel.Error = e.Message;
            }
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
                    default:
                    case Game.DarkSouls1:
                        throw new Exception("Not supported");

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
                case Game.DarkSouls1:
                    throw new Exception("Not supported");

                case Game.DarkSouls2:
                    _splitter.Update(MainControlFormsWrapper.MainViewModel.DarkSouls2ViewModel);
                    break;

                case Game.DarkSouls3:
                    _splitter.Update(MainControlFormsWrapper.MainViewModel.DarkSouls3ViewModel);
                    break;

                case Game.Sekiro:
                    _splitter.Update(MainControlFormsWrapper.MainViewModel.SekiroViewModel);
                    break;
                
                case Game.EldenRing:
                    _splitter.Update(MainControlFormsWrapper.MainViewModel.EldenRingViewModel);
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
            var xml = MainControlFormsWrapper.MainViewModel.Serialize();
            XmlDocumentFragment fragment = document.CreateDocumentFragment();
            fragment.InnerXml = xml;

            XmlElement root = document.CreateElement("Settings");
            root.AppendChild(fragment);
            return root;
        }

        public void SetSettings(XmlNode settings)
        {
            try
            {
                var vm = MainViewModel.Deserialize(settings.InnerXml);
                if (vm != null)
                {
                    MainControlFormsWrapper.MainViewModel = vm;
                }
            }
            catch
            {
                MainControlFormsWrapper.MainViewModel = new MainViewModel();
            }
        }

        public MainControlFormsWrapper MainControlFormsWrapper = new MainControlFormsWrapper();
        public System.Windows.Forms.Control GetSettingsControl(LayoutMode mode)
        {
            return MainControlFormsWrapper;
        }
        #endregion
    }
}
