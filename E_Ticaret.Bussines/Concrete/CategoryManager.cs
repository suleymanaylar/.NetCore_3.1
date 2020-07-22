using E_Ticaret.Bussines.Abstract;
using E_Ticaret.DataAccess.Abstract;
using E_Ticaret.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Ticaret.Bussines.Concrete
{
    class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
