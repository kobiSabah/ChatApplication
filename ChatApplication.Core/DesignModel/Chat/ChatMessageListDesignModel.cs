using System;
using System.Collections.ObjectModel;
using System.Data;

namespace ChatApplication.Core
{
    public class ChatMessageListDesignModel : ChatMessageListViewModel
    {
        #region Singleton

        private static ChatMessageListDesignModel s_Instance = null;

        public static ChatMessageListDesignModel Instance => s_Instance ?? (s_Instance = new ChatMessageListDesignModel());

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

        #region Public properties

        public void Send(string i_Message)
        {
            Item.Add(new ChatMessageItemViewModel
                         {
                             Message = i_Message,
                             MessageSendTime = DateTimeOffset.Now,
                             SendByMe = true,
                             SenderName = "kobi"
                         });
        }

        #endregion
    }
}
