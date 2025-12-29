using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class RolYetkiConfiguration : IEntityTypeConfiguration<RolYetki>
    {
        public void Configure(EntityTypeBuilder<RolYetki> builder)
        {
            builder.ToTable("RolYetkileri");

            builder.HasKey(x => x.RolYetkiId);

            builder.Property(x => x.RolYetkiId)
                   .UseIdentityColumn();

            builder.HasIndex(x => new { x.RolId, x.YetkiId })
                   .IsUnique();

            builder.HasOne(x => x.Rol)
                   .WithMany(x => x.RolYetkileri)
                   .HasForeignKey(x => x.RolId);

            builder.HasOne(x => x.Yetki)
                   .WithMany(x => x.RolYetkileri)
                   .HasForeignKey(x => x.YetkiId);
        }
    }
}
