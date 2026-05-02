using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class UyeConfiguration : IEntityTypeConfiguration<Uye>
    {
        public void Configure(EntityTypeBuilder<Uye> builder)
        {
            builder.ToTable("Uyeler");

            builder.HasKey(u => u.UyeId);

            builder.Property(u => u.TcPass)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(20);

            builder.Property(u => u.Ad)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(100);

            builder.Property(u => u.Soyad)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(100);

            builder.Property(u => u.CinsiyetId)
                   .HasColumnType("tinyint")
                   .IsRequired();

            builder.Property(u => u.DogumTarihi)
                   .HasColumnType("datetime")
                   .IsRequired();

            builder.Property(u => u.Telefon)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(15);

            builder.Property(u => u.Eposta)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200);

            builder.Property(u => u.Adres)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(400);

            builder.Property(u => u.AdresDetay)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(1000);

            builder.Property(u => u.AktifMi)
                   .IsRequired()
                   .HasDefaultValue(true);

            builder.Property(u => u.KurumId)
                   .IsRequired();

            builder.Property(u => u.UyeTipiId)
                   .IsRequired();

            builder.HasOne(u => u.Cinsiyet)
                   .WithMany()
                   .HasForeignKey(u => u.CinsiyetId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(u => u.Kurum)
                   .WithMany(k => k.Uyeler)
                   .HasForeignKey(u => u.KurumId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.UyeTipi)
                   .WithMany(ut => ut.Uyeler)
                   .HasForeignKey(u => u.UyeTipiId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
