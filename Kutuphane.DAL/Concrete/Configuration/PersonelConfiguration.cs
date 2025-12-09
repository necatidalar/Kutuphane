using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class PersonelConfiguration : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasKey(p => p.PersonelId);
            builder.Property(p => p.Ad)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder.Property(p => p.Soyad)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder.Property(p => p.KullaniciAdi)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(20);
            builder.Property(p => p.Sifre)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(250);
            builder.Property(p => p.CinsiyetId)
                .IsRequired();
            builder.Property(p=> p.AktifMi)
                .IsRequired()
                .HasDefaultValue(true);


            // Changed from one-to-one to many-to-one so multiple Personel can share a Cinsiyet
            builder.HasOne(p => p.Cinsiyet)
                .WithMany(c=> c.Personeller)
                .HasForeignKey(p => p.CinsiyetId);

            builder.HasMany(p => p.TeslimEdilenler)
                .WithOne(o => o.TeslimEdenPersonel)
                .HasForeignKey(o => o.TeslimEdenPersonelId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(p => p.TerslimAlinanlar)
                .WithOne(o => o.TeslimAlanPersonel)
                .HasForeignKey(o => o.TeslimAlanPersonelId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasData(
                new Personel
                {
                    PersonelId = 1,
                    Ad = "Necati",
                    Soyad = "Dalar",
                    CinsiyetId = 1,
                    KullaniciAdi = "neco",
                    Sifre = "MTIzNDU=", //base64 12345"
                    AktifMi = true
                },
                new Personel
                {
                    PersonelId = 2,
                    Ad = "Necoş",
                    Soyad = "Dalmaz",
                    CinsiyetId = 1,
                    KullaniciAdi = "neci",
                    Sifre = "MTIz", //base64 12345"
                    AktifMi = true
                }
            );

        }
    }
}
