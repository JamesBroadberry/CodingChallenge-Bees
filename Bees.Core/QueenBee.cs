namespace Bees.Core
{
    /// <summary>
    /// A type of bee which dies when it's health is less than 20%
    /// </summary>
    public class QueenBee : Bee
    {
        public QueenBee() : base(20) { }
    }
}
