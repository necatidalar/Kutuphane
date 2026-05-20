using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class UyeConfiguration : IEntityTypeConfiguration<Uye>
    {
        public void Configure(EntityTypeBuilder<Uye> builder)
        {
            // Veritabanında trigger bulunan tablolarda EF Core OUTPUT clause kullanırsa kayıt/güncelleme sırasında hata oluşur.
            // Bu ayar, mevcut triggerları bozmadan eski güvenli kaydetme davranışını kullanır.
            builder.ToTable("Uyeler", tb => tb.UseSqlOutputClause(false));

            builder.HasKey(u => u.UyeId);

            builder.Property(u => u.TcPass).IsRequired().HasColumnType("varchar").HasMaxLength(20);
            builder.Property(u => u.OkulNo).HasColumnType("varchar").HasMaxLength(20).IsRequired(false);
            builder.Property(u => u.Sinif).HasColumnType("nvarchar").HasMaxLength(20).IsRequired(false);
            builder.Property(u => u.Sube).HasColumnType("nvarchar").HasMaxLength(10).IsRequired(false);
            builder.Property(u => u.VeliAdSoyad).HasColumnType("nvarchar").HasMaxLength(100).IsRequired(false);
            builder.Property(u => u.VeliTelefon).HasColumnType("varchar").HasMaxLength(15).IsRequired(false);

            builder.Property(u => u.Ad).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(u => u.Soyad).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(u => u.CinsiyetId).HasColumnType("tinyint").IsRequired();
            builder.Property(u => u.DogumTarihi).HasColumnType("datetime").IsRequired();
            builder.Property(u => u.Telefon).IsRequired().HasColumnType("varchar").HasMaxLength(15);
            builder.Property(u => u.Eposta).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(u => u.Adres).IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            builder.Property(u => u.AdresDetay).IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            builder.Property(u => u.AktifMi).IsRequired().HasDefaultValue(true);

            builder.HasIndex(u => u.OkulNo)
                   .IsUnique()
                   .HasFilter("[OkulNo] IS NOT NULL AND [OkulNo] <> ''");

            builder.HasOne(u => u.Cinsiyet)
                   .WithMany()
                   .HasForeignKey(u => u.CinsiyetId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
