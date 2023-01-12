using MediatorApplication.DataMock;
using MediatorApplication.DTO;
using MediatorApplication.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApplication.QueryHandler
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductDTO>
    {
        private readonly ProductsInMemory _productsInMemory;

        public GetProductQueryHandler()
        {
            _productsInMemory = new ProductsInMemory();
        }

        public Task<ProductDTO> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product = _productsInMemory.ProductDTOs.FirstOrDefault(p => p.Sku.Equals(request.Sku));
            if (product == null)
            {
                throw new InvalidOperationException("Invalid product");
            }

            return Task.FromResult(product);
        }
    }
}
