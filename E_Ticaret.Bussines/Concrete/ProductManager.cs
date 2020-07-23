using E_Ticaret.Bussines.Abstract;
using E_Ticaret.DataAccess.Abstract;
using E_Ticaret.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Ticaret.Bussines.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId = productId });
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId || categoryId == 0);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
