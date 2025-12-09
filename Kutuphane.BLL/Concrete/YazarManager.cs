using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class YazarManager : IYazarService
    {
        readonly IYazarDal _yazarDal;

        public YazarManager(IYazarDal YazarDal)
        {
            _yazarDal = YazarDal;
        }

        public IResult AddService(Yazar entity)
        {
            //return new ErrorResult("hatavar baba");
            return _yazarDal.Add(entity);
        }

        public IDataResult<Yazar> GetByFilterService(Expression<Func<Yazar, bool>>? predicate = null)
        {
            return _yazarDal.GetByFilter(predicate);
        }

        public IDataResult<List<Yazar>> GetListByFilterService(Expression<Func<Yazar, bool>>? predicate = null)
        {
            return _yazarDal.GetListByFilter(predicate);
        }

        public IResult UpdateService(Yazar entity)
        {
            return _yazarDal.Update(entity);
        }
        public IDataResult<List<Yazar>> YazarListeDetayliGetirServis(Expression<Func<Yazar, bool>>? predicate = null)
        {
            return _yazarDal.YazarListeDetayliGetir(predicate);
        }
    }
}
