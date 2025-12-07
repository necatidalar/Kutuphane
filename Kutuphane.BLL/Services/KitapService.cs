using Core.IRepository;
using Kutuphane.DAL;
using Kutuphane.Model.Entity;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace Kutuphane.BLL.Services
{
    public class KitapService
    {
        private readonly IRepository<Kitap> _repository;

        public KitapService(IRepository<Kitap> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "Repository boş olamaz.");
        }

        public List<Kitap> Listele()
        {
            using var db = new KutuphaneDbContext();

            return db.Kitaplar
                     .Include(k => k.Yazar)
                     .Include(k => k.Yayinevi)
                     .Include(k => k.Kategori)
                     .ToList();
        }

        public List<Kitap> GetAll()
        {
            return _repository.GetAll();
        }
        public Kitap GetById(int id)
        {
            return _repository.GetById(id);
        }
        public class ServiceResult
        {
            public bool Basarili { get; set; }
            public string Mesaj { get; set; }
        }
        public List<Kitap> Ara(string kelime)
        {
            if (string.IsNullOrWhiteSpace(kelime) || kelime.Length < 3)
                return new List<Kitap>();

            return _repository.GetByFilter(k =>
                   (k.KitapAdi.Contains(kelime)) ||
                   (k.ISBN.Contains(kelime)) ||
                   (k.Yazar != null &&
                    (k.Yazar.Ad + " " + k.Yazar.Soyad).Contains(kelime)) ||
                   (k.Kategori != null && k.Kategori.KategoriAdi.Contains(kelime)) ||
                   (k.Yayinevi != null && k.Yayinevi.Ad.Contains(kelime))
            );
        }

        public ServiceResult Ekle(Kitap kitap)
        {
            if (kitap == null)
                return new ServiceResult { Basarili = false, Mesaj = "Kitap nesnesi boş olamaz." };

            if (string.IsNullOrWhiteSpace(kitap.KitapAdi))
                return new ServiceResult { Basarili = false, Mesaj = "Kitap adı boş olamaz." };

            if (kitap.KitapAdi.Length > 200)
                return new ServiceResult { Basarili = false, Mesaj = "Kitap adı çok uzun olamaz." };

            if (string.IsNullOrWhiteSpace(kitap.ISBN))
                return new ServiceResult { Basarili = false, Mesaj = "ISBN boş olamaz." };

            if (!Regex.IsMatch(kitap.ISBN, @"^\d{10}(\d{3})?$"))
                return new ServiceResult { Basarili = false, Mesaj = "Geçersiz ISBN formatı." };

            //var mevcutKitap = _repository.GetAll().FirstOrDefault(k => k.ISBN == kitap.ISBN);
            var mevcutKitap = _repository.GetByFilter(k => k.ISBN == kitap.ISBN);
            if (mevcutKitap != null)
                return new ServiceResult { Basarili = false, Mesaj = "Bu ISBN ile zaten bir kitap kayıtlı." };

            if (kitap.YazarID <= 0)
                return new ServiceResult { Basarili = false, Mesaj = "Geçersiz Yazar ID." };

            if (kitap.YayineviID <= 0)
                return new ServiceResult { Basarili = false, Mesaj = "Geçersiz Yayınevi ID." };

            _repository.Add(kitap);

            return new ServiceResult { Basarili = true, Mesaj = "Kitap başarıyla eklendi." };
        }
        public ServiceResult Guncelle(Kitap kitap)
        {
            if (kitap == null)
                return new ServiceResult { Basarili = false, Mesaj = "Kitap nesnesi boş olamaz." };

            if (kitap.KitapID <= 0)
                return new ServiceResult { Basarili = false, Mesaj = "Geçersiz kitap ID." };

            var mevcut = _repository.GetById(kitap.KitapID);

            if (mevcut == null)
                return new ServiceResult { Basarili = false, Mesaj = "Kitap bulunamadı." };

            if (!string.IsNullOrWhiteSpace(kitap.ISBN) &&
                !Regex.IsMatch(kitap.ISBN, @"^\d{10}(\d{3})?$"))
                return new ServiceResult { Basarili = false, Mesaj = "Geçersiz ISBN formatı." };

            var isbnKontrol = _repository.GetAll()
                .FirstOrDefault(k => k.ISBN == kitap.ISBN && k.KitapID != kitap.KitapID);

            if (isbnKontrol != null)
                return new ServiceResult { Basarili = false, Mesaj = "Bu ISBN ile zaten başka bir kitap kayıtlı." };

            mevcut.KitapAdi = kitap.KitapAdi;
            mevcut.ISBN = kitap.ISBN;
            mevcut.YazarID = kitap.YazarID;
            mevcut.YayineviID = kitap.YayineviID;
            mevcut.KategoriID = kitap.KategoriID;
            mevcut.BasimYili = kitap.BasimYili;
            mevcut.SayfaSayisi = kitap.SayfaSayisi;
            mevcut.Dil = kitap.Dil;
            mevcut.Stok = kitap.Stok;

            _repository.Update(mevcut);

            return new ServiceResult { Basarili = true, Mesaj = "Kitap başarıyla güncellendi." };
        }

        public ServiceResult Sil(int id)
        {
            if (id <= 0)
                return new ServiceResult { Basarili = false, Mesaj = "Geçersiz kitap ID." };

            var kitap = _repository.GetById(id);
            if (kitap == null)
                return new ServiceResult { Basarili = false, Mesaj = $"ID'si {id} olan kitap bulunamadı." };

            kitap.Aktif = false;

            _repository.Update(kitap);

            return new ServiceResult
            {
                Basarili = true,
                Mesaj = "Kitap silinmedi. Pasif hale getirildi."
            };
        }
        public ServiceResult GeriYukle(int id)
        {
            if (id <= 0)
                return new ServiceResult { Basarili = false, Mesaj = "Geçersiz kitap ID." };

            var kitap = _repository.GetById(id);

            if (kitap == null)
                return new ServiceResult { Basarili = false, Mesaj = "Kitap bulunamadı." };

            if (kitap.Aktif)
                return new ServiceResult { Basarili = false, Mesaj = "Bu kitap zaten aktif." };

            kitap.Aktif = true;
            _repository.Update(kitap);

            return new ServiceResult
            {
                Basarili = true,
                Mesaj = "Kitap başarıyla geri yüklendi."
            };
        }

        public ServiceResult StokAzalt(int kitapId, int miktar = 1)
        {
            var kitap = _repository.GetById(kitapId);
            if (kitap == null)
                return new ServiceResult { Basarili = false, Mesaj = "Kitap bulunamadı." };

            if (kitap.Stok < miktar)
                return new ServiceResult { Basarili = false, Mesaj = "Yeterli stok yok." };

            kitap.Stok -= miktar;
            _repository.Update(kitap);

            return new ServiceResult { Basarili = true, Mesaj = "Stok güncellendi." };
        }
    }
}
