using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class UyeTipiConfiguration : IEntityTypeConfiguration<UyeTipi>
    {
        public void Configure(EntityTypeBuilder<UyeTipi> builder)
        {
            builder.ToTable("UyeTipleri");

            builder.HasKey(x => x.UyeTipiId);

            builder.Property(x => x.UyeTipiAdi)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(100);

            builder.Property(x => x.UyeTipiKodu)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(x => x.AktifMi)
                   .IsRequired()
                   .HasDefaultValue(true);

            builder.Property(x => x.OlusturmaTarihi)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.GuncellemeTarihi)
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.HasIndex(x => x.UyeTipiKodu).IsUnique();
        }
    }
}
