using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class FormAlanAyariConfiguration : IEntityTypeConfiguration<FormAlanAyari>
    {
        public void Configure(EntityTypeBuilder<FormAlanAyari> builder)
        {
            builder.ToTable("FormAlanAyarlari");

            builder.HasKey(x => x.FormAlanAyariId);

            builder.Property(x => x.KurumId).IsRequired();
            builder.Property(x => x.UyeTipiId).IsRequired(false);

            builder.Property(x => x.FormKodu)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(x => x.AlanTanimId).IsRequired();
            builder.Property(x => x.GorunurMu).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.ZorunluMu).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.DegistirilebilirMi).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.ListedeGorunsunMu).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.SiraNo).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.AktifMi).IsRequired().HasDefaultValue(true);

            builder.Property(x => x.OlusturmaTarihi)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.GuncellemeTarihi)
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.HasOne(x => x.Kurum)
                   .WithMany(k => k.FormAlanAyarlari)
                   .HasForeignKey(x => x.KurumId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.UyeTipi)
                   .WithMany(ut => ut.FormAlanAyarlari)
                   .HasForeignKey(x => x.UyeTipiId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.AlanTanim)
                   .WithMany(at => at.FormAlanAyarlari)
                   .HasForeignKey(x => x.AlanTanimId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new { x.KurumId, x.UyeTipiId, x.FormKodu, x.AlanTanimId }).IsUnique();
        }
    }
}
