using System.Security;

namespace ChatApplication.Core
{
    public class User
    {
        #region Properties

        public string  Username { get; set; }

        public SecureString Password { get; set; }

        public string  FirstName { get; set; }

        public string  LastName { get; set; }
        public string Email { get; set; }

        #endregion
    }
}
