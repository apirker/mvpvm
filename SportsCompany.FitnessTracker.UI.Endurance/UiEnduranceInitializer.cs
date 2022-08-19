using SportsCompany.DependencyInjection;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain;
using SportsCompany.FitnessTracker.UI.Endurance.EnduranceMain.Interfaces;

namespace SportsCompany.FitnessTracker.UI.Endurance
{
    /// <summary>
    /// Static class to initialize the endurance user interface parts.
    /// </summary>
    public static class UiEnduranceInitializer
    {
        public static void Init(IContainer container)
        {
            container.Register<IEnduranceMainPresenter, EnduranceMainPresenter>();
            container.Register<IEnduranceMainEnvironment, EnduranceMainProductionEnvironment>();
        }
    }
}
