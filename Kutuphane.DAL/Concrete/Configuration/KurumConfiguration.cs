using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class KurumConfiguration : IEntityTypeConfiguration<Kurum>
    {
        public void Configure(EntityTypeBuilder<Kurum> builder)
        {
            builder.ToTable("Kurumlar");

            builder.HasKey(x => x.KurumId);

            builder.Property(x => x.KurumAdi)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200);

            builder.Property(x => x.KurumKodu)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(x => x.KurumTipi)
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

            builder.HasIndex(x => x.KurumKodu).IsUnique();
        }
    }
}
