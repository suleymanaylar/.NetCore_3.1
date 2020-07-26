using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Bussines.Abstract;
using E_Ticaret.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;

        public AdminController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products=_productService.GetAll()
            };
            return View(model);
        }
    }
}
