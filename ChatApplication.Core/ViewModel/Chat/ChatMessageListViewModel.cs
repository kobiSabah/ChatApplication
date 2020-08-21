using System.Collections.ObjectModel;

namespace ChatApplication.Core
{ 
    public class ChatMessageListViewModel : BaseViewModel
    {
        public ObservableCollection<ChatMessageItemViewModel> Item { get; set; }

    }
}
