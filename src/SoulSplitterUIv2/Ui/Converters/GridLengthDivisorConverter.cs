using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SoulSplitterUIv2.Ui.Converters
{
    public class GridLengthDivisorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double width && parameter is string s && int.TryParse(s, out int divisor))
            {
                return new GridLength(width / divisor);
            }

            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
