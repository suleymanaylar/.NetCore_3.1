using E_Ticaret.Entities.Concrete;
using E_Ticaret.WebUI.ExtensionMethods;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.WebUI.Services
{
    public class CartSessionService : ICartSessionService
    {
        IHttpContextAccessor _httpContextAccessor;

        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
            var carToCheck= _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (carToCheck==null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart",new Cart());
                carToCheck= _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return carToCheck;
        }

        public void SetCart(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("cart", cart);
        }
    }
}
