using Core.IRepository;
using Kutuphane.Model.Entity;

namespace Kutuphane.BLL.Services
{
    public class OduncService
    {
        private readonly IRepository<Odunc> _repository;
        private readonly KitapService _kitapService;

        public OduncService(IRepository<Odunc> repository, KitapService kitapService)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _kitapService = kitapService ?? throw new ArgumentNullException(nameof(kitapService));
        }
        public class ServiceResult
        {
            public bool Basarili { get; set; }
            public string Mesaj { get; set; }
        }

        public ServiceResult OduncVer(int uyeId, int kitapId, int personelId, DateTime alisTarihi, DateTime teslimTarihi)
        {
            if (uyeId <= 0 || kitapId <= 0)
                return new ServiceResult { Basarili = false, Mesaj = "Geçersiz ID." };

            if ((teslimTarihi - alisTarihi).TotalDays > 45)
                return new ServiceResult { Basarili = false, Mesaj = "Teslim süresi 45 günden fazla olamaz." };

            var kitap = _kitapService.GetById(kitapId);
            if (kitap == null)
                return new ServiceResult { Basarili = false, Mesaj = "Kitap bulunamadı." };

            if (kitap.Stok <= 0)
                return new ServiceResult { Basarili = false, Mesaj = "Kitap stokta yok." };

            var mevcutAyniUyeOdunc = _repository.GetByFilter(o => o.KitapID == kitapId && o.UyeID == uyeId && o.TeslimEdildi == false)
                                                .FirstOrDefault();
            if (mevcutAyniUyeOdunc != null)
                return new ServiceResult { Basarili = false, Mesaj = "Aynı kitabı aynı kişi birden fazla kez ödünç alamaz." };

            int aktifOduncler = _repository.GetByFilter(o => o.KitapID == kitapId && o.TeslimEdildi == false).Count();

            if (aktifOduncler >= kitap.Stok)
                return new ServiceResult { Basarili = false, Mesaj = "Kitap stokta yok." };

            var stokSonuc = _kitapService.StokAzalt(kitapId);
            if (!stokSonuc.Basarili)
                return new ServiceResult { Basarili = false, Mesaj = stokSonuc.Mesaj };

            var odunc = new Odunc
            {
                UyeID = uyeId,
                KitapID = kitapId,
                PersonelID = personelId,
                AlisTarihi = alisTarihi,
                TeslimTarihi = teslimTarihi,
                TeslimEdildi = false
            };

            _repository.Add(odunc);

            return new ServiceResult { Basarili = true, Mesaj = "Kitap ödünç verildi." };
        }

        public ServiceResult TeslimEt(int oduncId)
        {
            var o = _repository.GetById(oduncId);
            if (o == null)
                return new ServiceResult { Basarili = false, Mesaj = "Kayıt bulunamadı." };

            if (o.TeslimEdildi)
                return new ServiceResult { Basarili = false, Mesaj = "Zaten teslim edilmiş." };

            o.TeslimEdildi = true;
            o.TeslimTarihi = DateTime.Now;

            _repository.Update(o);

            return new ServiceResult { Basarili = true, Mesaj = "Teslim edildi." };
        }
        public Odunc GetById(int id)
        {
            return _repository
                .GetByFilter(x => x.OduncID == id)
                .FirstOrDefault();
        }
        public List<Odunc> GetTeslimEdilmeyenler() =>
            _repository.GetByFilter(x => x.TeslimEdildi == false).ToList();

        public List<Odunc> GetByUye(int uyeId) =>
            _repository.GetByFilter(x => x.UyeID == uyeId).ToList();

        public List<Odunc> GetAll() => _repository.GetAll();
    }
}
