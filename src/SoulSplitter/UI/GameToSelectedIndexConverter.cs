using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using SoulMemory.DarkSouls1_Old.Internal;

namespace SoulSplitter.UI
{
    internal class GameToSelectedIndexConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Game g)
            {
                return (int)g;
            }
            throw new NotSupportedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is int num && num.TryParseEnum(out Game g))
            {
                return g;
            }
            throw new NotSupportedException();
        }
    }
}
