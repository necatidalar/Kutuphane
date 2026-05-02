using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class DashboardWidgetRolConfiguration : IEntityTypeConfiguration<DashboardWidgetRol>
    {
        public void Configure(EntityTypeBuilder<DashboardWidgetRol> builder)
        {
            builder.ToTable("DashboardWidgetRolleri");

            builder.HasKey(x => x.DashboardWidgetRolId);

            builder.Property(x => x.DashboardWidgetId).IsRequired();
            builder.Property(x => x.RolId).IsRequired();
            builder.Property(x => x.GorunurMu).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.AktifMi).IsRequired().HasDefaultValue(true);

            builder.Property(x => x.OlusturmaTarihi)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.GuncellemeTarihi)
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.HasOne(x => x.DashboardWidget)
                   .WithMany(dw => dw.DashboardWidgetRolleri)
                   .HasForeignKey(x => x.DashboardWidgetId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Rol)
                   .WithMany()
                   .HasForeignKey(x => x.RolId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new { x.DashboardWidgetId, x.RolId }).IsUnique();
        }
    }
}
