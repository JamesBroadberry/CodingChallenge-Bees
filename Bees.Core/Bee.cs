using System.ComponentModel;

namespace Bees.Core
{
    public abstract class Bee : IBee, INotifyPropertyChanged
    {
        private readonly float _deathThreshold;

        private float _health;

        protected Bee(float initialHealth, float deathThresholdPercentage)
        {
            _deathThreshold = initialHealth * (deathThresholdPercentage / 100);
            _health = initialHealth;
        }

        protected Bee(float deathThresholdPercentage) : this(100, deathThresholdPercentage)
        {
        }

        public float Health
        {
            get => _health;
            set
            {
                _health = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Health)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsDead)));
            }
        }


        public bool IsDead => Health < _deathThreshold;

        public void Damage(int percentage)
        {
            if (IsDead) return;

            if (percentage > 100) percentage = 100;
            if (percentage < 0) percentage = 0;

            Health -= Health * (percentage / 100f);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return $"{GetType()} with {Health} health and is {(IsDead ? "dead" : "alive")}";
        }
    }
}