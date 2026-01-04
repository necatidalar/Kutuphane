using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class PersonelRolConfiguration : IEntityTypeConfiguration<PersonelRol>
    {
        public void Configure(EntityTypeBuilder<PersonelRol> builder)
        {
            builder.ToTable("PersonelRolleri");

            builder.HasKey(x => x.PersonelRolId);

            builder.Property(x => x.PersonelRolId)
                   .UseIdentityColumn();

            builder.HasIndex(x => new { x.PersonelId, x.RolId })
                   .IsUnique();

            builder.HasOne(x => x.Personel)
                   .WithMany(x => x.PersonelRolleri)
                   .HasForeignKey(x => x.PersonelId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Rol)
                   .WithMany(x => x.PersonelRolleri)
                   .HasForeignKey(x => x.RolId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new PersonelRol { PersonelRolId = 1, PersonelId = 1, RolId = 1 },
                new PersonelRol { PersonelRolId = 2, PersonelId = 2, RolId = 2 }
            );
        }
    }
}
