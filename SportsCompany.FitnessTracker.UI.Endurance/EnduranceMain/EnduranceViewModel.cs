using SportsCompany.UIFramework;
using System.ComponentModel;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain
{
    /// <summary>
    /// View model which contains the data for an individual endurance activity.
    /// </summary>
    public class EnduranceViewModel : ViewModelBase
    {
        private int laps;

        /// <summary>
        /// Number of laps completed as part of this activity.
        /// </summary>
        public int Laps
        {
            get
            {
                return laps;
            }
            set
            {
                if (laps == value) return;

                laps = value;
                OnPropertyChanged(nameof(Laps));
            }
        }

        private double average;

        /// <summary>
        /// Average heart beat for this endurance activity.
        /// </summary>
        public double Average
        {
            get
            {
                return average;
            }
            set
            {
                if (average == value) return;

                average = value;
                OnPropertyChanged(nameof(Average));
            }
        }

        private double trainingEffect;

        /// <summary>
        /// Training effect which the business logic determined for this activity.
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

        public override string ToString()
        {
            return $"Average heart rate {average} for {laps} laps with training effect is {TrainingEffect}";
        }
    }
}
