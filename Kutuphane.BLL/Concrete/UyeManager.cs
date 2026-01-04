using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Kutuphane.BLL.Concrete
{
    public class UyeManager : IUyeService
    {
        private readonly IUyeDal _uyeDal;

        private static readonly Regex PhoneRegex = new(@"^(\+90|0)?[0-9]{10}$");
        private static readonly Regex MailRegex = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        public UyeManager(IUyeDal uyeDal)
        {
            _uyeDal = uyeDal;
        }

        private IResult Validate(Uye uye)
        {
            if (string.IsNullOrWhiteSpace(uye.TcPass))
                return new ErrorResult("TC/Pass boş bırakılamaz.");

            if (uye.TcPass.Length < 5)
                return new ErrorResult("TC/Pass en az 5 karakter olmalıdır.");

            var tcVarMi = _uyeDal
                .GetListByFilter(x => x.TcPass == uye.TcPass && x.UyeId != uye.UyeId)
                .Data.Any();

            if (tcVarMi)
                return new ErrorResult("Bu TC/Pass zaten kayıtlı!");

            if (string.IsNullOrWhiteSpace(uye.Ad) || uye.Ad.Length < 2)
                return new ErrorResult("Ad en az 2 karakter olmalıdır.");

            if (string.IsNullOrWhiteSpace(uye.Soyad))
                return new ErrorResult("Soyad zorunludur.");

            if (uye.CinsiyetId <= 0)
                return new ErrorResult("Cinsiyet seçilmelidir.");

            if (uye.DogumTarihi == default ||
                uye.DogumTarihi.Year < 1900 ||
                uye.DogumTarihi > DateTime.Now)
                return new ErrorResult("Doğum tarihi geçersiz.");

            if (string.IsNullOrWhiteSpace(uye.Telefon) ||
                !PhoneRegex.IsMatch(uye.Telefon))
                return new ErrorResult("Telefon formatı hatalı. (05XXXXXXXXX)");

            if (!string.IsNullOrWhiteSpace(uye.Eposta) &&
                !MailRegex.IsMatch(uye.Eposta))
                return new ErrorResult("E-posta formatı geçersiz.");

            if (string.IsNullOrWhiteSpace(uye.Adres) || uye.Adres.Length < 5)
                return new ErrorResult("Adres çok kısa veya boş.");

            if (string.IsNullOrWhiteSpace(uye.AdresDetay))
                return new ErrorResult("Adres detay boş olamaz.");

            return new SuccessResult();
        }
        public IResult AddService(Uye entity)
        {
            var valid = Validate(entity);
            if (!valid.IsSuccess)
                return valid;

            return _uyeDal.Add(entity);
        }
        public IResult UpdateService(Uye entity)
        {
            var valid = Validate(entity);
            if (!valid.IsSuccess)
                return valid;

            return _uyeDal.Update(entity);
        }
        public IDataResult<Uye> GetByFilterService(Expression<Func<Uye, bool>>? predicate = null)
        {
            return _uyeDal.GetByFilter(predicate);
        }
        public IDataResult<List<Uye>> GetListByFilterService(Expression<Func<Uye, bool>>? predicate = null)
        {
            return _uyeDal.GetListByFilter(predicate);
        }
        public IDataResult<List<UyeDto>> UyeListeDetayliGetirServis(Expression<Func<Uye, bool>>? predicate = null)
        {
            return _uyeDal.UyeListeDetayliGetir(predicate);
        }

        public IDataResult<List<OduncUyeDto>> OduncUyeListeDetayliGetirServis(Expression<Func<Uye, bool>>? predicate = null)
        {
            return _uyeDal.OduncUyeListeDetayliGetir(predicate);
        }
    }
}
