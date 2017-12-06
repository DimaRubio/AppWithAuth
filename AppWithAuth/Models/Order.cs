using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWithAuth.Models
{
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