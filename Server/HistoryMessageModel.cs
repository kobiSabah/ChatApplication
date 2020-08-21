using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class HistoryMessageModel
    {
        public string SenderID { get; set; }

        public string ReceiverID { get; set; }

        public string  Message { get; set; }

        public DateTimeOffset SendTime { get; set; }
    }
}
