using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class KitapDal : EfRepositoryBase<Kitap, KutuphaneDbContext>, IKitapDal
    {

        public IDataResult<List<KitapDto>> KitapListeDetayliGetir(Expression<Func<Kitap, bool>>? predicate = null)
        {
            return new SuccessDataResult<List<KitapDto>>(new List<KitapDto>());
            //try
            //{
            //    using var db = new KutuphaneDbContext();
            //    var dto = db.Set<Kitap>()
            //        //.Include(k => k.Yazar)
            //        //.Include(k => k.Yayinevi)
            //        //.Include(k => k.Kategori)
            //        .Where(predicate ?? (x => true))
            //        .Select(k => new KitapDto
            //        {
            //            KitapID = k.KitapId,
            //            KitapAdi = k.KitapAdi,
            //            ISBN = k.ISBN,
            //            YazarID = k.YazarId,
            //            YazarAd = k.Yazar.Ad,
            //            YazarSoyad = k.Yazar.Soyad,
            //            YayineviID = k.YayineviId,
            //            YayineviAd = k.Yayinevi.Ad,
            //            KategoriID = k.KategoriId,
            //            KategoriAdi = k.Kategori.KategoriAdi,
            //            BasimYili = k.BasimYili,
            //            SayfaSayisi = k.SayfaSayisi,
            //            Dil = k.DilId,
            //            Stok = k.Stok,
            //            Aktif = k.Aktif
            //        }).ToList();
            //    return new SuccessDataResult<List<KitapDto>>(dto);
            //}
            //catch (Exception e)
            //{
            //    return new ErrorDataResult<List<KitapDto>>(e.Message);
            //}            

        }
    }
}