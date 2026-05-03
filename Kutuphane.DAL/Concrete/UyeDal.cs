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
    public class UyeDal : EfRepositoryBase<Uye, KutuphaneDbContext>, IUyeDal
    {
        public IDataResult<List<UyeDto>> UyeListeDetayliGetir(Expression<Func<Uye, bool>>? predicate = null)
        {
            try
            {
                using var db = new KutuphaneDbContext();

                var dto = db.Set<Uye>()
                    .AsNoTracking()
                    .Include(x => x.Cinsiyet)
                    .Include(x => x.Kurum)
                    .Include(x => x.UyeTipi)
                    .Where(predicate ?? (x => true))
                    .Select(x => new UyeDto
                    {
                        UyeId = x.UyeId,
                        TcPass = x.TcPass,
                        Ad = x.Ad,
                        Soyad = x.Soyad,
                        CinsiyetId = x.CinsiyetId,
                        Cinsiyet = x.Cinsiyet != null ? x.Cinsiyet.CinsiyetAdi : "",
                        DogumTarihi = x.DogumTarihi,
                        Telefon = x.Telefon,
                        Eposta = x.Eposta,
                        Adres = x.Adres,
                        AdresDetay = x.AdresDetay,
                        AktifMi = x.AktifMi,

                        KurumId = x.KurumId,
                        KurumAdi = x.Kurum != null ? x.Kurum.KurumAdi : "",
                        KurumKodu = x.Kurum != null ? x.Kurum.KurumKodu : "",
                        KurumTipi = x.Kurum != null ? x.Kurum.KurumTipi : "",

                        UyeTipiId = x.UyeTipiId,
                        UyeTipiAdi = x.UyeTipi != null ? x.UyeTipi.UyeTipiAdi : "",
                        UyeTipiKodu = x.UyeTipi != null ? x.UyeTipi.UyeTipiKodu : ""
                    })
                    .ToList();

                if (dto.Count == 0)
                    return new SuccessDataResult<List<UyeDto>>(dto);

                var uyeIdListesi = dto.Select(x => x.UyeId).ToList();

                var ekAlanlar = db.EntityEkAlanDegerleri
                    .AsNoTracking()
                    .Include(x => x.AlanTanim)
                    .Where(x => x.EntityAdi == "UYE" && uyeIdListesi.Contains(x.EntityId))
                    .ToList();

                var alanTanimIdListesi = ekAlanlar
                    .Select(x => x.AlanTanimId)
                    .Distinct()
                    .ToList();

                var secenekler = db.AlanSecenekleri
                    .AsNoTracking()
                    .Where(x => alanTanimIdListesi.Contains(x.AlanTanimId) && x.AktifMi)
                    .ToList();

                string? DegerGetir(List<EntityEkAlanDegeri> uyeEkAlanlari, string alanKodu)
                {
                    var ekAlan = uyeEkAlanlari.FirstOrDefault(x => x.AlanTanim != null && x.AlanTanim.AlanKodu == alanKodu);
                    if (ekAlan == null)
                        return null;

                    if (string.Equals(ekAlan.AlanTanim?.VeriTipi, "SELECT", StringComparison.OrdinalIgnoreCase))
                    {
                        var secenek = secenekler.FirstOrDefault(x => x.AlanTanimId == ekAlan.AlanTanimId && x.Deger == ekAlan.DegerText);
                        return secenek?.Etiket ?? ekAlan.DegerText;
                    }

                    return ekAlan.DegerText;
                }

                foreach (var uye in dto)
                {
                    var uyeEkAlanlari = ekAlanlar
                        .Where(x => x.EntityId == uye.UyeId)
                        .ToList();

                    uye.OkulNo = DegerGetir(uyeEkAlanlari, "OKUL_NO");
                    uye.Sinif = DegerGetir(uyeEkAlanlari, "SINIF");
                    uye.Sube = DegerGetir(uyeEkAlanlari, "SUBE");
                    uye.VeliAdi = DegerGetir(uyeEkAlanlari, "VELI_ADI");
                    uye.VeliTelefonu = DegerGetir(uyeEkAlanlari, "VELI_TELEFONU");
                    uye.Brans = DegerGetir(uyeEkAlanlari, "BRANS");
                    uye.AktifOduncSayisi = db.Oduncler.Count(o => o.UyeId == uye.UyeId && (!o.TeslimEdildi || o.OduncDurum == "ODUNCTE" || o.OduncDurum == "GECIKTI"));
                    uye.GecikmisKitapSayisi = db.Oduncler.Count(o => o.UyeId == uye.UyeId && (!o.TeslimEdildi || o.OduncDurum == "ODUNCTE" || o.OduncDurum == "GECIKTI") && (o.OduncDurum == "GECIKTI" || (o.PlanlananIadeTarihi != null && o.PlanlananIadeTarihi < DateTime.Now)));
                }

                return new SuccessDataResult<List<UyeDto>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<UyeDto>>(e.Message);
            }
        }
        public IDataResult<List<OduncUyeDto>> OduncUyeListeDetayliGetir(Expression<Func<Uye, bool>>? predicate = null)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Uye>()
                    .AsNoTracking()
                    .Where(predicate ?? (x => true))
                    .Select(x => new OduncUyeDto
                    {
                        UyeId = x.UyeId,
                        TcPass = x.TcPass,
                        Ad = x.Ad,
                        Soyad = x.Soyad
                    }).ToList();
                return new SuccessDataResult<List<OduncUyeDto>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<OduncUyeDto>>(e.Message);
            }
        }
    }
}