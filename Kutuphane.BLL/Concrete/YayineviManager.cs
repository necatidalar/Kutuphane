using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class YayineviManager : IYayineviService
    {
        readonly IYayineviDal _yayineviDal;

        public YayineviManager(IYayineviDal YayineviDal)
        {
            _yayineviDal = YayineviDal;
        }
        private IResult Validate(Yayinevi entity)
        {
            if (entity == null)
                return new ErrorResult("Yayınevi bilgisi boş olamaz.");

            if (string.IsNullOrWhiteSpace(entity.Ad))
                return new ErrorResult("Yayınevi adı boş olamaz.");

            if (entity.Ad.Length < 2)
                return new ErrorResult("Yayınevi adı en az 2 karakter olmalıdır.");

            if (entity.KurulusYili.HasValue)
            {
                if (entity.KurulusYili < 1400 || entity.KurulusYili > DateTime.Now.Year)
                    return new ErrorResult("Kuruluş yılı geçersiz.");
            }

            return new SuccessResult();
        }

        public IResult AddService(Yayinevi entity)
        {
            var validationResult = Validate(entity);
            if (!validationResult.IsSuccess)
                return validationResult;

            var mevcutKayit = _yayineviDal.GetByFilter(
                x => x.Ad == entity.Ad && x.AktifMi);

            if (mevcutKayit.Data != null)
                return new ErrorResult("Bu yayınevi zaten kayıtlı.");

            entity.AktifMi = true;

            return _yayineviDal.Add(entity);
        }

        public IResult UpdateService(Yayinevi entity)
        {
            if (entity == null)
                return new ErrorResult("Yayınevi bilgisi boş olamaz.");

            if (entity.YayineviId <= 0)
                return new ErrorResult("Geçersiz yayınevi Id.");

            var validationResult = Validate(entity);
            if (!validationResult.IsSuccess)
                return validationResult;

            var dbKayit = _yayineviDal.GetByFilter(x => x.YayineviId == entity.YayineviId);
            if (dbKayit.Data == null)
                return new ErrorResult("Güncellenecek yayınevi bulunamadı.");

            var ayniAdBaskaKayit = _yayineviDal.GetByFilter(
                x => x.Ad == entity.Ad &&
                     x.YayineviId != entity.YayineviId &&
                     x.AktifMi);

            if (ayniAdBaskaKayit.Data != null)
                return new ErrorResult("Bu yayınevi adı başka bir kayıt tarafından kullanılıyor.");

            return _yayineviDal.Update(entity);
        }

        public IDataResult<Yayinevi> GetByFilterService(Expression<Func<Yayinevi, bool>>? predicate = null)
        {
            return _yayineviDal.GetByFilter(predicate);
        }
        public IDataResult<List<Yayinevi>> GetListByFilterService(Expression<Func<Yayinevi, bool>>? predicate = null)
        {
            return _yayineviDal.GetListByFilter(predicate);
        }
    }
}
