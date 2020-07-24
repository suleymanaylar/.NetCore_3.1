using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace E_Ticaret.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
