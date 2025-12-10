using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class PersonelManager : IPersonelService
    {
        readonly IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public IResult AddService(Personel entity)
        {
            //return new ErrorResult("hatavar baba");
            return _personelDal.Add(entity);
        }

        public IDataResult<Personel> GetByFilterService(Expression<Func<Personel, bool>>? predicate = null)
        {
            return _personelDal.GetByFilter(predicate);
        }

        public IDataResult<List<Personel>> GetListByFilterService(Expression<Func<Personel, bool>>? predicate = null)
        {
            return _personelDal.GetListByFilter(predicate);
        }

        public IResult UpdateService(Personel entity)
        {
            return _personelDal.Update(entity);
        }

        public IDataResult<List<PersonelBilgileriDto>> PersonelBilgiGetirServis(Expression<Func<Personel, bool>>? predicate = null)
        {
            return _personelDal.PersonelBilgiGetir(predicate);
        }

        public IDataResult<List<PersonelOduncBilgileriDto>> PersonelOduncListeIleGetirServis(Expression<Func<Personel, bool>>? predicate = null)
        {
            return _personelDal.PersonelOduncListeIleGetir(predicate);
        }
    }
}
