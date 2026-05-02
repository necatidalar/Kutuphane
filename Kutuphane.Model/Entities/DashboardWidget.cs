using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class DashboardWidget : IEntity
    {
        public int DashboardWidgetId { get; set; }
        public string WidgetKodu { get; set; } = string.Empty;
        public string Baslik { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public string WidgetTipi { get; set; } = string.Empty;
        public string VeriKaynagi { get; set; } = string.Empty;
        public string? Icon { get; set; }
        public int VarsayilanSiraNo { get; set; }
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public ICollection<DashboardWidgetAyari>? DashboardWidgetAyarlari { get; set; }
        public ICollection<DashboardWidgetRol>? DashboardWidgetRolleri { get; set; }
    }
}
