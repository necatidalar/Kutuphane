using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kutuphane.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ss : Migration
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
                    DilKodu = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
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
                    KategoriAdi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolAdi = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    RolKodu = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "Yayinevleri",
                columns: table => new
                {
                    YayineviId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    KurulusYili = table.Column<int>(type: "int", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
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
                    Ad = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlumTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlar", x => x.YazarId);
                });

            migrationBuilder.CreateTable(
                name: "Yetkiler",
                columns: table => new
                {
                    YetkiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YetkiKodu = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    YetkiAdi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetkiler", x => x.YetkiId);
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
                name: "RolYetkileri",
                columns: table => new
                {
                    RolYetkiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    YetkiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolYetkileri", x => x.RolYetkiId);
                    table.ForeignKey(
                        name: "FK_RolYetkileri_Roller_RolId",
                        column: x => x.RolId,
                        principalTable: "Roller",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolYetkileri_Yetkiler_YetkiId",
                        column: x => x.YetkiId,
                        principalTable: "Yetkiler",
                        principalColumn: "YetkiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonelRolleri",
                columns: table => new
                {
                    PersonelRolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelRolleri", x => x.PersonelRolId);
                    table.ForeignKey(
                        name: "FK_PersonelRolleri_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonelRolleri_Roller_RolId",
                        column: x => x.RolId,
                        principalTable: "Roller",
                        principalColumn: "RolId",
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
                columns: new[] { "DilId", "AktifMi", "DilAdi", "DilKodu" },
                values: new object[,]
                {
                    { (short)1, true, "Türkçe", "tr" },
                    { (short)2, true, "İngilizce", "en" },
                    { (short)3, true, "Almanca", "de" },
                    { (short)4, true, "Fransızca", "fr" },
                    { (short)5, true, "İspanyolca", "es" },
                    { (short)6, true, "İtalyanca", "it" },
                    { (short)7, true, "Rusça", "ru" },
                    { (short)8, true, "Çince", "zh" },
                    { (short)9, true, "Japonca", "ja" },
                    { (short)10, true, "Arapça", "ar" },
                    { (short)11, true, "Portekizce", "pt" },
                    { (short)12, true, "Hollandaca", "nl" },
                    { (short)13, true, "İsveççe", "sv" },
                    { (short)14, true, "Fince", "fi" },
                    { (short)15, true, "Danca", "da" },
                    { (short)16, true, "Norveççe", "no" },
                    { (short)17, true, "Macarca", "hu" },
                    { (short)18, true, "Lehçe", "pl" },
                    { (short)19, true, "Çekçe", "cs" },
                    { (short)20, true, "Rumence", "ro" },
                    { (short)21, true, "Yunanca", "el" },
                    { (short)22, true, "Korece", "ko" },
                    { (short)23, true, "Hintçe", "hi" },
                    { (short)24, true, "Tayca", "th" },
                    { (short)25, true, "Vietnamca", "vi" },
                    { (short)26, true, "Endonezce", "id" },
                    { (short)27, true, "Malayca", "ms" },
                    { (short)28, true, "Filipince", "tl" }
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
                table: "Roller",
                columns: new[] { "RolId", "AktifMi", "RolAdi", "RolKodu" },
                values: new object[,]
                {
                    { 1, true, "Admin", "ADMIN" },
                    { 2, true, "Personel", "PERSONEL" }
                });

            migrationBuilder.InsertData(
                table: "Yetkiler",
                columns: new[] { "YetkiId", "YetkiAdi", "YetkiKodu" },
                values: new object[,]
                {
                    { 1, "Dashboard", "DASHBOARD" },
                    { 2, "Kitap Listeleme", "KITAP_LISTELE" },
                    { 3, "Kitap Ekleme", "KITAP_EKLE" },
                    { 4, "Kitap Güncelleme", "KITAP_GUNCELLE" },
                    { 5, "Kitap Silme", "KITAP_SIL" },
                    { 6, "Kategori Listeleme", "KATEGORI_LISTELE" },
                    { 7, "Kategori Ekleme", "KATEGORI_EKLE" },
                    { 8, "Kategori Güncelleme", "KATEGORI_GUNCELLE" },
                    { 9, "Kategori Silme", "KATEGORI_SIL" },
                    { 10, "Yazar Listeleme", "YAZAR_LISTELE" },
                    { 11, "Yazar Ekleme", "YAZAR_EKLE" },
                    { 12, "Yazar Güncelleme", "YAZAR_GUNCELLE" },
                    { 13, "Yazar Silme", "YAZAR_SIL" },
                    { 14, "Yayınevi Listeleme", "YAYINEVI_LISTELE" },
                    { 15, "Yayınevi Ekleme", "YAYINEVI_EKLE" },
                    { 16, "Yayınevi Güncelleme", "YAYINEVI_GUNCELLE" },
                    { 17, "Yayınevi Silme", "YAYINEVI_SIL" },
                    { 18, "Dil Listeleme", "DIL_LISTELE" },
                    { 19, "Dil Ekleme", "DIL_EKLE" },
                    { 20, "Dil Güncelleme", "DIL_GUNCELLE" },
                    { 21, "Dil Silme", "DIL_SIL" },
                    { 22, "Ödünç Listeleme", "ODUNC_LISTELE" },
                    { 23, "Ödünç Verme", "ODUNC_VER" },
                    { 24, "İade Alma", "IADE_AL" },
                    { 25, "Üye Listeleme", "UYE_LISTELE" },
                    { 26, "Üye Ekleme", "UYE_EKLE" },
                    { 27, "Üye Güncelleme", "UYE_GUNCELLE" },
                    { 28, "Üye Silme", "UYE_SIL" },
                    { 29, "Personel Listeleme", "PERSONEL_LISTELE" },
                    { 30, "Personel Ekleme", "PERSONEL_EKLE" },
                    { 31, "Personel Güncelleme", "PERSONEL_GUNCELLE" },
                    { 32, "Personel Silme", "PERSONEL_SIL" },
                    { 33, "Yönetim Listeleme", "YONETIM_LISTELE" },
                    { 34, "Yönetim Ekleme", "YONETIM_EKLE" },
                    { 35, "Yönetim Güncelleme", "YONETIM_GUNCELLE" },
                    { 36, "Yönetim Silme", "YONETIM_SIL" },
                    { 37, "Raporlama", "RAPORLAMA" },
                    { 38, "Ayarlar", "AYARLAR" },
                    { 39, "Yerleşim Ayarları", "YERLESIM_AYARLARI" }
                });

            migrationBuilder.InsertData(
                table: "Personeller",
                columns: new[] { "PersonelId", "Ad", "AktifMi", "CinsiyetId", "KullaniciAdi", "Sifre", "Soyad" },
                values: new object[,]
                {
                    { 1, "Necati", true, (byte)1, "neco", "MTIzNDU=", "Dalar" },
                    { 2, "Necoş", true, (byte)1, "neci", "MTIz", "Dalmaz" }
                });

            migrationBuilder.InsertData(
                table: "RolYetkileri",
                columns: new[] { "RolYetkiId", "RolId", "YetkiId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 1, 7 },
                    { 8, 1, 8 },
                    { 9, 1, 9 },
                    { 10, 1, 10 },
                    { 11, 1, 11 },
                    { 12, 1, 12 },
                    { 13, 1, 13 },
                    { 14, 1, 14 },
                    { 15, 1, 15 },
                    { 16, 1, 16 },
                    { 17, 1, 17 },
                    { 18, 1, 18 },
                    { 19, 1, 19 },
                    { 20, 1, 20 },
                    { 21, 1, 21 },
                    { 22, 1, 22 },
                    { 23, 1, 23 },
                    { 24, 1, 24 },
                    { 25, 1, 25 },
                    { 26, 1, 26 },
                    { 27, 1, 27 },
                    { 28, 1, 28 },
                    { 29, 1, 29 },
                    { 30, 1, 30 },
                    { 31, 1, 31 },
                    { 32, 1, 32 },
                    { 33, 1, 33 },
                    { 34, 1, 34 },
                    { 35, 1, 35 },
                    { 36, 1, 36 },
                    { 37, 2, 1 },
                    { 38, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "PersonelRolleri",
                columns: new[] { "PersonelRolId", "PersonelId", "RolId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
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
                name: "IX_PersonelRolleri_PersonelId_RolId",
                table: "PersonelRolleri",
                columns: new[] { "PersonelId", "RolId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonelRolleri_RolId",
                table: "PersonelRolleri",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_Roller_RolAdi",
                table: "Roller",
                column: "RolAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolYetkileri_RolId_YetkiId",
                table: "RolYetkileri",
                columns: new[] { "RolId", "YetkiId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolYetkileri_YetkiId",
                table: "RolYetkileri",
                column: "YetkiId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Yetkiler_YetkiKodu",
                table: "Yetkiler",
                column: "YetkiKodu",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KitapKategori");

            migrationBuilder.DropTable(
                name: "Oduncler");

            migrationBuilder.DropTable(
                name: "PersonelRolleri");

            migrationBuilder.DropTable(
                name: "RolYetkileri");

            migrationBuilder.DropTable(
                name: "YayineviKitaplari");

            migrationBuilder.DropTable(
                name: "YazarKitaplari");

            migrationBuilder.DropTable(
                name: "Uyeler");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.DropTable(
                name: "Yetkiler");

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
