using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class PersonelRolManager : IPersonelRolService
    {
        readonly IPersonelRolDal _dalPersonelRolDal;
        public PersonelRolManager(IPersonelRolDal dalPersonelRolDal)
        {
            _dalPersonelRolDal = dalPersonelRolDal;
        }
        public IResult AddService(PersonelRol entity)
        {
            throw new NotImplementedException();
        }
        public IResult UpdateService(PersonelRol entity)
        {
            throw new NotImplementedException();
        }
        public IDataResult<PersonelRol> GetByFilterService(Expression<Func<PersonelRol, bool>>? predicate = null)
        {
            return _dalPersonelRolDal.GetByFilter(predicate);
        }
        public IDataResult<List<PersonelRol>> GetListByFilterService(Expression<Func<PersonelRol, bool>>? predicate = null)
        {
            return _dalPersonelRolDal.GetListByFilter(predicate);
        }
    }
}
