using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Yetki : IEntity
    {
        public int YetkiId { get; set; }
        public string YetkiKodu { get; set; }
        public string YetkiAdi { get; set; }

        public ICollection<RolYetki> RolYetkileri { get; set; }
    }
}
