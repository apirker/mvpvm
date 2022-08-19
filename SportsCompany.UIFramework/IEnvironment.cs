using System;

namespace SportsCompany.UIFramework
{
    /// <summary>
    /// The interface which defines an environment
    /// </summary>
    /// <typeparam name="IPresenterInterface"></typeparam>
    public interface IEnvironment<IPresenterInterface> 
        : IDisposable
        where IPresenterInterface : IPresenter
    {
        /// <summary>
        /// Register all types of which are specific to 
        /// this environment
        /// </summary>
        /// <param name="presenter"></param>
        void RegisterTypes(IPresenterInterface presenter);

        /// <summary>
        /// Resolve an interface within the environment
        /// </summary>
        /// <typeparam name="IInterface"></typeparam>
        /// <returns></returns>
        IInterface Resolve<IInterface>();

        /// <summary>
        /// Resolve an interface for a given name
        /// </summary>
        /// <typeparam name="IInterface"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        IInterface Resolve<IInterface>(string name);
    }
}
