using ClassLibraryEntities.Interfaces;
using ClassLibraryEntities.POCOs;
using Cucuta.DTOs;
using Cucuta.UseCasePorts_Aplicacion_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cucuta.UseCases_Aplicacion_.CreateProduct
{
    public class CreateProductInteractor: ICreateProductInputPort
    {
        readonly IProductRepository _Repository;
        readonly IUnitOfWork _UnitOfWork;
        readonly ICreateProductOutputPort _OutPort;

        public CreateProductInteractor(IProductRepository repository, IUnitOfWork unitOfWork, ICreateProductOutputPort outPort)
        {
            _Repository = repository;
            _UnitOfWork = unitOfWork;
            _OutPort = outPort;
        }

        public async Task Handle(CreateProductDTO product)
        {
            Product NewProduct = new Product
            {
                Name = product.ProductName
            };
            _Repository.CreateProduct(NewProduct);
            await _UnitOfWork.SaveChanges();
            await _OutPort.Handle(
                new ProductDTO
                {
                    Id = NewProduct.Id,
                    Name = NewProduct.Name
                });
        }
    }
}
