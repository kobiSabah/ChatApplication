using ChatApplication.Core.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApplication.Core.ApiDataModel.Responses
{
    public class ChatMessagesRespone
    {
        public IEnumerable<Message> Messages { get; set; }
    }
}
