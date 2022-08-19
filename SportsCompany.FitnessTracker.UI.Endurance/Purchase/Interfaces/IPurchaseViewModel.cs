using SportsCompany.UIFramework;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.Purchase.Interfaces
{
    public interface IPurchaseViewModel : IViewModel
    {
        ObservableCollection<string> PurchaseItems { get; }
        ICommand FinishPurchaseUICommand { get; set; }
        ICommand CancelPurchaseUICommand { get; set; }
    }
}
