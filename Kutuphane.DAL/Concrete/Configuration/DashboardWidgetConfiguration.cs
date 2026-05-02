using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class DashboardWidgetConfiguration : IEntityTypeConfiguration<DashboardWidget>
    {
        public void Configure(EntityTypeBuilder<DashboardWidget> builder)
        {
            builder.ToTable("DashboardWidgetlari");

            builder.HasKey(x => x.DashboardWidgetId);

            builder.Property(x => x.WidgetKodu)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(x => x.Baslik)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200);

            builder.Property(x => x.Aciklama)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(500)
                   .IsRequired(false);

            builder.Property(x => x.WidgetTipi)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(30);

            builder.Property(x => x.VeriKaynagi)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(x => x.Icon)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(x => x.VarsayilanSiraNo).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.AktifMi).IsRequired().HasDefaultValue(true);

            builder.Property(x => x.OlusturmaTarihi)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.GuncellemeTarihi)
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.HasIndex(x => x.WidgetKodu).IsUnique();
        }
    }
}
