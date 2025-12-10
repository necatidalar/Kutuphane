using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class YazarDal : EfRepositoryBase<Yazar, KutuphaneDbContext>, IYazarDal
    {
        public IDataResult<List<YazarDto>> YazarListeGetir(Expression<Func<Yazar, bool>>? predicate = null)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Yazar>()
                    .Where(predicate ?? (x => true))
                    .Select(x => new YazarDto
                    {
                        YazarId = x.YazarId,
<<<<<<< Updated upstream
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

=======
                        Ad = x.Ad,
                        Soyad = x.Soyad,
                        DogumTarihi = x.DogumTarihi
>>>>>>> Stashed changes
                    }).ToList();
                return new SuccessDataResult<List<YazarDto>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<YazarDto>>(e.Message);
            }
        }
    }
}
