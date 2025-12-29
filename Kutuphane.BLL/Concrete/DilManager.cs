using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class DilManager : IDilService
    {
        readonly IDilDal _dilDal;

        public DilManager(IDilDal dilDal)
        {
            _dilDal = dilDal;
        }
        private IResult Validate(Dil entity)
        {
            if (entity == null)
                return new ErrorResult("Dil bilgisi boş olamaz.");

            if (string.IsNullOrWhiteSpace(entity.DilAdi))
                return new ErrorResult("Dil adı boş olamaz.");

            if (entity.DilAdi.Length < 2)
                return new ErrorResult("Dil adı en az 2 karakter olmalıdır.");

            if (string.IsNullOrWhiteSpace(entity.DilKodu))
                return new ErrorResult("Dil kodu boş olamaz.");

            if (entity.DilKodu.Length > 10)
                return new ErrorResult("Dil kodu 10 karakterden uzun olamaz.");

            return new SuccessResult();
        }
        public IResult AddService(Dil entity)
        {
            var validationResult = Validate(entity);
            if (!validationResult.IsSuccess)
                return validationResult;

            var mevcutDil = _dilDal.GetByFilter(x => x.DilKodu == entity.DilKodu);
            if (mevcutDil.Data != null)
                return new ErrorResult("Bu dil kodu zaten mevcut.");

            entity.AktifMi = true;

            return _dilDal.Add(entity);
        }
        public IResult UpdateService(Dil entity)
        {
            if (entity.DilId <= 0)
                return new ErrorResult("Geçersiz Dil Id.");

            var validationResult = Validate(entity);
            if (!validationResult.IsSuccess)
                return validationResult;

            var dbDil = _dilDal.GetByFilter(x => x.DilId == entity.DilId);
            if (dbDil.Data == null)
                return new ErrorResult("Güncellenecek dil bulunamadı.");

            var ayniKodBaskaKayit = _dilDal.GetByFilter(
                x => x.DilKodu == entity.DilKodu && x.DilId != entity.DilId);

            if (ayniKodBaskaKayit.Data != null)
                return new ErrorResult("Bu dil kodu başka bir kayıt tarafından kullanılıyor.");

            return _dilDal.Update(entity);
        }
        public IDataResult<Dil> GetByFilterService(Expression<Func<Dil, bool>>? predicate = null)
        {
            return _dilDal.GetByFilter(predicate);
        }
        public IDataResult<List<Dil>> GetListByFilterService(Expression<Func<Dil, bool>>? predicate = null)
        {
            return _dilDal.GetListByFilter(predicate);
        }
    }
}
