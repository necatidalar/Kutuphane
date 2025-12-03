using Kutuphane.DAL;
using Kutuphane.DAL.Repository;
using Kutuphane.Model.Entity;
using System.Data.Entity;

namespace Kutuphane.BLL.Services
{
    public class OduncService
    {
        private readonly Repository<Odunc> _repository;

        public OduncService()
        {
            _repository = new Repository<Odunc>();
        }

        
        public List<Odunc> GetOdunclerByUye(string deger)
        {
            using var db = new KutuphaneDbContext();

            return db.Oduncler
                .Include(o => o.Kitap)
                .Include(o => o.Uye)
                .Where(o =>
                    (o.Uye.TcPass == deger || o.UyeID.ToString() == deger) &&
                    !o.TeslimEdildi)
                .ToList();
        }

        public void TeslimEt(int oduncId)
        {
            var odunc = _repository.GetById(oduncId);
            if (odunc != null && !odunc.TeslimEdildi)
            {
                odunc.TeslimEdildi = true;
                odunc.TeslimTarihi = DateTime.Now;
                _repository.Update(odunc);
            }
        }
    }
}
