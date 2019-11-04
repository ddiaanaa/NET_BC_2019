using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInternetveikals
{
    public class InternetShopDB : DbContext
    {
        public InternetShopDB(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Advertisment> Advertisments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
