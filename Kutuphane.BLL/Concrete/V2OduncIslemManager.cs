using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;

namespace Kutuphane.BLL.Concrete
{
    public class V2OduncIslemManager : IV2OduncIslemService
    {
        private readonly IStoredProcedureDal _storedProcedureDal;

        public V2OduncIslemManager(IStoredProcedureDal storedProcedureDal)
        {
            _storedProcedureDal = storedProcedureDal;
        }

        public IDataResult<List<OduncKuralDto>> OduncKuraliGetir(int kurumId, int uyeTipiId)
        {
            if (kurumId <= 0)
                return new ErrorDataResult<List<OduncKuralDto>>("KurumId geçersiz.");

            if (uyeTipiId <= 0)
                return new ErrorDataResult<List<OduncKuralDto>>("UyeTipiId geçersiz.");

            return _storedProcedureDal.ExecuteStoredProcedure<OduncKuralDto>(
                "sp_OduncKuraliGetir",
                kurumId,
                uyeTipiId);
        }

        public IDataResult<List<OduncBilgileriDto>> UyeninAktifOduncleriniGetir(int uyeId)
        {
            if (uyeId <= 0)
                return new ErrorDataResult<List<OduncBilgileriDto>>("UyeId geçersiz.");

            return _storedProcedureDal.ExecuteStoredProcedure<OduncBilgileriDto>(
                "sp_UyeninAktifOduncleriniGetir",
                uyeId);
        }

        public IDataResult<List<OduncBilgileriDto>> GecikenOduncleriGetir(int? kurumId = null)
        {
            return _storedProcedureDal.ExecuteStoredProcedure<OduncBilgileriDto>(
                "sp_GecikenOduncleriGetir",
                kurumId.HasValue ? kurumId.Value : (object)DBNull.Value);
        }
        public IDataResult<List<OduncVerSonucDto>> OduncVer(
            int uyeId,
            int kitapId,
            int personelId,
            DateTime? planlananIadeTarihi = null)
        {
            if (uyeId <= 0)
                return new ErrorDataResult<List<OduncVerSonucDto>>("UyeId geçersiz.");

            if (kitapId <= 0)
                return new ErrorDataResult<List<OduncVerSonucDto>>("KitapId geçersiz.");

            if (personelId <= 0)
                return new ErrorDataResult<List<OduncVerSonucDto>>("PersonelId geçersiz.");

            return _storedProcedureDal.ExecuteStoredProcedure<OduncVerSonucDto>(
                "sp_OduncVer",
                uyeId,
                kitapId,
                personelId,
                planlananIadeTarihi.HasValue ? planlananIadeTarihi.Value : (object)DBNull.Value);
        }

        public IDataResult<List<IadeAlSonucDto>> IadeAl(
            int oduncId,
            int personelId,
            string iadeDurum = "IADE_EDILDI",
            string? iadeNotu = null,
            DateTime? gercekIadeTarihi = null,
            bool? stokArtirilsin = null)
        {
            if (oduncId <= 0)
                return new ErrorDataResult<List<IadeAlSonucDto>>("OduncId geçersiz.");

            if (personelId <= 0)
                return new ErrorDataResult<List<IadeAlSonucDto>>("PersonelId geçersiz.");

            if (string.IsNullOrWhiteSpace(iadeDurum))
                iadeDurum = "IADE_EDILDI";

            return _storedProcedureDal.ExecuteStoredProcedure<IadeAlSonucDto>(
                "sp_IadeAl",
                oduncId,
                personelId,
                iadeDurum,
                string.IsNullOrWhiteSpace(iadeNotu) ? (object)DBNull.Value : iadeNotu,
                gercekIadeTarihi.HasValue ? gercekIadeTarihi.Value : (object)DBNull.Value,
                stokArtirilsin.HasValue ? stokArtirilsin.Value : (object)DBNull.Value);
        }

    }
}