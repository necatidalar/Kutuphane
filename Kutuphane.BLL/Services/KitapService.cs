using Core.IRepository;
using Kutuphane.Model.Entity;

namespace Kutuphane.BLL.Services
{
    public class KitapService
    {
        private readonly IRepository<Kitap> _repository;

        public KitapService(IRepository<Kitap> repository)
        {
            _repository = repository;
        }

        public List<Kitap> Listele()
        {
            return _repository.GetAll();
        }

        public Kitap Getir(int id)
        {
            return _repository.GetById(id);
        }

        public void Ekle(Kitap kitap)
        {
            if (string.IsNullOrWhiteSpace(kitap.KitapAdi))
                throw new Exception("Kitap adı boş olamaz.");

            if (string.IsNullOrWhiteSpace(kitap.ISBN))
                throw new Exception("ISBN boş olamaz.");

            _repository.Add(kitap);
        }

        public void Guncelle(Kitap kitap)
        {
            if (kitap.KitapID <= 0)
                throw new Exception("Geçersiz kitap ID.");

            if (string.IsNullOrWhiteSpace(kitap.KitapAdi))
                throw new Exception("Kitap adı boş olamaz.");

            _repository.Update(kitap);
        }

        public void Sil(int id)
        {
            if (id <= 0)
                throw new Exception("Geçersiz ID.");

            _repository.Delete(id);
        }
    }
}
