using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatApplication.Web.Server
{

    /// <summary>
    /// Database representation model
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Constructor
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }
        #endregion

        #region Public Properties

        /// <summary>
        /// The settings table in the database
        /// </summary>
        public DbSet<SettingsDataModel> Settings { get; set; }

        #endregion
    }
}
