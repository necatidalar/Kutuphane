

using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class YazarKitapConfiguration : IEntityTypeConfiguration<YazarKitap>
    {
        public void Configure(EntityTypeBuilder<YazarKitap> builder)
        {
            builder.Property(yk => yk.YazarId).IsRequired();
            builder.Property(yk => yk.KitapId).IsRequired();

            builder.HasOne(yk => yk.Yazar)
                   .WithMany(y => y.YazarKitaplari)
                   .HasForeignKey(yk => yk.YazarId)
                   .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(yk => yk.Kitap)
                   .WithMany(k => k.KitapYazarlari)
                   .HasForeignKey(yk => yk.KitapId)
                   .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
