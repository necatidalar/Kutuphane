using Kutuphane.Model.Entity;
using System.Data.Entity;

namespace Kutuphane.DAL
{
    public class RafRepository
    {
        public List<Raf> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.Raflar.Include(r => r.Kolon).ToList();
        }

        public void Add(Raf raf)
        {
            using var db = new KutuphaneDbContext();
            db.Raflar.Add(raf);
            db.SaveChanges();
        }

        public void Update(Raf raf)
        {
            using var db = new KutuphaneDbContext();
            db.Raflar.Update(raf);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new KutuphaneDbContext();
            var raf = db.Raflar.Find(id);
            if (raf != null)
            {
                db.Raflar.Remove(raf);
                db.SaveChanges();
            }
        }
    }
}
