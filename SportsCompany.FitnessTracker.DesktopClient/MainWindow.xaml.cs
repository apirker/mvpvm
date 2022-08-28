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

            //boot strap the windows framework
            var container = UiFrameworkWindows.Initialize();

            //register the ui parts for handling endurance
            UiEnduranceInitializer.Init(container);

            //register the domain parts for handling endurance
            EnduranceDomainInitializer.Initialize(container);

            //register the main view and the ui command to the DI container
            container.RegisterSingleton<MainWindowViewModel, MainWindowViewModel>();
            container.Register<ITriggeredCommand, StartRunningUiCommand>(nameof(StartRunningUiCommand));

            DataContext = container.Resolve<MainWindowViewModel>();
        }
    }
}
