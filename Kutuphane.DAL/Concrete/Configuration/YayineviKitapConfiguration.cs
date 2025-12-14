


using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class YayineviKitapConfiguration : IEntityTypeConfiguration<YayineviKitap>
    {
        public void Configure(EntityTypeBuilder<YayineviKitap> builder)
        {
            builder.Property(yk => yk.YayineviId).IsRequired();
            builder.Property(yk => yk.KitapId).IsRequired();
            builder.Property(yk => yk.DonemBaslangici).HasColumnType("datetime").IsRequired();
            builder.Property(yk => yk.DonemBitisi).HasColumnType("datetime").IsRequired(false);
            builder.HasOne(yk => yk.Yayinevi)
                   .WithMany(y => y.YayineviKitaplari)
                   .HasForeignKey(yk => yk.YayineviId)
                   .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(yk => yk.Kitap)
                   .WithMany(k => k.KitapYayinevleri)
                   .HasForeignKey(yk => yk.KitapId)
                   .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
