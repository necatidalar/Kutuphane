using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class YayineviDal : EfRepositoryBase<Yayinevi, KutuphaneDbContext>, IYayineviDal
    {
        public IDataResult<List<Yayinevi>> YayineviListeDetayliGetir(Expression<Func<Yayinevi, bool>>? predicate = null)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Yayinevi>()
                    .Include(c => c.YayineviKitaplari)
                    .Where(predicate ?? (x => true))
                    .Select(x => new Yayinevi
                    {
                        YayineviId = x.YayineviId,
                        Ad = x.Ad,
                        KurulusYili = x.KurulusYili,
                        YayineviKitaplari = x.YayineviKitaplari
                    }).ToList();
                return new SuccessDataResult<List<Yayinevi>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<Yayinevi>>(e.Message);
            }
        }
    }
}
