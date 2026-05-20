using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class OduncManager : IOduncService
    {
        private readonly IOduncDal _oduncDal;

        public OduncManager(IOduncDal oduncDal)
        {
            _oduncDal = oduncDal;
        }

        private IResult Validate(Odunc odunc)
        {
            if (odunc == null)
                return new ErrorResult("Ödünç bilgisi boş olamaz.");

            if (odunc.UyeId <= 0)
                return new ErrorResult("Öğrenci seçilmelidir.");

            if (odunc.KitapId <= 0)
                return new ErrorResult("Kitap seçilmelidir.");

            if (odunc.TeslimEdenPersonelId <= 0)
                return new ErrorResult("Teslim eden personel bilgisi eksiktir.");

            if (odunc.AlisTarihi == default || odunc.AlisTarihi > DateTime.Now.AddMinutes(1))
                return new ErrorResult("Alış tarihi geçersizdir.");

            if (odunc.TeslimTarihi.HasValue && odunc.TeslimTarihi < odunc.AlisTarihi.Date)
                return new ErrorResult("Teslim tarihi alış tarihinden önce olamaz.");

            if (odunc.TeslimEdildi && !odunc.TeslimTarihi.HasValue)
                return new ErrorResult("Teslim edildi işaretlenmiş ama teslim tarihi girilmemiştir.");

            if (odunc.TeslimEdildi && odunc.TeslimAlanPersonelId <= 0)
                return new ErrorResult("Teslim alan personel bilgisi eksiktir.");

            return new SuccessResult();
        }

        public IResult AddService(Odunc entity)
        {
            var validationResult = Validate(entity);
            if (!validationResult.IsSuccess)
                return validationResult;

            var aktifKayitVarMi = _oduncDal.GetListByFilter(x =>
                x.UyeId == entity.UyeId &&
                x.KitapId == entity.KitapId &&
                x.TeslimEdildi == false).Data.Any();

            if (aktifKayitVarMi)
                return new ErrorResult("Bu kitap aynı öğrenci üzerinde zaten ödünçte görünüyor.");

            return _oduncDal.Add(entity);
        }

        public IResult UpdateService(Odunc entity)
        {
            if (entity == null)
                return new ErrorResult("Ödünç bilgisi boş olamaz.");

            if (entity.OduncId <= 0)
                return new ErrorResult("Geçersiz ödünç seçimi.");

            var validationResult = Validate(entity);
            if (!validationResult.IsSuccess)
                return validationResult;

            var dbOdunc = _oduncDal.GetByFilter(x => x.OduncId == entity.OduncId);
            if (!dbOdunc.IsSuccess || dbOdunc.Data == null)
                return new ErrorResult("Güncellenecek ödünç kaydı bulunamadı.");

            return _oduncDal.Update(entity);
        }

        public IDataResult<Odunc> GetByFilterService(Expression<Func<Odunc, bool>>? predicate = null)
        {
            return _oduncDal.GetByFilter(predicate);
        }

        public IDataResult<List<Odunc>> GetListByFilterService(Expression<Func<Odunc, bool>>? predicate = null)
        {
            return _oduncDal.GetListByFilter(predicate);
        }

        public IDataResult<List<OduncBilgileriDto>> OduncBilgileriGetirServis(Expression<Func<Odunc, bool>>? predicate = null)
        {
            return _oduncDal.OduncBilgileriGetir(predicate);
        }
    }
}
