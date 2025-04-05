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

using SoulMemory.Abstractions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Media;
using System.Xml.Serialization;

namespace SoulSplitter.UI.Generic;

public class FlagTrackerCategoryViewModel : ICustomNotifyPropertyChanged
{
    public string CategoryName
    {
        get => _categoryName;
        set => this.SetField(ref _categoryName, value);
    }
    private string _categoryName = null!;
    
    [XmlIgnore]
    public string Progress
    {
        get => _progress;
        set => this.SetField(ref _progress, value);
    }
    private string _progress = null!;

    public ObservableCollection<FlagDescription> EventFlags { get; set; } = [];

    #region ICustomNotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void InvokePropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}

public class FlagTrackerViewModel : ICustomNotifyPropertyChanged
{
    public FlagTrackerViewModel()
    {
        CommandAddEventFlag = new RelayCommand(AddEventFlag, _ => !string.IsNullOrWhiteSpace(CategoryName) && FlagDescription.Flag != 0);
        CommandRemoveEventFlag = new RelayCommand(RemoveEventFlag, _ => SelectedFlagDescription != null);
    }

    
    #region Add/remove
    private void AddEventFlag()
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

    private void RemoveEventFlag()
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
    private List<(FlagTrackerCategoryViewModel category, FlagDescription eventFlag)>? _lookup;
    private int _currentIndex;

    public void Start()
    {
        _lookup = EventFlagCategories.SelectMany(i => i.EventFlags, (category, eventFlag) => (category, eventFlag)).ToList();
        _currentIndex = 0;

        switch (DisplayMode)
        {
            case EventFlagTrackerDisplayMode.Percentage:
                foreach (var category in EventFlagCategories)
                {
                    category.Progress = $"{0.0f:0.00}%";
                }

                Progress = $"{0.0f:0.00}%";
                break;

            case EventFlagTrackerDisplayMode.Count:
                foreach (var category in EventFlagCategories)
                {
                    category.Progress = $"0/{category.EventFlags.Count}";
                }

                Progress = $"0/{EventFlagCategories.SelectMany(i => i.EventFlags).Count()}";
                break;
        }
    }

    public void Update(IGame game)
    {
        if(!EventFlagCategories.Any() || _lookup == null)
        {
            return;
        }

        //Keep track of changed categories, their total percentage will need to be updated
        var changedCategories = new List<FlagTrackerCategoryViewModel>();

        //Check the next x flags
        for(var i = 0; i < FlagsPerFrame; i++)
        {
            var (category, flag) = _lookup[_currentIndex];
            if (!flag.State)
            {
                flag.State = game.ReadEventFlag(flag.Flag);
                
                //If flag state has changed, recalculate category percentage later
                if(flag.State)
                {
                    changedCategories.Add(category);
                }
            }

            //Calc next index
            _currentIndex++;
            if(_currentIndex >= _lookup.Count)
            {
                _currentIndex = 0;
            }
        }

        switch(DisplayMode) 
        {
            case EventFlagTrackerDisplayMode.Percentage:
                //Recalculate total percentage of categories that changed
                foreach (var category in changedCategories)
                {
                    var done = category.EventFlags.Count(i => i.State);
                    var percentage = (done / (float)category.EventFlags.Count) * 100.0f;
                    category.Progress = $"{percentage:0.00}%";
                }

                //Recalculate total percentage of all flags (only if there is a change)
                if (changedCategories.Any())
                {
                    var done = _lookup.Count(i => i.eventFlag.State);
                    var percentageDone = (done / (float)_lookup.Count) * 100.0f;
                    Progress = $"{percentageDone:0.00}%";
                }
                break;

            case EventFlagTrackerDisplayMode.Count:
                foreach (var category in changedCategories)
                {
                    var done = category.EventFlags.Count(i => i.State);
                    category.Progress = $"{done}/{category.EventFlags.Count}";
                }

                if (changedCategories.Any())
                {
                    var done = _lookup.Count(i => i.eventFlag.State);
                    Progress = $"{done}/{_lookup.Count}";
                }
                break;
        }

    }


    public void Reset()
    {
        _lookup = null;
        _currentIndex = 0;
        foreach (var category in EventFlagCategories)
        {
            category.Progress = "";
            foreach(var eventFlag in category.EventFlags)
            {
                eventFlag.State = false;
            }
        }
    }

    #endregion

    #region UI bindable properties
    public ObservableCollection<FlagTrackerCategoryViewModel> EventFlagCategories { get; set; } = [];

    public EventFlagTrackerDisplayMode DisplayMode
    {
        get => _displayMode;
        set => this.SetField(ref _displayMode, value);
    }
    private EventFlagTrackerDisplayMode _displayMode = EventFlagTrackerDisplayMode.Percentage;

    #region UI customization

    [XmlIgnore]
    public string Progress
    {
        get => _progress;
        set => this.SetField(ref _progress, value);
    }
    private string _progress = null!;
    
    public double WindowWidth
    {
        get => _windowWidth;
        set => this.SetField(ref _windowWidth, value);
    }
    private double _windowWidth = 800;

    public double WindowHeight
    {
        get => _windowHeight;
        set => this.SetField(ref _windowHeight, value);
    }
    private double _windowHeight = 600;

    public double InputColumnWidth
    {
        get => _inputColumnWidth;
        set => this.SetField(ref _inputColumnWidth, value);
    }
    private double _inputColumnWidth = 400;

    public double CategoryPercentagesRowHeight
    {
        get => _categoryPercentagesRowHeight;
        set => this.SetField(ref _categoryPercentagesRowHeight, value);
    }
    private double _categoryPercentagesRowHeight = 300;

    public double CategoryPercentageFontSize
    {
        get => _categoryPercentageFontSize;
        set => this.SetField(ref _categoryPercentageFontSize, value);
    }
    private double _categoryPercentageFontSize = 30.0;

    public int TotalPercentageFontSize
    {
        get => _totalPercentageFontSize;
        set => this.SetField(ref _totalPercentageFontSize, value);
    }
    private int _totalPercentageFontSize = 60;

    public Color BackgroundColor
    {
        get => _backgroundColor;
        set => this.SetField(ref _backgroundColor, value);
    }
    private Color _backgroundColor = Colors.White;

    public Color TextColor
    {
        get => _textColor;
        set => this.SetField(ref _textColor, value);
    }
    private Color _textColor = Colors.Black;

    public int FlagsPerFrame
    {
        get => _flagsPerFrame;
        set => this.SetField(ref _flagsPerFrame, value);
    }
    private int _flagsPerFrame = 10;

    #endregion

    #region Inputs

    [XmlIgnore]
    public string CategoryName
    {
        get => _categoryName;
        set => this.SetField(ref _categoryName, value);
    }
    private string _categoryName = null!;

    [XmlIgnore]
    public FlagDescription FlagDescription
    {
        get => _flagDescription;
        set => this.SetField(ref _flagDescription, value);
    }
    private FlagDescription _flagDescription = new();

    [XmlIgnore]
    public FlagDescription? SelectedFlagDescription
    {
        get => _selectedFlagDescription;
        set => this.SetField(ref _selectedFlagDescription, value);
    }
    private FlagDescription? _selectedFlagDescription;

    [XmlIgnore]
    public RelayCommand CommandAddEventFlag { get; }

    [XmlIgnore]
    public RelayCommand CommandRemoveEventFlag { get; }

    #endregion

    #endregion


    #region ICustomNotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void InvokePropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
