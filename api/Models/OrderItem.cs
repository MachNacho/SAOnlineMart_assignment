using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        [Column(TypeName = "decimal(18,2)")]// make column 18 digits long and 2 decimal places
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int? OrderID {get; set; }
        public Order? order { get; set;}
    }
}