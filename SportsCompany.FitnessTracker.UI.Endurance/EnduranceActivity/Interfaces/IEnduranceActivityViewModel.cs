using SportsCompany.UIFramework;
using System;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.Interfaces
{
    public interface IEnduranceActivityViewModel : IViewModel
    {   
        string State { get; set; }

        double Distance { get; set; }
        
        TimeSpan Duration { get; set; }

        double TrainingEffect { get; set; }

        ICommand StartActivityUiCommand { get; set; }

        ICommand StopActivityUiCommand { get; set; }

        ICommand SaveActivityUiCommand { get; set; }

    }
}
