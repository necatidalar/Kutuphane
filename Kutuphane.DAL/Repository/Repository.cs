using Core.IRepository;

namespace Kutuphane.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public List<T> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.Set<T>().ToList();
        }

        public void Add(T entity)
        {
            using var db = new KutuphaneDbContext();
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            using var db = new KutuphaneDbContext();
            db.Set<T>().Update(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new KutuphaneDbContext();
            var entity = db.Set<T>().Find(id);
            if (entity != null)
            {
                db.Set<T>().Remove(entity);
                db.SaveChanges();
            }
        }
    }
}
