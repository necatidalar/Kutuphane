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
    public class KitapDal : EfRepositoryBase<Kitap, KutuphaneDbContext>, IKitapDal
    {
        public IDataResult<List<KitapDto>> KitapListeDetayliGetir(Expression<Func<Kitap, bool>>? predicate = null)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Kitap>()
                    .Include(k => k.Yazar)
                    .Include(k => k.Yayinevi)
                    .Include(k => k.Kategori)
                    .Include(k => k.Diller)
                    .Where(predicate ?? (x => true))
                    .Select(k => new KitapDto
                    {
                        KitapId = k.KitapId,
                        KitapAdi = k.KitapAdi,
                        ISBN = k.ISBN ?? string.Empty,
                        YazarId = k.YazarId,
                        YazarAd = k.Yazar.Ad,
                        YazarSoyad = k.Yazar.Soyad,
                        YayineviId = k.YayineviId,
                        YayineviAd = k.Yayinevi.Ad,
                        KategoriId = k.KategoriId,
                        KategoriAdi = k.Kategori.KategoriAdi,
                        BasimYili = k.BasimYili,
                        SayfaSayisi = k.SayfaSayisi,
                        DilId = k.Diller.DilId,
                        Dil = k.Diller.DilAdi,
                        Stok = k.Stok,
                        Aktif = k.Aktif
                    }).ToList();

                return new SuccessDataResult<List<KitapDto>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<KitapDto>>(e.Message);
            }
        }

        public IDataResult<List<OduncKitapDto>> OduncIcinListeGetir(Expression<Func<Kitap, bool>>? predicate = null)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Kitap>()
                    .Include(k => k.Yazar)
                    .Where(predicate ?? (x => true))
                    .Select(k => new OduncKitapDto
                    {
                        Id = k.KitapId,
                        KitapAdi = k.KitapAdi,
                        ISBN = k.ISBN ?? string.Empty,
                        YazarId = k.YazarId,
                        Yazar = $"{k.Yazar.Ad} {k.Yazar.Soyad}",
                        Stok = k.Stok
                    }).ToList();

                return new SuccessDataResult<List<OduncKitapDto>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<OduncKitapDto>>(e.Message);
            }
        }
    }
}
