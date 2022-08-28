using SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity.Interfaces;
using SportsCompany.UIFramework;
using System;

namespace SportsCompany.FitnessTracker.UI.Endurance.EnduranceActivity
{
    /// <summary>
    /// Presenter of the endurance activity ui component.
    /// </summary>
    public class EnduranceActivityPresenter : IEnduranceActivityPresenter
    {
        private readonly IEnduranceActivityEnvironment enduranceActivityEnvironment;

        public EnduranceActivityPresenter(IEnduranceActivityEnvironment enduranceActivityEnvironment)
        {
            this.enduranceActivityEnvironment = enduranceActivityEnvironment;
            this.enduranceActivityEnvironment.RegisterTypes(this);
        }

        public event EventHandler<EventArgs> Closed;

        public void Close()
        {
            enduranceActivityEnvironment.Dispose();
            Closed?.Invoke(this, EventArgs.Empty);
        }

        public IView Show(object param)
        {
            var view = enduranceActivityEnvironment.Resolve<IEnduranceActivityView>();
            return view;
        }
    }
}
