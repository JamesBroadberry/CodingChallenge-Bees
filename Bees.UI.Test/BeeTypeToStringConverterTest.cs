using Bees.Core;
using Bees.UI.Converters;
using NUnit.Framework;
using System;

namespace Bees.UI.Test
{
    class BeeTypeToStringConverterTest
    {
        [Test]
        public void WhenConvertingAWorkerBeeToTypeString_CorrectStringIsReturned()
        {
            // Arrange
            var bee = new WorkerBee();
            var converter = new BeeTypeToStringConverter();

            // Act
            var beeTypeString = converter.Convert(bee, null, null, null);

            // Assert
            Assert.AreEqual("Worker Bee", beeTypeString);
        }

        [Test]
        public void WhenConvertingADroneBeeToTypeString_CorrectStringIsReturned()
        {
            // Arrange
            var bee = new DroneBee();
            var converter = new BeeTypeToStringConverter();

            // Act
            var beeTypeString = converter.Convert(bee, null, null, null);

            // Assert
            Assert.AreEqual("Drone Bee", beeTypeString);
        }

        [Test]
        public void WhenConvertingAQueenBeeToTypeString_CorrectStringIsReturned()
        {
            // Arrange
            var bee = new QueenBee();
            var converter = new BeeTypeToStringConverter();

            // Act
            var beeTypeString = converter.Convert(bee, null, null, null);

            // Assert
            Assert.AreEqual("Queen Bee", beeTypeString);
        }

        [Test]
        public void WhenConvertingAnUnknownObjectToTypeString_CorrectStringIsReturned()
        {
            // Arrange
            var bee = new object();
            var converter = new BeeTypeToStringConverter();

            // Act
            var beeTypeString = converter.Convert(bee, null, null, null);

            // Assert
            Assert.AreEqual("Unknown Bee", beeTypeString);
        }

        [Test]
        public void WhenConvertingANullToTypeString_EmptyStringIsReturned()
        {
            // Arrange
            var converter = new BeeTypeToStringConverter();

            // Act
            var beeTypeString = converter.Convert(null, null, null, null);

            // Assert
            Assert.AreEqual(string.Empty, beeTypeString);
        }

        [Test]
        public void WhenConvertingBackToBeeTypeFromString_NotImplementedExceptionIsThrown()
        {
            // Arrange
            var converter = new BeeTypeToStringConverter();

            // Act & Assert
            Assert.Throws<NotImplementedException>(
                delegate { converter.ConvertBack("Anything", null, null, null); }
            );
        }
    }
}
