using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class PersonelDal : EfRepositoryBase<Personel, KutuphaneDbContext>, IPersonelDal
    {
        public IDataResult<List<Personel>> PersonelListeDetayliGetir(Expression<Func<Personel, bool>>? predicate = null)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Personel>()
                    .Include(p => p.Cinsiyet)
                    .Where(predicate ?? (x => true))
                    .Select(x => new Personel
                    {
                        PersonelId = x.PersonelId,
                        Ad = x.Ad,
                        Soyad = x.Soyad,
                        CinsiyetId = x.CinsiyetId,
                        KullaniciAdi = x.KullaniciAdi,
                        Sifre = x.Sifre,
                        Cinsiyet = x.Cinsiyet

                    }).ToList();
                return new SuccessDataResult<List<Personel>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<Personel>>(e.Message);
            }
        }
    }
}
