using MediatorApplication.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApplication.Query
{
    public class GetAllProductsQuery : IRequest<List<ProductDTO>>
    {

    }
}
