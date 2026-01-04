using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class LoginUserDto : IDto
    {
        public int PersonelId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
