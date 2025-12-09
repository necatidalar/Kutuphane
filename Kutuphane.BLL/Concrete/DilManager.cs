using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class DilManager: IDilService
    {
        readonly IDilDal _dilDal;

        public DilManager(IDilDal dilDal)
        {
            _dilDal = dilDal;
        }

        public IResult AddService(Dil entity)
        {
            //return new ErrorResult("hatavar baba");
            return _dilDal.Add(entity);
        }

        public IDataResult<Dil> GetByFilterService(Expression<Func<Dil, bool>>? predicate = null)
        {
            return _dilDal.GetByFilter(predicate);
        }

        public IDataResult<List<Dil>> GetListByFilterService(Expression<Func<Dil, bool>>? predicate = null)
        {
            return _dilDal.GetListByFilter(predicate);
        }

        public IResult UpdateService(Dil entity)
        {
            return _dilDal.Update(entity);
        }
        public IDataResult<List<Dil>> DilListeDetayliGetirServis(Expression<Func<Dil, bool>>? predicate = null)
        {
            return _dilDal.DilListeDetayliGetir(predicate);
        }
    }
}
