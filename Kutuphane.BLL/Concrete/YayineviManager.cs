using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class YayineviManager: IYayineviService
    {
        readonly IYayineviDal _yayineviDal;

        public YayineviManager(IYayineviDal YayineviDal)
        {
            _yayineviDal = YayineviDal;
        }

        public IResult AddService(Yayinevi entity)
        {
            //return new ErrorResult("hatavar baba");
            return _yayineviDal.Add(entity);
        }

        public IDataResult<Yayinevi> GetByFilterService(Expression<Func<Yayinevi, bool>>? predicate = null)
        {
            return _yayineviDal.GetByFilter(predicate);
        }

        public IDataResult<List<Yayinevi>> GetListByFilterService(Expression<Func<Yayinevi, bool>>? predicate = null)
        {
            return _yayineviDal.GetListByFilter(predicate);
        }

        public IResult UpdateService(Yayinevi entity)
        {
            return _yayineviDal.Update(entity);
        }
    }
}
