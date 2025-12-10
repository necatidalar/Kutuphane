using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class LoginDto : IDto
    {
        public int PersonelID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
