using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class CinsiyetManager : ICinsiyetService
    {
        readonly ICinsiyetDal _cinsiyetDal;

        public CinsiyetManager(ICinsiyetDal cinsiyetDal)
        {
            _cinsiyetDal = cinsiyetDal;
        }

        public IResult AddService(Cinsiyet entity)
        {
            //return new ErrorResult("hatavar baba");
            return _cinsiyetDal.Add(entity);
        }

        public IDataResult<Cinsiyet> GetByFilterService(Expression<Func<Cinsiyet, bool>>? predicate = null)
        {
            return _cinsiyetDal.GetByFilter(predicate);
        }

        public IDataResult<List<Cinsiyet>> GetListByFilterService(Expression<Func<Cinsiyet, bool>>? predicate = null)
        {
            return _cinsiyetDal.GetListByFilter(predicate);
        }

        public IResult UpdateService(Cinsiyet entity)
        {
            return _cinsiyetDal.Update(entity);
        }

    }
}
