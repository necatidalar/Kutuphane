using Kutuphane.Model.Entity;
using System.Data.Entity;

namespace Kutuphane.DAL
{
    public class OduncRepository
    {
        public List<Odunc> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.Oduncler
                     .Include(o => o.Uye)
                     .Include(o => o.Kitap)
                     .Include(o => o.Personel)
                     .ToList();
        }

        public void Add(Odunc odunc)
        {
            using var db = new KutuphaneDbContext();
            db.Oduncler.Add(odunc);
            db.SaveChanges();
        }

        public void Update(Odunc odunc)
        {
            using var db = new KutuphaneDbContext();
            db.Oduncler.Update(odunc);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new KutuphaneDbContext();
            var odunc = db.Oduncler.Find(id);
            if (odunc != null)
            {
                db.Oduncler.Remove(odunc);
                db.SaveChanges();
            }
        }
    }
}
