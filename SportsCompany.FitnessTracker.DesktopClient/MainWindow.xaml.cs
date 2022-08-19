using SportsCompany.FitnessTracker.DesktopClient.UiCommands;
using SportsCompany.FitnessTracker.Domain;
using SportsCompany.FitnessTracker.UI.Endurance;
using SportsCompany.UIFramework;
using SportsCompany.UIFramework.Windows;
using System.Windows;
using System.Windows.Input;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.DesktopClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly UnityContainer unityContainer;

        public MainWindow()
        {
            InitializeComponent();

            var container = UiFrameworkWindows.Initialize();

            UiEnduranceInitializer.Init(container);
            EnduranceDomainInitializer.Initialize(container);

            container.RegisterSingleton<MainWindowViewModel, MainWindowViewModel>();
            container.Register<ITriggeredCommand, StartRunningUiCommand>(nameof(StartRunningUiCommand));

            DataContext = container.Resolve<MainWindowViewModel>();
        }
    }
}
