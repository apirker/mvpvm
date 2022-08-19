using SportsCompany.FitnessTracker.UI.Endurance.Purchase.Interfaces;
using SportsCompany.UIFramework;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.Purchase
{
    public class PurchaseViewModel : ViewModelBase, IPurchaseViewModel
    {
        public PurchaseViewModel(IPurchaseEnvironment purchaseEnvironment)
        {
            FinishPurchaseUICommand = purchaseEnvironment.Resolve<ICommand>(nameof(UiCommands.FinishPurchaseUICommand));
            CancelPurchaseUICommand = purchaseEnvironment.Resolve<ICommand>(nameof(UiCommands.CancelPurchaseUICommand));
        }

        private ObservableCollection<string> purchaseItems = new ObservableCollection<string>();
        public ObservableCollection<string> PurchaseItems => purchaseItems;

        public ICommand FinishPurchaseUICommand { get; set; }

        public ICommand CancelPurchaseUICommand { get; set; }
    }
}
