using NUnit.Framework;

namespace Bees.Core.Test
{
    public class WorkerBeeTest
    {
        [Test]
        public void WhenAWorkerBeeIsCreated_ItsHealthIsOneHundred()
        {
            // Arrange
            var workerBee = new WorkerBee();

            // Assert
            Assert.AreEqual(100, workerBee.Health);
        }

        [Test]
        public void WhenAWorkerBeeIsCreated_ItIsAlive()
        {
            // Arrange
            var workerBee = new WorkerBee();

            // Assert
            Assert.IsFalse(workerBee.IsDead);
        }

        [Test]
        public void WhenDamagingAWorkerBeeForThirtyPercent_ItIsAlive()
        {
            // Arrange
            var workerBee = new WorkerBee();

            // Act
            workerBee.Damage(30);

            // Assert
            Assert.IsFalse(workerBee.IsDead);
        }

        [Test]
        public void WhenDamagingAWorkerBeeForThirtyOne_ItIsDead()
        {
            // Arrange
            var workerBee = new WorkerBee();

            // Act
            workerBee.Damage(31);

            // Assert
            Assert.IsTrue(workerBee.IsDead);
        }
    }
}
