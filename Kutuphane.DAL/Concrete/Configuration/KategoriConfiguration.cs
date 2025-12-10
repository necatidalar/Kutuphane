

using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class KategoriConfiguration : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasKey(k => k.KategoriId);
            builder.Property(k => k.KategoriAdi)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(150);
            builder.Property(k => k.AktifMi)
                   .IsRequired()
                   .HasDefaultValue(true);

            builder.HasData(
                new Kategori { KategoriId = 1, KategoriAdi = "Roman" },
                new Kategori { KategoriId = 2, KategoriAdi = "Hikaye" },
                new Kategori { KategoriId = 3, KategoriAdi = "Şiir" },
                new Kategori { KategoriId = 4, KategoriAdi = "Tarih" },
                new Kategori { KategoriId = 5, KategoriAdi = "Bilim" },
                new Kategori { KategoriId = 6, KategoriAdi = "Sanat" },
                new Kategori { KategoriId = 7, KategoriAdi = "Felsefe" },
                new Kategori { KategoriId = 8, KategoriAdi = "Çocuk" },
                new Kategori { KategoriId = 9, KategoriAdi = "Gezi" },
                new Kategori { KategoriId = 10, KategoriAdi = "Biyografi" },
                new Kategori { KategoriId = 11, KategoriAdi = "Kişisel Gelişim" },
                new Kategori { KategoriId = 12, KategoriAdi = "Psikoloji" },
                new Kategori { KategoriId = 13, KategoriAdi = "Ekonomi" },
                new Kategori { KategoriId = 14, KategoriAdi = "Politika" },
                new Kategori { KategoriId = 15, KategoriAdi = "Din" },
                new Kategori { KategoriId = 16, KategoriAdi = "Mitoloji" },
                new Kategori { KategoriId = 17, KategoriAdi = "Fantastik" },
                new Kategori { KategoriId = 18, KategoriAdi = "Bilim Kurgu" },
                new Kategori { KategoriId = 19, KategoriAdi = "Macera" },
                new Kategori { KategoriId = 20, KategoriAdi = "Korku" },
                new Kategori { KategoriId = 21, KategoriAdi = "Polisiye" },
                new Kategori { KategoriId = 22, KategoriAdi = "Dram" },
                new Kategori { KategoriId = 23, KategoriAdi = "Komedi" },
                new Kategori { KategoriId = 24, KategoriAdi = "Aşk" },
                new Kategori { KategoriId = 25, KategoriAdi = "Dünya Klasikleri" },
                new Kategori { KategoriId = 26, KategoriAdi = "Edebiyat" },
                new Kategori { KategoriId = 27, KategoriAdi = "Sağlık" },
                new Kategori { KategoriId = 28, KategoriAdi = "Yemek" },
                new Kategori { KategoriId = 29, KategoriAdi = "Spor" },
                new Kategori { KategoriId = 30, KategoriAdi = "Diğer" }

            );

        }
    }
}
