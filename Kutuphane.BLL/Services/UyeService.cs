using System.Text.RegularExpressions;
using Core.IRepository;
using Kutuphane.Model.Entity;

namespace Kutuphane.BLL.Services
{
    public class UyeService
    {
        private readonly IRepository<Uye> _repository;

        public UyeService(IRepository<Uye> repository)
        {
            _repository = repository;
        }

        public List<Uye> Listele() => _repository.GetAll();

        public List<Uye> GetAll()
        {
            return _repository.GetAll();
        }


        public class ServiceResult
        {
            public bool Basarili { get; set; }
            public string Mesaj { get; set; }
        }

        public Uye GetById(int id)
        {
            return _repository
                .GetByFilter(x => x.UyeID == id)
                .FirstOrDefault();
        }

        public Uye UyeBul(string tcPass)
        {
            return _repository
                .GetByFilter(x => x.TcPass == tcPass)
                .FirstOrDefault();
        }

        private ServiceResult Validate(Uye uye)
        {
            if (string.IsNullOrWhiteSpace(uye.TcPass))
                return new ServiceResult { Basarili = false, Mesaj = "TC/Pass boş bırakılamaz." };

            if (uye.TcPass.Length < 5)
                return new ServiceResult { Basarili = false, Mesaj = "TC/Pass en az 5 karakter olmalıdır." };

            var tcAyniMi = _repository.GetAll()
                .Any(x => x.TcPass == uye.TcPass && x.UyeID != uye.UyeID);

            if (tcAyniMi)
                return new ServiceResult { Basarili = false, Mesaj = "Bu TC/Pass zaten kayıtlı!" };

            if (string.IsNullOrWhiteSpace(uye.Ad))
                return new ServiceResult { Basarili = false, Mesaj = "Ad zorunludur." };

            if (uye.Ad.Length < 2)
                return new ServiceResult { Basarili = false, Mesaj = "Ad en az 2 karakter olmalıdır." };

            if (string.IsNullOrWhiteSpace(uye.Soyad))
                return new ServiceResult { Basarili = false, Mesaj = "Soyad zorunludur." };

            if (string.IsNullOrWhiteSpace(uye.Cinsiyet))
                return new ServiceResult { Basarili = false, Mesaj = "Cinsiyet seçilmelidir." };

            if (uye.Cinsiyet != "Erkek" && uye.Cinsiyet != "Kadın")
                return new ServiceResult { Basarili = false, Mesaj = "Cinsiyet hatalı." };

            if (!uye.DogumYili.HasValue)
                return new ServiceResult { Basarili = false, Mesaj = "Doğum yılı zorunludur." };

            int yil = uye.DogumYili.Value;
            if (yil < 1900 || yil > DateTime.Now.Year)
                return new ServiceResult { Basarili = false, Mesaj = "Doğum yılı geçersiz." };

            if (string.IsNullOrWhiteSpace(uye.Telefon))
                return new ServiceResult { Basarili = false, Mesaj = "Telefon zorunludur." };

            var phoneRegex = new Regex(@"^(\+90|0)?[0-9]{10}$");
            if (!phoneRegex.IsMatch(uye.Telefon))
                return new ServiceResult { Basarili = false, Mesaj = "Telefon formatı hatalı. (Örnek: 05XXXXXXXXX)" };

            if (!string.IsNullOrWhiteSpace(uye.Eposta))
            {
                var mailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (!mailRegex.IsMatch(uye.Eposta))
                    return new ServiceResult { Basarili = false, Mesaj = "E-posta formatı geçersiz." };
            }

            if (string.IsNullOrWhiteSpace(uye.Adres))
                return new ServiceResult { Basarili = false, Mesaj = "Adres boş bırakılamaz." };

            if (uye.Adres.Length < 5)
                return new ServiceResult { Basarili = false, Mesaj = "Adres çok kısa." };


            if (string.IsNullOrWhiteSpace(uye.AdresDetay))
                return new ServiceResult { Basarili = false, Mesaj = "Adres detay boş olamaz." };

            return new ServiceResult { Basarili = true };
        }

        public ServiceResult Ekle(Uye uye)
        {
            var kontrol = Validate(uye);
            if (!kontrol.Basarili)
                return kontrol;

            _repository.Add(uye);
            return new ServiceResult { Basarili = true, Mesaj = "Üye başarıyla eklendi." };
        }

        public ServiceResult Guncelle(Uye uye)
        {
            if (_repository.GetById(uye.UyeID) == null)
                return new ServiceResult { Basarili = false, Mesaj = "Güncellenecek üye bulunamadı." };

            var kontrol = Validate(uye);
            if (!kontrol.Basarili)
                return kontrol;

            _repository.Update(uye);
            return new ServiceResult { Basarili = true, Mesaj = "Üye güncellendi." };
        }

        public ServiceResult Sil(int id)
        {
            var uye = _repository.GetById(id);
            if (uye == null)
                return new ServiceResult { Basarili = false, Mesaj = "Silinecek üye bulunamadı." };

            _repository.Delete(id);
            return new ServiceResult { Basarili = true, Mesaj = "Üye silindi." };
        }
    }
}