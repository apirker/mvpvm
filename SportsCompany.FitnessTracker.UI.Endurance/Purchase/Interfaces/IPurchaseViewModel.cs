using SportsCompany.UIFramework;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.Purchase.Interfaces
{
    /// <summary>
    /// Interface which defines the purchase viewmodel
    /// </summary>
    public interface IPurchaseViewModel : IViewModel
    {
        /// <summary>
        /// Collection holding all the purchase items randomly generated.
        /// </summary>
        ObservableCollection<string> PurchaseItems { get; }
        ICommand FinishPurchaseUICommand { get; set; }
        ICommand CancelPurchaseUICommand { get; set; }
    }
}
