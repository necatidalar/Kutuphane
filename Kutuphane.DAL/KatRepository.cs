using Kutuphane.Model.Entity;

namespace Kutuphane.DAL
{
    public class KatRepository
    {
        public List<Kat> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.Katlar.ToList();
        }

        public void Add(Kat kat)
        {
            using var db = new KutuphaneDbContext();
            db.Katlar.Add(kat);
            db.SaveChanges();
        }

        public void Update(Kat kat)
        {
            using var db = new KutuphaneDbContext();
            db.Katlar.Update(kat);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new KutuphaneDbContext();
            var kat = db.Katlar.Find(id);
            if (kat != null)
            {
                db.Katlar.Remove(kat);
                db.SaveChanges();
            }
        }
    }
}
