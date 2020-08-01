using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ChatApplication.Annotations;

namespace ChatApplication
{
    public class ChatMessageListDesignModel : ChatMessageListViewModel, INotifyPropertyChanged
    {
        #region Singleton

        private static ChatMessageListDesignModel s_Instance = null;

        public static ChatMessageListDesignModel Instance => s_Instance ?? (s_Instance = new ChatMessageListDesignModel());
       // public static ChatMessageListDesignModel Instance => new ChatMessageListDesignModel();
        #endregion

        #region Constructor

        public ChatMessageListDesignModel()
        {
            Item = new ObservableCollection<ChatMessageItemViewModel>
                       {
                           new ChatMessageItemDesignModel
                               {
                                   SenderName = "Kobi",
                                   MessageSendTime = DateTimeOffset.Now,
                                   SendByMe = true,
                                   Message = "Hi"
                               },
                           new ChatMessageItemDesignModel
                               {
                                   SenderName = "Dan",
                                   MessageSendTime = DateTimeOffset.Now,
                                   SendByMe = false,
                                   Message = "Hello !"
                               },
                           new ChatMessageItemDesignModel
                               {
                                   SenderName = "Dan",
                                   MessageSendTime = DateTimeOffset.Now,
                                   SendByMe = false,
                                   Message = "How are you ?"
                               },
                           new ChatMessageItemDesignModel
                               {
                                   SenderName = "Kobi",
                                   MessageSendTime = DateTimeOffset.Now,
                                   SendByMe = true,
                                   Message = "Fine, Thank you"
                               },
                           new ChatMessageItemDesignModel
                               {
                                   SenderName = "Kobi",
                                   MessageSendTime = DateTimeOffset.Now,
                                   SendByMe = true,
                                   Message = "And how are you ?"
                               },
                           new ChatMessageItemDesignModel
                               {
                                   SenderName = "Kobi",
                                   MessageSendTime = DateTimeOffset.Now,
                                   SendByMe = true,
                                   Message = "Fine"
                               },

                       };
        }

        #endregion

        public void Send(string i_Message)
        {
            Item.Add(new ChatMessageItemViewModel
                         {
                             Message = i_Message,
                             MessageSendTime = DateTimeOffset.Now,
                             SendByMe = true,
                             SenderName = "kobi"
                         });
            OnPropertyChanged();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string i_PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(i_PropertyName));
        }
    }
}
