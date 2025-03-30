using SoulSplitterUIv2.Resources;
using System;
using System.Globalization;
using System.Windows.Data;

namespace SoulSplitterUIv2.Ui.Converters
{
    public enum EnumEventFlagConverterTarget
    {
        NumericFlag,
        Name,
        Description,
        Location,
    }

    /// <summary>
    /// Converts an event flag enum to a language target type, name/description etc.
    /// </summary>
    public class EnumEventFlagConverter : IValueConverter
    {
        public ILanguageManager LanguageManager { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Enum key && parameter is EnumEventFlagConverterTarget target)
            {
                var obj = LanguageManager.Get(key);
                if (obj is EventFlag eventFlag)
                {
                    switch (target)
                    {
                        case EnumEventFlagConverterTarget.NumericFlag:
                            return System.Convert.ToInt32(key);
                        case EnumEventFlagConverterTarget.Name:
                            return eventFlag.Name;
                        case EnumEventFlagConverterTarget.Description:
                            return eventFlag.Description;
                        case EnumEventFlagConverterTarget.Location:
                            return eventFlag.Location;
                    }
                }
                throw new ArgumentException($"{key} is not an event flag. Cannot convert.");
            }
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
