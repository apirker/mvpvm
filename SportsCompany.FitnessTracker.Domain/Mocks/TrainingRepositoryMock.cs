using System.Collections.Generic;

namespace SportsCompany.FitnessTracker.Domain.Mocks
{
    internal class TrainingRepositoryMock : ITrainingRepository
    {
        private static IList<Training> trainings = new List<Training>();

        public void Add(Training training)
        {
            trainings.Add(training);
        }

        public IList<Training> GetAll()
        {
            return trainings;
        }
    }
}
