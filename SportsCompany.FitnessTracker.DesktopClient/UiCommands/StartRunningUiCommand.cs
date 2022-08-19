using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.Interfaces;
using SportsCompany.UIFramework;
using Unity;

namespace SportsCompany.FitnessTracker.DesktopClient.UiCommands
{
    /// <summary>
    /// Ui Command to open the running UI.
    /// </summary>
    class StartRunningUiCommand : UICommandBase<MainWindowViewModel>
    {
        private readonly IUnityContainer unityContainer;

        public StartRunningUiCommand(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }

        protected override bool CanExecute(MainWindowViewModel parameter)
        {
            return true;
        }

        /// <summary>
        /// Command execution.
        /// </summary>
        protected override void Execute(MainWindowViewModel parameter)
        {
            var view = unityContainer.Resolve<IEnduranceMainPresenter>().Show(null);
            view.Show();
        }
    }
}
