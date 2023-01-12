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
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly ProductsInMemory _productsInMemory;

        public DeleteProductCommandHandler()
        {
            _productsInMemory = new ProductsInMemory();
        }

        public Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var existingProduct =
                _productsInMemory.ProductDTOs.FirstOrDefault(p => p.Sku.Equals(request.Sku));

            if (existingProduct != null)
            {
                var result = _productsInMemory.ProductDTOs.Remove(existingProduct);
                return Task.FromResult(result);
            }

            throw new InvalidOperationException("Invalid product");
        }
    }
}
