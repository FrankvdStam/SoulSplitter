using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SoulSplitter.Resources;
using System.IO.Packaging;
using System.Windows;
using SoulMemory.Enums;

namespace SoulSplitter.Tests.Resources
{
    [TestClass]
    public class LanguageManagerTests
    {
        [STATestMethod]
        public void LanguageManager_Should_Load_Languages()
        {
            //packurihelper needs to be called to init some WPF related things.
            //Same for the windows.application
            var uri = PackUriHelper.Create(new Uri("reliable://0"));

            //Make sure the application is started, ignore errors
            try
            {
                var _ = new Application { ShutdownMode = ShutdownMode.OnExplicitShutdown };
                Application.ResourceAssembly = typeof(LanguageManager).Assembly;
            }
            catch
            {
                //ignored
            }
            
        
            var languageDictionary = new ResourceDictionary();
            languageDictionary.Source = new Uri($"pack://application:,,,/SoulSplitter;component/Resources/{Language.English}/Language.xaml", UriKind.RelativeOrAbsolute);
            Application.Current.Resources.MergedDictionaries.Add(languageDictionary);
        
            ILanguageManager languageManager = new LanguageManager();
            var onLanguageChangedIsCalled = false;
            languageManager.OnLanguageChanged += (o, l) =>
            {
                onLanguageChangedIsCalled = true;
            };
            
            languageManager.LoadLanguage(Language.English);
            var boss = languageManager.Get(SoulMemory.Games.EldenRing.Boss.AbductorVirginsVolcanoManor);
            
            Assert.IsInstanceOfType<EventFlag>(boss);
            var eventFlag = (EventFlag)boss;
            Assert.AreEqual("Abductor Virgins", eventFlag.Name);
            Assert.AreEqual("Volcano Manor", eventFlag.Location);
            Assert.IsTrue(onLanguageChangedIsCalled);
        }
    }
}
