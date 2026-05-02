using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class MenuAyariConfiguration : IEntityTypeConfiguration<MenuAyari>
    {
        public void Configure(EntityTypeBuilder<MenuAyari> builder)
        {
            builder.ToTable("MenuAyarlari");

            builder.HasKey(x => x.MenuAyariId);

            builder.Property(x => x.KurumId).IsRequired();
            builder.Property(x => x.MenuTanimId).IsRequired();
            builder.Property(x => x.GorunurMu).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.SiraNo).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.AktifMi).IsRequired().HasDefaultValue(true);

            builder.Property(x => x.OlusturmaTarihi)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.GuncellemeTarihi)
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.HasOne(x => x.Kurum)
                   .WithMany(k => k.MenuAyarlari)
                   .HasForeignKey(x => x.KurumId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.MenuTanim)
                   .WithMany(mt => mt.MenuAyarlari)
                   .HasForeignKey(x => x.MenuTanimId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new { x.KurumId, x.MenuTanimId }).IsUnique();
        }
    }
}
