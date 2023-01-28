using ClassLibraryEntities.POCOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.RepositoryEFCore.DataContext
{
    public class CucutaContext : DbContext
    {
        public CucutaContext(DbContextOptions<CucutaContext>options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
