using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class KitapManager : IKitapService
    {
        readonly IKitapDal _kitapDal;

        public KitapManager(IKitapDal kitapDal)
        {
            _kitapDal = kitapDal;
        }
        private IResult Validate(Kitap entity, bool isUpdate = false)
        {
            if (entity == null)
                return new ErrorResult("Kitap bilgisi boş.");

            if (string.IsNullOrWhiteSpace(entity.KitapAdi))
                return new ErrorResult("Kitap adı boş olamaz.");

            if (entity.KitapAdi.Length < 2)
                return new ErrorResult("Kitap adı en az 2 karakter olmalı.");

            if (!string.IsNullOrWhiteSpace(entity.ISBN))
            {
                if (entity.ISBN.Length < 10 || entity.ISBN.Length > 13)
                    return new ErrorResult("ISBN 10 veya 13 haneli olmalıdır.");
            }

            if (entity.YazarId <= 0)
                return new ErrorResult("Yazar seçilmelidir.");

            if (entity.KategoriId <= 0)
                return new ErrorResult("Kategori seçilmelidir.");

            if (entity.YayineviId <= 0)
                return new ErrorResult("Yayınevi seçilmelidir.");

            if (entity.DilId <= 0)
                return new ErrorResult("Dil seçilmelidir.");

            if (entity.BasimYili.HasValue)
            {
                if (entity.BasimYili < 1450 || entity.BasimYili > DateTime.Now.Year)
                    return new ErrorResult("Basım yılı geçersiz.");
            }

            if (entity.SayfaSayisi.HasValue && entity.SayfaSayisi <= 0)
                return new ErrorResult("Sayfa sayısı 0'dan büyük olmalıdır.");

            if (entity.Stok < 0)
                return new ErrorResult("Stok miktarı negatif olamaz.");

            if (!isUpdate && !string.IsNullOrWhiteSpace(entity.ISBN))
            {
                var kontrol = _kitapDal.GetByFilter(x => x.ISBN == entity.ISBN);
                if (kontrol.IsSuccess && kontrol.Data != null)
                    return new ErrorResult("Bu ISBN ile kayıtlı kitap zaten var.");
            }

            return new SuccessResult();
        }

        public IResult AddService(Kitap entity)
        {
            var validation = Validate(entity);
            if (!validation.IsSuccess)
                return validation;

            entity.Aktif = true;
            return _kitapDal.Add(entity);
        }

        public IResult UpdateService(Kitap entity)
        {
            if (entity.KitapId <= 0)
                return new ErrorResult("Geçersiz kitap seçimi.");

            if (!string.IsNullOrWhiteSpace(entity.ISBN))
            {
                var kontrol = _kitapDal.GetByFilter(x => x.ISBN == entity.ISBN && x.KitapId != entity.KitapId);
                if (kontrol.IsSuccess && kontrol.Data != null)
                    return new ErrorResult("Bu ISBN ile kayıtlı başka bir kitap zaten var.");
            }
            var validation = Validate(entity, isUpdate: true);
            if (!validation.IsSuccess)
                return validation;

            return _kitapDal.Update(entity);
        }

        public IDataResult<Kitap> GetByFilterService(Expression<Func<Kitap, bool>>? predicate = null)
        {
            return _kitapDal.GetByFilter(predicate);
        }

        public IDataResult<List<Kitap>> GetListByFilterService(Expression<Func<Kitap, bool>>? predicate = null)
        {
            return _kitapDal.GetListByFilter(predicate);
        }

        public IDataResult<List<KitapDto>> KitapListeDetayliGetirServis(Expression<Func<Kitap, bool>>? predicate = null)
        {
            return _kitapDal.KitapListeDetayliGetir(predicate);
        }

        public IDataResult<List<OduncKitapDto>> OduncIcinListeGetir(Expression<Func<Kitap, bool>>? predicate = null)
        {
            return _kitapDal.OduncIcinListeGetir(predicate);
        }
    }
}
