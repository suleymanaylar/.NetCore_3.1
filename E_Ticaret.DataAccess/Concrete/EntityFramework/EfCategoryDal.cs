using E_Ticaret.Core.DataAccess.EntityFramework;
using E_Ticaret.DataAccess.Abstract;
using E_Ticaret.Entities.Concrete;

namespace E_Ticaret.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
