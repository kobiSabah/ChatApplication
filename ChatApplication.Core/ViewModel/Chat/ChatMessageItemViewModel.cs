using System;

namespace ChatApplication.Core
{
    public class ChatMessageItemViewModel : BaseViewModel
    {
        #region Public Properties

        public string SenderName { get; set; }

        public string Message { get; set; }

        public DateTimeOffset MessageSendTime { get; set; }

        public bool SendByMe { get; set; }


        #endregion
    }
}
