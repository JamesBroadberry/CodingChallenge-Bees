using Bees.Core;
using Bees.UI.Boilerplate;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Bees.UI.ViewModel
{
    public class BeesViewModel
    {
        private readonly Random _random = new Random();

        public BeesViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                Bees.Add(new WorkerBee());
            }

            for (int i = 0; i < 10; i++)
            {
                Bees.Add(new DroneBee());
            }

            for (int i = 0; i < 10; i++)
            {
                Bees.Add(new QueenBee());
            }
        }


        public ObservableCollection<IBee> Bees { get; } = new ObservableCollection<IBee>();

        public ICommand Damage => new RelayCommand(DamageBee);

        private void DamageBee(object e)
        {
            ((IBee)e).Damage(_random.Next(0,80));
        }
    }
}
