using Cucuta.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cucuta.UseCasePorts_Aplicacion_
{
    public interface ICreateProductInputPort
    {
        Task Handle(CreateProductDTO product);
    }
}
