using CL.RepositoryEFCore;
using Cucuta.Presentador;
using Cucuta.UseCases_Aplicacion_;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cucuta.InversionControl
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddCucutaDependencias( this IServiceCollection service, IConfiguration configuration)
        {
            service.AddRepositories(configuration);
            service.AddUseCasesServices();
            service.AddPresentador();
            return service;
        }
    }
}
