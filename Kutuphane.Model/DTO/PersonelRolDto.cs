using Core.Entity;

namespace Kutuphane.Model.DTO
{
    public class PersonelRolDto : IDto
    {
        public int PersonelRolId { get; set; }
        public int PersonelId { get; set; }
        public int RolId { get; set; }

        public string? PersonelAd { get; set; }
        public string? PersonelSoyad { get; set; }
        public string? RolAdi { get; set; }
    }
}