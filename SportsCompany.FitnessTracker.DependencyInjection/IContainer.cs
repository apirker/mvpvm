using System;

namespace SportsCompany.DependencyInjection
{
/// <summary>
/// Interface for dependency injection
/// </summary>
public interface IContainer : IDisposable
{
    /// <summary>
    /// Creates a child container/scope
    /// </summary>
    /// <returns></returns>
    IContainer CreateChildContainer();

    /// <summary>
    /// Register a class for an interface
    /// </summary>
    /// <typeparam name="IInterface"></typeparam>
    /// <typeparam name="Impl"></typeparam>
    void Register<IInterface, Impl>() 
        where Impl : IInterface;

    /// <summary>
    /// Register a class for an interface together 
    /// with a name
    /// </summary>
    /// <typeparam name="IInterface"></typeparam>
    /// <typeparam name="Impl"></typeparam>
    /// <param name="name"></param>
    void Register<IInterface, Impl>(string name) 
        where Impl : IInterface;

    /// <summary>
    /// Register a class for an interface as singleton
    /// </summary>
    /// <typeparam name="IInterface"></typeparam>
    /// <typeparam name="Impl"></typeparam>
    void RegisterSingleton<IInterface, Impl>() 
        where Impl:IInterface;

    /// <summary>
    /// Register a particular interface instance
    /// </summary>
    /// <typeparam name="IInterface"></typeparam>
    /// <param name="iinterface"></param>
    void RegisterInstance<IInterface>(IInterface iinterface);

    /// <summary>
    /// Resolve an interface
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
