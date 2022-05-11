using System;
using System.Windows.Data;
using SoulMemory.EldenRing;
using SoulMemory.Memory;

namespace SoulSplitter.UI.EldenRing
{
    public class SplitObjectToDescriptionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Enum e)
            {
                return e.GetDisplayName();
            }

            if (value is Item i)
            {
                return i.Name;
            }

            if (value is uint u)
            {
                return u;
            }

            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
