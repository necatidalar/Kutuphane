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
    public class PersonelDal : EfRepositoryBase<Personel, KutuphaneDbContext>, IPersonelDal
    {
        IDataResult<List<PersonelBilgileriDto>> IPersonelDal.PersonelBilgiGetir(Expression<Func<Personel, bool>>? predicate)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Personel>()
                    .Include(p => p.Cinsiyet)
                    .Where(predicate ?? (x => true))
                    .Select(x => new PersonelBilgileriDto
                    {
                        PersonelId = x.PersonelId,
                        Ad = x.Ad,
                        Soyad = x.Soyad,
                        KullaniciAdi = x.KullaniciAdi,
                        Sifre = x.Sifre,
                        CinsiyetId = x.CinsiyetId,
                        CinsiyetAdi = x.Cinsiyet.CinsiyetAdi,
                        AktifMi = x.AktifMi

                    }).ToList();
                return new SuccessDataResult<List<PersonelBilgileriDto>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<PersonelBilgileriDto>>(e.Message);
            }
        }

        IDataResult<List<PersonelOduncBilgileriDto>> IPersonelDal.PersonelOduncListeIleGetir(Expression<Func<Personel, bool>>? predicate)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Personel>()
                    .Include(p => p.TeslimEdilenler)
                        .ThenInclude(o => o.Kitap)
                    .Include(p => p.TeslimEdilenler)
                        .ThenInclude(o => o.Uye)
                    .Include(p => p.TeslimAlinanlar)
                        .ThenInclude(o => o.Kitap)
                    .Include(p => p.TeslimAlinanlar)
                        .ThenInclude(o => o.Uye)
                    .Where(predicate ?? (x => true))
                    .Select(x => new PersonelOduncBilgileriDto
                    {
                        PersonelId = x.PersonelId,
                        Ad = x.Ad,
                        Soyad = x.Soyad,
                        OduncSayisi = x.TeslimEdilenler.Count,
                        TeslimAlinanlar = x.TeslimAlinanlar.Select(te => new OduncBilgileriDto
                        {
                            OduncId = te.OduncId,
                            KitapId = te.KitapId,
                            UyeId = te.UyeId,
                            AlisTarihi = te.AlisTarihi,
                            TeslimTarihi = te.TeslimTarihi,
                            TeslimEdildi = te.TeslimEdildi,
                            KitapAdi = te.Kitap.KitapAdi,
                            UyeAd = te.Uye.Ad,
                            UyeSoyad = te.Uye.Soyad,
                            UyeEposta = te.Uye.Eposta,
                            UyeTelefon = te.Uye.Telefon,
                        }).ToList(),
                    }).ToList();
                return new SuccessDataResult<List<PersonelOduncBilgileriDto>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<PersonelOduncBilgileriDto>>(e.Message);
            }
        }
    }
}
