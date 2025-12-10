using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class YazarConfiguration : IEntityTypeConfiguration<Yazar>
    {
        public void Configure(EntityTypeBuilder<Yazar> builder)
        {
            builder.Property(y => y.AdSoyad).HasMaxLength(200).IsRequired();
            builder.Property(y => y.DogumTarihi).HasColumnType("datetime").IsRequired(false);
            builder.Property(y => y.AktifMi).IsRequired().HasDefaultValue(true);
        }
    }
}
