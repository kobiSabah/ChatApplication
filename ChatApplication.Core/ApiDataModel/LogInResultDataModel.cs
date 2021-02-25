using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApplication.Core
{
    /// <summary>
    /// User representation details after login 
    /// </summary>
    public class LogInResultDataModel
    {
        public string Token { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
