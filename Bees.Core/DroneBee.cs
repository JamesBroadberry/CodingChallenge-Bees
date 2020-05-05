namespace Bees.Core
{
    /// <summary>
    /// A type of bee which dies when it's health is less than 50%
    /// </summary>
    public class DroneBee: Bee
    {
        public DroneBee() : base(50) { }
    }
}
