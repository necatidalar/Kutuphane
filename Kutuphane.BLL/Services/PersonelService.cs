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
            _repository = repository;
        }

        public Personel Login(string kullaniciAdi, string sifre)
        {
            string sifreBase64 = SecurityHelper.EncodeBase64(sifre);

            return _repository
                   .GetAll()
                   .FirstOrDefault(p => p.KullaniciAdi == kullaniciAdi && p.Sifre == sifreBase64);
        }

        public void Add(Personel personel)
        {
            personel.Sifre = SecurityHelper.EncodeBase64(personel.Sifre);

            _repository.Add(personel);
        }
    }
}
