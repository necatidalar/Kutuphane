using Kutuphane.Model.Entity;
using System.Data.Entity;

namespace Kutuphane.DAL
{
    public class KitapRepository
    {
        public List<Kitap> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.Kitaplar
                     .Include(k => k.Yazar)
                     .Include(k => k.Yayinevi)
                     .Include(k => k.Kategori)
                     .ToList();
        }

        public void Add(Kitap kitap)
        {
            using var db = new KutuphaneDbContext();
            db.Kitaplar.Add(kitap);
            db.SaveChanges();
        }

        public void Update(Kitap kitap)
        {
            using var db = new KutuphaneDbContext();
            db.Kitaplar.Update(kitap);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new KutuphaneDbContext();
            var kitap = db.Kitaplar.Find(id);
            if (kitap != null)
            {
                db.Kitaplar.Remove(kitap);
                db.SaveChanges();
            }
        }
    }
}