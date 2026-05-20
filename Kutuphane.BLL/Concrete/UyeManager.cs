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
            if (uye == null)
                return new ErrorResult("Öğrenci bilgisi boş olamaz.");

            uye.OkulNo = uye.OkulNo?.Trim();
            uye.Sinif = uye.Sinif?.Trim();
            uye.Sube = uye.Sube?.Trim();
            uye.VeliAdSoyad = uye.VeliAdSoyad?.Trim();
            uye.VeliTelefon = uye.VeliTelefon?.Trim();
            uye.TcPass = string.IsNullOrWhiteSpace(uye.TcPass) ? (uye.OkulNo ?? string.Empty) : uye.TcPass.Trim();

            if (string.IsNullOrWhiteSpace(uye.OkulNo))
                return new ErrorResult("Okul numarası boş bırakılamaz.");

            if (uye.OkulNo.Length < 2 || uye.OkulNo.Length > 20)
                return new ErrorResult("Okul numarası 2-20 karakter aralığında olmalıdır.");

            var okulNoKontrol = _uyeDal.GetListByFilter(x => x.OkulNo == uye.OkulNo && x.UyeId != uye.UyeId);
            if (okulNoKontrol.IsSuccess && okulNoKontrol.Data.Any())
                return new ErrorResult("Bu okul numarası ile kayıtlı başka bir öğrenci var.");

            if (string.IsNullOrWhiteSpace(uye.Ad) || uye.Ad.Trim().Length < 2)
                return new ErrorResult("Ad en az 2 karakter olmalıdır.");

            if (string.IsNullOrWhiteSpace(uye.Soyad))
                return new ErrorResult("Soyad zorunludur.");

            if (string.IsNullOrWhiteSpace(uye.Sinif))
                return new ErrorResult("Sınıf boş bırakılamaz.");

            if (string.IsNullOrWhiteSpace(uye.Sube))
                return new ErrorResult("Şube boş bırakılamaz.");

            if (uye.CinsiyetId <= 0)
                return new ErrorResult("Cinsiyet seçilmelidir.");

            if (uye.DogumTarihi == default || uye.DogumTarihi.Year < 1900 || uye.DogumTarihi > DateTime.Now)
                return new ErrorResult("Doğum tarihi geçersiz.");

            if (string.IsNullOrWhiteSpace(uye.Telefon) || !PhoneRegex.IsMatch(uye.Telefon))
                return new ErrorResult("Telefon formatı hatalı. Örnek: 05XXXXXXXXX");

            if (!string.IsNullOrWhiteSpace(uye.Eposta) && !MailRegex.IsMatch(uye.Eposta))
                return new ErrorResult("E-posta formatı geçersiz.");

            if (string.IsNullOrWhiteSpace(uye.VeliAdSoyad))
                return new ErrorResult("Veli adı soyadı boş bırakılamaz.");

            if (string.IsNullOrWhiteSpace(uye.VeliTelefon) || !PhoneRegex.IsMatch(uye.VeliTelefon))
                return new ErrorResult("Veli telefonu formatı hatalı. Örnek: 05XXXXXXXXX");

            if (string.IsNullOrWhiteSpace(uye.Adres) || uye.Adres.Trim().Length < 5)
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

            entity.AktifMi = true;
            return _uyeDal.Add(entity);
        }

        public IResult UpdateService(Uye entity)
        {
            if (entity == null)
                return new ErrorResult("Öğrenci bilgisi boş olamaz.");

            // Pasife alma işleminde eski kayıtlarda okul alanları eksik olabilir; veri kaybı olmaması için sadece durum güncellenir.
            if (entity.AktifMi == false)
                return _uyeDal.Update(entity);

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
