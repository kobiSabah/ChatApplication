using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatApplication
{
    public class ContactItemViewModel
    {
        #region Properties

        public string Name { get; set; }

        public string ProfileColor { get; set; }

        public string NickName { get; set; }

        public string Message { get; set; }

        public ChatMessageItemViewModel History { get; set; }


        #endregion

        #region Command properties

        public ICommand OpenMessageCommand { get; set; }

        #endregion

        #region Constructor

        public ContactItemViewModel()
        {
           // Add relay command to invoke the page change
        }

        #endregion

        public void OpenMessage()
        {

        }
    }
}
