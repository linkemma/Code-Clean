using ClassLibraryEntities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntities.Interfaces
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        IEnumerable<Product> GetAll();
    }
}
