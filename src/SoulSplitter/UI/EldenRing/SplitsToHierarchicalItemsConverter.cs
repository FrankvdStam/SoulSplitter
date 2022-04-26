using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using SoulSplitter.Splits.EldenRing;

namespace SoulSplitter.UI.EldenRing
{
    internal class SplitsToHierarchicalItemsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //if (value is ObservableCollection<SplitViewModel> splits)
            //{
            //    var result = new List<TreeViewItem>();
            //
            //    var sorted = splits.OrderBy(i => i.TimingType).ThenBy(i => i.SplitType).ToList();
            //    if (!sorted.Any())
            //    {
            //        return result;
            //    }
            //
            //    TimingType? currentTimingType = null;
            //    SplitType? currentSplitType = null;
            //    
            //    TreeViewItem timingTypeParent = null;
            //    TreeViewItem splitTypeParent = null;
            //
            //    foreach (var split in sorted)
            //    {
            //        if (!currentTimingType.HasValue || currentTimingType != split.TimingType)
            //        {
            //            currentSplitType = null;
            //            timingTypeParent = new TreeViewItem();
            //            timingTypeParent.Header = split.TimingType.GetDisplayName();
            //            result.Add(timingTypeParent);
            //            currentTimingType = split.TimingType;
            //        }
            //
            //        if (!currentSplitType.HasValue || currentSplitType != split.SplitType)
            //        {
            //            splitTypeParent = new TreeViewItem();
            //            splitTypeParent.Header = split.SplitType.GetDisplayName();
            //            timingTypeParent.Items.Add(splitTypeParent);
            //            currentSplitType = split.SplitType;
            //        }
            //
            //        var item = new TreeViewItem
            //        {
            //            Header = split.Boss.GetDisplayName(),
            //            Tag = split,
            //        };
            //
            //        splitTypeParent.Items.Add(item);
            //    }
            //
            //    return result;
            //}

            throw new NotSupportedException();
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
