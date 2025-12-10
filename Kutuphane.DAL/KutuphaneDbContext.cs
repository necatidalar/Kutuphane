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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API Configuration'ları otomatik yükle
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(KutuphaneDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cinsiyet> Cinsiyetler { get; set; }
        public DbSet<Dil> Diller { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Odunc> Oduncler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Yayinevi> Yayinevleri { get; set; }
        public DbSet<YayineviKitap> YayineviKitaplari { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<YazarKitap> YazarKitaplari { get; set; }

    }
}