using SportsCompany.DependencyInjection;
using Unity;

namespace SportsCompany.UIFramework.Windows
{
    public class UiFrameworkWindows
    {
        private static IContainer CreateContainer()
        {

            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<IContainer, UnityContainerImpl>();

            return unityContainer.Resolve<IContainer>();

        }
        public static IContainer Initialize()
        {
            var container = CreateContainer();

            container.RegisterSingleton<INavigationService, NavigationServiceWindows>();

            return container;
        }
    }
}
