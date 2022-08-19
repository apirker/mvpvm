using SportsCompany.UIFramework;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.Interfaces
{
    public interface IEnduranceMainViewModel : IViewModel
    {
        /// <summary>
        /// Collection of all endurance activities which where recorded.
        /// </summary>
        ObservableCollection<EnduranceViewModel> EnduranceItems { get; }

        ICommand OpenNewEnduranceUiCommand { get; set; }
        ICommand OpenNewPurchaseUiCommand { get; set; }

    }
}
