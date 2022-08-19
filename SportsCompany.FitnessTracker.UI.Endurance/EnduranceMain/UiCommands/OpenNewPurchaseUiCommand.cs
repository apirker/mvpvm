using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.Interfaces;
using SportsCompany.FitnessTracker.UI.Endurance.Purchase.Interfaces;
using SportsCompany.UIFramework;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.UiCommands
{
    internal class OpenNewPurchaseUiCommand : UICommandBase<IEnduranceMainViewModel>
    {
        private readonly IEnduranceMainEnvironment environment;

        public OpenNewPurchaseUiCommand(IEnduranceMainEnvironment environment)
        {
            this.environment = environment;
        }
        protected override bool CanExecute(IEnduranceMainViewModel viewModel)
        {
            return true;
        }

        protected override void Execute
            (IEnduranceMainViewModel viewModel)
        {
            var presenter = environment
                .Resolve<IPurchasePresenter>();
            var navigationService = environment
                .Resolve<INavigationService>();

            navigationService.Navigate(presenter, null);
        }
    }
}
