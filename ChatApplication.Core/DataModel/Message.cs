using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApplication.Core.DataModel
{
    public class Message
    {
        public string SenderToken { get; set; }
        public DateTimeOffset MessageSendTime { get; set; }
        public bool SendByMe { get; set; }
        public string ContectUsername { get; set; }
        public string Context { get; set; }
    }
}
