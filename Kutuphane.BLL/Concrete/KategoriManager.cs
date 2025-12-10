using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class KategoriManager: IKategoriService
    {
        readonly IKategoriDal _kategoriDal;

        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public IResult AddService(Kategori entity)
        {
            //return new ErrorResult("hatavar baba");
            return _kategoriDal.Add(entity);
        }

        public IDataResult<Kategori> GetByFilterService(Expression<Func<Kategori, bool>>? predicate = null)
        {
            return _kategoriDal.GetByFilter(predicate);
        }

        public IDataResult<List<Kategori>> GetListByFilterService(Expression<Func<Kategori, bool>>? predicate = null)
        {
            return _kategoriDal.GetListByFilter(predicate);
        }

        public IResult UpdateService(Kategori entity)
        {
            return _kategoriDal.Update(entity);
        }
    }
}
