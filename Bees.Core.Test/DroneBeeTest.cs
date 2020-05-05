using NUnit.Framework;

namespace Bees.Core.Test
{
    public class DroneBeeTest
    {
        [Test]
        public void WhenADroneBeeIsCreated_ItsHealthIsOneHundred()
        {
            // Arrange
            var droneBee = new DroneBee();

            // Assert
            Assert.AreEqual(100, droneBee.Health);
        }

        [Test]
        public void WhenADroneBeeIsCreated_ItIsAlive()
        {
            // Arrange
            var droneBee = new DroneBee();

            // Assert
            Assert.IsFalse(droneBee.IsDead);
        }

        [Test]
        public void WhenDamagingADroneBeeForFiftyPercent_ItIsAlive()
        {
            // Arrange
            var droneBee = new DroneBee();

            // Act
            droneBee.Damage(50);

            // Assert
            Assert.IsFalse(droneBee.IsDead);
        }

        [Test]
        public void WhenDamagingADroneBeeForFiftyOne_ItIsDead()
        {
            // Arrange
            var droneBee = new DroneBee();

            // Act
            droneBee.Damage(51);

            // Assert
            Assert.IsTrue(droneBee.IsDead);
        }
    }
}
