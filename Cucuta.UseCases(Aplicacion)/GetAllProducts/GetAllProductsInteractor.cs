using ClassLibraryEntities.Interfaces;
using Cucuta.DTOs;
using Cucuta.UseCasePorts_Aplicacion_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cucuta.UseCases_Aplicacion_.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        readonly IProductRepository _Repository;
        readonly IGetAllProducsOutputPort _OutputPort;
        
        public GetAllProductsInteractor(IProductRepository repository, IGetAllProducsOutputPort outputPort)
        {
            _Repository = repository;
            _OutputPort = outputPort;
        }

        public Task Handle()
        {
            var Products = _Repository.GetAll().Select(p =>
            new ProductDTO
            {
                Id = p.Id,
                Name = p.Name
            });
            _OutputPort.Handle(Products);
            return Task.CompletedTask;
        }
    }
}
