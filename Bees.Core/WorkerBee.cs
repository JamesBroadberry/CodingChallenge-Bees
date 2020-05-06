namespace Bees.Core
{
    /// <summary>
    ///     A type of bee which dies when it's health is less than 70%
    /// </summary>
    public class WorkerBee : Bee
    {
        public WorkerBee() : base(70)
        {
        }
    }
}