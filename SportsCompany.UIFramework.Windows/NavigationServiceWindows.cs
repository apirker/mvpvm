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
            //for windows, just show the view
            view.Show();
        }

        protected override void NavigateBack(IView view)
        {
            //close the view on navigating backwards
            view.Close();
        }

        protected override void NavigateModal(IView view)
        {
            //for windows, just show the view
            view.Show();
        }
    }
}
