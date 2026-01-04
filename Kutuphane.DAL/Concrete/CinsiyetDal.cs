using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class CinsiyetDal : EfRepositoryBase<Cinsiyet, KutuphaneDbContext>, ICinsiyetDal
    {
        public IDataResult<List<Cinsiyet>> CinsiyetListeDetayliGetir(Expression<Func<Cinsiyet, bool>>? predicate = null)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Cinsiyet>()
                    .Select(x => new Cinsiyet
                    {
                        Id = x.Id,
                        CinsiyetAdi = x.CinsiyetAdi,
                        Personeller = x.Personeller

                    }).ToList();
                return new SuccessDataResult<List<Cinsiyet>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<Cinsiyet>>(e.Message);
            }
        }
    }
}
