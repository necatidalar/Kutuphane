

using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class CinsiyetConfiguration : IEntityTypeConfiguration<Cinsiyet>
    {
        public void Configure(EntityTypeBuilder<Cinsiyet> builder)
        {
            builder.HasKey(c => c.CinsiyetId);
            builder.Property(c => c.CinsiyetId).HasColumnType("tinyint");
            builder.Property(c => c.CinsiyetAdi)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(15);
            builder.HasData(
                new Cinsiyet { CinsiyetId = 1, CinsiyetAdi = "Erkek" },
                new Cinsiyet { CinsiyetId = 2, CinsiyetAdi = "Kadın" },
                new Cinsiyet { CinsiyetId = 3, CinsiyetAdi = "Belirtilmemiş" }
            );

        }
    }
}
