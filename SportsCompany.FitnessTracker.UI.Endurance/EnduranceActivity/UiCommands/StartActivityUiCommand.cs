using SportsCompany.FitnessTracker.Domain;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.Interfaces;
using SportsCompany.UIFramework;
using System;
using System.Windows;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.UiCommands
{
    /// <summary>
    /// Ui Command to start a new endurance activity within the domain.
    /// </summary>
    class StartActivityUiCommand : UICommandBase<IEnduranceActivityViewModel>
    {
        private readonly ITrainingService trainingService;
        public StartActivityUiCommand(ITrainingService trainingService)
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
                if (viewModel is null)
                    return;

                viewModel.State = "Running...";

                trainingService.StartTraining();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong on starting the activity.");
            }
        }
    }
}
