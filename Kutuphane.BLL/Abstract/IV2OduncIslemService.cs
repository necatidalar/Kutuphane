using Core.Utility.Results;
using Kutuphane.Model.DTO;

namespace Kutuphane.BLL.Abstract
{
    public interface IV2OduncIslemService
    {
        IDataResult<List<OduncKuralDto>> OduncKuraliGetir(int kurumId, int uyeTipiId);

        IDataResult<List<OduncBilgileriDto>> UyeninAktifOduncleriniGetir(int uyeId);

        IDataResult<List<OduncBilgileriDto>> GecikenOduncleriGetir(int? kurumId = null);

        IDataResult<List<OduncVerSonucDto>> OduncVer(
            int uyeId,
            int kitapId,
            int personelId,
            DateTime? planlananIadeTarihi = null);

        IDataResult<List<IadeAlSonucDto>> IadeAl(
            int oduncId,
            int personelId,
            string iadeDurum = "IADE_EDILDI",
            string? iadeNotu = null,
            DateTime? gercekIadeTarihi = null,
            bool? stokArtirilsin = null);
    }
}
