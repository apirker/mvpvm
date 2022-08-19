using System;

namespace SportsCompany.UIFramework
{
    /// <summary>
    /// The interface for presenters
    /// </summary>
    public interface IPresenter
    {
        /// <summary>
        /// Performs steps to show a new view
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        IView Show(object param);

        /// <summary>
        /// Close the presenter means closing the view
        /// </summary>
        void Close();

        /// <summary>
        /// Event raised when the presenter finished closing
        /// </summary>
        event EventHandler<EventArgs> Closed;
    }
}
