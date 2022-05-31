using KonusarakOgren.Abstract;
using KonusarakOgren.Areas.Identity.Data;

namespace KonusarakOgren.Concrete
{
    public class ProductManager : IProductService
    {
        private IProduct _productDal;

        public ProductManager(IProduct productDal)
        {
            _productDal = productDal;
        }
        public void Create(Products entity)
        {
            _productDal.Create(entity);
        }

        public void Delete(Products entity)
        {
            _productDal.Delete(entity);
        }

        public List<Products> GetAll()
        {
            return _productDal.GetAll();
        }

        public Products GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Products> GetPoularProduct()
        {
            return _productDal.GetAll();
        }

        public void Update(Products entity)
        {
            _productDal.Update(entity);
        }
    }
}
