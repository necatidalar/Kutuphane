using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class RolManager : IRolService
    {
        readonly IRolDal _rolDal;

        public RolManager(IRolDal rolDal)
        {
            _rolDal = rolDal;
        }

        private IResult Validate(Rol entity)
        {
            if (entity == null)
                return new ErrorResult("Rol bilgisi boş olamaz.");

            if (string.IsNullOrWhiteSpace(entity.RolAdi))
                return new ErrorResult("Rol adı boş olamaz.");

            if (entity.RolAdi.Length < 2)
                return new ErrorResult("Rol adı en az 2 karakter olmalıdır.");

            if (string.IsNullOrWhiteSpace(entity.RolKodu))
                return new ErrorResult("Rol kodu boş olamaz.");

            var kodVarMi = _rolDal.GetByFilter(x => x.RolKodu == entity.RolKodu);
            if (kodVarMi.Data != null)
                return new ErrorResult("Bu rol kodu zaten mevcut.");

            return new SuccessResult();
        }

        public IResult AddService(Rol entity)
        {
            var validationResult = Validate(entity);
            if (!validationResult.IsSuccess)
                return validationResult;

            var mevcutRol = _rolDal.GetByFilter(x => x.RolAdi == entity.RolAdi);
            if (mevcutRol.Data != null)
                return new ErrorResult("Bu rol adı zaten mevcut.");

            entity.AktifMi = true;

            return _rolDal.Add(entity);
        }

        public IResult UpdateService(Rol entity)
        {
            if (entity.RolId <= 0)
                return new ErrorResult("Geçersiz Rol Id.");

            var validationResult = Validate(entity);
            if (!validationResult.IsSuccess)
                return validationResult;

            var dbRol = _rolDal.GetByFilter(x => x.RolId == entity.RolId);
            if (dbRol.Data == null)
                return new ErrorResult("Güncellenecek rol bulunamadı.");

            var ayniRolBaskaKayit = _rolDal.GetByFilter(
                x => x.RolAdi == entity.RolAdi && x.RolId != entity.RolId);

            if (ayniRolBaskaKayit.Data != null)
                return new ErrorResult("Bu rol adı başka bir kayıt tarafından kullanılıyor.");

            return _rolDal.Update(entity);
        }

        public IDataResult<Rol> GetByFilterService(Expression<Func<Rol, bool>>? predicate = null)
        {
            return _rolDal.GetByFilter(predicate);
        }

        public IDataResult<List<Rol>> GetListByFilterService(Expression<Func<Rol, bool>>? predicate = null)
        {
            return _rolDal.GetListByFilter(predicate);
        }
    }
}
