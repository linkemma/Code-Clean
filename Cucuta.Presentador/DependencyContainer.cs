using Cucuta.UseCasePorts_Aplicacion_;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cucuta.Presentador
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresentador( this IServiceCollection services)
        {
            services.AddScoped<ICreateProductOutputPort, CreateProductPresentador>();
            services.AddScoped<IGetAllProducsOutputPort, GetAllProductsPresentador>();
            return services; 
        }
    }
}
