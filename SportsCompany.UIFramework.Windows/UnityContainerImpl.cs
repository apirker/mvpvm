using SportsCompany.DependencyInjection;
using Unity;
using Unity.Lifetime;

namespace SportsCompany.UIFramework.Windows
{
    /// <summary>
    /// Dependency injection implementation for Unity
    /// </summary>
    public class UnityContainerImpl : IContainer
    {
        private readonly IUnityContainer unityContainer;
        private bool disposedValue;

        public UnityContainerImpl(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
            this.unityContainer.RegisterType<IContainer, UnityContainerImpl>();
        }

        /// <inheritdoc />
        public IContainer CreateChildContainer()
        {
            return new UnityContainerImpl(unityContainer.CreateChildContainer());
        }

        /// <inheritdoc />
        public void Register<IInterface, Impl>() where Impl : IInterface
        {
            unityContainer.RegisterType<IInterface, Impl>();
        }

        /// <inheritdoc />
        public void Register<IInterface, Impl>(string name) where Impl:IInterface
        {
            unityContainer.RegisterType<IInterface, Impl>(name);
        }

        /// <inheritdoc />
        public void RegisterSingleton<IInterface, Impl>() where Impl : IInterface
        {
            unityContainer.RegisterType<IInterface, Impl>(new ContainerControlledLifetimeManager());
        }

        /// <inheritdoc />
        public void RegisterInstance<IInterface>(IInterface iinterface)
        {
            unityContainer.RegisterInstance(typeof(IInterface), iinterface, new ExternallyControlledLifetimeManager());
        }

        /// <inheritdoc />
        public IInterface Resolve<IInterface>()
        {
            return unityContainer.Resolve<IInterface>();
        }

        /// <inheritdoc />
        public IInterface Resolve<IInterface>(string name)
        {
            return unityContainer.Resolve<IInterface>(name);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    unityContainer.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
        
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }
    }
}
