using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class YazarDal : EfRepositoryBase<Yazar, KutuphaneDbContext>, IYazarDal
    {
        public IDataResult<List<Yazar>> YazarListeDetayliGetir(Expression<Func<Yazar, bool>>? predicate = null)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Yazar>()
                    .Include(y => y.YazarKitaplari)
                        .ThenInclude(yk => yk.Kitap)
                    .Where(predicate ?? (x => true))
                    .Select(x => new Yazar
                    {
                        YazarId = x.YazarId,
                        AdSoyad = x.AdSoyad,
                        DogumTarihi = x.DogumTarihi,
                        AktifMi = x.AktifMi,
                        YazarKitaplari = x.YazarKitaplari
                            .Select(yk => new YazarKitap
                            {
                                Id = yk.Id,
                                KitapId = yk.KitapId,
                                YazarId = yk.YazarId,
                                Kitap = new Kitap
                                {
                                    KitapId = yk.Kitap.KitapId,
                                    KitapAdi = yk.Kitap.KitapAdi,
                                    YayineviId = yk.Kitap.YayineviId,
                                    KategoriId = yk.Kitap.KategoriId,
                                    DilId = yk.Kitap.DilId,
                                    BasimYili = yk.Kitap.BasimYili,
                                    SayfaSayisi = yk.Kitap.SayfaSayisi,
                                    ISBN = yk.Kitap.ISBN
                                }

                            }).ToList()

                    }).ToList();
                return new SuccessDataResult<List<Yazar>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<Yazar>>(e.Message);
            }
        }
    }
}
