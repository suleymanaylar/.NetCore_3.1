using E_Ticaret.Core.DataAccess.EntityFramework;
using E_Ticaret.DataAccess.Abstract;
using E_Ticaret.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Ticaret.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
