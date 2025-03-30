using System;
using System.Globalization;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulSplitterUIv2.Ui.Converters;

namespace SoulSplitterUIv2.Tests.Ui.Converters
{
    [TestClass]
    public class GridLengthDivisorConverterTests
    {
        [DataTestMethod]
        [DataRow(500, "2", 250)]
        [DataRow(300, "3", 100)]
        public void GridLengthDivisorConverter_Convert_Should_Divide(double width, string divisor, double expected)
        {
            var converter = new GridLengthDivisorConverter();

            var result = converter.Convert(width, typeof(string), divisor, CultureInfo.CurrentCulture);

            Assert.IsInstanceOfType<GridLength>(result);
            var len = (GridLength)result;
            Assert.AreEqual(expected, len.Value);
        }

        [TestMethod]
        public void Converter_ConvertBack_Should_Throw()
        {
            var converter = new GridLengthDivisorConverter();
            Assert.ThrowsException<NotImplementedException>(() => converter.ConvertBack(null, null, null, null));
        }
    }
}
