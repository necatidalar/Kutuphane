using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kutuphane.DAL.Migrations
{
    /// <inheritdoc />
    public partial class d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinsiyetler",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    CinsiyetAdi = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinsiyetler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diller",
                columns: table => new
                {
                    DilId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DilAdi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DilKodu = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diller", x => x.DilId);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Yayinevleri",
                columns: table => new
                {
                    YayineviId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    KurulusYili = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yayinevleri", x => x.YayineviId);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlar",
                columns: table => new
                {
                    YazarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlar", x => x.YazarId);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CinsiyetId = table.Column<byte>(type: "tinyint", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_Personeller_Cinsiyetler_CinsiyetId",
                        column: x => x.CinsiyetId,
                        principalTable: "Cinsiyetler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    UyeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TcPass = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CinsiyetId = table.Column<byte>(type: "tinyint", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    Telefon = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AdresDetay = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.UyeId);
                    table.ForeignKey(
                        name: "FK_Uyeler_Cinsiyetler_CinsiyetId",
                        column: x => x.CinsiyetId,
                        principalTable: "Cinsiyetler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    KitapId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAdi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    YazarId = table.Column<int>(type: "int", nullable: false),
                    YayineviId = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    BasimYili = table.Column<int>(type: "int", nullable: true),
                    SayfaSayisi = table.Column<int>(type: "int", nullable: true),
                    DilId = table.Column<short>(type: "smallint", nullable: false),
                    Stok = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Aktif = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.KitapId);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Diller_DilId",
                        column: x => x.DilId,
                        principalTable: "Diller",
                        principalColumn: "DilId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Yayinevleri_YayineviId",
                        column: x => x.YayineviId,
                        principalTable: "Yayinevleri",
                        principalColumn: "YayineviId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Yazarlar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazarlar",
                        principalColumn: "YazarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapId = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapKategori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KitapKategori_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriId");
                    table.ForeignKey(
                        name: "FK_KitapKategori_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapId");
                });

            migrationBuilder.CreateTable(
                name: "Oduncler",
                columns: table => new
                {
                    OduncId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeId = table.Column<int>(type: "int", nullable: false),
                    KitapId = table.Column<int>(type: "int", nullable: false),
                    AlisTarihi = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    TeslimTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    TeslimEdildi = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    TeslimEdenPersonelId = table.Column<int>(type: "int", nullable: false),
                    TeslimAlanPersonelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oduncler", x => x.OduncId);
                    table.ForeignKey(
                        name: "FK_Oduncler_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Oduncler_Personeller_TeslimAlanPersonelId",
                        column: x => x.TeslimAlanPersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelId");
                    table.ForeignKey(
                        name: "FK_Oduncler_Personeller_TeslimEdenPersonelId",
                        column: x => x.TeslimEdenPersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelId");
                    table.ForeignKey(
                        name: "FK_Oduncler_Uyeler_UyeId",
                        column: x => x.UyeId,
                        principalTable: "Uyeler",
                        principalColumn: "UyeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "YayineviKitaplari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayineviId = table.Column<int>(type: "int", nullable: false),
                    KitapId = table.Column<int>(type: "int", nullable: false),
                    DonemBaslangici = table.Column<DateTime>(type: "datetime", nullable: false),
                    DonemBitisi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YayineviKitaplari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YayineviKitaplari_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapId");
                    table.ForeignKey(
                        name: "FK_YayineviKitaplari_Yayinevleri_YayineviId",
                        column: x => x.YayineviId,
                        principalTable: "Yayinevleri",
                        principalColumn: "YayineviId");
                });

            migrationBuilder.CreateTable(
                name: "YazarKitaplari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarId = table.Column<int>(type: "int", nullable: false),
                    KitapId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YazarKitaplari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YazarKitaplari_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapId");
                    table.ForeignKey(
                        name: "FK_YazarKitaplari_Yazarlar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazarlar",
                        principalColumn: "YazarId");
                });

            migrationBuilder.InsertData(
                table: "Cinsiyetler",
                columns: new[] { "Id", "CinsiyetAdi" },
                values: new object[,]
                {
                    { (byte)1, "Erkek" },
                    { (byte)2, "Kadın" },
                    { (byte)3, "Belirtilmemiş" }
                });

            migrationBuilder.InsertData(
                table: "Diller",
                columns: new[] { "DilId", "DilAdi", "DilKodu" },
                values: new object[,]
                {
                    { (short)1, "Türkçe", "tr" },
                    { (short)2, "İngilizce", "en" },
                    { (short)3, "Almanca", "de" },
                    { (short)4, "Fransızca", "fr" },
                    { (short)5, "İspanyolca", "es" },
                    { (short)6, "İtalyanca", "it" },
                    { (short)7, "Rusça", "ru" },
                    { (short)8, "Çince", "zh" },
                    { (short)9, "Japonca", "ja" },
                    { (short)10, "Arapça", "ar" },
                    { (short)11, "Portekizce", "pt" },
                    { (short)12, "Hollandaca", "nl" },
                    { (short)13, "İsveççe", "sv" },
                    { (short)14, "Fince", "fi" },
                    { (short)15, "Danca", "da" },
                    { (short)16, "Norveççe", "no" },
                    { (short)17, "Macarca", "hu" },
                    { (short)18, "Lehçe", "pl" },
                    { (short)19, "Çekçe", "cs" },
                    { (short)20, "Rumence", "ro" },
                    { (short)21, "Yunanca", "el" },
                    { (short)22, "Korece", "ko" },
                    { (short)23, "Hintçe", "hi" },
                    { (short)24, "Tayca", "th" },
                    { (short)25, "Vietnamca", "vi" },
                    { (short)26, "Endonezce", "id" },
                    { (short)27, "Malayca", "ms" },
                    { (short)28, "Filipince", "tl" }
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriId", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "Roman" },
                    { 2, "Hikaye" },
                    { 3, "Şiir" },
                    { 4, "Tarih" },
                    { 5, "Bilim" },
                    { 6, "Sanat" },
                    { 7, "Felsefe" },
                    { 8, "Çocuk" },
                    { 9, "Gezi" },
                    { 10, "Biyografi" },
                    { 11, "Kişisel Gelişim" },
                    { 12, "Psikoloji" },
                    { 13, "Ekonomi" },
                    { 14, "Politika" },
                    { 15, "Din" },
                    { 16, "Mitoloji" },
                    { 17, "Fantastik" },
                    { 18, "Bilim Kurgu" },
                    { 19, "Macera" },
                    { 20, "Korku" },
                    { 21, "Polisiye" },
                    { 22, "Dram" },
                    { 23, "Komedi" },
                    { 24, "Aşk" },
                    { 25, "Dünya Klasikleri" },
                    { 26, "Edebiyat" },
                    { 27, "Sağlık" },
                    { 28, "Yemek" },
                    { 29, "Spor" },
                    { 30, "Diğer" }
                });

            migrationBuilder.InsertData(
                table: "Personeller",
                columns: new[] { "PersonelId", "Ad", "AktifMi", "CinsiyetId", "KullaniciAdi", "Sifre", "Soyad" },
                values: new object[,]
                {
                    { 1, "Necati", true, (byte)1, "neco", "MTIzNDU=", "Dalar" },
                    { 2, "Necoş", true, (byte)1, "neci", "MTIz", "Dalmaz" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KitapKategori_KategoriId",
                table: "KitapKategori",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_KitapKategori_KitapId",
                table: "KitapKategori",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_DilId",
                table: "Kitaplar",
                column: "DilId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KategoriId",
                table: "Kitaplar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_YayineviId",
                table: "Kitaplar",
                column: "YayineviId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_YazarId",
                table: "Kitaplar",
                column: "YazarId");

            migrationBuilder.CreateIndex(
                name: "IX_Oduncler_KitapId",
                table: "Oduncler",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_Oduncler_TeslimAlanPersonelId",
                table: "Oduncler",
                column: "TeslimAlanPersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Oduncler_TeslimEdenPersonelId",
                table: "Oduncler",
                column: "TeslimEdenPersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Oduncler_UyeId",
                table: "Oduncler",
                column: "UyeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_CinsiyetId",
                table: "Personeller",
                column: "CinsiyetId");

            migrationBuilder.CreateIndex(
                name: "IX_Uyeler_CinsiyetId",
                table: "Uyeler",
                column: "CinsiyetId");

            migrationBuilder.CreateIndex(
                name: "IX_YayineviKitaplari_KitapId",
                table: "YayineviKitaplari",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_YayineviKitaplari_YayineviId",
                table: "YayineviKitaplari",
                column: "YayineviId");

            migrationBuilder.CreateIndex(
                name: "IX_YazarKitaplari_KitapId",
                table: "YazarKitaplari",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_YazarKitaplari_YazarId",
                table: "YazarKitaplari",
                column: "YazarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KitapKategori");

            migrationBuilder.DropTable(
                name: "Oduncler");

            migrationBuilder.DropTable(
                name: "YayineviKitaplari");

            migrationBuilder.DropTable(
                name: "YazarKitaplari");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Uyeler");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Cinsiyetler");

            migrationBuilder.DropTable(
                name: "Diller");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Yayinevleri");

            migrationBuilder.DropTable(
                name: "Yazarlar");
        }
    }
}
