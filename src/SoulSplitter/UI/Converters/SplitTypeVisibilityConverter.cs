using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.UI.Converters
{
    internal class SplitTypeVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var result =
                value != null &&
                value is SplitType splitType &&
                parameter is string s &&
                Enum.TryParse(s, out SplitType target) &&
                splitType == target;

            if (result)
            {
                return Visibility.Visible;
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
