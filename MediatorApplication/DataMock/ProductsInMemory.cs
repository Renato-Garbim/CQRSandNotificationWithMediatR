using MediatorApplication.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApplication.DataMock
{
    public class ProductsInMemory
    {
        private readonly List<ProductDTO> _productList;

        public ProductsInMemory()
        {
            _productList = new List<ProductDTO>()
            {
                new ProductDTO()
                {
                    Id = 1,
                    Name = "Milk",
                    Sku = "MILK",
                    Quantity = 10,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new ProductDTO()
                {
                    Id = 2,
                    Name = "Coffee",
                    Sku = "COFFEE",
                    Quantity = 10,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new ProductDTO()
                {
                    Id = 3,
                    Name = "Toast",
                    Sku = "TOAST",
                    Quantity = 10,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new ProductDTO()
                {
                    Id = 4,
                    Name = "Butter",
                    Sku = "BUTTER",
                    Quantity = 10,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                }
            };
        }

        public List<ProductDTO> ProductDTOs => _productList;
    }
}
