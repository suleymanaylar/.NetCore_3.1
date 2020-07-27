using E_Ticaret.Entities.Concrete;
using System.Collections.Generic;

namespace E_Ticaret.WebUI.Models
{
    public class ProductUpdateViewModel
    {
        public    List<Category> Categories;

        public Product Product { get; set; }
    }
}