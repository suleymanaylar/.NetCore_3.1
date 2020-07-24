using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Bussines.Abstract;
using E_Ticaret.WebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.WebUI.Controllers
{
    public class CartController : Controller
    {
        ICartSessionService _cartSessionService;
        ICartService _cartService;
        IProductService _productService;


        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }



        public IActionResult AddToCart(int productId)
        {
            var addToProduct = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, addToProduct);
            _cartSessionService.SetCart(cart);

            TempData.Add("message", addToProduct.ProductName + " İsimli ürününüz eklendi.");

            return RedirectToAction("List", "Product");
        }
    }
}
