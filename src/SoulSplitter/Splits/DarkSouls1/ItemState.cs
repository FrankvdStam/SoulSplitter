using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SoulMemory.DarkSouls1;

namespace SoulSplitter.Splits.DarkSouls1
{
    [XmlType(Namespace = "DarkSouls1")]
    public class ItemState : INotifyPropertyChanged
    {
        public ItemType? ItemType
        {
            get => _itemType;
            set => SetField(ref _itemType, value);
        }
        private ItemType? _itemType;

        private string ItemString => Item.AllItems.FirstOrDefault(i => i.ItemType == ItemType)?.Name ?? "";

        public override string ToString()
        {
            return $"{ItemString}";
        }

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
