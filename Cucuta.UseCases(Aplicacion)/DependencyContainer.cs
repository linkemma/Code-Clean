using Cucuta.UseCasePorts_Aplicacion_;
using Cucuta.UseCases_Aplicacion_.CreateProduct;
using Cucuta.UseCases_Aplicacion_.GetAllProducts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cucuta.UseCases_Aplicacion_
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
            services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>();

            return services;
        }
    }
}
