using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Rol : IEntity
    {
        public int RolId { get; set; }
        public string RolAdi { get; set; }
        public string RolKodu { get; set; }
        public bool AktifMi { get; set; } = true;

        public ICollection<PersonelRol> PersonelRolleri { get; set; }
        public ICollection<RolYetki> RolYetkileri { get; set; }
    }
}