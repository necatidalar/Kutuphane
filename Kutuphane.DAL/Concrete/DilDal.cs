using Core.Utility.Results;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class DilDal
    {
        public IDataResult<List<Dil>> DilListeDetayliGetir(Expression<Func<Dil, bool>>? predicate = null)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Dil>()
                    .Where(predicate ?? (x => true))
                    .Select(x => new Dil
                    {
                        DilId = x.DilId,
                        DilAdi = x.DilAdi,
                        DilKodu = x.DilKodu
                    }).ToList();
                return new SuccessDataResult<List<Dil>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<Dil>>(e.Message);
            }
        }
    }
}
