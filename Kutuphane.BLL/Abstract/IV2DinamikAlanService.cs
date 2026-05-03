using Core.Utility.Results;
using Kutuphane.Model.DTO;

namespace Kutuphane.BLL.Abstract
{
    public interface IV2DinamikAlanService
    {
        IDataResult<List<FormAlanAyariDto>> FormAlanlariniGetir(int kurumId, int? uyeTipiId, string formKodu);

        IDataResult<List<AlanSecenekDto>> AlanSecenekleriniGetir(int alanTanimId);

        IDataResult<List<EntityEkAlanDegeriDto>> EntityEkAlanDegerleriniGetir(string entityAdi, int entityId);

        IResult EntityEkAlanDegeriKaydet(
            string entityAdi,
            int entityId,
            int alanTanimId,
            string? degerText = null,
            int? degerNumber = null,
            decimal? degerDecimal = null,
            DateTime? degerDate = null,
            bool? degerBool = null);


        IDataResult<List<FormAlanAyariDto>> FormAlanAyarlariniGetir(int kurumId, int? uyeTipiId, string formKodu);

        IResult FormAlanAyariKaydet(
            int kurumId,
            int? uyeTipiId,
            string formKodu,
            int alanTanimId,
            bool gorunurMu,
            bool zorunluMu,
            bool degistirilebilirMi,
            bool listedeGorunsunMu,
            int siraNo,
            int? kullaniciId = null);

        IDataResult<List<FormAlanAyariDto>> FormListeKolonlariniGetir(int kurumId, int? uyeTipiId, string formKodu);
    }
}
