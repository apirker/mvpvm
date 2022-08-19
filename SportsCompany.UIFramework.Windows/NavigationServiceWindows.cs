using System;

namespace SportsCompany.UIFramework.Windows
{
    /// <summary>
    /// Navigation Service which implements navigation with windows 
    /// </summary>
    public class NavigationServiceWindows : NavigationServiceBase
    {
        protected override void Navigate(IView view)
        {
            view.Show();
        }

        protected override void NavigateBack(IView view)
        {
            view.Close();
        }

        protected override void NavigateModal(IView view)
        {
            view.Show();
        }
    }
}
