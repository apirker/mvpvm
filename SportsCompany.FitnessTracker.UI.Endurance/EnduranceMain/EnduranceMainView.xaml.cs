using SportsCompany.FitnessTracker.Domain;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.Interfaces;
using System.Windows;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain
{
    /// <summary>
    /// Interaction logic for EnduranceMainView.xaml
    /// </summary>
    public partial class EnduranceMainView : Window, IEnduranceMainView
    {

        public EnduranceMainView(IEnduranceMainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
