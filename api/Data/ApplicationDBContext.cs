using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Models;
namespace api.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
        }
        public DbSet<Customer> customers { get;set;}
        public DbSet<Address_book> address_Books { get;set;}
        public DbSet<Cart> carts { get;set;}
        public DbSet<Order> orders { get;set;}
        public DbSet<Product> products { get;set;}
        public DbSet<OrderItem>orderItems { get;set;}       
    }
}