using System.Collections.Generic;

namespace ChatApplication.Core
{
    public class ContactListViewModel : BaseViewModel
    {
        public List<ContactItemViewModel> Items { get; set; }
    }
}
