using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatApplication
{
    public class ContactItemViewModel : BaseViewModel
    {
        #region Properties

        public string Name { get; set; }

        public string ProfileColor { get; set; }

        public string NickName { get; set; }

        public string Message { get; set; }

        public bool IsSelected { get; set; }

        public ChatMessageItemViewModel History { get; set; }


        #endregion

        #region Command properties

        public ICommand OpenMessageCommand { get; set; }

        #endregion

        #region Constructor

        public ContactItemViewModel()
        {
           // Add relay command to invoke the page change
           OpenMessageCommand = new RelayCommand(OpenMessage);
        }

        #endregion

        public void OpenMessage()
        {
            IsSelected = true;
            ChatMessageListDesignModel.Instance.Item = new ObservableCollection<ChatMessageItemViewModel>
                                                           {
                                                               new ChatMessageItemDesignModel
                                                                   {
                                                                       SenderName = "Kobi",
                                                                       MessageSendTime = DateTimeOffset.Now,
                                                                       SendByMe = true,
                                                                       Message = "New message"
                                                                   },
                                                               new ChatMessageItemDesignModel
                                                                   {
                                                                       SenderName = "Dan",
                                                                       MessageSendTime = DateTimeOffset.Now,
                                                                       SendByMe = false,
                                                                       Message = "Ok"
                                                                   },
                                                               new ChatMessageItemDesignModel
                                                                   {
                                                                       SenderName = "Dan",
                                                                       MessageSendTime = DateTimeOffset.Now,
                                                                       SendByMe = false,
                                                                       Message = "How are you ?"
                                                                   },
                                                           };

        }
    }
}
