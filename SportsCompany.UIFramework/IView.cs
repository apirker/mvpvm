namespace SportsCompany.UIFramework
{
    /// <summary>
    /// Interface for all views
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Displays the view on the screen of the user
        /// </summary>
        void Show();

        /// <summary>
        /// Closes the view
        /// </summary>
        void Close();
    }
}
