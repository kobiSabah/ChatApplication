using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class ContactListViewModel : BaseViewModel
    {
        public List<ContactItemViewModel> Items { get; set; }
    }
}
