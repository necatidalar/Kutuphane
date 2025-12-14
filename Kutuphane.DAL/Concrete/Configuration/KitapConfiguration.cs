using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class KitapConfiguration : IEntityTypeConfiguration<Kitap>
    {
        public void Configure(EntityTypeBuilder<Kitap> builder)
        {
            builder.HasKey(k => k.KitapId);
            builder.Property(k => k.KitapAdi).IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            builder.Property(k => k.ISBN).IsRequired(false).HasColumnType("nvarchar").HasMaxLength(25);
            builder.Property(k => k.BasimYili).IsRequired(false);
            builder.Property(k => k.SayfaSayisi).IsRequired(false);
            builder.Property(k => k.DilId).IsRequired().HasColumnType("smallint");
            builder.Property(k => k.Stok).IsRequired().HasDefaultValue(0);
            builder.Property(k => k.Aktif).IsRequired().HasDefaultValue(true);
            builder.Property(k => k.YazarId).IsRequired();
            builder.Property(k => k.YayineviId).IsRequired();
            builder.Property(k => k.KategoriId).IsRequired();

            builder.HasOne(k => k.Diller).WithMany().HasForeignKey(k => k.DilId);


        }
    }
}
