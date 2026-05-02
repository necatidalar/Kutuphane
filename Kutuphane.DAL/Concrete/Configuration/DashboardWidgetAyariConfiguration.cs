using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class DashboardWidgetAyariConfiguration : IEntityTypeConfiguration<DashboardWidgetAyari>
    {
        public void Configure(EntityTypeBuilder<DashboardWidgetAyari> builder)
        {
            builder.ToTable("DashboardWidgetAyarlari");

            builder.HasKey(x => x.DashboardWidgetAyariId);

            builder.Property(x => x.KurumId).IsRequired();
            builder.Property(x => x.DashboardWidgetId).IsRequired();
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
                   .WithMany(k => k.DashboardWidgetAyarlari)
                   .HasForeignKey(x => x.KurumId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.DashboardWidget)
                   .WithMany(dw => dw.DashboardWidgetAyarlari)
                   .HasForeignKey(x => x.DashboardWidgetId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new { x.KurumId, x.DashboardWidgetId }).IsUnique();
        }
    }
}
