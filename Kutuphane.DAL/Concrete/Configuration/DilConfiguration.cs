

using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kutuphane.DAL.Concrete.Configuration
{
    public class DilConfiguration : IEntityTypeConfiguration<Dil>
    {
        public void Configure(EntityTypeBuilder<Dil> builder)
        {
            builder.HasKey(d => d.DilId);
            builder.Property(d => d.DilId).HasColumnType("smallint");
            builder.Property(d => d.DilAdi)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(25);
            builder.Property(d => d.DilKodu)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(5);
            builder.HasData(
                new Dil { DilId = 1, DilAdi = "Türkçe", DilKodu = "tr" },
                new Dil { DilId = 2, DilAdi = "İngilizce", DilKodu = "en" },
                new Dil { DilId = 3, DilAdi = "Almanca", DilKodu = "de" },
                new Dil { DilId = 4, DilAdi = "Fransızca", DilKodu = "fr" },
                new Dil { DilId = 5, DilAdi = "İspanyolca", DilKodu = "es" },
                new Dil { DilId = 6, DilAdi = "İtalyanca", DilKodu = "it" },
                new Dil { DilId = 7, DilAdi = "Rusça", DilKodu = "ru" },
                new Dil { DilId = 8, DilAdi = "Çince", DilKodu = "zh" },
                new Dil { DilId = 9, DilAdi = "Japonca", DilKodu = "ja" },
                new Dil { DilId = 10, DilAdi = "Arapça", DilKodu = "ar" },
                new Dil { DilId = 11, DilAdi = "Portekizce", DilKodu = "pt" },
                new Dil { DilId = 12, DilAdi = "Hollandaca", DilKodu = "nl" },
                new Dil { DilId = 13, DilAdi = "İsveççe", DilKodu = "sv" },
                new Dil { DilId = 14, DilAdi = "Fince", DilKodu = "fi" },
                new Dil { DilId = 15, DilAdi = "Danca", DilKodu = "da" },
                new Dil { DilId = 16, DilAdi = "Norveççe", DilKodu = "no" },
                new Dil { DilId = 17, DilAdi = "Macarca", DilKodu = "hu" },
                new Dil { DilId = 18, DilAdi = "Lehçe", DilKodu = "pl" },
                new Dil { DilId = 19, DilAdi = "Çekçe", DilKodu = "cs" },
                new Dil { DilId = 20, DilAdi = "Rumence", DilKodu = "ro" },
                new Dil { DilId = 21, DilAdi = "Yunanca", DilKodu = "el" },
                new Dil { DilId = 22, DilAdi = "Korece", DilKodu = "ko" },
                new Dil { DilId = 23, DilAdi = "Hintçe", DilKodu = "hi" },
                new Dil { DilId = 24, DilAdi = "Tayca", DilKodu = "th" },
                new Dil { DilId = 25, DilAdi = "Vietnamca", DilKodu = "vi" },
                new Dil { DilId = 26, DilAdi = "Endonezce", DilKodu = "id" },
                new Dil { DilId = 27, DilAdi = "Malayca", DilKodu = "ms" },
                new Dil { DilId = 28, DilAdi = "Filipince", DilKodu = "tl" }

            );
        }
    
    }
}
