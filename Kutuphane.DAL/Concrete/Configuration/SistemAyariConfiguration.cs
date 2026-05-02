using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class SistemAyariConfiguration : IEntityTypeConfiguration<SistemAyari>
    {
        public void Configure(EntityTypeBuilder<SistemAyari> builder)
        {
            builder.ToTable("SistemAyarlari");

            builder.HasKey(x => x.SistemAyariId);

            builder.Property(x => x.KurumId).IsRequired(false);

            builder.Property(x => x.AyarKodu)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(x => x.AyarAdi)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200);

            builder.Property(x => x.AyarDegeri)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(1000)
                   .IsRequired(false);

            builder.Property(x => x.VeriTipi)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(30)
                   .HasDefaultValue("TEXT");

            builder.Property(x => x.Aciklama)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(500)
                   .IsRequired(false);

            builder.Property(x => x.AktifMi).IsRequired().HasDefaultValue(true);

            builder.Property(x => x.OlusturmaTarihi)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.GuncellemeTarihi)
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.HasOne(x => x.Kurum)
                   .WithMany(k => k.SistemAyarlari)
                   .HasForeignKey(x => x.KurumId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new { x.KurumId, x.AyarKodu }).IsUnique();
        }
    }
}
