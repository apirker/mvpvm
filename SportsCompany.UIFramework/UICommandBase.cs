using System;

namespace SportsCompany.UIFramework
{
    /// <summary>
    /// Base implementation for all UICommands.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class UICommandBase<T> 
        : ITriggeredCommand where T:class
    {
        //event fired when can execute changed
        public event EventHandler CanExecuteChanged;

        /// <inheritdoc />
        public bool CanExecute(object parameter)
        {
            return CanExecute(parameter as T);
        }

        /// <inheritdoc />
        public void Execute(object parameter)
        {
            Execute((T)parameter);
        }

        /// <inheritdoc />
        public void TriggerCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        protected abstract bool CanExecute(T viewModel);
        protected abstract void Execute(T viewModel);
    }
}
