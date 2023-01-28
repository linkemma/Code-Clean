using CL.RepositoryEFCore.DataContext;
using CL.RepositoryEFCore.Repositories;
using ClassLibraryEntities.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.RepositoryEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories( this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CucutaContext>(options => options.UseSqlServer(configuration.GetConnectionString("CodeClean")));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
