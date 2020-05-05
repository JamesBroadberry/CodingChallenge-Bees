using Bees.UI.ViewModel;
using System.Windows;

namespace Bees.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new BeesViewModel();
        }

    }
}
