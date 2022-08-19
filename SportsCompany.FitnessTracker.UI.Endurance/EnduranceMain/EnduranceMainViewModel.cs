using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain
{
    /// <summary>
    /// View model of the main view of the endurance user interface part.
    /// </summary>
    class EnduranceMainViewModel : INotifyPropertyChanged, IEnduranceMainViewModel
    {
        public EnduranceMainViewModel(IEnduranceMainEnvironment environment)
        {
            OpenNewEnduranceUiCommand = environment.Resolve<ICommand>(nameof(UiCommands.OpenNewEnduranceUiCommand));
            OpenNewPurchaseUiCommand = environment.Resolve<ICommand>(nameof(UiCommands.OpenNewPurchaseUiCommand));
        }

        /// <summary>
        /// Collection of all endurance activities which where recorded.
        /// </summary>
        public ObservableCollection<EnduranceViewModel> EnduranceItems { get; } = new ObservableCollection<EnduranceViewModel>();

        /// <summary>
        /// Ui command to open a new endurance activity view.
        /// </summary>
        public ICommand OpenNewEnduranceUiCommand { get; set; }
        public ICommand OpenNewPurchaseUiCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
