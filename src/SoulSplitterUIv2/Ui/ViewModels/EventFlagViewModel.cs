using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SoulSplitterUIv2.Resources;
using SoulSplitterUIv2.Ui.View;

namespace SoulSplitterUIv2.Ui.ViewModels
{
    /// <summary>
    /// Internally used to represent an even flag with language strings resolved and cached for searching
    /// </summary>
    public class EventFlagViewModel : INotifyPropertyChanged, IFilterableItem
    {
        public EventFlagViewModel(Enum eventFlag, ILanguageManager languageManager)
        {
            EventFlag = eventFlag;
            Flag = Convert.ToUInt32(eventFlag);

            if (languageManager != null && languageManager.Get(eventFlag) is EventFlag eventFlagLanguage)
            {
                Name = eventFlagLanguage.Name;
                Description = eventFlagLanguage.Description;
                Location = eventFlagLanguage.Location;
                _filterValueCache = $"{Flag} {Name} {Description} {Location}";
            }
        }

        #region IFilterableItem

        private readonly string _filterValueCache;
        public string GetFilterValue() => _filterValueCache;

        #endregion

        public uint Flag
        {
            get => _flag;
            set => SetField(ref _flag, value);
        }
        private uint _flag;

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }
        private string _name;

        public string Description
        {
            get => _description;
            set => SetField(ref _description, value);
        }
        private string _description;

        public string Location
        {
            get => _location;
            set => SetField(ref _location, value);
        }
        private string _location;


        public Enum EventFlag
        {
            get => _eventFlag;
            set => SetField(ref _eventFlag, value);
        }
        private Enum _eventFlag;

        #region INotifyPropertyChanged
        private bool SetField<TField>(ref TField field, TField value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<TField>.Default.Equals(field, value)) return false;
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
