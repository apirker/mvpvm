using SportsCompany.DependencyInjection;
using Unity;

namespace SportsCompany.UIFramework.Windows
{
    /// <summary>
    /// Entry point for initializing a new windows ui application in this framework.
    /// </summary>
    public class UiFrameworkWindows
    {
        private static IContainer CreateContainer()
        {
            //use unity container here for demonstration purposes
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<IContainer, UnityContainerImpl>();

            return unityContainer.Resolve<IContainer>();

        }

        /// <summary>
        /// Initialize the windows ui framework by creating a new DI container, and registering
        /// the windows navigation service.
        /// </summary>
        /// <returns></returns>
        public static IContainer Initialize()
        {
            var container = CreateContainer();
            container.RegisterSingleton<INavigationService, NavigationServiceWindows>();

            return container;
        }
    }
}
