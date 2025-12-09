using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class CinsiyetDal : EfRepositoryBase<Cinsiyet, KutuphaneDbContext>, ICinsiyetDal
    {
        public IDataResult<List<CinsiyetDto>> CinsiyetListeDetayliGetir(Expression<Func<Cinsiyet, bool>>? predicate = null)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Cinsiyet>()
                    .Where(predicate ?? (x => true))
                    .Select(k => new CinsiyetDto
                    {
                        CinsiyetID = k.Id,
                        CinsiyetAdi = k.CinsiyetAdi
                    }).ToList();
                return new SuccessDataResult<List<CinsiyetDto>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<CinsiyetDto>>(e.Message);
            }
        }
    }
}
