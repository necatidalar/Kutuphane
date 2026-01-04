

using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class OduncConfiguration : IEntityTypeConfiguration<Odunc>
    {
        public void Configure(EntityTypeBuilder<Odunc> builder)
        {
            builder.HasKey(o => o.OduncId);
            builder.Property(o => o.UyeId)
                .IsRequired();
            builder.Property(o => o.KitapId)
                .IsRequired();
            builder.Property(o => o.AlisTarihi)
                .HasColumnType("datetime")
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();
            builder.Property(o => o.TeslimTarihi)
                .HasColumnType("datetime")
                .IsRequired(false);
            builder.Property(o => o.TeslimEdildi)
                .IsRequired()
                .HasDefaultValue(false);
            builder.Property(o => o.TeslimEdenPersonelId)
                .IsRequired();
            builder.Property(o => o.TeslimAlanPersonelId)
                .IsRequired(false);

            builder.HasOne(o => o.Uye)
                .WithMany(u => u.Oduncler)
                .HasForeignKey(o => o.UyeId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Kitap)
                .WithMany(k => k.Oduncler)
                .HasForeignKey(o => o.KitapId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
