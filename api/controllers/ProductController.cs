using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController: ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public ProductController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        { 
            var products = _context.products.ToList();//defer excecution
            return Ok(products);
        }

       [HttpGet("{id}")]
       public IActionResult GetById([FromRoute]int id)
       {
            var product = _context.products.Find(id);
            if(product == null){return NotFound();}
            return Ok(product);
       }
    }
}