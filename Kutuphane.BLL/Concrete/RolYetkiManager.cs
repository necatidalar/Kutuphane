using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class RolYetkiManager : IRolYetkiService
    {
        readonly IRolYetkiDal _rolYetkiDal;

        public RolYetkiManager(IRolYetkiDal rolYetkiDal)
        {
            _rolYetkiDal = rolYetkiDal;
        }

        private IResult Validate(RolYetki entity)
        {
            if (entity == null)
                return new ErrorResult("Rol yetki bilgisi boş olamaz.");

            if (entity.RolId <= 0)
                return new ErrorResult("Rol seçimi zorunludur.");

            if (entity.YetkiId <= 0)
                return new ErrorResult("Yetki seçimi zorunludur.");

            return new SuccessResult();
        }
        public IResult AddService(RolYetki entity)
        {
            var validation = Validate(entity);
            if (!validation.IsSuccess)
                return validation;

            var mevcut = _rolYetkiDal.GetByFilter(
                x => x.RolId == entity.RolId && x.YetkiId == entity.YetkiId);

            if (mevcut.Data != null)
                return new ErrorResult("Bu yetki zaten bu role tanımlıdır.");

            return _rolYetkiDal.Add(entity);
        }
        public IResult DeleteService(RolYetki entity)
        {
            var dbKayit = _rolYetkiDal.GetByFilter(x => x.RolYetkiId == entity.RolYetkiId);
            if (dbKayit.Data == null)
                return new ErrorResult("Silinecek kayıt bulunamadı.");

            return _rolYetkiDal.Delete(dbKayit.Data);
        }
        public IDataResult<RolYetki> GetByFilterService(Expression<Func<RolYetki, bool>>? predicate = null)
        {
            return _rolYetkiDal.GetByFilter(predicate);
        }
        public IDataResult<List<RolYetki>> GetListByFilterService(Expression<Func<RolYetki, bool>>? predicate = null)
        {
            return _rolYetkiDal.GetListByFilter(predicate);
        }
    }
}