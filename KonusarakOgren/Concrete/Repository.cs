namespace KonusarakOgren.Concrete
{
    //public class Repository<T> where T : BaseEntity
    //{
    //    JetCaseContext db;
    //    public Repository()
    //    {
    //        db = new JetCaseContext();
    //    }  //Repository new lendiği yerde devreye giren ilk fonksiynumuz budur.
    //       //Ctor çağırılır. Bu metot db bağlantısını new'ler. 



    //    public void AddDal(T obje)
    //    {
    //        db.Set<T>().Add(obje);
    //        db.SaveChanges();
    //        //Libary enttiy framework
    //    }


    //    public void DeleteDal(T obje)
    //    {
    //        db.Set<T>().Remove(obje);
    //        db.SaveChanges();
    //    }
    //    public List<T> ListDal()
    //    {
    //        return db.Set<T>().ToList();
    //    }

    //    public T GetbyIdDal(int id)
    //    {

    //        return db.Set<T>().FirstOrDefault(x => x.Id == id);
    //    }

    //    public void UpdateDal(int id, T obje)
    //    {
    //        var objeyibul = GetbyIdDal(id);
    //        objeyibul = obje;
    //        db.SaveChanges();

    //    }
    //}
}
