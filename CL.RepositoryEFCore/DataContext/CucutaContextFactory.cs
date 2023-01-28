using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.RepositoryEFCore.DataContext
{
    internal class CucutaContextFactory : IDesignTimeDbContextFactory<CucutaContext>
    {
        public CucutaContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<CucutaContext>();
            OptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=CodeClean");
            return new CucutaContext(OptionsBuilder.Options);
        }
    }
}
