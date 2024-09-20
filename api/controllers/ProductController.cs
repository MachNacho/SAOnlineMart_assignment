using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Product;
using api.Mapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var products = _context.products.ToList().Select(s => s.ToProductDto());//defer excecution
            return Ok(products);
        }

       [HttpGet("{id}")]
       public IActionResult GetById([FromRoute]int id)
       {
            var product = _context.products.Find(id);
            if(product == null){return NotFound();}
            return Ok(product.ToProductDto());
       }

       [HttpPost]
       public IActionResult CreateProduct([FromBody]CreateProductRequestDTO productDTO)
       {
            var productsModel = productDTO.ToProductFromCreateDTO();
            _context.products.Add(productsModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new{id = productsModel.Id},productsModel.ToProductDto());
       }

       [HttpPut]
       [Route("{id}")]
       public IActionResult Update([FromRoute]int id,[FromBody]CreateProductRequestDTO productDTO)
       {
            var productsModel = _context.products.FirstOrDefault(x =>x.Id==id);
            if(productsModel == null){return NotFound();}
            productsModel.Name = productDTO.Name;     
            productsModel.Price = productDTO.Price;     
            productsModel.Description = productDTO.Description;     
            productsModel.Category = productDTO.Category;
            _context.SaveChanges();
            return Ok(productsModel.ToProductDto());
       }

       [HttpDelete]
       [Route("{id}")]
       public IActionResult Delete([FromRoute]int id)
       {
            var productsModel = _context.products.FirstOrDefault(x =>x.Id==id);
            if(productsModel == null){return NotFound();}
            _context.products.Remove(productsModel);
            _context.SaveChanges();
            return NoContent();
       }
    }
}