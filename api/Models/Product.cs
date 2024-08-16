using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UploadDate { get; set; } = DateTime.Now;
        [Column(TypeName = "decimal(18,2)")]// make column 18 digits long and 2 decimal places
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
    }
}