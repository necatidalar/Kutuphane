

using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class YayineviConfiguration : IEntityTypeConfiguration<Yayinevi>
    {
        public void Configure(EntityTypeBuilder<Yayinevi> builder)
        {
            builder.Property(y => y.Ad).HasMaxLength(300).IsRequired();
            builder.Property(y => y.KurulusYili).IsRequired(false);
           
        }
    }
}
