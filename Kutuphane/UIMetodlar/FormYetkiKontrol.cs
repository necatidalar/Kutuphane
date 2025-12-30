namespace Kutuphane.UI.UIMetodlar
{
    public class FormYetkiKontrol
    {
        public static bool YetkiKontrol(string kullaniciYetki, string gerekliYetki)
        {
            return kullaniciYetki.Contains(gerekliYetki);
        }
    }
}
