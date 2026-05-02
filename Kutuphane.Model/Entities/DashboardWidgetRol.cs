using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class DashboardWidgetRol : IEntity
    {
        public int DashboardWidgetRolId { get; set; }
        public int DashboardWidgetId { get; set; }
        public int RolId { get; set; }
        public bool GorunurMu { get; set; } = true;
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public DashboardWidget? DashboardWidget { get; set; }
        public Rol? Rol { get; set; }
    }
}
