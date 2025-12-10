using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class UyeManager : IUyeService
    {
        readonly IUyeDal _uyeDal;

        public UyeManager(IUyeDal uyeDal)
        {
            _uyeDal = uyeDal;
        }

        public IResult AddService(Uye entity)
        {
            //return new ErrorResult("hatavar baba");
            return _uyeDal.Add(entity);
        }

        public IDataResult<Uye> GetByFilterService(Expression<Func<Uye, bool>>? predicate = null)
        {
            return _uyeDal.GetByFilter(predicate);
        }

        public IDataResult<List<Uye>> GetListByFilterService(Expression<Func<Uye, bool>>? predicate = null)
        {
            return _uyeDal.GetListByFilter(predicate);
        }

        public IResult UpdateService(Uye entity)
        {
            return _uyeDal.Update(entity);
        }
        public IDataResult<List<UyeDto>> UyeListeDetayliGetirServis(Expression<Func<Uye, bool>>? predicate = null)
        {
            return _uyeDal.UyeListeDetayliGetir(predicate);
        }
    }
}