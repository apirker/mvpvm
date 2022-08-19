using SportsCompany.DependencyInjection;
using SportsCompany.UIFramework;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.DesktopClient
{
    /// <summary>
    /// Main view model of the first window.
    /// </summary>
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(IContainer container)
        {
            StartRunningUiCommand = container.Resolve<ITriggeredCommand>(nameof(UiCommands.StartRunningUiCommand));
            StartRunningUiCommand.TriggerCanExecuteChanged();
        }
        /// <summary>
        /// Ui command to open the running.
        /// </summary>
        public ITriggeredCommand StartRunningUiCommand { get; set; }
    }
}
