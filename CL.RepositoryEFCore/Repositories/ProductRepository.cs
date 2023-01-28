using CL.RepositoryEFCore.DataContext;
using ClassLibraryEntities.Interfaces;
using ClassLibraryEntities.POCOs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.RepositoryEFCore.Repositories
{
    
    public class ProductRepository: IProductRepository
    {
        readonly CucutaContext _context;
        public ProductRepository(CucutaContext context)
        {
            _context = context;
        }
        public void CreateProduct(Product product)
        {
            _context.Add(product);
        }
        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }
    }
}
