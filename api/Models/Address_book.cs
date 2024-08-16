using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Address_book
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public int CustomerID {get; set;}
        public Customer? Customer { get; set;}
    }
}