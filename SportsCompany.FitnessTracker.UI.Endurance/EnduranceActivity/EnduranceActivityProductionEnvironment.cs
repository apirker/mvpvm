using SportsCompany.DependencyInjection;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.Interfaces;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.UiCommands;
using SportsCompany.UIFramework;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity
{
    class EnduranceActivityProductionEnvironment : EnvironmentBase<IEnduranceActivityPresenter>, IEnduranceActivityEnvironment
    {
        public EnduranceActivityProductionEnvironment(IContainer container) : base(container)
        {
        }

        public override void RegisterTypes(IEnduranceActivityPresenter presenter)
        {
            container.RegisterInstance(presenter);
            container.RegisterInstance(this as IEnduranceActivityEnvironment);

            container.RegisterSingleton<IEnduranceActivityView, EnduranceActivityView>();
            container.RegisterSingleton<IEnduranceActivityViewModel, EnduranceActivityViewModel>();

            container.Register<ICommand, StartActivityUiCommand>(nameof(StartActivityUiCommand));
            container.Register<ICommand, StopActivityUiCommand>(nameof(StopActivityUiCommand));
            container.Register<ICommand, SaveActivityUiCommand>(nameof(SaveActivityUiCommand));
        }
    }
}
