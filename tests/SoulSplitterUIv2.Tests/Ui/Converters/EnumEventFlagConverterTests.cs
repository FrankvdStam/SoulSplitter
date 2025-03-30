using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoulMemory.Enums;
using SoulMemory.Games.DarkSouls1;
using SoulSplitterUIv2.Resources;
using SoulSplitterUIv2.Ui.Converters;

namespace SoulSplitterUIv2.Tests.Ui.Converters
{
    [TestClass]
    public class EnumEventFlagConverterTests
    {
        [TestInitialize]
        public void Setup()
        {
            _languageManagerMock = new Mock<ILanguageManager>();
            _languageManagerMock
                .Setup(i => i.Get(It.Is<Boss>(b => b == Boss.ArtoriasTheAbysswalker)))
                .Returns(new EventFlag()
                {
                    Name = "Artorias",
                    Description = "Abyss walker",
                    Location = "Oolacile Township",
                });

            _languageManagerMock
                .Setup(i => i.Get(It.Is<SplitType>(b => b == SplitType.Boss)))
                .Returns("Not an event flag object");
        }
        private Mock<ILanguageManager> _languageManagerMock;


        [DataTestMethod]
        [DataRow(EnumEventFlagConverterTarget.Name, "Artorias")]
        [DataRow(EnumEventFlagConverterTarget.Description, "Abyss walker")]
        [DataRow(EnumEventFlagConverterTarget.Location, "Oolacile Township")]
        public void EnumEventFlagConverter_Should_Convert_Type(EnumEventFlagConverterTarget converterTargetType, string expected)
        {
            var converter = new EnumEventFlagConverter();
            converter.LanguageManager = _languageManagerMock.Object;

            var result = converter.Convert(Boss.ArtoriasTheAbysswalker, typeof(string), converterTargetType, CultureInfo.CurrentCulture);

            Assert.IsInstanceOfType<string>(result);
            var str = result as string;
            Assert.AreEqual(expected, str);
        }

        [TestMethod]
        public void Converter_Convert_With_Non_EventFlag_Enum_Should_Throw()
        {
            var converter = new EnumEventFlagConverter();
            converter.LanguageManager = _languageManagerMock.Object;
            Assert.ThrowsException<ArgumentException>(() => converter.Convert(SplitType.Boss, null, EnumEventFlagConverterTarget.Name, null));
        }

        [TestMethod]
        public void EnumEventFlagConverter_Should_Convert_NumericFlag()
        {
            var converter = new EnumEventFlagConverter();
            converter.LanguageManager = _languageManagerMock.Object;

            var result = converter.Convert(Boss.ArtoriasTheAbysswalker, typeof(string), EnumEventFlagConverterTarget.NumericFlag, CultureInfo.CurrentCulture);

            Assert.IsInstanceOfType<int>(result);
            var num = (int)result;
            Assert.AreEqual(11210001, num);
        }

        [TestMethod]
        public void Converter_ConvertBack_Should_Throw()
        {
            var converter = new EnumEventFlagConverter();
            Assert.ThrowsException<NotImplementedException>(() => converter.ConvertBack(null, null, null, null));
        }
    }
}
