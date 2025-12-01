using Kutuphane.Model.Entity;

namespace Kutuphane.DAL
{
    public class YayineviRepository
    {
        public List<Yayinevi> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.Yayinevleri.ToList();
        }

        public void Add(Yayinevi yayinevi)
        {
            using var db = new KutuphaneDbContext();
            db.Yayinevleri.Add(yayinevi);
            db.SaveChanges();
        }

        public void Update(Yayinevi yayinevi)
        {
            using var db = new KutuphaneDbContext();
            db.Yayinevleri.Update(yayinevi);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new KutuphaneDbContext();
            var yayinevi = db.Yayinevleri.Find(id);
            if (yayinevi != null)
            {
                db.Yayinevleri.Remove(yayinevi);
                db.SaveChanges();
            }
        }
    }
}
