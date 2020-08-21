using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ChatApplication.Server
{
    public class DbChatContext : DbContext
    {
        #region Constructor

        public DbChatContext(DbContextOptions<DbChatContext> i_Options) : base(i_Options) { }

        #endregion

        #region DataSet

        //public DbSet<User> Users { get; set; }

        #endregion
    }
}
