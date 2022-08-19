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
            var view = presenter.Show(arg);

            if(!viewPresenters.ContainsKey(presenter))
                viewPresenters[presenter] = view;

            presenter.Closed += Presenter_Closed;
            Navigate(view);
        }

        private void Presenter_Closed(object sender, System.EventArgs e)
        {
            var presenter = (IPresenter)sender;
            presenter.Closed -= Presenter_Closed;

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
            var view = presenter.Show(arg);
            NavigateModal(view);
        }

        protected abstract void Navigate(IView view);
        protected abstract void NavigateModal(IView view);
        protected abstract void NavigateBack(IView view);
    }
}
