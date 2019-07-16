using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Interface;
using ServiceLayer.Model;

namespace ServiceLayer.Services
{
    public class ProductServices :IProductServices
    {
        public IEnumerable<Product> GetAll()
        {
            var dbSet = Context.Storage;
            if (dbSet == null)
            {
                Context.InitStorage();
            }
            return Context.Storage;
        }

        public void CreateOrUpdate(Product product)
        {
            var dbSet = Context.Storage;
            if (dbSet == null)
            {
                Context.InitStorage();
            }

            if (dbSet != null && dbSet.Any(q => q.Id == product.Id))
            {
                var findItem = dbSet.First(x => x.Id == product.Id);
                findItem = product;
            }
            else
            {
                Context.Storage.Add(product);
            }
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
