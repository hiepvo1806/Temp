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
            return new List<Product>
            {
                new Product()
                {
                    Description = "Plastic Ball",
                    Id = 1,
                    Name = "BALL"
                }
            };
        }

        public void CreateOrUpdate(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
