namespace Bees.Core
{
    public interface IBee
    {
        /// <summary>
        ///     The remaining health of the bee
        /// </summary>
        float Health { get; }

        /// <summary>
        ///     Whether the bee is dead
        /// </summary>
        bool IsDead { get; }

        /// <summary>
        ///     Damage the bee by a percentage of it's remaining health
        /// </summary>
        /// <param name="percentage">The percentage of health to damage the bee by</param>
        void Damage(int percentage);
    }
}