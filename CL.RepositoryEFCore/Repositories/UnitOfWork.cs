using CL.RepositoryEFCore.DataContext;
using ClassLibraryEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CL.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly CucutaContext _context;

        public UnitOfWork(CucutaContext context)
        {
            _context = context;
        }   
        public Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
