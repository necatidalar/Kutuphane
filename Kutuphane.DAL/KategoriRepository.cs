using Kutuphane.Model.Entity;

namespace Kutuphane.DAL
{
    public class KategoriRepository
    {
        public List<Kategori> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.Kategoriler.ToList();
        }

        public void Add(Kategori kategori)
        {
            using var db = new KutuphaneDbContext();
            db.Kategoriler.Add(kategori);
            db.SaveChanges();
        }

        public void Update(Kategori kategori)
        {
            using var db = new KutuphaneDbContext();
            db.Kategoriler.Update(kategori);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new KutuphaneDbContext();
            var kategori = db.Kategoriler.Find(id);
            if (kategori != null)
            {
                db.Kategoriler.Remove(kategori);
                db.SaveChanges();
            }
        }
    }
}
