using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;

namespace Kutuphane.BLL.Concrete
{
    public class V2DinamikAlanManager : IV2DinamikAlanService
    {
        private readonly IStoredProcedureDal _storedProcedureDal;

        public V2DinamikAlanManager(IStoredProcedureDal storedProcedureDal)
        {
            _storedProcedureDal = storedProcedureDal;
        }

        public IDataResult<List<FormAlanAyariDto>> FormAlanlariniGetir(int kurumId, int? uyeTipiId, string formKodu)
        {
            if (kurumId <= 0)
                return new ErrorDataResult<List<FormAlanAyariDto>>("KurumId geçersiz.");

            if (string.IsNullOrWhiteSpace(formKodu))
                return new ErrorDataResult<List<FormAlanAyariDto>>("FormKodu boş olamaz.");

            return _storedProcedureDal.ExecuteStoredProcedure<FormAlanAyariDto>(
                "sp_FormAlanlariniGetir",
                kurumId,
                uyeTipiId.HasValue ? uyeTipiId.Value : (object)DBNull.Value,
                formKodu);
        }

        public IDataResult<List<AlanSecenekDto>> AlanSecenekleriniGetir(int alanTanimId)
        {
            if (alanTanimId <= 0)
                return new ErrorDataResult<List<AlanSecenekDto>>("AlanTanimId geçersiz.");

            return _storedProcedureDal.ExecuteStoredProcedure<AlanSecenekDto>(
                "sp_AlanSecenekleriniGetir",
                alanTanimId);
        }

        public IDataResult<List<EntityEkAlanDegeriDto>> EntityEkAlanDegerleriniGetir(string entityAdi, int entityId)
        {
            if (string.IsNullOrWhiteSpace(entityAdi))
                return new ErrorDataResult<List<EntityEkAlanDegeriDto>>("EntityAdi boş olamaz.");

            if (entityId <= 0)
                return new ErrorDataResult<List<EntityEkAlanDegeriDto>>("EntityId geçersiz.");

            return _storedProcedureDal.ExecuteStoredProcedure<EntityEkAlanDegeriDto>(
                "sp_EntityEkAlanDegerleriniGetir",
                entityAdi,
                entityId);
        }

        public IResult EntityEkAlanDegeriKaydet(
            string entityAdi,
            int entityId,
            int alanTanimId,
            string? degerText = null,
            int? degerNumber = null,
            decimal? degerDecimal = null,
            DateTime? degerDate = null,
            bool? degerBool = null)
        {
            if (string.IsNullOrWhiteSpace(entityAdi))
                return new ErrorResult("EntityAdi boş olamaz.");

            if (entityId <= 0)
                return new ErrorResult("EntityId geçersiz.");

            if (alanTanimId <= 0)
                return new ErrorResult("AlanTanimId geçersiz.");

            return _storedProcedureDal.ExecuteStoredProcedureNoReturn(
                "sp_EntityEkAlanDegeriKaydet",
                entityAdi,
                entityId,
                alanTanimId,
                degerText ?? (object)DBNull.Value,
                degerNumber.HasValue ? degerNumber.Value : (object)DBNull.Value,
                degerDecimal.HasValue ? degerDecimal.Value : (object)DBNull.Value,
                degerDate.HasValue ? degerDate.Value : (object)DBNull.Value,
                degerBool.HasValue ? degerBool.Value : (object)DBNull.Value);
        }


        public IDataResult<List<FormAlanAyariDto>> FormAlanAyarlariniGetir(int kurumId, int? uyeTipiId, string formKodu)
        {
            if (kurumId <= 0)
                return new ErrorDataResult<List<FormAlanAyariDto>>("KurumId geçersiz.");

            if (string.IsNullOrWhiteSpace(formKodu))
                return new ErrorDataResult<List<FormAlanAyariDto>>("FormKodu boş olamaz.");

            return _storedProcedureDal.ExecuteStoredProcedure<FormAlanAyariDto>(
                "sp_FormAlanAyarlariniGetir",
                kurumId,
                uyeTipiId.HasValue ? uyeTipiId.Value : (object)DBNull.Value,
                formKodu);
        }

        public IResult FormAlanAyariKaydet(
            int kurumId,
            int? uyeTipiId,
            string formKodu,
            int alanTanimId,
            bool gorunurMu,
            bool zorunluMu,
            bool degistirilebilirMi,
            bool listedeGorunsunMu,
            int siraNo,
            int? kullaniciId = null)
        {
            if (kurumId <= 0)
                return new ErrorResult("KurumId geçersiz.");

            if (string.IsNullOrWhiteSpace(formKodu))
                return new ErrorResult("FormKodu boş olamaz.");

            if (alanTanimId <= 0)
                return new ErrorResult("AlanTanimId geçersiz.");

            if (siraNo <= 0)
                return new ErrorResult("Sıra numarası 1 veya daha büyük olmalıdır.");

            return _storedProcedureDal.ExecuteStoredProcedureNoReturn(
                "sp_FormAlanAyariKaydet",
                kurumId,
                uyeTipiId.HasValue ? uyeTipiId.Value : (object)DBNull.Value,
                formKodu.Trim(),
                alanTanimId,
                gorunurMu,
                zorunluMu,
                degistirilebilirMi,
                listedeGorunsunMu,
                siraNo,
                kullaniciId.HasValue ? kullaniciId.Value : (object)DBNull.Value);
        }

        public IDataResult<List<FormAlanAyariDto>> FormListeKolonlariniGetir(int kurumId, int? uyeTipiId, string formKodu)
        {
            if (kurumId <= 0)
                return new ErrorDataResult<List<FormAlanAyariDto>>("KurumId geçersiz.");

            if (string.IsNullOrWhiteSpace(formKodu))
                return new ErrorDataResult<List<FormAlanAyariDto>>("FormKodu boş olamaz.");

            return _storedProcedureDal.ExecuteStoredProcedure<FormAlanAyariDto>(
                "sp_FormListeKolonlariniGetir",
                kurumId,
                uyeTipiId.HasValue ? uyeTipiId.Value : (object)DBNull.Value,
                formKodu);
        }
    }
}
