using System;

namespace SportsCompany.UIFramework
{
    public abstract class UICommandBase<T> 
        : ITriggeredCommand where T:class
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return CanExecute(parameter as T);
        }

        public void Execute(object parameter)
        {
            Execute((T)parameter);
        }

        public void TriggerCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        protected abstract bool CanExecute(T viewModel);
        protected abstract void Execute(T viewModel);
    }
}
