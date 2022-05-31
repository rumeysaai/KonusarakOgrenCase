using KonusarakOgren.Areas.Identity.Data;

namespace KonusarakOgren.Abstract
{
    public interface IProduct:IRepository<Products>
    {
        IEnumerable<Products> GetPopularProducts();
    }
}
