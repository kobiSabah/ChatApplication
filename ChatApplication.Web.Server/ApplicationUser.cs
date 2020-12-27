using Microsoft.AspNetCore.Identity;

namespace ChatApplication.Web.Server
{
    /// <summary>
    /// Representation for the identity user class 
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// The user firs name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The user last name 
        /// </summary>
        public string LastName { get; set; }
    }
}
