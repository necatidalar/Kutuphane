using System;
using System.Linq;
using System.Text;
using Kutuphane.DAL.Contexes;

namespace Kutuphane.UI.Helpers
{
    public static class V2SmokeTest
    {
        public static string Run()
        {
            var sb = new StringBuilder();

            try
            {
                using var db = new KutuphaneDbContext();

                var kurum = db.Kurumlar.FirstOrDefault(x => x.KurumKodu == "VARSAYILAN");
                var ogrenciTipi = db.UyeTipleri.FirstOrDefault(x => x.UyeTipiKodu == "OGRENCI");

                if (kurum == null)
                    return "HATA: Varsayılan kurum bulunamadı.";

                if (ogrenciTipi == null)
                    return "HATA: Öğrenci üye tipi bulunamadı.";

                sb.AppendLine("DB bağlantısı başarılı.");
                sb.AppendLine($"Kurum: {kurum.KurumAdi}");
                sb.AppendLine($"Üye Tipi: {ogrenciTipi.UyeTipiAdi}");

                var dinamikAlanService = V2ServiceFactory.DinamikAlanService();

                var alanSonuc = dinamikAlanService.FormAlanlariniGetir(
                    kurum.KurumId,
                    ogrenciTipi.UyeTipiId,
                    "UYE_FORM"
                );

                if (!alanSonuc.IsSuccess)
                {
                    sb.AppendLine("Dinamik alan servisi hata verdi:");
                    sb.AppendLine(alanSonuc.Message);
                    return sb.ToString();
                }

                sb.AppendLine($"Dinamik alan sayısı: {alanSonuc.Data?.Count ?? 0}");

                foreach (var alan in alanSonuc.Data ?? Enumerable.Empty<Kutuphane.Model.DTO.FormAlanAyariDto>())
                {
                    sb.AppendLine($"- {alan.AlanKodu} / {alan.AlanAdi} / Zorunlu: {alan.ZorunluMu}");
                }

                sb.AppendLine();
                sb.AppendLine("V2 servis testi başarılı.");

                return sb.ToString();
            }
            catch (Exception ex)
            {
                return "V2 servis testi hata verdi:\n" + ex.Message;
            }
        }
    }
}
