using KonusarakOgren.Areas.Identity.Data;

namespace KonusarakOgren.Abstract
{
    public interface IProductService
    {
        Products GetById(int id);


        List<Products> GetAll();

        List<Products> GetPoularProduct();

        void Create(Products entity);
        void Update(Products entity);
        void Delete(Products entity);
    }
}
