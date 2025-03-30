using System;
using System.Windows.Controls;
using System.Windows;
using SoulSplitterUIv2.Resources;

namespace SoulSplitterUIv2.Ui
{
    public class SplitTypeDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EventFlagDataTemplate { get; set; }
        public DataTemplate EnumDataTemplate { get; set; }

        public ILanguageManager LanguageManager { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null)
            {
                return null;
            }

            if (item is Enum e)
            {
                var languageItem = LanguageManager.Get(e);
                var enumType = languageItem.GetType();

                if (enumType == typeof(EventFlag))
                {
                    return EventFlagDataTemplate;
                }
                return EnumDataTemplate;
            }

            return EnumDataTemplate;
        }
    }
}
