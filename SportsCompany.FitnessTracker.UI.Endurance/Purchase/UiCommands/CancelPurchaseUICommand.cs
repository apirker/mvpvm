using SportsCompany.FitnessTracker.UI.Endurance.Purchase.Interfaces;
using SportsCompany.UIFramework;
using System.Windows;

namespace SportsCompany.FitnessTracker.UI.Endurance.Purchase.UiCommands
{
    public class CancelPurchaseUICommand : UICommandBase<IPurchaseViewModel>
    {
        private readonly IPurchaseEnvironment purchaseEnvironment;

        public CancelPurchaseUICommand(IPurchaseEnvironment purchaseEnvironment)
        {
            this.purchaseEnvironment = purchaseEnvironment;
        }

        protected override bool CanExecute(IPurchaseViewModel viewModel)
        {
            return true;
        }

        protected override void Execute(IPurchaseViewModel viewModel)
        {
            MessageBox.Show("Cancelled the purchase!");
            purchaseEnvironment.Resolve<IPurchasePresenter>().Close();
        }
    }
}
