using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set;}
        public string Password { get; set;}
        public List<Cart> cart { get; set; } = new List<Cart>();
        public List<Order> order { get; set; } = new List<Order>();
        public List<Address_book> address_Books { get; set; } = new List<Address_book>();
    }
}