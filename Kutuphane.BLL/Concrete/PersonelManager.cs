using Core.Helpers;
using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.DAL.Concrete;
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

        // ---------------------------------------------
        // PERSONEL EKLEME
        // ---------------------------------------------
        public IResult AddService(Personel entity)
        {
            if (entity == null)
                return new ErrorResult("Personel nesnesi boş olamaz.");

            if (string.IsNullOrWhiteSpace(entity.Ad))
                return new ErrorResult("Ad boş olamaz.");

            if (string.IsNullOrWhiteSpace(entity.Soyad))
                return new ErrorResult("Soyad boş olamaz.");

            if (entity.CinsiyetId <= 0)
                return new ErrorResult("Cinsiyet seçilmelidir.");

            if (string.IsNullOrWhiteSpace(entity.KullaniciAdi))
                return new ErrorResult("Kullanıcı adı boş olamaz.");

            if (entity.KullaniciAdi.Length < 4)
                return new ErrorResult("Kullanıcı adı en az 4 karakter olmalıdır.");

            if (string.IsNullOrWhiteSpace(entity.Sifre))
                return new ErrorResult("Şifre boş olamaz.");

            if (entity.Sifre.Length < 4)
                return new ErrorResult("Şifre en az 4 karakter olmalıdır.");

            var mevcut = _personelDal.GetByFilter(p =>
                p.KullaniciAdi.ToLower() == entity.KullaniciAdi.ToLower() &&
                p.AktifMi == true);

            if (mevcut.Data != null)
                return new ErrorResult("Bu kullanıcı adı zaten kayıtlı.");


            entity.Sifre = SecurityHelper.EncodeBase64(entity.Sifre);

            return _personelDal.Add(entity);
        }

        // ---------------------------------------------
        // PERSONEL GÜNCELLEME
        // ---------------------------------------------
        public IResult UpdateService(Personel entity)
        {
            if (entity == null)
                return new ErrorResult("Personel nesnesi boş olamaz.");

            if (entity.PersonelId <= 0)
                return new ErrorResult("Geçersiz Personel ID.");

            if (string.IsNullOrWhiteSpace(entity.Ad))
                return new ErrorResult("Ad boş olamaz.");

            if (string.IsNullOrWhiteSpace(entity.Soyad))
                return new ErrorResult("Soyad boş olamaz.");

            if (entity.CinsiyetId <= 0)
                return new ErrorResult("Cinsiyet seçilmelidir.");

            if (string.IsNullOrWhiteSpace(entity.KullaniciAdi))
                return new ErrorResult("Kullanıcı adı boş olamaz.");

            if (entity.KullaniciAdi.Length < 4)
                return new ErrorResult("Kullanıcı adı en az 4 karakter olmalıdır.");


            var mevcut = _personelDal.GetByFilter(p =>
                p.KullaniciAdi.ToLower() == entity.KullaniciAdi.ToLower() &&
                p.PersonelId != entity.PersonelId &&
                p.AktifMi == true);

            if (mevcut.Data != null)
                return new ErrorResult("Bu kullanıcı adı başka bir personelde zaten kullanılıyor.");


            if (string.IsNullOrWhiteSpace(entity.Sifre))
            {
                var eski = _personelDal.GetByFilter(x => x.PersonelId == entity.PersonelId);

                if (eski.Data != null)
                    entity.Sifre = eski.Data.Sifre;
            }
            else
            {
                if (entity.Sifre.Length < 4)
                    return new ErrorResult("Şifre en az 4 karakter olmalıdır.");

                entity.Sifre = SecurityHelper.EncodeBase64(entity.Sifre);
            }

            return _personelDal.Update(entity);
        }

        // ---------------------------------------------
        // Giris
        // ---------------------------------------------
        public IResult Login(LoginUserDto kullanici)
        {
            if (string.IsNullOrWhiteSpace(kullanici.KullaniciAdi) || string.IsNullOrWhiteSpace(kullanici.Sifre))
                return new ErrorResult("Kullanıcı adı veya şifre boş olamaz.");

            IFunctionService _functionService = new FunctionManager(new FunctionDal());
            var funcResult = _functionService.ExecuteScalarFunctionService<bool>("fn_LoginKontrol", new object[] { kullanici.KullaniciAdi, kullanici.Sifre });

            if (!funcResult.IsSuccess)
                return new ErrorResult("Kullanıcı kontrolü sırasında bir hata oluştu.");

            if (funcResult.Data == false)
                return new ErrorResult("Kullanıcı adı veya şifre hatalı.");

            return new SuccessResult("Giriş başarılı.");
        }



        public IDataResult<Personel> GetByFilterService(Expression<Func<Personel, bool>>? predicate = null)
        {
            return _personelDal.GetByFilter(predicate);
        }

        public IDataResult<List<Personel>> GetListByFilterService(Expression<Func<Personel, bool>>? predicate = null)
        {
            return _personelDal.GetListByFilter(predicate);
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
