﻿using System.Collections.Generic;
using System.Linq;

namespace E_Ticaret.Entities.Concrete
{
    public class Cart
    {
        public Cart()
        {
            CartLines = new List<CartLine>();
        }
        public List<CartLine> CartLines { get; set; }
        public decimal Total 
        { 
            get { return CartLines.Sum(x => x.Product.Unitprice * x.Quantity); }  
        }
    }
}
