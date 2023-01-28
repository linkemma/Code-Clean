using Cucuta.DTOs;
using Cucuta.Presentador;
using Cucuta.UseCasePorts_Aplicacion_;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cucuta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        readonly ICreateProductInputPort _InputPort;
        readonly ICreateProductOutputPort _OutputPort;
        public CreateProductController(ICreateProductInputPort inputPort, ICreateProductOutputPort outputPort)
        {
            _InputPort = inputPort;
            _OutputPort = outputPort;
        }
        [HttpPost]
        public async Task<ProductDTO> CreateProducto(CreateProductDTO product)
        {
            await _InputPort.Handle(product);
            return ((IPresentador<ProductDTO>)_OutputPort).Content;
        }
    }
}
