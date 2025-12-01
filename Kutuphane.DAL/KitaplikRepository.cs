using Kutuphane.Model.Entity;
using System.Data.Entity;

namespace Kutuphane.DAL
{
    public class KitaplikRepository
    {
        public List<Kitaplik> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.Kitapliklar.Include(k => k.Kat).ToList();
        }

        public void Add(Kitaplik kitaplik)
        {
            using var db = new KutuphaneDbContext();
            db.Kitapliklar.Add(kitaplik);
            db.SaveChanges();
        }

        public void Update(Kitaplik kitaplik)
        {
            using var db = new KutuphaneDbContext();
            db.Kitapliklar.Update(kitaplik);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new KutuphaneDbContext();
            var kitaplik = db.Kitapliklar.Find(id);
            if (kitaplik != null)
            {
                db.Kitapliklar.Remove(kitaplik);
                db.SaveChanges();
            }
        }
    }
}
