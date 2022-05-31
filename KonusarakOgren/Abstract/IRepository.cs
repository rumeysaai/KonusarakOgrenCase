using System.Linq.Expressions;

namespace KonusarakOgren.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int id);
        T GetTOne(Expression<Func<T, bool>> filter);
        //Lamda ve linq ifaadeleri için expression kullanırız
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
