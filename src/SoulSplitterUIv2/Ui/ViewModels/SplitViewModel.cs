using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SoulSplitterUIv2.Enums;

namespace SoulSplitterUIv2.Ui.ViewModels
{
    public class SplitViewModel
    {
        public SplitViewModel(){}

        public SplitViewModel(Game game, int newGamePlusLevel, TimingType timingType, SplitType splitType, object split, string userDescription)
        {
            Game = game;
            NewGamePlusLevel = newGamePlusLevel;
            TimingType = timingType;
            SplitType = splitType;
            Split = split;
            Description = userDescription;
        }

        #region Bindable
        public string Description { get; set; }

        public Game Game { get; set; }
        public int NewGamePlusLevel { get; set; }
        public TimingType TimingType { get; set; }
        public SplitType SplitType { get; set; }
        public object Split{ get; set; }

        #endregion

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
