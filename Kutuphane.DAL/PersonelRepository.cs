using Core.Helpers;
using Kutuphane.Model.Entity;

namespace Kutuphane.DAL
{
    public class PersonelRepository
    {
        public List<Personel> GetAll()
        {
            using var db = new KutuphaneDbContext();
            return db.Personel.ToList();
        }

        public void Add(Personel personel)
        {
            using var db = new KutuphaneDbContext();
            personel.Sifre = SecurityHelper.EncodeBase64(personel.Sifre);

            db.Personel.Add(personel);
            db.SaveChanges();
        }

        public void Update(Personel personel)
        {
            using var db = new KutuphaneDbContext();
            personel.Sifre = SecurityHelper.EncodeBase64(personel.Sifre);

            db.Personel.Update(personel);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new KutuphaneDbContext();
            var personel = db.Personel.Find(id);
            if (personel != null)
            {
                db.Personel.Remove(personel);
                db.SaveChanges();
            }
        }
    }
}
