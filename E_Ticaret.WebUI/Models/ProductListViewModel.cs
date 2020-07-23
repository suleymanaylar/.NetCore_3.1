using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.WebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
    }
}
