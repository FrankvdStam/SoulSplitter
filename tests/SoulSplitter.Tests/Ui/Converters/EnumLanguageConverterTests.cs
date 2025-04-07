using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoulSplitter.Resources;
using SoulSplitter.Ui.Converters;
using System.Globalization;
using System;
using SoulMemory.Enums;

namespace SoulSplitter.Tests.Ui.Converters
{
    [TestClass]
    public class EnumLanguageConverterTests
    {
        [TestInitialize]
        public void Setup()
        {
            _languageManagerMock = new Mock<ILanguageManager>();
            _languageManagerMock
                .Setup(i => i.Get(It.Is<SplitType>(e => e == SplitType.Bonfire)))
                .Returns("Bonfire/Idol/Grace");
        }
        private Mock<ILanguageManager> _languageManagerMock  = null!;

        [TestMethod]
        public void EnumLanguageConverter_Should_Convert()
        {
            var converter = new EnumLanguageConverter();
            converter.LanguageManager = _languageManagerMock.Object;

            var result = converter.Convert(SplitType.Bonfire, typeof(string), null, CultureInfo.CurrentCulture);

            Assert.IsInstanceOfType<string>(result);
            var name = (string)result;
            Assert.AreEqual("Bonfire/Idol/Grace", name);
        }

        [TestMethod]
        public void Converter_ConvertBack_Should_Throw()
        {
            var converter = new EnumLanguageConverter();
            Assert.ThrowsException<NotImplementedException>(() => converter.ConvertBack(null, null!, null, null!));
        }
    }
}
