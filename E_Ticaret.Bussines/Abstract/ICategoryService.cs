using E_Ticaret.Entities.Concrete;
using System.Collections.Generic;

namespace E_Ticaret.Bussines.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
