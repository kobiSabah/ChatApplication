using System;

namespace ChatApplication.Core
{
    public class ChatMessageItemDesignModel : ChatMessageItemViewModel
    {
        #region Singleton

        private static ChatMessageItemDesignModel s_Instance;

        public static ChatMessageItemDesignModel Instance => s_Instance ?? (s_Instance = new ChatMessageItemDesignModel());

        #endregion

        #region Constructor

        public ChatMessageItemDesignModel()
        {
            SenderName = "Kobi";
            MessageSendTime = DateTimeOffset.Now;
            SendByMe = true;
            Message = "Hi";
        }
        
        #endregion
    }
}
