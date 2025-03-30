using System;
using System.Globalization;
using System.Windows.Data;
using SoulSplitterUIv2.Resources;

namespace SoulSplitterUIv2.Ui.Converters
{
    /// <summary>
    /// Converts an enum key to a language string
    /// </summary>
    public class EnumLanguageConverter : IValueConverter
    {
        public ILanguageManager LanguageManager { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Enum key)
            {
                return LanguageManager.Get(key);
            }
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
