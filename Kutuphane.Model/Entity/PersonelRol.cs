using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class PersonelRol : IEntity
    {
        public int PersonelRolId { get; set; }
        public int PersonelId { get; set; }
        public int RolId { get; set; }
        
        public Personel? Personel { get; set; }
        public Rol? Rol { get; set; }
    }
}
