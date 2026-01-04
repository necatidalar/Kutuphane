using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Kutuphane.BLL.Concrete
{
    public class YazarManager : IYazarService
    {
        readonly IYazarDal _yazarDal;

        public YazarManager(IYazarDal YazarDal)
        {
            _yazarDal = YazarDal;
        }
        private IResult Validate(Yazar entity, bool isUpdate = false)
        {
            if (entity == null)
                return new ErrorResult("Yazar bilgisi boş.");

            //basta sonda bosluk,cift bosluk engelleme
            entity.Ad = Regex.Replace(entity.Ad?.Trim() ?? "", @"\s+", " ");
            entity.Soyad = Regex.Replace(entity.Soyad?.Trim() ?? "", @"\s+", " ");


            if (string.IsNullOrWhiteSpace(entity.Ad))
                return new ErrorResult("Yazar adı boş olamaz.");

            if (string.IsNullOrWhiteSpace(entity.Soyad))
                return new ErrorResult("Yazar soyadı boş olamaz.");

            if (entity.Ad.Length < 2)
                return new ErrorResult("Yazar adı en az 2 karakter olmalıdır.");

            if (entity.Soyad.Length < 2)
                return new ErrorResult("Yazar soyadı en az 2 karakter olmalıdır.");


            if (!Regex.IsMatch(entity.Ad, @"^[\p{L} ]+$"))
                return new ErrorResult("Yazar adı sadece harf içermelidir.");

            if (!Regex.IsMatch(entity.Soyad, @"^[\p{L} ]+$"))
                return new ErrorResult("Yazar soyadı sadece harf içermelidir.");


            if (entity.OlumTarihi.HasValue && !entity.DogumTarihi.HasValue)
                return new ErrorResult("Ölüm tarihi girilen yazarın doğum tarihi olmalıdır.");

            if (entity.OlumTarihi.HasValue && entity.OlumTarihi > DateTime.Today)
                return new ErrorResult("Ölüm tarihi bugünden büyük olamaz.");

            if (entity.DogumTarihi.HasValue && entity.OlumTarihi.HasValue &&
                entity.OlumTarihi < entity.DogumTarihi)
                return new ErrorResult("Ölüm tarihi doğum tarihinden önce olamaz.");


            var ayniYazarVarMi = _yazarDal.GetByFilter(x =>
                x.AktifMi &&
                x.Ad.ToLower() == entity.Ad.ToLower() &&
                x.Soyad.ToLower() == entity.Soyad.ToLower() &&
                (!isUpdate || x.YazarId != entity.YazarId)
            );

            if (ayniYazarVarMi.Data != null)
                return new ErrorResult("Bu yazar zaten kayıtlı.");

            return new SuccessResult();
        }

        public IResult AddService(Yazar entity)
        {
            var validationResult = Validate(entity);

            if (!validationResult.IsSuccess)
                return validationResult;

            entity.AktifMi = true;

            return _yazarDal.Add(entity);
        }

        public IResult UpdateService(Yazar entity)
        {
            if (entity.YazarId <= 0)
                return new ErrorResult("Geçersiz Yazar Id.");

            var validationResult = Validate(entity, isUpdate: true);

            if (!validationResult.IsSuccess)
                return validationResult;

            var dbYazar = _yazarDal.GetByFilter(x => x.YazarId == entity.YazarId);

            if (dbYazar.Data == null)
                return new ErrorResult("Yazar bulunamadı.");

            return _yazarDal.Update(entity);
        }


        public IDataResult<Yazar> GetByFilterService(Expression<Func<Yazar, bool>>? predicate = null)
        {
            return _yazarDal.GetByFilter(predicate);
        }

        public IDataResult<List<Yazar>> GetListByFilterService(Expression<Func<Yazar, bool>>? predicate = null)
        {
            return _yazarDal.GetListByFilter(predicate);
        }

        public IDataResult<List<YazarDto>> YazarListeGetirServis(Expression<Func<Yazar, bool>>? predicate = null)
        {
            return _yazarDal.YazarListeGetir(predicate);
        }
    }
}