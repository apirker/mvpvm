using SportsCompany.FitnessTracker.UI.Endurance.Purchase.Interfaces;
using SportsCompany.UIFramework;
using System;

namespace SportsCompany.FitnessTracker.UI.Endurance.Purchase
{
    public class PurchasePresenter : IPurchasePresenter
    {
        private readonly IPurchaseEnvironment environment;

        public PurchasePresenter(IPurchaseEnvironment environment)
        {
            this.environment = environment;
            this.environment.RegisterTypes(this);
        }

        public event EventHandler<EventArgs> Closed;

        public void Close()
        {
            environment.Dispose();
            Closed?.Invoke(this, EventArgs.Empty);
        }

        public IView Show(object param)
        {
            var view = environment.Resolve<IPurchaseView>();
            var viewModel = environment.Resolve<IPurchaseViewModel>();

            var randomCount = 0;
            var random = new Random();

            while (randomCount == 0)
                randomCount = random.Next(5);

            for (int i = 0; i < randomCount; i++)
                viewModel.PurchaseItems.Add($"Item {i}: Another random item");

            return view;
        }

    }
}
