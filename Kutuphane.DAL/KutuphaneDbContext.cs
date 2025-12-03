using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kutuphane.DAL
{
    public class KutuphaneDbContext : DbContext
    {
        public KutuphaneDbContext()
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=localhost;Database=KutuphaneOtomasyonu;Trusted_Connection=True;TrustServerCertificate=True;");
                optionsBuilder.UseSqlServer("Server=CLK-STAJERPC\\STAJYERSQL;Database=KutuphaneOtomasyonu;User Id=sa;Password=Yesilyurt.55; TrustServerCertificate=True;");
                //optionsBuilder.UseSqlServer("Server=YDC-TUNAAKSU-LE\\YDCLENOVO;Database=StajyerKutuphane;User Id=stajyer;Password=Yesilyurt.55; TrustServerCertificate=True;");
            }
        }

        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Yayinevi> Yayinevleri { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kat> Katlar { get; set; }
        public DbSet<Kitaplik> Kitapliklar { get; set; }
        public DbSet<Kolon> Kolonlar { get; set; }
        public DbSet<Raf> Raflar { get; set; }
        public DbSet<KitapSirasi> KitapSirasi { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Odunc> Oduncler { get; set; }
        public DbSet<Personel> Personel { get; set; }

    }
}