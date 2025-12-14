using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class KategoriManager: IKategoriService
    {
        readonly IKategoriDal _kategoriDal;

        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }
        private IResult Validate(Kategori kategori)
        {
            if (kategori == null)
                return new ErrorResult("Kategori bilgisi boş olamaz.");


            if (string.IsNullOrWhiteSpace(kategori.KategoriAdi))
                return new ErrorResult("Kategori adı boş olamaz.");


            string ad = kategori.KategoriAdi.Trim();


            if (ad.Length < 2)
                return new ErrorResult("Kategori adı en az 2 karakter olmalıdır.");

            if (ad.Length > 50)
                return new ErrorResult("Kategori adı 50 karakterden uzun olamaz.");

            return new SuccessResult();
        }

        public IResult AddService(Kategori entity)
        {
            var validate = Validate(entity);
            if (!validate.IsSuccess)
                return validate;


            var existing = _kategoriDal.GetByFilter(x =>
                x.KategoriAdi.ToLower().Trim() == entity.KategoriAdi.ToLower().Trim()
                && x.AktifMi == true
            );

            if (existing.IsSuccess && existing.Data != null)
                return new ErrorResult("Bu kategori zaten kayıtlı.");

            entity.AktifMi = true;

            return _kategoriDal.Add(entity);
        }

        public IResult UpdateService(Kategori entity)
        {
            if (entity.KategoriId <= 0)
                return new ErrorResult("Kategori Id geçersiz.");

            var validate = Validate(entity);
            if (!validate.IsSuccess)
                return validate;

            var existing = _kategoriDal.GetByFilter(x =>
                x.KategoriId != entity.KategoriId &&
                x.KategoriAdi.ToLower().Trim() == entity.KategoriAdi.ToLower().Trim()
                && x.AktifMi == true
            );

            if (existing.IsSuccess && existing.Data != null)
                return new ErrorResult("Aynı isimde başka bir kategori zaten mevcut.");

            return _kategoriDal.Update(entity);
        }

        public IDataResult<Kategori> GetByFilterService(Expression<Func<Kategori, bool>>? predicate = null)
        {
            return _kategoriDal.GetByFilter(predicate);
        }

        public IDataResult<List<Kategori>> GetListByFilterService(Expression<Func<Kategori, bool>>? predicate = null)
        {
            return _kategoriDal.GetListByFilter(predicate);
        }
    }
}
