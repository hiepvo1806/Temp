using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ServiceLayer.Interface;
using ServiceLayer.Model;

namespace cqrsmvc5.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;
        public ProductController(IProductServices ProductService)
        {
            _productServices = ProductService;
        }
        // GET: Product
        public ActionResult Index()
        {
            var result = _productServices.GetAll();
            return View(result);
        }
        public string RefreshIndex()
        {
            var result = _productServices.GetAll();
            return JsonConvert.SerializeObject(result, Formatting.Indented);
        }

        public string Update()
        {
            Random rnd = new Random();
            string name = Guid.NewGuid().ToString();
            _productServices.CreateOrUpdate(new Product()
            {
                Id = rnd.Next(1,999),
                Name = name,
                Description = name
            });
            return "Ok";
        }
    }
}