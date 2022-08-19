using SportsCompany.DependencyInjection;
using SportsCompany.FitnessTracker.Domain.Mocks;

namespace SportsCompany.FitnessTracker.Domain
{
    public class EnduranceDomainInitializer
    {
        public static void Initialize(IContainer container)
        {
            container.RegisterSingleton<ITrainingRepository, TrainingRepositoryMock>();
            container.Register<ITrainingService, TrainingServiceMock>();
        }
    }
}
