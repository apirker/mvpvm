using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.Interfaces;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.UiCommands;
using System;
using System.Windows;
using System.Windows.Input;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity
{
    /// <summary>
    /// Interaction logic for EnduranceActivityView.xaml
    /// </summary>
    public partial class EnduranceActivityView : Window, IEnduranceActivityView
    {
        public EnduranceActivityView(IEnduranceActivityViewModel viewModel)
        {
            InitializeComponent();
            
            DataContext = viewModel;
        }

        public event EventHandler ViewClosed;

        public new void Close()
        {
            base.Close();

            if (ViewClosed != null)
                ViewClosed(this, EventArgs.Empty);
        }
    }
}
