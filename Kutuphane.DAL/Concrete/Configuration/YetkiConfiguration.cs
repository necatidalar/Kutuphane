using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class YetkiConfiguration : IEntityTypeConfiguration<Yetki>
    {
        public void Configure(EntityTypeBuilder<Yetki> builder)
        {
            builder.ToTable("Yetkiler");

            builder.HasKey(x => x.YetkiId);

            builder.Property(x => x.YetkiId)
                   .UseIdentityColumn();

            builder.Property(x => x.YetkiKodu)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(x => x.YetkiAdi)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.HasIndex(x => x.YetkiKodu).IsUnique();

            builder.HasData(
                new Yetki { YetkiId = 1, YetkiAdi = "Dashboard", YetkiKodu = "DASHBOARD" },

                new Yetki { YetkiId = 2, YetkiAdi = "Kitap Listeleme", YetkiKodu = "KITAP_LISTELE" },
                new Yetki { YetkiId = 3, YetkiAdi = "Kitap Ekleme", YetkiKodu = "KITAP_EKLE" },
                new Yetki { YetkiId = 4, YetkiAdi = "Kitap Güncelleme", YetkiKodu = "KITAP_GUNCELLE" },
                new Yetki { YetkiId = 5, YetkiAdi = "Kitap Silme", YetkiKodu = "KITAP_SIL" },

                new Yetki { YetkiId = 6, YetkiAdi = "Kategori Listeleme", YetkiKodu = "KATEGORI_LISTELE" },
                new Yetki { YetkiId = 7, YetkiAdi = "Kategori Ekleme", YetkiKodu = "KATEGORI_EKLE" },
                new Yetki { YetkiId = 8, YetkiAdi = "Kategori Güncelleme", YetkiKodu = "KATEGORI_GUNCELLE" },
                new Yetki { YetkiId = 9, YetkiAdi = "Kategori Silme", YetkiKodu = "KATEGORI_SIL" },

                new Yetki { YetkiId = 10, YetkiAdi = "Yazar Listeleme", YetkiKodu = "YAZAR_LISTELE" },
                new Yetki { YetkiId = 11, YetkiAdi = "Yazar Ekleme", YetkiKodu = "YAZAR_EKLE" },
                new Yetki { YetkiId = 12, YetkiAdi = "Yazar Güncelleme", YetkiKodu = "YAZAR_GUNCELLE" },
                new Yetki { YetkiId = 13, YetkiAdi = "Yazar Silme", YetkiKodu = "YAZAR_SIL" },

                new Yetki { YetkiId = 14, YetkiAdi = "Yayınevi Listeleme", YetkiKodu = "YAYINEVI_LISTELE" },
                new Yetki { YetkiId = 15, YetkiAdi = "Yayınevi Ekleme", YetkiKodu = "YAYINEVI_EKLE" },
                new Yetki { YetkiId = 16, YetkiAdi = "Yayınevi Güncelleme", YetkiKodu = "YAYINEVI_GUNCELLE" },
                new Yetki { YetkiId = 17, YetkiAdi = "Yayınevi Silme", YetkiKodu = "YAYINEVI_SIL" },

                new Yetki { YetkiId = 18, YetkiAdi = "Dil Listeleme", YetkiKodu = "DIL_LISTELE" },
                new Yetki { YetkiId = 19, YetkiAdi = "Dil Ekleme", YetkiKodu = "DIL_EKLE" },
                new Yetki { YetkiId = 20, YetkiAdi = "Dil Güncelleme", YetkiKodu = "DIL_GUNCELLE" },
                new Yetki { YetkiId = 21, YetkiAdi = "Dil Silme", YetkiKodu = "DIL_SIL" },

                new Yetki { YetkiId = 22, YetkiAdi = "Ödünç Listeleme", YetkiKodu = "ODUNC_LISTELE" },
                new Yetki { YetkiId = 23, YetkiAdi = "Ödünç Verme", YetkiKodu = "ODUNC_VER" },
                new Yetki { YetkiId = 24, YetkiAdi = "İade Alma", YetkiKodu = "IADE_AL" },

                new Yetki { YetkiId = 25, YetkiAdi = "Üye Listeleme", YetkiKodu = "UYE_LISTELE" },
                new Yetki { YetkiId = 26, YetkiAdi = "Üye Ekleme", YetkiKodu = "UYE_EKLE" },
                new Yetki { YetkiId = 27, YetkiAdi = "Üye Güncelleme", YetkiKodu = "UYE_GUNCELLE" },
                new Yetki { YetkiId = 28, YetkiAdi = "Üye Silme", YetkiKodu = "UYE_SIL" },

                new Yetki { YetkiId = 29, YetkiAdi = "Personel Listeleme", YetkiKodu = "PERSONEL_LISTELE" },
                new Yetki { YetkiId = 30, YetkiAdi = "Personel Ekleme", YetkiKodu = "PERSONEL_EKLE" },
                new Yetki { YetkiId = 31, YetkiAdi = "Personel Güncelleme", YetkiKodu = "PERSONEL_GUNCELLE" },
                new Yetki { YetkiId = 32, YetkiAdi = "Personel Silme", YetkiKodu = "PERSONEL_SIL" },

                new Yetki { YetkiId = 33, YetkiAdi = "Yönetim Listeleme", YetkiKodu = "YONETIM_LISTELE" },
                new Yetki { YetkiId = 34, YetkiAdi = "Yönetim Ekleme", YetkiKodu = "YONETIM_EKLE" },
                new Yetki { YetkiId = 35, YetkiAdi = "Yönetim Güncelleme", YetkiKodu = "YONETIM_GUNCELLE" },
                new Yetki { YetkiId = 36, YetkiAdi = "Yönetim Silme", YetkiKodu = "YONETIM_SIL" }
            );
        }
    }
}