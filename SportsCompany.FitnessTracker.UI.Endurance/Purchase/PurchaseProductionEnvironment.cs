using SportsCompany.DependencyInjection;
using SportsCompany.FitnessTracker.UI.Endurance.Purchase.Interfaces;
using SportsCompany.FitnessTracker.UI.Endurance.Purchase.UiCommands;
using SportsCompany.UIFramework;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.Purchase
{
    internal class PurchaseProductionEnvironment 
        : EnvironmentBase<IPurchasePresenter>
        , IPurchaseEnvironment
    {
        public PurchaseProductionEnvironment
            (IContainer container) : base(container)
        {
        }

        public override void RegisterTypes
            (IPurchasePresenter presenter)
        {
            container.RegisterInstance(presenter);
            container.RegisterInstance(this as IPurchaseEnvironment);

            container.RegisterSingleton<IPurchaseView
                , PurchaseView>();
            container.RegisterSingleton<IPurchaseViewModel
                , PurchaseViewModel>();

            container.Register<ICommand, 
                FinishPurchaseUICommand>(nameof(FinishPurchaseUICommand));
            container.Register<ICommand, 
                CancelPurchaseUICommand>(nameof(CancelPurchaseUICommand));
        }
    }
}
