using System.ComponentModel;

namespace SportsCompany.UIFramework
{
    public class ViewModelBase : IViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
