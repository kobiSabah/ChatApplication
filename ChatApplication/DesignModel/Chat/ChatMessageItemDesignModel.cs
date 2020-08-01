using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class ChatMessageItemDesignModel : ChatMessageItemViewModel
    {
        #region Singleton

        private static ChatMessageItemDesignModel s_Instance;

        public static ChatMessageItemDesignModel Instance => s_Instance ?? (s_Instance = new ChatMessageItemDesignModel());

        // public static ChatMessageItemDesignModel Instance => new ChatMessageItemDesignModel();


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
