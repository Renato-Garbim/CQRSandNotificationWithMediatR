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
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductDTO>>
    {
        private readonly ProductsInMemory _productsInMemory;

        public GetAllProductsQueryHandler()
        {
            _productsInMemory = new ProductsInMemory();
        }

        public Task<List<ProductDTO>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = _productsInMemory.ProductDTOs;

            return Task.FromResult(products);
        }
    }
}
