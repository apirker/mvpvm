using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.Interfaces;
using SportsCompany.UIFramework;
using System;
using System.Windows.Input;
using Unity;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity
{
    /// <summary>
    /// View model for the view of an endurance activity.
    /// </summary>
    class EnduranceActivityViewModel : ViewModelBase, IEnduranceActivityViewModel
    {
        public EnduranceActivityViewModel(IEnduranceActivityEnvironment environment)
        {
            StartActivityUiCommand = environment.Resolve<ICommand>(nameof(UiCommands.StartActivityUiCommand));
            StopActivityUiCommand = environment.Resolve<ICommand>(nameof(UiCommands.StopActivityUiCommand));
            SaveActivityUiCommand = environment.Resolve<ICommand>(nameof(UiCommands.SaveActivityUiCommand));
        }

        private string state;

        /// <summary>
        /// State of the activity, started, stopped, ...
        /// </summary>
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                if (state == value) return;

                state = value;
                OnPropertyChanged(nameof(State));
            }
        }

        private double distance;

        /// <summary>
        /// Total distance of the activity.
        /// </summary>
        public double Distance
        {
            get
            {
                return distance;
            }
            set
            {
                if (distance == value) return;

                distance = value;
                OnPropertyChanged(nameof(Distance));
            }
        }

        private TimeSpan duration;
        
        /// <summary>
        /// Total duration of the activity.
        /// </summary>
        public TimeSpan Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (duration == value) return;

                duration = value;
                OnPropertyChanged(nameof(Duration));
            }
        }

        private double trainingEffect;
        
        /// <summary>
        /// The training effect which the business logic determined for this activity.
        /// </summary>
        public double TrainingEffect
        {
            get
            {
                return trainingEffect;
            }
            set
            {
                if (trainingEffect == value) return;

                trainingEffect = value;
                OnPropertyChanged(nameof(TrainingEffect));
            }
        }

        /// <summary>
        /// Ui command to start the activity.
        /// </summary>
        public ICommand StartActivityUiCommand { get; set; }

        /// <summary>
        /// Ui command to stop the activity.
        /// </summary>
        public ICommand StopActivityUiCommand { get; set; }

        /// <summary>
        /// Ui command to save the activity.
        /// </summary>
        public ICommand SaveActivityUiCommand { get; set; }
    }
}
