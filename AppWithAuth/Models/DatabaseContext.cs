using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppWithAuth.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
    
}