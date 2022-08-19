using SportsCompany.DependencyInjection;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.Interfaces;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.Interfaces;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.UiCommands;
using SportsCompany.FitnessTracker.UI.Endurance.Purchase;
using SportsCompany.FitnessTracker.UI.Endurance.Purchase.Interfaces;
using SportsCompany.UIFramework;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain
{
    public class EnduranceMainProductionEnvironment : EnvironmentBase<IEnduranceMainPresenter>, IEnduranceMainEnvironment
    {
        public EnduranceMainProductionEnvironment(IContainer container) : base(container)
        {
        }

        public override void RegisterTypes(IEnduranceMainPresenter presenter)
        {
            container.RegisterInstance(presenter);
            container.RegisterInstance(this as IEnduranceMainEnvironment);

            container.RegisterSingleton<IEnduranceMainView, EnduranceMainView>();
            container.RegisterSingleton<IEnduranceMainViewModel, EnduranceMainViewModel>();
            
            container.Register<IEnduranceActivityEnvironment, EnduranceActivityProductionEnvironment>();
            container.Register<IEnduranceActivityPresenter, EnduranceActivityPresenter>(); ;

            container.Register<IPurchaseEnvironment, PurchaseProductionEnvironment>();
            container.Register<IPurchasePresenter, PurchasePresenter>();

            container.Register<ICommand, OpenNewEnduranceUiCommand>(nameof(OpenNewEnduranceUiCommand));
            container.Register<ICommand, OpenNewPurchaseUiCommand>(nameof(OpenNewPurchaseUiCommand));
        }
    }
}
