using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class OduncDal : EfRepositoryBase<Odunc, KutuphaneDbContext>, IOduncDal
    {
        public IDataResult<List<OduncBilgileriDto>> OduncBilgileriGetir(Expression<Func<Odunc, bool>>? predicate = null)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Odunc>()
                    .Include(o => o.Uye)
                    .Include(o => o.Kitap)
                    .Where(predicate ?? (x => true))
                    .Select(o => new OduncBilgileriDto
                    {
                        OduncId = o.OduncId,
                        UyeId = o.UyeId,
                        UyeOkulNo = o.Uye.OkulNo,
                        UyeSinif = o.Uye.Sinif,
                        UyeSube = o.Uye.Sube,
                        UyeAd = o.Uye.Ad,
                        UyeSoyad = o.Uye.Soyad,
                        UyeTelefon = o.Uye.Telefon,
                        UyeEposta = o.Uye.Eposta,
                        KitapId = o.KitapId,
                        KitapAdi = o.Kitap.KitapAdi,
                        AlisTarihi = o.AlisTarihi,
                        TeslimTarihi = o.TeslimTarihi,
                        TeslimEdildi = o.TeslimEdildi
                    }).ToList();

                return new SuccessDataResult<List<OduncBilgileriDto>>(dto);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<OduncBilgileriDto>>(ex.Message);
            }
        }
    }
}
