using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class CinsiyetDal<TContext> : EfRepositoryBase<Cinsiyet, TContext>, ICinsiyetDal
        where TContext : DbContext, new()
    {
        public IDataResult<List<Cinsiyet>> CinsiyetListeDetayliGetir(Expression<Func<Cinsiyet, bool>>? predicate = null)
        {
            try
            {
                using var db = new TContext();
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
