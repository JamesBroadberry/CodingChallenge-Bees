namespace Bees.Core.Test.TestResources
{
    /// <summary>
    /// Implementation of the Bee abstract class for test purposes
    /// </summary>
    class TestBee: Bee
    {
        public TestBee(float initialHealth, float deathThresholdPercentage) : base(initialHealth, deathThresholdPercentage) { }
    }
}
