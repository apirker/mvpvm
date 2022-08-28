using SportsCompany.FitnessTracker.Domain;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.Interfaces;
using SportsCompany.UIFramework;
using System;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain
{
    /// <summary>
    /// Presenter for the endurance main view ui component.
    /// </summary>
    internal class EnduranceMainPresenter : IEnduranceMainPresenter
    {
        private readonly IEnduranceMainEnvironment environment;

        public event EventHandler<EventArgs> Closed;

        public EnduranceMainPresenter(IEnduranceMainEnvironment environment)
        {
            this.environment = environment;
            this.environment.RegisterTypes(this);
        }

        public void Close()
        {
            environment.Dispose();
            Closed?.Invoke(this, EventArgs.Empty);
        }

        public IView Show(object param)
        {
            var view = environment.Resolve<IEnduranceMainView>();

            var viewModel = environment.Resolve<IEnduranceMainViewModel>();
            var trainingRepository = environment.Resolve<ITrainingRepository>();

            viewModel.EnduranceItems.Clear();

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

            return view;
        }
    }
}
