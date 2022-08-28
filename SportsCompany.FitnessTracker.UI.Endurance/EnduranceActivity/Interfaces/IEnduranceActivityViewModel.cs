using SportsCompany.UIFramework;
using System;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.Interfaces
{
    /// <summary>
    /// Interface for the view model of the endurance activity ui component.
    /// </summary>
    public interface IEnduranceActivityViewModel : IViewModel
    {   
        /// <summary>
        /// State of the activity
        /// </summary>
        string State { get; set; }

        /// <summary>
        /// Distance of the activity
        /// </summary>
        double Distance { get; set; }
        
        /// <summary>
        /// Duration of the activity
        /// </summary>
        TimeSpan Duration { get; set; }

        /// <summary>
        /// Trainings effect of the activity
        /// </summary>
        double TrainingEffect { get; set; }

        ICommand StartActivityUiCommand { get; set; }

        ICommand StopActivityUiCommand { get; set; }

        ICommand SaveActivityUiCommand { get; set; }

    }
}
