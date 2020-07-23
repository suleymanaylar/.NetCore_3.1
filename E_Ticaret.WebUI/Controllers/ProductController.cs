using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Bussines.Abstract;
using E_Ticaret.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel
            {
                Products=products
            };
            return View(model);
        }
    }
}
