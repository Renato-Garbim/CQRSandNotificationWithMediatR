using MediatorApplication.Command;
using MediatorApplication.DataMock;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApplication.CommandHandler
{
    public class AddOrUpdateProductCommandHandler : IRequestHandler<AddOrUpdateProductCommand, bool>
    {
        private readonly ProductsInMemory _productsInMemory;

        public AddOrUpdateProductCommandHandler()
        {
            _productsInMemory = new ProductsInMemory();
        }

        public Task<bool> Handle(AddOrUpdateProductCommand request, CancellationToken cancellationToken)
        {
            var existingProduct =
                _productsInMemory.ProductDTOs.FirstOrDefault(p => p.Sku.Equals(request.ProductDto.Sku));

            if (existingProduct != null)
            {
                var index = _productsInMemory.ProductDTOs.FindIndex(p => p.Sku.Equals(request.ProductDto.Sku));
                _productsInMemory.ProductDTOs[index] = request.ProductDto;
                return Task.FromResult(true);
            }

            _productsInMemory.ProductDTOs.Add(request.ProductDto);

            return Task.FromResult(true);
        }
    }
}
