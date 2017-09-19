using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWithAuth.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public decimal Email { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public decimal ProductID { get; set; }
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}