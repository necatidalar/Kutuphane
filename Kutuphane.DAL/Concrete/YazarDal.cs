using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.DAL.Contexes;
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

                        Ad = x.Ad,
                        Soyad = x.Soyad,
                        DogumTarihi = x.DogumTarihi
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
