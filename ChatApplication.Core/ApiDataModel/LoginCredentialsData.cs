using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace ChatApplication.Core
{
    /// <summary>
    /// The login credentials data representation
    /// </summary>
    public class LoginCredentialsData
    {
        /// <summary>
        /// The username or the Email
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// The user password 
        /// </summary>
        public string Password { get; set; }
    }
}
