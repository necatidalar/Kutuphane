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
                    .Include(x => x.Cinsiyet)
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
                        AdresDetay = x.AdresDetay
                    }).ToList();
                return new SuccessDataResult<List<UyeDto>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<UyeDto>>(e.Message);
            }
        }
    }
}