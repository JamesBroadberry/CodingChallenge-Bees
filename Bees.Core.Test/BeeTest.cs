using Bees.Core.Test.TestResources;
using NUnit.Framework;

namespace Bees.Core.Test
{
    public class BeeTest
    {
        [Test]
        public void WhenABeeIsFirstCreated_ItIsNotDead()
        {
            // Arrange
            var bee = new TestBee(100, 50);

            // Assert
            Assert.IsFalse(bee.IsDead);
        }

        [Test]
        public void WhenABeeIsDamagedByFourtyNinePercent_ItsHealthIsReducedToFiftyOnePercent()
        {
            // Arrange
            var initialHealth = 50f;
            var fiftyOnePercentOfInitialHealth = initialHealth * 0.51;
            var bee = new TestBee(initialHealth, 50);

            // Act
            bee.Damage(49);

            // Assert
            Assert.AreEqual(fiftyOnePercentOfInitialHealth, bee.Health);
        }

        [Test]
        public void WhenABeeIsDamagedByFiftyPercent_ItsHealthIsReducedByFiftyPercent()
        {
            // Arrange
            var initialHealth = 50f;
            var fiftyPercentOfInitialHealth = initialHealth * 0.5;
            var bee = new TestBee(initialHealth, 50);

            // Act
            bee.Damage(50);

            // Assert
            Assert.AreEqual(fiftyPercentOfInitialHealth, bee.Health);
        }

        [Test]
        public void WhenABeeIsDamagedByFiftyOnePercent_ItsHealthIsReducedToFourtyNinePercent()
        {
            // Arrange
            var initialHealth = 50f;
            var fourtyNinePercentOfInitialHealth = initialHealth * 0.49;
            var bee = new TestBee(initialHealth, 50);

            // Act
            bee.Damage(51);

            // Assert
            Assert.AreEqual(fourtyNinePercentOfInitialHealth, bee.Health);
        }

        [Test]
        public void WhenDamagingABeeTwiceForFiftyPercent_ItsHealthIsReducedToTwentyFivePercent()
        {
            // Arrange
            var initialHealth = 50f;
            var twentyFivePercentOfInitialHealth = initialHealth * 0.25;
            var bee = new TestBee(initialHealth, 10);

            // Act
            bee.Damage(50);
            bee.Damage(50);

            // Assert
            Assert.AreEqual(twentyFivePercentOfInitialHealth, bee.Health);
        }

        [Test]
        public void WhenDamagingADeadBee_NoFurtherHeathDeductionsAreMadeAndNoErrorIsThrown()
        {
            // Arrange
            var initialHealth = 50f;
            var bee = new TestBee(initialHealth, 99);

            // Act
            bee.Damage(50);
            var healthAfterFirstDamage = bee.Health;

            bee.Damage(50);
            var healthAfterSecondDamage = bee.Health;

            // Assert
            Assert.AreEqual(healthAfterFirstDamage, healthAfterSecondDamage);
        }


        [Test]
        public void WhenABeeIsDamagedSlightlyLessThanItsThreshold_ItLives()
        {
            // Arrange
            var threshold = 50;
            var bee = new TestBee(50, threshold);

            // Act
            bee.Damage(threshold - 1);

            // Assert
            Assert.IsFalse(bee.IsDead);
        }

        [Test]
        public void WhenABeeIsDamagedByExactlyItsThreshold_ItLives()
        {
            // Arrange
            var threshold = 50;
            var bee = new TestBee(50, threshold);

            // Act
            bee.Damage(threshold);

            // Assert
            Assert.IsFalse(bee.IsDead);
        }

        [Test]
        public void WhenABeeIsDamagedSlightlyMoreThanItsThreshold_ItDies()
        {
            // Arrange
            var threshold = 50;
            var bee = new TestBee(50, threshold);

            // Act
            bee.Damage(threshold + 1);

            // Assert
            Assert.IsTrue(bee.IsDead);
        }

        [Test]
        public void WhenABeeIsDamagedMoreThanOneHundredPercent_ItsHealthIsZero()
        {
            // Arrange
            var bee = new TestBee(50, 50);

            // Act
            bee.Damage(200);

            // Assert
            Assert.AreEqual(0, bee.Health);
        }

        [Test]
        public void WhenABeeIsDamagedLessThanZeroPercent_ItsHealthIsUnchanged()
        {
            // Arrange
            var initialHealth = 50;
            var bee = new TestBee(initialHealth, 50);

            // Act
            bee.Damage(-100);

            // Assert
            Assert.AreEqual(initialHealth, bee.Health);
        }

        [Test]
        public void WhenCallingToStringOnABee_TheStringContainsItsHealth()
        {
            // Arrange
            var bee = new TestBee(50, 50);

            // Act
            var beeString = bee.ToString();

            // Assert
            Assert.IsTrue(beeString.Contains(bee.Health.ToString()));
        }

        [Test]
        public void WhenCallingToStringOnABeeAndTheBeeIsAlive_TheStringContainsAlive()
        {
            // Arrange
            var bee = new TestBee(50, 50);

            // Act
            var beeString = bee.ToString();

            // Assert
            Assert.IsTrue(beeString.Contains("alive"));
        }

        [Test]
        public void WhenCallingToStringOnABeeAndTheBeeIsDead_TheStringContainsDead()
        {
            // Arrange
            var bee = new TestBee(50, 50);

            // Act
            bee.Damage(100);
            var beeString = bee.ToString();

            // Assert
            Assert.IsTrue(beeString.Contains("dead"));
        }

        [Test]
        public void WhenCallingToStringOnABee_TheStringContainsItsType()
        {
            // Arrange
            var bee = new TestBee(50, 50);

            // Act
            bee.Damage(100);
            var beeString = bee.ToString();

            // Assert
            Assert.IsTrue(beeString.Contains("TestBee"));
        }
    }
}