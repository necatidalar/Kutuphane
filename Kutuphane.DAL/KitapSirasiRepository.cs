using Kutuphane.Model.Entity;
using System.Data.Entity;

namespace Kutuphane.DAL
{
    public class KitapSirasiRepository
    {
        public List<KitapSirasi> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.KitapSirasi.Include(k => k.Raf).Include(k => k.Kitap).ToList();
        }

        public void Add(KitapSirasi ks)
        {
            using var db = new KutuphaneDbContext();
            db.KitapSirasi.Add(ks);
            db.SaveChanges();
        }

        public void Update(KitapSirasi ks)
        {
            using var db = new KutuphaneDbContext();
            db.KitapSirasi.Update(ks);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new KutuphaneDbContext();
            var ks = db.KitapSirasi.Find(id);
            if (ks != null)
            {
                db.KitapSirasi.Remove(ks);
                db.SaveChanges();
            }
        }
    }
}
