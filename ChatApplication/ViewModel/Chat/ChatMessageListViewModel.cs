using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{ 
    public class ChatMessageListViewModel : BaseViewModel
    {
        public ObservableCollection<ChatMessageItemViewModel> Item { get; set; }

    }
}
