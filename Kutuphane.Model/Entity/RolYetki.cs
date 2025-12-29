using Core.Entity;
using Kutuphane.Model.Entity;

public class RolYetki : IEntity
{
    public int RolYetkiId { get; set; }
    public int RolId { get; set; }
    public int YetkiId { get; set; }

    public Rol Rol { get; set; }
    public Yetki Yetki { get; set; }
}
