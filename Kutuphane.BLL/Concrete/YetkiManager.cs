using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class YetkiManager : IYetkiService
    {
        readonly IYetkiDal _yetkiDal;
        private readonly KutuphaneDbContext _context;

        public YetkiManager(IYetkiDal yetkiDal)
        {
            _yetkiDal = yetkiDal;
        }
        private IResult Validate(Yetki entity)
        {
            if (entity == null)
                return new ErrorResult("Yetki bilgisi boş olamaz.");

            if (string.IsNullOrWhiteSpace(entity.YetkiAdi))
                return new ErrorResult("Yetki adı boş olamaz.");

            if (string.IsNullOrWhiteSpace(entity.YetkiKodu))
                return new ErrorResult("Yetki kodu boş olamaz.");

            return new SuccessResult();
        }
        public IResult AddService(Yetki entity)
        {
            var validationResult = Validate(entity);
            if (!validationResult.IsSuccess)
                return validationResult;

            var varMi = _yetkiDal.GetByFilter(x => x.YetkiKodu == entity.YetkiKodu);
            if (varMi.Data != null)
                return new ErrorResult("Bu yetki kodu zaten mevcut.");

            return _yetkiDal.Add(entity);
        }
        public IResult UpdateService(Yetki entity)
        {
            if (entity.YetkiId <= 0)
                return new ErrorResult("Geçersiz Yetki Id.");

            var validationResult = Validate(entity);
            if (!validationResult.IsSuccess)
                return validationResult;

            var db = _yetkiDal.GetByFilter(x => x.YetkiId == entity.YetkiId);
            if (db.Data == null)
                return new ErrorResult("Yetki bulunamadı.");

            var ayniKod = _yetkiDal.GetByFilter(x => x.YetkiKodu == entity.YetkiKodu && x.YetkiId != entity.YetkiId);
            if (ayniKod.Data != null)
                return new ErrorResult("Bu yetki kodu başka kayıtta kullanılıyor.");

            return _yetkiDal.Update(entity);
        }
        public IDataResult<Yetki> GetByFilterService(Expression<Func<Yetki, bool>>? predicate = null)
        {
            return _yetkiDal.GetByFilter(predicate);
        }
        public IDataResult<List<Yetki>> GetListByFilterService(Expression<Func<Yetki, bool>>? predicate = null)
        {
            return _yetkiDal.GetListByFilter(predicate);
        }
    }
}
