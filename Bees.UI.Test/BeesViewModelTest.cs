using Bees.Core;
using Bees.UI.ViewModel;
using NUnit.Framework;
using System.Linq;

namespace Bees.UI.Test
{
    public class BeesViewModelTest
    {
        [Test]
        public void WhenSettingUpTheViewModel_ThirtyBeesArePresent()
        {
            // Arrange
            var viewModel = new BeesViewModel();

            // Assert
            Assert.AreEqual(30, viewModel.Bees.Count);
        }

        [Test]
        public void WhenSettingUpTheViewModel_TenBeesAreWorkerBees()
        {
            // Arrange
            var viewModel = new BeesViewModel();

            // Assert
            Assert.AreEqual(10, viewModel.Bees.Count(x => x.GetType() == typeof(WorkerBee)));
        }

        [Test]
        public void WhenSettingUpTheViewModel_TenBeesAreDroneBees()
        {
            // Arrange
            var viewModel = new BeesViewModel();

            // Assert
            Assert.AreEqual(10, viewModel.Bees.Count(x => x.GetType() == typeof(DroneBee)));
        }

        [Test]
        public void WhenSettingUpTheViewModel_TenBeesAreQueenBees()
        {
            // Arrange
            var viewModel = new BeesViewModel();

            // Assert
            Assert.AreEqual(10, viewModel.Bees.Count(x => x.GetType() == typeof(QueenBee)));
        }

        [Test]
        public void WhenCallingTheDamageCommandForABee_TheBeeIsDamaged()
        {
            // Arrange
            var viewModel = new BeesViewModel();
            var beeToDamage = viewModel.Bees.First();
            var beeHealthDamaged = false;
         
            ((Bee)beeToDamage).PropertyChanged += (sender, e) => {
                if (e.PropertyName == nameof(Bee.Health))
                {
                    beeHealthDamaged = true;
                }
            };

            // Act
            viewModel.Damage.Execute(beeToDamage);

            // Assert
            Assert.IsTrue(beeHealthDamaged);
        }

    }
}