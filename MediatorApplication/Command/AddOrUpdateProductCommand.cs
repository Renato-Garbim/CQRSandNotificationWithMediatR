using MediatorApplication.DataMock;
using MediatorApplication.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApplication.Command
{
    public class AddOrUpdateProductCommand : IRequest<bool>
    {
        public ProductDTO ProductDto { get; set; }
        
    }

}
