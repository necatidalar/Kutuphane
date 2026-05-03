using Core.Utility.Results;
using Kutuphane.Model.DTO;

namespace Kutuphane.BLL.Abstract
{
    public interface IV2SistemService
    {
        IDataResult<List<SistemAyariDto>> SistemAyarlariGetir(int? kurumId = null);

        IDataResult<List<SistemAyariDto>> SistemAyariGetir(int? kurumId, string ayarKodu);

        IResult SistemAyariKaydet(
            int? kurumId,
            string ayarKodu,
            string ayarAdi,
            string? ayarDegeri = null,
            string veriTipi = "TEXT",
            string? aciklama = null,
            bool aktifMi = true);

        IDataResult<List<AuditLogDto>> AuditLoglariniGetir(
            string? tabloAdi = null,
            string? kayitId = null,
            DateTime? baslangicTarihi = null,
            DateTime? bitisTarihi = null,
            int top = 100);
    }
}
