using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Model;

namespace ServiceLayer.Interface
{
    public interface IProductServices
    {
        IEnumerable<Product> GetAll();
        void CreateOrUpdate(Product product);
        void Delete(int productId);

    }
}
