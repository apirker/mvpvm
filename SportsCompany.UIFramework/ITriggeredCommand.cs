using System.Windows.Input;

namespace SportsCompany.UIFramework
{
    /// <summary>
    /// For some frameworks potentially a can execute changed needs to be triggered,
    /// which should be invoked on the OnPropertyChanged implementation in the 
    /// ViewModelBase. This will update the view's state with regards to commands.
    /// </summary>
    public interface ITriggeredCommand : ICommand
    {
        /// <summary>
        /// Raises the can execute changed event of the command. Should be called 
        /// whenever a property changed has happened in the view model. 
        /// </summary>
        void TriggerCanExecuteChanged();
    }
}
