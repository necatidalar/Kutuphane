using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class AlanSecenekConfiguration : IEntityTypeConfiguration<AlanSecenek>
    {
        public void Configure(EntityTypeBuilder<AlanSecenek> builder)
        {
            builder.ToTable("AlanSecenekleri");

            builder.HasKey(x => x.AlanSecenekId);

            builder.Property(x => x.AlanTanimId).IsRequired();

            builder.Property(x => x.Deger)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(100);

            builder.Property(x => x.Etiket)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200);

            builder.Property(x => x.SiraNo)
                   .IsRequired()
                   .HasDefaultValue(0);

            builder.Property(x => x.AktifMi)
                   .IsRequired()
                   .HasDefaultValue(true);

            builder.Property(x => x.OlusturmaTarihi)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.GuncellemeTarihi)
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.HasOne(x => x.AlanTanim)
                   .WithMany(at => at.AlanSecenekleri)
                   .HasForeignKey(x => x.AlanTanimId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new { x.AlanTanimId, x.Deger }).IsUnique();
        }
    }
}
