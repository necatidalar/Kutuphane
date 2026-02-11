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

            builder.HasData(
                new RolYetki { RolYetkiId = 1, RolId = 1, YetkiId = 1 },
                new RolYetki { RolYetkiId = 2, RolId = 1, YetkiId = 2 },
                new RolYetki { RolYetkiId = 3, RolId = 1, YetkiId = 3 },
                new RolYetki { RolYetkiId = 4, RolId = 1, YetkiId = 4 },
                new RolYetki { RolYetkiId = 5, RolId = 1, YetkiId = 5 },
                new RolYetki { RolYetkiId = 6, RolId = 1, YetkiId = 6 },
                new RolYetki { RolYetkiId = 7, RolId = 1, YetkiId = 7 },
                new RolYetki { RolYetkiId = 8, RolId = 1, YetkiId = 8 },
                new RolYetki { RolYetkiId = 9, RolId = 1, YetkiId = 9 },
                new RolYetki { RolYetkiId = 10, RolId = 1, YetkiId = 10 },
                new RolYetki { RolYetkiId = 11, RolId = 1, YetkiId = 11 },
                new RolYetki { RolYetkiId = 12, RolId = 1, YetkiId = 12 },
                new RolYetki { RolYetkiId = 13, RolId = 1, YetkiId = 13 },
                new RolYetki { RolYetkiId = 14, RolId = 1, YetkiId = 14 },
                new RolYetki { RolYetkiId = 15, RolId = 1, YetkiId = 15 },
                new RolYetki { RolYetkiId = 16, RolId = 1, YetkiId = 16 },
                new RolYetki { RolYetkiId = 17, RolId = 1, YetkiId = 17 },
                new RolYetki { RolYetkiId = 18, RolId = 1, YetkiId = 18 },
                new RolYetki { RolYetkiId = 19, RolId = 1, YetkiId = 19 },
                new RolYetki { RolYetkiId = 20, RolId = 1, YetkiId = 20 },
                new RolYetki { RolYetkiId = 21, RolId = 1, YetkiId = 21 },
                new RolYetki { RolYetkiId = 22, RolId = 1, YetkiId = 22 },
                new RolYetki { RolYetkiId = 23, RolId = 1, YetkiId = 23 },
                new RolYetki { RolYetkiId = 24, RolId = 1, YetkiId = 24 },
                new RolYetki { RolYetkiId = 25, RolId = 1, YetkiId = 25 },
                new RolYetki { RolYetkiId = 26, RolId = 1, YetkiId = 26 },
                new RolYetki { RolYetkiId = 27, RolId = 1, YetkiId = 27 },
                new RolYetki { RolYetkiId = 28, RolId = 1, YetkiId = 28 },
                new RolYetki { RolYetkiId = 29, RolId = 1, YetkiId = 29 },
                new RolYetki { RolYetkiId = 30, RolId = 1, YetkiId = 30 },
                new RolYetki { RolYetkiId = 31, RolId = 1, YetkiId = 31 },
                new RolYetki { RolYetkiId = 32, RolId = 1, YetkiId = 32 },
                new RolYetki { RolYetkiId = 33, RolId = 1, YetkiId = 33 },
                new RolYetki { RolYetkiId = 34, RolId = 1, YetkiId = 34 },
                new RolYetki { RolYetkiId = 35, RolId = 1, YetkiId = 35 },
                new RolYetki { RolYetkiId = 36, RolId = 1, YetkiId = 36 },

                new RolYetki { RolYetkiId = 37, RolId = 2, YetkiId = 1 },
                new RolYetki { RolYetkiId = 38, RolId = 2, YetkiId = 2 }
            );
        }
    }
}
