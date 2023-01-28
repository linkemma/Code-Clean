using Cucuta.DTOs;
using Cucuta.UseCasePorts_Aplicacion_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cucuta.Presentador
{
    internal class GetAllProductsPresentador : IGetAllProducsOutputPort, IPresentador<IEnumerable<ProductDTO>>
    {
        public IEnumerable<ProductDTO> Content { get; private set; }

        public Task Handle(IEnumerable<ProductDTO> products)
        {
            Content = products;
            return Task.CompletedTask;
        }
    }
}
