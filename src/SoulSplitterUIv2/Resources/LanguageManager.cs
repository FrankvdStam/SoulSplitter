using System;
using System.Windows;
using SoulSplitterUIv2.Enums;

namespace SoulSplitterUIv2.Resources
{
    public class LanguageManager : ILanguageManager
    {
        private ResourceDictionary _languageDictionary;

        /// <inheritdoc />
        public Language CurrentLanguage { get; set; }

        /// <inheritdoc />
        public event CurrentLanguageChangedEventHandler OnLanguageChanged;

        /// <inheritdoc />
        public void LoadLanguage(Language language)
        {
            _languageDictionary = new ResourceDictionary();
            _languageDictionary.Source = new Uri($"pack://application:,,,/SoulSplitterUIv2;component/Resources/{language}/Language.xaml", UriKind.RelativeOrAbsolute);

            for (int i = 0; i < Application.Current.Resources.MergedDictionaries.Count; i++)
            {
                var dict = Application.Current.Resources.MergedDictionaries[i];
                if (dict.Contains("Language"))
                {
                    Application.Current.Resources.MergedDictionaries[i] = _languageDictionary;
                    break;
                }
            }

            CurrentLanguage = language;
            OnLanguageChanged?.Invoke(this, CurrentLanguage);
        }

        /// <inheritdoc />
        public object Get(object key) => _languageDictionary[key];
    }
}
