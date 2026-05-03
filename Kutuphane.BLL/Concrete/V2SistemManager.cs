using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;

namespace Kutuphane.BLL.Concrete
{
    public class V2SistemManager : IV2SistemService
    {
        private readonly IStoredProcedureDal _storedProcedureDal;

        public V2SistemManager(IStoredProcedureDal storedProcedureDal)
        {
            _storedProcedureDal = storedProcedureDal;
        }

        public IDataResult<List<SistemAyariDto>> SistemAyarlariGetir(int? kurumId = null)
        {
            return _storedProcedureDal.ExecuteStoredProcedure<SistemAyariDto>(
                "sp_SistemAyarlariGetir",
                kurumId.HasValue ? kurumId.Value : (object)DBNull.Value);
        }

        public IDataResult<List<SistemAyariDto>> SistemAyariGetir(int? kurumId, string ayarKodu)
        {
            if (string.IsNullOrWhiteSpace(ayarKodu))
                return new ErrorDataResult<List<SistemAyariDto>>("AyarKodu boş olamaz.");

            return _storedProcedureDal.ExecuteStoredProcedure<SistemAyariDto>(
                "sp_SistemAyariGetir",
                kurumId.HasValue ? kurumId.Value : (object)DBNull.Value,
                ayarKodu);
        }

        public IResult SistemAyariKaydet(
            int? kurumId,
            string ayarKodu,
            string ayarAdi,
            string? ayarDegeri = null,
            string veriTipi = "TEXT",
            string? aciklama = null,
            bool aktifMi = true)
        {
            if (string.IsNullOrWhiteSpace(ayarKodu))
                return new ErrorResult("AyarKodu boş olamaz.");

            if (string.IsNullOrWhiteSpace(ayarAdi))
                return new ErrorResult("AyarAdi boş olamaz.");

            return _storedProcedureDal.ExecuteStoredProcedureNoReturn(
                "sp_SistemAyariKaydet",
                kurumId.HasValue ? kurumId.Value : (object)DBNull.Value,
                ayarKodu,
                ayarAdi,
                ayarDegeri ?? (object)DBNull.Value,
                veriTipi,
                aciklama ?? (object)DBNull.Value,
                aktifMi);
        }

        public IDataResult<List<AuditLogDto>> AuditLoglariniGetir(
            string? tabloAdi = null,
            string? kayitId = null,
            DateTime? baslangicTarihi = null,
            DateTime? bitisTarihi = null,
            int top = 100)
        {
            if (top <= 0)
                top = 100;

            return _storedProcedureDal.ExecuteStoredProcedure<AuditLogDto>(
                "sp_AuditLoglariniGetir",
                tabloAdi ?? (object)DBNull.Value,
                kayitId ?? (object)DBNull.Value,
                baslangicTarihi.HasValue ? baslangicTarihi.Value : (object)DBNull.Value,
                bitisTarihi.HasValue ? bitisTarihi.Value : (object)DBNull.Value,
                top);
        }
    }
}
