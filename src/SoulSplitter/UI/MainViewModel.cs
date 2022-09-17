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

using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;
using SoulSplitter.UI.DarkSouls1;
using SoulSplitter.UI.DarkSouls2;
using SoulSplitter.UI.DarkSouls3;
using SoulSplitter.UI.EldenRing;
using SoulSplitter.UI.Generic;
using SoulSplitter.UI.Sekiro;

namespace SoulSplitter.UI
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public void Update(MainViewModel mainViewModel)
        {
            SelectedGame        = mainViewModel.SelectedGame;
            DarkSouls1ViewModel = mainViewModel.DarkSouls1ViewModel;
            DarkSouls2ViewModel = mainViewModel.DarkSouls2ViewModel;
            DarkSouls3ViewModel = mainViewModel.DarkSouls3ViewModel;
            SekiroViewModel     = mainViewModel.SekiroViewModel;
            EldenRingViewModel  = mainViewModel.EldenRingViewModel;
        }
        
        [XmlIgnore]
        public string Error
        {
            get => _error;
            set
            {
                _error = value;
                OnPropertyChanged();
            }
        }
        private string _error;

        public string Version { get; set; } = VersionHelper.Version.ToString();

        public Game SelectedGame
        {
            get => _selectedGame;
            set => SetField(ref _selectedGame, value);
        }
        private Game _selectedGame = Game.EldenRing;

        #region Game View models

        public DarkSouls1ViewModel DarkSouls1ViewModel
        {
            get => _darkSouls1ViewModel;
            set => SetField(ref _darkSouls1ViewModel, value);
        }
        private DarkSouls1ViewModel _darkSouls1ViewModel = new DarkSouls1ViewModel();
        
        public DarkSouls2ViewModel DarkSouls2ViewModel
        {
            get => _darkSouls2ViewModel;
            set => SetField(ref _darkSouls2ViewModel, value);
        }
        private DarkSouls2ViewModel _darkSouls2ViewModel = new DarkSouls2ViewModel();

        public DarkSouls3ViewModel DarkSouls3ViewModel
        {
            get => _darkSouls3ViewModel;
            set => SetField(ref _darkSouls3ViewModel, value);
        }
        private DarkSouls3ViewModel _darkSouls3ViewModel = new DarkSouls3ViewModel();

        public SekiroViewModel SekiroViewModel
        {
            get => _sekiroViewModel;
            set => SetField(ref _sekiroViewModel, value);
        }
        private SekiroViewModel _sekiroViewModel = new SekiroViewModel();

        public EldenRingViewModel EldenRingViewModel
        {
            get => _eldenRingViewModel;
            set => SetField(ref _eldenRingViewModel, value);
        }
        private EldenRingViewModel _eldenRingViewModel = new EldenRingViewModel();

        #endregion

        #region Serializing
        public string Serialize()
        {
            var settings = new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                Indent = true,
            };

            var xml = "";
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                var serializer = new XmlSerializer(GetType());
                serializer.Serialize(writer, this);
                xml = stream.ToString();
            }
            return xml;
        }

        public static MainViewModel Deserialize(string xml)
        {
            var vm = xml.DeserializeXml<MainViewModel>();
            vm.DarkSouls1ViewModel.SplitsViewModel.RestoreHierarchy();
            vm.DarkSouls2ViewModel.RestoreHierarchy();
            vm.DarkSouls3ViewModel.RestoreHierarchy();
            vm.SekiroViewModel.SplitsViewModel.RestoreHierarchy();
            vm.EldenRingViewModel.RestoreHierarchy();
            return vm;
        }

        #endregion
        
        #region INotifyPropertyChanged

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? "");
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? ""));
        }

        #endregion

    }
}
