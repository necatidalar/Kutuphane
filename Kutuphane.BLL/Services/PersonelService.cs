using Core.Helpers;
using Core.IRepository;
using Kutuphane.Model.Entity;

namespace Kutuphane.BLL.Services
{
    public class PersonelService
    {
        private readonly IRepository<Personel> _repository;

        public PersonelService(IRepository<Personel> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "Repository boş olamaz.");
        }
        public ServiceResult Login(string kullaniciAdi, string sifre, out Personel personel)
        {
            personel = null;

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
                return new ServiceResult { Basarili = false, Mesaj = "Kullanıcı adı ve şifre boş olamaz." };

            string sifreBase64 = SecurityHelper.EncodeBase64(sifre);

            personel = _repository
                .GetAll()
                .FirstOrDefault(p => p.KullaniciAdi == kullaniciAdi && p.Sifre == sifreBase64);

            if (personel == null)
                return new ServiceResult { Basarili = false, Mesaj = "Kullanıcı adı veya şifre hatalı." };

            return new ServiceResult { Basarili = true, Mesaj = string.Empty };
        }


        public class ServiceResult
        {
            public bool Basarili { get; set; }
            public string Mesaj { get; set; }
        }

        public ServiceResult Add(Personel personel)
        {
            try
            {
                if (personel == null)
                    return new ServiceResult { Basarili = false, Mesaj = "Personel nesnesi boş olamaz." };

                if (string.IsNullOrWhiteSpace(personel.AdSoyad))
                    return new ServiceResult { Basarili = false, Mesaj = "Ad veya Soyad boş olamaz." };

                if (string.IsNullOrWhiteSpace(personel.KullaniciAdi))
                    return new ServiceResult { Basarili = false, Mesaj = "Kullanıcı adı boş olamaz." };

                if (personel.KullaniciAdi.Length < 4)
                    return new ServiceResult { Basarili = false, Mesaj = "Kullanıcı adı en az 4 karakter olmalıdır." };

                if (string.IsNullOrWhiteSpace(personel.Sifre))
                    return new ServiceResult { Basarili = false, Mesaj = "Şifre boş olamaz." };

                var mevcut = _repository.GetAll()
                    .FirstOrDefault(p => p.KullaniciAdi.ToLower() == personel.KullaniciAdi.ToLower());

                if (mevcut != null)
                    return new ServiceResult { Basarili = false, Mesaj = "Bu kullanıcı adı zaten kayıtlı." };

                personel.Sifre = SecurityHelper.EncodeBase64(personel.Sifre);

                _repository.Add(personel);

                return new ServiceResult { Basarili = true, Mesaj = "Personel başarıyla eklendi." };
            }
            catch (Exception ex)
            {
                return new ServiceResult { Basarili = false, Mesaj = "Hata: " + ex.Message };
            }
        }

        public ServiceResult Update(Personel personel)
        {
            try
            {
                if (personel == null)
                    return new ServiceResult { Basarili = false, Mesaj = "Personel nesnesi boş olamaz." };

                if (personel.PersonelID <= 0)
                    return new ServiceResult { Basarili = false, Mesaj = "Geçersiz Personel ID." };

                if (string.IsNullOrWhiteSpace(personel.AdSoyad))
                    return new ServiceResult { Basarili = false, Mesaj = "AdSoyad boş olamaz." };

                if (string.IsNullOrWhiteSpace(personel.KullaniciAdi))
                    return new ServiceResult { Basarili = false, Mesaj = "Kullanıcı adı boş olamaz." };

                if (personel.KullaniciAdi.Length < 4)
                    return new ServiceResult { Basarili = false, Mesaj = "Kullanıcı adı en az 4 karakter olmalıdır." };

                var mevcut = _repository.GetAll()
                    .FirstOrDefault(p => p.KullaniciAdi.ToLower() == personel.KullaniciAdi.ToLower()
                                      && p.PersonelID != personel.PersonelID);

                if (mevcut != null)
                    return new ServiceResult { Basarili = false, Mesaj = "Bu kullanıcı adı başka bir personelde zaten kullanılıyor." };

                if (!string.IsNullOrWhiteSpace(personel.Sifre))
                    personel.Sifre = SecurityHelper.EncodeBase64(personel.Sifre);

                _repository.Update(personel);

                return new ServiceResult { Basarili = true, Mesaj = "Personel başarıyla güncellendi." };
            }
            catch (Exception ex)
            {
                return new ServiceResult { Basarili = false, Mesaj = "Hata: " + ex.Message };
            }
        }

        public ServiceResult Delete(int personelId)
        {
            if (personelId <= 0)
                return new ServiceResult { Basarili = false, Mesaj = "Geçersiz Personel ID." };

            var personel = _repository.GetById(personelId);
            if (personel == null)
                return new ServiceResult { Basarili = false, Mesaj = $"ID'si {personelId} olan personel bulunamadı." };

            _repository.Delete(personelId);

            return new ServiceResult { Basarili = true, Mesaj = "Personel başarıyla silindi." };
        }

        public Personel GetById(int personelId)
        {
            if (personelId <= 0) return null;
            return _repository.GetById(personelId);
        }

        public List<Personel> GetAll()
        {
            return _repository.GetAll().ToList();
        }
    }
}