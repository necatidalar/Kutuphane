using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class OduncKuralConfiguration : IEntityTypeConfiguration<OduncKural>
    {
        public void Configure(EntityTypeBuilder<OduncKural> builder)
        {
            builder.ToTable("OduncKurallari");

            builder.HasKey(x => x.OduncKuralId);

            builder.Property(x => x.KurumId).IsRequired();
            builder.Property(x => x.UyeTipiId).IsRequired();
            builder.Property(x => x.MaksimumKitapSayisi).IsRequired();
            builder.Property(x => x.OduncSuresiGun).IsRequired();

            builder.Property(x => x.GecikmisKitabiOlanOduncAlabilirMi)
                   .IsRequired()
                   .HasDefaultValue(false);

            builder.Property(x => x.AyniKitaptanTekrarAlabilirMi)
                   .IsRequired()
                   .HasDefaultValue(false);

            builder.Property(x => x.AktifMi)
                   .IsRequired()
                   .HasDefaultValue(true);

            builder.Property(x => x.OlusturmaTarihi)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.GuncellemeTarihi)
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.HasOne(x => x.Kurum)
                   .WithMany(k => k.OduncKurallari)
                   .HasForeignKey(x => x.KurumId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.UyeTipi)
                   .WithMany(ut => ut.OduncKurallari)
                   .HasForeignKey(x => x.UyeTipiId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new { x.KurumId, x.UyeTipiId }).IsUnique();
        }
    }
}
