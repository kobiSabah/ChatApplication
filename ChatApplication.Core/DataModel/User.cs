using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Core
{
    public class User
    {
        #region Properties

        public string  UserName { get; set; }

        public SecureString Password { get; set; }

        public string  FirstName { get; set; }

        public string  LastName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTimeOffset Birthday { get; set; }

        #endregion
    }
}
