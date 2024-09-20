using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Product
{
    public class productDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UploadDate { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
    }
}