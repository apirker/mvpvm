using SportsCompany.DependencyInjection;

namespace SportsCompany.UIFramework
{
    /// <summary>
    /// Class providing base functions for all environments
    /// </summary>
    /// <typeparam name="IPresenterInterface"></typeparam>
    public abstract class EnvironmentBase<IPresenterInterface>
        : IEnvironment<IPresenterInterface>
        where IPresenterInterface : IPresenter
    {
        protected readonly IContainer container;
        private bool disposedValue;

        /// <summary>
        /// Construct a new instance
        /// </summary>
        /// <param name="container"></param>
        public EnvironmentBase(IContainer container)
        {
            this.container = container.CreateChildContainer();
        }

        /// <inheritdoc />
        public IInterface Resolve<IInterface>()
        {
            return container.Resolve<IInterface>();
        }

        /// <inheritdoc />
        public IInterface Resolve<IInterface>(string name)
        {
            return container.Resolve<IInterface>(name);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.container.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }

        public abstract void RegisterTypes(IPresenterInterface presenter);

    }
}
