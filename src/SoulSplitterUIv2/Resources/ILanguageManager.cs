using SoulSplitterUIv2.Enums;

namespace SoulSplitterUIv2.Resources
{
    public delegate void CurrentLanguageChangedEventHandler(object sender, Language newLanguage);

    public interface ILanguageManager
    {
        /// <summary>
        /// Load the given language
        /// </summary>
        void LoadLanguage(Language language);

        /// <summary>
        /// Returns the current selected and loaded language
        /// </summary>
        Language CurrentLanguage { get; }

        /// <summary>
        /// Event raised whenever a new language is loaded
        /// </summary>
        event CurrentLanguageChangedEventHandler OnLanguageChanged;

        /// <summary>
        /// Attempt to retrieve a language specific object of the current selected language with the given key
        /// </summary>
        object Get(object key);
    }
}
