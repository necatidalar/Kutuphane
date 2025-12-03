using Core.Entity;
using Core.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Kutuphane.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public List<T> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.Set<T>().ToList();
        }
        public List<T> GetByFilter(Expression<Func<T, bool>>? predicate = null)
        {
            using var db = new KutuphaneDbContext();
            var query = db.Set<T>().AsQueryable();
            if (predicate != null) query = query.Where(predicate);
            return query.ToList();
        }

        public T GetById(int id)
        {
            using var db = new KutuphaneDbContext();
            return db.Set<T>().Find(id);
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
            db.Set<T>().Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
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