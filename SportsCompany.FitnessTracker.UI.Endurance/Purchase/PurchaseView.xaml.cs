using SportsCompany.FitnessTracker.UI.Endurance.Purchase.Interfaces;
using System.Windows;

namespace SportsCompany.FitnessTracker.UI.Endurance.Purchase
{
    /// <summary>
    /// Interaktionslogik für PurchaseView.xaml
    /// </summary>
    public partial class PurchaseView : Window, IPurchaseView
    {
        public PurchaseView(IPurchaseViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
