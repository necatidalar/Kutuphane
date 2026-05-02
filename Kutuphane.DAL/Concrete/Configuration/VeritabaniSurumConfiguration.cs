using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class VeritabaniSurumConfiguration : IEntityTypeConfiguration<VeritabaniSurum>
    {
        public void Configure(EntityTypeBuilder<VeritabaniSurum> builder)
        {
            builder.ToTable("VeritabaniSurumleri");

            builder.HasKey(x => x.VeritabaniSurumId);

            builder.Property(x => x.SurumKodu)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(x => x.SurumAdi)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200);

            builder.Property(x => x.Aciklama)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(1000)
                   .IsRequired(false);

            builder.Property(x => x.UygulamaTarihi)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.AktifMi)
                   .IsRequired()
                   .HasDefaultValue(true);

            builder.HasIndex(x => x.SurumKodu).IsUnique();
        }
    }
}
