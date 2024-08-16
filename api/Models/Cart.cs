using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Cart
    {        
        public int CustomerID {get; set;}
        public Customer? Customer { get; set;}
        public int ProductId { get; set;}
        public Product? Product{ get; set;}
        public int Quantity { get; set; }
    }
}