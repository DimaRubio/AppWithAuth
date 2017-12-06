using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWithAuth.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public decimal Email { get; set; }
        public List<Order> Orders { get; set; }
    }
}