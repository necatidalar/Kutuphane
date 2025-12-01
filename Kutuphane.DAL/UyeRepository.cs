using Kutuphane.Model.Entity;

namespace Kutuphane.DAL
{
    public class UyeRepository
    {
        public List<Uye> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.Uyeler.ToList();
        }

        public void Add(Uye uye)
        {
            using var db = new KutuphaneDbContext();
            db.Uyeler.Add(uye);
            db.SaveChanges();
        }

        public void Update(Uye uye)
        {
            using var db = new KutuphaneDbContext();
            db.Uyeler.Update(uye);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new KutuphaneDbContext();
            var uye = db.Uyeler.Find(id);
            if (uye != null)
            {
                db.Uyeler.Remove(uye);
                db.SaveChanges();
            }
        }
    }
}
