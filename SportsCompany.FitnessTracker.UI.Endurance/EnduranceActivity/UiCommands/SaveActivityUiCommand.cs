using SportsCompany.FitnessTracker.Domain;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.Interfaces;
using SportsCompany.UIFramework;
using System;
using System.Windows;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.UiCommands
{
    /// <summary>
    /// Ui Command to to save the last endurance activity.
    /// </summary>
    class SaveActivityUiCommand : UICommandBase<IEnduranceActivityViewModel>
    {
        private readonly ITrainingService trainingService;
        private readonly IEnduranceActivityEnvironment enduranceActivityEnvironment;

        public SaveActivityUiCommand(ITrainingService trainingService, IEnduranceActivityEnvironment enduranceActivityEnvironment)
        {
            this.trainingService = trainingService;
            this.enduranceActivityEnvironment = enduranceActivityEnvironment;
        }

        protected override bool CanExecute(IEnduranceActivityViewModel parameter)
        {
            return true;
        }

        /// <summary>
        /// Command execution.
        /// </summary>
        protected override void Execute(IEnduranceActivityViewModel parameter)
        {
            try
            {
                trainingService.SaveTraining();

                var presenter = enduranceActivityEnvironment.Resolve<IEnduranceActivityPresenter>();
                presenter.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Something went wrong on saving the activity.");
            }
        }
    }
}
