using E_Ticaret.Core.DataAccess;
using E_Ticaret.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Ticaret.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //TODO Custom Operation
    }
}
