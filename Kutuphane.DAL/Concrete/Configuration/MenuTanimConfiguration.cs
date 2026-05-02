using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class MenuTanimConfiguration : IEntityTypeConfiguration<MenuTanim>
    {
        public void Configure(EntityTypeBuilder<MenuTanim> builder)
        {
            builder.ToTable("MenuTanimlari");

            builder.HasKey(x => x.MenuTanimId);

            builder.Property(x => x.UstMenuId).IsRequired(false);

            builder.Property(x => x.MenuKodu)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(x => x.MenuAdi)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200);

            builder.Property(x => x.FormAdi)
                   .HasColumnType("varchar")
                   .HasMaxLength(200)
                   .IsRequired(false);

            builder.Property(x => x.YetkiKodu)
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(x => x.Icon)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(x => x.SiraNo).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.SistemMenusuMu).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.AktifMi).IsRequired().HasDefaultValue(true);

            builder.Property(x => x.OlusturmaTarihi)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.GuncellemeTarihi)
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.HasOne(x => x.UstMenu)
                   .WithMany(x => x.AltMenuler)
                   .HasForeignKey(x => x.UstMenuId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => x.MenuKodu).IsUnique();
        }
    }
}
