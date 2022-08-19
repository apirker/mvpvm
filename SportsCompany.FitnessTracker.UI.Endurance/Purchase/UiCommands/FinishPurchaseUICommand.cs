using SportsCompany.FitnessTracker.UI.Endurance.Purchase.Interfaces;
using SportsCompany.UIFramework;
using System.Windows;

namespace SportsCompany.FitnessTracker.UI.Endurance.Purchase.UiCommands
{
    internal class FinishPurchaseUICommand : UICommandBase<IPurchaseViewModel>
    {
        private readonly IPurchaseEnvironment environment;

        public FinishPurchaseUICommand(IPurchaseEnvironment environment)
        {
            this.environment = environment;
        }

        protected override bool CanExecute(IPurchaseViewModel viewModel)
        {
            return true;
        }

        protected override void Execute(IPurchaseViewModel viewModel)
        {
            MessageBox.Show("Thanks for the purchase!");

            environment.Resolve<IPurchasePresenter>().Close();
        }
    }
}
