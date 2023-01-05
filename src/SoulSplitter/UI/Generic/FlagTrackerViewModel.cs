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

using SoulMemory;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoulSplitter.UI.Generic
{
    public class FlagTrackerCategoryViewModel : INotifyPropertyChanged
    {
        public string CategoryName
        {
            get => _categoryName;
            set => SetField(ref _categoryName, value);
        }
        private string _categoryName;

        [XmlIgnore]
        public float PercentageDone
        {
            get => _percentageDone;
            set => SetField(ref _percentageDone, value);
        }
        private float _percentageDone;

        public ObservableCollection<FlagDescription> EventFlags { get; set; } = new ObservableCollection<FlagDescription>();

        #region INotifyPropertyChanged
        private bool SetField<U>(ref U field, U value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<U>.Default.Equals(field, value)) return false;
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

    public class FlagTrackerViewModel : INotifyPropertyChanged
    {
        public FlagTrackerViewModel()
        {
            CommandAddEventFlag = new RelayCommand(AddEventFlag, (o) => { return !string.IsNullOrWhiteSpace(CategoryName) && FlagDescription.Flag != 0; });
            CommandRemoveEventFlag = new RelayCommand(RemoveEventFlag, (o) => { return SelectedFlagDescription != null; });
        }

        
        #region Add/remove
        private void AddEventFlag(object param)
        {
            //Resolve category
            var category = EventFlagCategories.FirstOrDefault(i => i.CategoryName == CategoryName);
            if(category == null)
            {
                category = new FlagTrackerCategoryViewModel();
                category.CategoryName = CategoryName;
                EventFlagCategories.Add(category);
            }

            //Resolve flag
            var flag = category.EventFlags.FirstOrDefault(i => i.Flag == FlagDescription.Flag);
            
            //Update flag description but don't duplicate
            if (flag != null)
            {
                flag.Description = FlagDescription.Description;
            }   
            else
            {
                //deep clone
                var clone = new FlagDescription { Flag = FlagDescription.Flag, Description = FlagDescription.Description };
                category.EventFlags.Add(clone);
            }

            //Reset
            FlagDescription.Flag = 0;
            FlagDescription.Description = "";
        }

        private void RemoveEventFlag(object param)
        {
            if(SelectedFlagDescription == null)
            {
                return;
            }

            for(var i = 0; i < EventFlagCategories.Count; i++)
            {
                var category = EventFlagCategories[i];
                if(category.EventFlags.Contains(SelectedFlagDescription))
                {
                    category.EventFlags.Remove(SelectedFlagDescription);
                    if(!category.EventFlags.Any())
                    {
                        EventFlagCategories.Remove(category);
                        return;
                    }
                }
            }
        }
        #endregion

        #region update/reset

        public void Update(IGame game)
        {
            if(!EventFlagCategories.Any())
            {
                return;
            }

            var totalFlags = 0;
            var totalDone = 0;
            foreach (var category in EventFlagCategories)
            {
                //category.PercentageDone = 0.0f;
                foreach (var eventFlag in category.EventFlags)
                {
                    if(!eventFlag.State)
                    {
                        eventFlag.State = game.ReadEventFlag(eventFlag.Flag);
                    }
                }
                var done = category.EventFlags.Count(i => i.State);
                category.PercentageDone = (done / (float)category.EventFlags.Count) * 100.0f;

                totalFlags += category.EventFlags.Count;
                totalDone += done;
            }
            PercentageDone = (totalDone / (float)totalFlags) * 100.0f;
        }


        public void Reset()
        {
            PercentageDone = 0;
            foreach (var category in EventFlagCategories)
            {
                category.PercentageDone = 0.0f;
                foreach(var eventFlag in category.EventFlags)
                {
                    eventFlag.State = false;
                }
            }
        }

        #endregion

        #region UI bindable properties
        public ObservableCollection<FlagTrackerCategoryViewModel> EventFlagCategories { get; set; } = new ObservableCollection<FlagTrackerCategoryViewModel>();


        #region UI customization

        [XmlIgnore]
        public float PercentageDone
        {
            get => _percentageDone;
            set => SetField(ref _percentageDone, value);
        }
        private float _percentageDone;

        public double WindowWidth
        {
            get => _windowWidth;
            set => SetField(ref _windowWidth, value);
        }
        private double _windowWidth = 800;

        public double WindowHeight
        {
            get => _windowHeight;
            set => SetField(ref _windowHeight, value);
        }
        private double _windowHeight = 600;

        public double InputColumnWidth
        {
            get => _inputColumnWidth;
            set => SetField(ref _inputColumnWidth, value);
        }
        private double _inputColumnWidth = 400;

        public double UiCustomizationColumnWidth
        {
            get => _uiCustomizationColumnWidth;
            set => SetField(ref _uiCustomizationColumnWidth, value);
        }
        private double _uiCustomizationColumnWidth = 400;

        public double CategoryPercentagesRowHeight
        {
            get => _categoryPercentagesRowHeight;
            set => SetField(ref _categoryPercentagesRowHeight, value);
        }
        private double _categoryPercentagesRowHeight = 300;

        public int CategoryPercentageFontSize
        {
            get => _categoryPercentageFontSize;
            set => SetField(ref _categoryPercentageFontSize, value);
        }
        private int _categoryPercentageFontSize = 30;

        public int TotalPercentageFontSize
        {
            get => _totalPercentageFontSize;
            set => SetField(ref _totalPercentageFontSize, value);
        }
        private int _totalPercentageFontSize = 60;

        #endregion

        #region Inputs

        [XmlIgnore]
        public string CategoryName
        {
            get => _categoryName;
            set => SetField(ref _categoryName, value);
        }
        private string _categoryName;

        [XmlIgnore]
        public FlagDescription FlagDescription
        {
            get => _flagDescription;
            set => SetField(ref _flagDescription, value);
        }
        private FlagDescription _flagDescription = new FlagDescription();

        [XmlIgnore]
        public FlagDescription SelectedFlagDescription
        {
            get => _selectedFlagDescription;
            set => SetField(ref _selectedFlagDescription, value);
        }
        private FlagDescription _selectedFlagDescription = null;

        [XmlIgnore]
        public RelayCommand CommandAddEventFlag
        {
            get => _commandAddEventFlag;
            set => SetField(ref _commandAddEventFlag, value);
        }
        private RelayCommand _commandAddEventFlag;

        [XmlIgnore]
        public RelayCommand CommandRemoveEventFlag
        {
            get => _commandRemoveEventFlag;
            set => SetField(ref _commandRemoveEventFlag, value);
        }
        private RelayCommand _commandRemoveEventFlag;

        #endregion

        #endregion

        #region INotifyPropertyChanged
        private bool SetField<U>(ref U field, U value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<U>.Default.Equals(field, value)) return false;
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
