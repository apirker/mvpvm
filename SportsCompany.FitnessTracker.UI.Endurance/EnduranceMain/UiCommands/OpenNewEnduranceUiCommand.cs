using SportsCompany.FitnessTracker.Domain;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.Interfaces;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.Interfaces;
using SportsCompany.UIFramework;
using System;
using System.Windows;
using System.Windows.Input;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.UiCommands
{
    /// <summary>
    /// Ui Command to open a new endurance activity.
    /// </summary>
    class OpenNewEnduranceUiCommand : UICommandBase<IEnduranceMainViewModel>
    {
        private readonly IEnduranceMainEnvironment environment;

        public OpenNewEnduranceUiCommand(IEnduranceMainEnvironment environment)
        {
            this.environment = environment;
        }

        protected override bool CanExecute(IEnduranceMainViewModel parameter)
        {
            return true;
        }

        /// <summary>
        /// Command execution.
        /// </summary>
        protected override void Execute(IEnduranceMainViewModel parameter)
        {
            try
            {
                var presenter = environment.Resolve<IEnduranceActivityPresenter>();
                var navigationService = environment.Resolve<INavigationService>();

                navigationService.Navigate(presenter, null);

                presenter.Closed += Presenter_Closed;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong on opening the activity.");
            }
        }

        private void Presenter_Closed(object sender, EventArgs e)
        {
            //could also be done via event, as outline in the article (!)
            var presenter = sender as IEnduranceActivityPresenter;
            if (presenter == null)
                return;

            presenter.Closed -= Presenter_Closed;

            var viewModel = environment.Resolve<IEnduranceMainViewModel>();
            viewModel.EnduranceItems.Clear();

            try
            {
                var trainingRepository = environment.Resolve<ITrainingRepository>();
                var trainings = trainingRepository.GetAll();

                foreach (var training in trainings)
                {
                    var enduranceViewModel = new EnduranceViewModel()
                    {
                        Laps = training.Count,
                        Average = training.Average,
                        TrainingEffect = training.TrainingEffect
                    };

                    viewModel.EnduranceItems.Add(enduranceViewModel);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong on getting activities.");
            }
        }
    }
}
