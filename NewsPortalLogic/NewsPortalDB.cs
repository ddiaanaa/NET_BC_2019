using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortalLogic
{
    public class NewsPortalDB : DbContext
    {
        public NewsPortalDB(DbContextOptions options) : base(options)
        {

        }
        public DbSet<New> News { get; set; }
        public DbSet<Topic> Topics { get; set; }        
    }
}
