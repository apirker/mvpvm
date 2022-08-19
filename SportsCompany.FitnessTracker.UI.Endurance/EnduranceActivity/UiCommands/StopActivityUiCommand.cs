using SportsCompany.FitnessTracker.Domain;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.Interfaces;
using SportsCompany.UIFramework;
using System;
using System.Windows;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.UiCommands
{
    /// <summary>
    /// Ui Command to open the stop the last endurance activity.
    /// </summary>
    class StopActivityUiCommand : UICommandBase<IEnduranceActivityViewModel>
    {
        private readonly ITrainingService trainingService;

        public StopActivityUiCommand(ITrainingService trainingService)
        {
            this.trainingService = trainingService;
        }

        protected override bool CanExecute(IEnduranceActivityViewModel parameter)
        {
            return true;
        }

        /// <summary>
        /// Command execution.
        /// </summary>
        protected override void Execute(IEnduranceActivityViewModel viewModel)
        {
            try
            {
                if (viewModel == null)
                    return;

                viewModel.State = "Stopped";

                var result = trainingService.StopTraining();

                viewModel.Distance = result.Distance;
                viewModel.Duration = result.Duration;
                viewModel.TrainingEffect = result.TrainingEffect;
            }
            catch(Exception)
            {
                MessageBox.Show("Something went wrong on stoping the activity.");
            }
}
    }
}
