

using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class KitapKategoriConfiguration : IEntityTypeConfiguration<KitapKategori>
    {

        public void Configure(EntityTypeBuilder<KitapKategori> builder)
        {
            builder.HasKey(kk => kk.Id);
            builder.HasOne(kk => kk.Kitap)
                   .WithMany(k => k.KitapKategoriler)
                   .HasForeignKey(kk => kk.KitapId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(kk => kk.Kategori)
                   .WithMany(kat => kat.KitapKategoriler)
                   .HasForeignKey(kk => kk.KategoriId)
                   .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
