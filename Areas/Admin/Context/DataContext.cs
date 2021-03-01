using PharmacyOnline.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PharmacyOnline.Areas.Admin.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("PharmacyOnline")
        {
        }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}