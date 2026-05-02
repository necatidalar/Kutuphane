using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class EntityEkAlanDegeriConfiguration : IEntityTypeConfiguration<EntityEkAlanDegeri>
    {
        public void Configure(EntityTypeBuilder<EntityEkAlanDegeri> builder)
        {
            builder.ToTable("EntityEkAlanDegerleri");

            builder.HasKey(x => x.EntityEkAlanDegeriId);

            builder.Property(x => x.EntityAdi)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(x => x.EntityId).IsRequired();
            builder.Property(x => x.AlanTanimId).IsRequired();

            builder.Property(x => x.DegerText)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(1000)
                   .IsRequired(false);

            builder.Property(x => x.DegerNumber).IsRequired(false);

            builder.Property(x => x.DegerDecimal)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired(false);

            builder.Property(x => x.DegerDate)
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.Property(x => x.DegerBool).IsRequired(false);

            builder.Property(x => x.OlusturmaTarihi)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.GuncellemeTarihi)
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.HasOne(x => x.AlanTanim)
                   .WithMany(at => at.EntityEkAlanDegerleri)
                   .HasForeignKey(x => x.AlanTanimId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new { x.EntityAdi, x.EntityId, x.AlanTanimId }).IsUnique();
        }
    }
}
