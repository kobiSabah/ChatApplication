using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class ChatMessageItemViewModel
    {
        #region Properties

        public string SenderName { get; set; }

        public string Message { get; set; }

        public DateTimeOffset MessageSendTime { get; set; }

        public bool SendByMe { get; set; }

        #endregion

    }
}
