using SportsCompany.UIFramework;
using System;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.Interfaces
{
    /// <summary>
    /// Interface to hide the view implementation.
    /// </summary>
    interface IEnduranceActivityView : IView
    {
        /// <summary>
        /// Event which signals that the view has been closed by the user.
        /// </summary>
        event EventHandler ViewClosed;
    }
}
