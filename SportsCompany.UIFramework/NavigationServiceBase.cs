using System.Collections.Generic;

namespace SportsCompany.UIFramework
{
    /// <summary>
    /// Base implementation for all navigation services
    /// </summary>
    public abstract class NavigationServiceBase : INavigationService
    {
        private IDictionary<IPresenter, IView> viewPresenters 
            = new Dictionary<IPresenter, IView>();

        /// <inheritdoc />
        public void Navigate(IPresenter presenter, object arg)
        {
            //show the presenter, which returns the view
            var view = presenter.Show(arg);

            //check if the presenter is already known
            if(!viewPresenters.ContainsKey(presenter))
                viewPresenters[presenter] = view;

            //register the for the closed event such that we remove the presenter.
            presenter.Closed += Presenter_Closed;

            //navigate to the view
            Navigate(view);
        }

        private void Presenter_Closed(object sender, System.EventArgs e)
        {
            var presenter = (IPresenter)sender;
            presenter.Closed -= Presenter_Closed;

            //remove the presenter which has been closed
            if(viewPresenters.ContainsKey(presenter))
            {
                var view = viewPresenters[presenter];
                NavigateBack(view);
                viewPresenters.Remove(presenter);
            }
        }

        /// <inheritdoc />
        public void NavigateModal(IPresenter presenter, object arg)
        {
            //show the presenter, which returns the view
            var view = presenter.Show(arg);

            //navigate modal to the view
            NavigateModal(view);
        }

        protected abstract void Navigate(IView view);
        protected abstract void NavigateModal(IView view);
        protected abstract void NavigateBack(IView view);
    }
}
