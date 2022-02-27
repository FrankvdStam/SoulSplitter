using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SoulSplitter.Splits;
using SoulSplitter.Splits.DarkSouls2;

namespace SoulSplitter.UI.ViewModel
{
    public class DarkSouls2ViewModel : INotifyPropertyChanged
    {
        #region Splits
        public ObservableCollection<SplitViewModel> Splits { get; set; } = new ObservableCollection<SplitViewModel>();
        public List<ISplit> GetSplits()
        {
            var splits = new List<ISplit>();
            foreach (var splitViewModel in Splits)
            {
                switch (splitViewModel.SplitType)
                {
                    case SplitType.Boss:
                        splits.Add(splitViewModel.BossSplit);
                        break;

                    case SplitType.Item:
                        splits.Add(splitViewModel.ItemSplit);
                        break;

                    case SplitType.Box:
                        splits.Add(splitViewModel.BoxSplit);
                        break;
                }
            }
            return splits;
        }

        public void SetSplits(List<ISplit> splits)
        {
            Splits.Clear();
            foreach (var split in splits)
            {
                Splits.Add(new SplitViewModel(split));
            }
        }

        #endregion



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
