using System.ComponentModel;

namespace Bees.Core
{
    public abstract class Bee : IBee, INotifyPropertyChanged
    {
        public Bee(float initialHealth, float deathThresholdPercentage)
        {
            _deathThreshold = initialHealth * (deathThresholdPercentage / 100);
            _health = initialHealth;
        }

        public Bee(float deathThresholdPercentage) : this(100, deathThresholdPercentage) { }

        private readonly float _deathThreshold;

        public event PropertyChangedEventHandler PropertyChanged;

        private float _health; 
        public float Health 
        { 
            get 
            {
                return _health;
            }
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
            if (IsDead)
            {
                return;
            }

            Health -= Health * (percentage / 100f);
        }

        public override string ToString()
        {
            return $"{GetType()} with {Health} health and is {(IsDead ? "dead" : "alive")}";
        }
    }
}
