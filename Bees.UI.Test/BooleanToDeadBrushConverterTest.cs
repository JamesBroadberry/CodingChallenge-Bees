using Bees.UI.Converters;
using NUnit.Framework;
using System;
using System.Windows.Media;

namespace Bees.UI.Test
{
    class BooleanToDeadBrushConverterTest
    {
        [Test]
        public void WhenConvertingTrueToBrush_RedBrushIsReturned()
        {
            // Arrange
            var converter = new BooleanToDeadBrushConverter();

            // Act
            var beeTypeString = converter.Convert(true, null, null, null);

            // Assert
            Assert.AreEqual(Brushes.Red, beeTypeString);
        }

        [Test]
        public void WhenConvertingFalseToBrush_GreenBrushIsReturned()
        {
            // Arrange
            var converter = new BooleanToDeadBrushConverter();

            // Act
            var beeTypeString = converter.Convert(false, null, null, null);

            // Assert
            Assert.AreEqual(Brushes.Green, beeTypeString);
        }

        [Test]
        public void WhenConvertingNonBoolToBrush_BlackBrushIsReturned()
        {
            // Arrange
            var converter = new BooleanToDeadBrushConverter();

            // Act
            var beeTypeString = converter.Convert(new object(), null, null, null);

            // Assert
            Assert.AreEqual(Brushes.Black, beeTypeString);
        }

        [Test]
        public void WhenConvertingNullToBrush_BlackBrushIsReturned()
        {
            // Arrange
            var converter = new BooleanToDeadBrushConverter();

            // Act
            var beeTypeString = converter.Convert(null, null, null, null);

            // Assert
            Assert.AreEqual(Brushes.Black, beeTypeString);
        }

        [Test]
        public void WhenConvertingBackToBoolFromBrush_NotImplementedExceptionIsThrown()
        {
            // Arrange
            var converter = new BooleanToDeadBrushConverter();

            // Act & Assert
            Assert.Throws<NotImplementedException>(
                delegate { converter.ConvertBack("Black", null, null, null); }
            );
        }
    }
}
