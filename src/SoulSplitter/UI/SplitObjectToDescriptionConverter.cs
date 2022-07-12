using System;
using System.Windows.Data;
using System.Windows.Forms.Design;
using SoulMemory;
using SoulMemory.EldenRing;
using SoulMemory.Memory;

namespace SoulSplitter.UI
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

            if (value?.GetType().IsClass ?? false)
            {
                return value.ToString();
            }
            
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
