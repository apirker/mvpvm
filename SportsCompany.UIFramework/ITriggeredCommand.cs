using System.Windows.Input;

namespace SportsCompany.UIFramework
{
    public interface ITriggeredCommand : ICommand
    {
        void TriggerCanExecuteChanged();
    }
}
