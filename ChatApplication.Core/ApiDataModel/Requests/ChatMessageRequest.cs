using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApplication.Core.ApiDataModel.Requests
{
    public class ChatMessageRequest
    {
        public string Token { get; set; }
        public string ContectUsername { get; set; }
    }
}
