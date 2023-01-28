using Cucuta.DTOs;
using Cucuta.Presentador;
using Cucuta.UseCasePorts_Aplicacion_;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cucuta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllProductsController
    {
        readonly IGetAllProductsInputPort _InputPort;
        readonly IGetAllProducsOutputPort _OutputPort;
        public GetAllProductsController(IGetAllProductsInputPort inputPort, IGetAllProducsOutputPort outputPort)
        {
            _InputPort = inputPort;
            _OutputPort = outputPort;
        }
        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            await _InputPort.Handle();
            return ((IPresentador<IEnumerable<ProductDTO>>)_OutputPort).Content;
        }
    }
}
