

using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class PersonelBilgileriDto : IDto
    {
        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public byte CinsiyetId { get; set; }
        public string CinsiyetAdi { get; set; }
        public bool AktifMi { get; set; }
    }
}
