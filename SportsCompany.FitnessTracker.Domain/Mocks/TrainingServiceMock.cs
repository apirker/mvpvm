using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsCompany.FitnessTracker.Domain.Mocks
{
    internal class TrainingServiceMock : ITrainingService
    {
        private readonly ITrainingRepository trainingRepository;

        public TrainingServiceMock(ITrainingRepository trainingRepository)
        {
            this.trainingRepository = trainingRepository;
        }

        private Training CreateMockTraining()
        {
            return new Training(
                11,
                2,
                3.8,
                21,
                new TimeSpan(1, 20, 53)
                );
        }

        public void SaveTraining()
        {
            var training = CreateMockTraining();
            trainingRepository.Add(training);
        }

        public void StartTraining()
        {
        }

        public Training StopTraining()
        {
            return CreateMockTraining();
        }
    }
}
