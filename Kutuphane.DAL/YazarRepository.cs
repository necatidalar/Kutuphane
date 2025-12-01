using Kutuphane.Model.Entity;

namespace Kutuphane.DAL
{
    public class YazarRepository
    {
        public List<Yazar> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.Yazarlar.ToList();
        }

        public void Add(Yazar yazar)
        {
            using var db = new KutuphaneDbContext();
            db.Yazarlar.Add(yazar);
            db.SaveChanges();
        }

        public void Update(Yazar yazar)
        {
            using var db = new KutuphaneDbContext();
            db.Yazarlar.Update(yazar);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new KutuphaneDbContext();
            var yazar = db.Yazarlar.Find(id);
            if (yazar != null)
            {
                db.Yazarlar.Remove(yazar);
                db.SaveChanges();
            }
        }
    }
}
