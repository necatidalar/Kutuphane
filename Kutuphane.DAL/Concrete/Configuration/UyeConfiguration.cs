using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class UyeConfiguration : IEntityTypeConfiguration<Uye>
    {
        public void Configure(EntityTypeBuilder<Uye> builder)
        {
            builder.HasKey(u => u.UyeId);
            builder.Property(u => u.TcPass).IsRequired().HasColumnType("varchar").HasMaxLength(20);
            builder.Property(u => u.Ad).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(u => u.Soyad).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(u => u.CinsiyetId).HasColumnType("tinyint").IsRequired();
            builder.Property(u => u.DogumTarihi).HasColumnType("datetime").IsRequired(false);
            builder.Property(u => u.Telefon).IsRequired().HasColumnType("varchar").HasMaxLength(15);
            builder.Property(u => u.Eposta).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(u => u.Adres).IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            builder.Property(u => u.AdresDetay).IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            builder.Property(u => u.AktifMi).IsRequired().HasDefaultValue(true);

            builder.HasOne(u => u.Cinsiyet)
                   .WithMany()
                   .HasForeignKey(u => u.CinsiyetId)
                   .OnDelete(DeleteBehavior.SetNull);


        }
    }
}
