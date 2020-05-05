using NUnit.Framework;

namespace Bees.Core.Test
{
    public class QueenBeeTest
    {
        [Test]
        public void WhenAQueenBeeIsCreated_ItsHealthIsOneHundred()
        {
            // Arrange
            var queenBee = new QueenBee();

            // Assert
            Assert.AreEqual(100, queenBee.Health);
        }

        [Test]
        public void WhenAQueenBeeIsCreated_ItIsAlive()
        {
            // Arrange
            var queenBee = new QueenBee();

            // Assert
            Assert.IsFalse(queenBee.IsDead);
        }

        [Test]
        public void WhenDamagingAQueenBeeForEightyPercent_ItIsAlive()
        {
            // Arrange
            var queenBee = new QueenBee();

            // Act
            queenBee.Damage(80);

            // Assert
            Assert.IsFalse(queenBee.IsDead);
        }

        [Test]
        public void WhenDamagingAQueenBeeForEightyOne_ItIsDead()
        {
            // Arrange
            var queenBee = new QueenBee();

            // Act
            queenBee.Damage(81);

            // Assert
            Assert.IsTrue(queenBee.IsDead);
        }
    }
}
