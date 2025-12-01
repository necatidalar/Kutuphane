using Kutuphane.Model.Entity;
using System.Data.Entity;

namespace Kutuphane.DAL
{
    public class KolonRepository
    {
        public List<Kolon> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.Kolonlar.Include(k => k.Kitaplik).ToList();
        }

        public void Add(Kolon kolon)
        {
            using var db = new KutuphaneDbContext();
            db.Kolonlar.Add(kolon);
            db.SaveChanges();
        }

        public void Update(Kolon kolon)
        {
            using var db = new KutuphaneDbContext();
            db.Kolonlar.Update(kolon);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new KutuphaneDbContext();
            var kolon = db.Kolonlar.Find(id);
            if (kolon != null)
            {
                db.Kolonlar.Remove(kolon);
                db.SaveChanges();
            }
        }
    }
}
