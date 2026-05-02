using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
    {
        public void Configure(EntityTypeBuilder<AuditLog> builder)
        {
            builder.ToTable("AuditLoglari");

            builder.HasKey(x => x.AuditLogId);

            builder.Property(x => x.TabloAdi)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(x => x.IslemTipi)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(20);

            builder.Property(x => x.KayitId)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(x => x.EskiDegerJson)
                   .HasColumnType("nvarchar(max)")
                   .IsRequired(false);

            builder.Property(x => x.YeniDegerJson)
                   .HasColumnType("nvarchar(max)")
                   .IsRequired(false);

            builder.Property(x => x.KullaniciId).IsRequired(false);

            builder.Property(x => x.KullaniciAdi)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(x => x.HostAdi)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200)
                   .IsRequired(false);

            builder.Property(x => x.UygulamaAdi)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200)
                   .IsRequired(false);

            builder.Property(x => x.IslemTarihi)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.HasIndex(x => x.TabloAdi);
            builder.HasIndex(x => x.IslemTarihi);
        }
    }
}
