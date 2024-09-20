using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Product;
using api.Models;

namespace api.Mapper
{
    public static class productMapper
    {
        public static productDTO ToProductDto(this Product productModel)
        {
            return new productDTO{
                Id = productModel.Id,
                Name = productModel.Name,
                UploadDate = productModel.UploadDate,
                Price = productModel.Price,
                Description = productModel.Description,
                Category = productModel.Category
            };
        }

        public static Product ToProductFromCreateDTO (this CreateProductRequestDTO createProductRequestDTO)
        {
            return new Product
            {
                Name = createProductRequestDTO.Name,
                Price = createProductRequestDTO.Price,
                Description = createProductRequestDTO.Description,
                Category = createProductRequestDTO.Category
            };
        }
    }
}