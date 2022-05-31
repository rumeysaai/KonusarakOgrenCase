using KonusarakOgren.Abstract;
using KonusarakOgren.Areas.Identity.Data;

namespace KonusarakOgren.Concrete
{
    public class EfCoreProduct : EfCoreGenericRepository<Products, ApplicationDbContext>, IProduct
    {
        public IEnumerable<Products> GetPopularProducts()
        {
            throw new NotImplementedException();
        }
    }
}
