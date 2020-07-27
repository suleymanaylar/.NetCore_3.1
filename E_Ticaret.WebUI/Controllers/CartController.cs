using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Bussines.Abstract;
using E_Ticaret.Entities.Concrete;
using E_Ticaret.WebUI.Models;
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

            return RedirectToAction("Index", "Product");
        }
        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartSummaryViewModel model = new CartSummaryViewModel
            {
                Cart = cart
            };

            return View(model);
        }
        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            var getCartName = cart.CartLines.Where(x => x.Product.ProductId == productId).Select(x => x.Product.ProductName);
            var CartName = getCartName.FirstOrDefault().ToString();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", CartName + " Ürününüz Çıkartıldı.");
            return RedirectToAction("List");
        }
        public ActionResult Complete()
        {
            var model = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", "Teşekkürler " + shippingDetails.FirstName + " Siparişiniz alındı.");
            ModelState.Clear();
            return View();
        }
    }
}
