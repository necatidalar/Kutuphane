using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DAL.Contexes
{
    public class SupervisorDbContext : DbContext
    {
        public SupervisorDbContext()
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=YDC-TUNAAKSU-LE\\YDCLENOVO;Database=StajyerKutuphane;User Id=stajyer;Password=Yesilyurt.55; TrustServerCertificate=True;");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API Configuration'ları otomatik yükle
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SupervisorDbContext).Assembly);

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
