using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class CinsiyetConfiguration : IEntityTypeConfiguration<Cinsiyet>
    {
        public void Configure(EntityTypeBuilder<Cinsiyet> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnType("tinyint");
            builder.Property(c => c.CinsiyetAdi)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(15);
            builder.HasData(
                new Cinsiyet { Id = 1, CinsiyetAdi = "Erkek" },
                new Cinsiyet { Id = 2, CinsiyetAdi = "Kadın" },
                new Cinsiyet { Id = 3, CinsiyetAdi = "Belirtilmemiş" }
            );

        }
    }
}
