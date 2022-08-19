namespace SportsCompany.UIFramework
{
    /// <summary>
    /// Interface declaring how to navigate in applications
    /// </summary>
    public interface INavigationService
    {
        /// <summary>
        /// Navigates forward to a new presenter
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="arg"></param>
        void Navigate(IPresenter presenter, object arg);

        /// <summary>
        /// Navigates forward to a new presenter in a modal way
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="arg"></param>
        void NavigateModal(IPresenter presenter, object arg);
    }
}
