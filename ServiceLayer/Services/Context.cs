using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Model;

namespace ServiceLayer.Services
{
    public static class Context
    {
        public static List<Product> Storage { get; set; }

        public static void InitStorage()
        {
            if (Storage == null)
            {
                Storage = new List<Product>
                {
                    new Product()
                    {
                        Description = "Plastic Ball",
                        Id = 1,
                        Name = "BALL"
                    }
                };
            }
        }
    }
}
