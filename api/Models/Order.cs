using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string Address { get; set; }
        public string PaymentMethod {get; set; }
        public int? CustomerID {get; set; }
        public Customer? Customer { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();
    }
}