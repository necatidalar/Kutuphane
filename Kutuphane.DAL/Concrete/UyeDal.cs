using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class UyeDal : EfRepositoryBase<Uye, KutuphaneDbContext>, IUyeDal
    {
        public IDataResult<List<UyeDto>> UyeListeDetayliGetir(Expression<Func<Uye, bool>>? predicate = null)
        {
            try
            {
                //using var db = new KutuphaneDbContext();
                //var dto = db.Set<Uye>()
                //    .Include(x => x.Oduncler)
                //    .Where(predicate ?? (x => true))
                //    .Select(x => new UyeDto
                //    {
                //        TcPass = x.TcPass,
                //        Ad = x.Ad,
                //        Soyad = x.Soyad,
                //        CinsiyetID = x.CinsiyetId ?? 3,
                //        DogumYili = x.DogumTarihi,
                //        Telefon = x.Telefon,
                //        Eposta = x.Eposta,
                //        Adres = x.Adres,
                //        AdresDetay = x.AdresDetay
                //    }).ToList();
                return new SuccessDataResult<List<UyeDto>>(new List<UyeDto>());
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<UyeDto>>(e.Message);
            }
        }
    }
}