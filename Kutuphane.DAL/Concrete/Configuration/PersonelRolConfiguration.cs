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

            builder.HasKey(x => new { x.PersonelId, x.RolId });

            builder.HasOne(x => x.Personel)
                   .WithMany(x => x.PersonelRolleri)
                   .HasForeignKey(x => x.PersonelId);

            builder.HasOne(x => x.Rol)
                   .WithMany(x => x.PersonelRolleri)
                   .HasForeignKey(x => x.RolId);

            builder.HasData(
                new PersonelRol { PersonelId = 1, RolId = 1 },
                new PersonelRol { PersonelId = 2, RolId = 2 }
            );
        }
    }
}
