using E_Ticaret.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Ticaret.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int MyProperty { get; set; }
        public decimal Unitprice { get; set; }
        public short UnıtsInStock { get; set; }
    }
}
