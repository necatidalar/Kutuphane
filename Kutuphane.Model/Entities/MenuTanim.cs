using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class MenuTanim : IEntity
    {
        public int MenuTanimId { get; set; }
        public int? UstMenuId { get; set; }
        public string MenuKodu { get; set; } = string.Empty;
        public string MenuAdi { get; set; } = string.Empty;
        public string? FormAdi { get; set; }
        public string? YetkiKodu { get; set; }
        public string? Icon { get; set; }
        public int SiraNo { get; set; }
        public bool SistemMenusuMu { get; set; }
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public MenuTanim? UstMenu { get; set; }
        public ICollection<MenuTanim>? AltMenuler { get; set; }
        public ICollection<MenuAyari>? MenuAyarlari { get; set; }
    }
}
