using System.ComponentModel;

namespace ChatApplication.Core
{
    /// <summary>
    ///  Base class for view model that implement property change for binding.
    /// </summary>
    public class BaseViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
