using Cucuta.DTOs;
using Cucuta.UseCasePorts_Aplicacion_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cucuta.Presentador
{
    public class CreateProductPresentador: ICreateProductOutputPort , IPresentador<ProductDTO>
    {

        public ProductDTO Content { get; private set; }

        public Task Handle(ProductDTO product)
        {
            Content = product;
            return Task.CompletedTask;
        }
    }
}
