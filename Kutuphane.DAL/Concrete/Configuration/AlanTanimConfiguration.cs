using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class AlanTanimConfiguration : IEntityTypeConfiguration<AlanTanim>
    {
        public void Configure(EntityTypeBuilder<AlanTanim> builder)
        {
            builder.ToTable("AlanTanimlari");

            builder.HasKey(x => x.AlanTanimId);

            builder.Property(x => x.EntityAdi)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(x => x.AlanKodu)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(x => x.AlanAdi)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200);

            builder.Property(x => x.VeriTipi)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(30);

            builder.Property(x => x.MaxLength).IsRequired(false);
            builder.Property(x => x.SistemAlaniMi).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.AktifMi).IsRequired().HasDefaultValue(true);

            builder.Property(x => x.OlusturmaTarihi)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.GuncellemeTarihi)
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.HasIndex(x => new { x.EntityAdi, x.AlanKodu }).IsUnique();
        }
    }
}
