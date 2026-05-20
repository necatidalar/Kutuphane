using Kutuphane.DAL.Contexes;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kutuphane.DAL.Migrations
{
    /// <inheritdoc />
    [DbContext(typeof(KutuphaneDbContext))]
    [Migration("20260520180000_OkulKutuphaneOgrenciAlanlari")]
    public partial class OkulKutuphaneOgrenciAlanlari : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Bu migration bilinçli olarak idempotent SQL ile yazıldı.
            // Böylece kullanıcı SQL scriptini daha önce elle çalıştırmış olsa bile
            // Update-Database tekrar kolon eklemeye çalışıp hata vermez.
            migrationBuilder.Sql(@"
IF OBJECT_ID(N'dbo.Uyeler', N'U') IS NOT NULL
BEGIN
    IF COL_LENGTH('dbo.Uyeler', 'OkulNo') IS NULL
        ALTER TABLE dbo.Uyeler ADD OkulNo varchar(20) NULL;

    IF COL_LENGTH('dbo.Uyeler', 'Sinif') IS NULL
        ALTER TABLE dbo.Uyeler ADD Sinif nvarchar(20) NULL;

    IF COL_LENGTH('dbo.Uyeler', 'Sube') IS NULL
        ALTER TABLE dbo.Uyeler ADD Sube nvarchar(10) NULL;

    IF COL_LENGTH('dbo.Uyeler', 'VeliAdSoyad') IS NULL
        ALTER TABLE dbo.Uyeler ADD VeliAdSoyad nvarchar(100) NULL;

    IF COL_LENGTH('dbo.Uyeler', 'VeliTelefon') IS NULL
        ALTER TABLE dbo.Uyeler ADD VeliTelefon varchar(15) NULL;
END
");

            // SQL Server aynı batch içinde yeni eklenen OkulNo kolonunu filtreli indexte
            // derleme anında göremeyebileceği için CREATE INDEX dinamik SQL ile çalıştırılır.
            migrationBuilder.Sql(@"
IF OBJECT_ID(N'dbo.Uyeler', N'U') IS NOT NULL
   AND COL_LENGTH('dbo.Uyeler', 'OkulNo') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'IX_Uyeler_OkulNo'
          AND object_id = OBJECT_ID('dbo.Uyeler')
   )
BEGIN
    EXEC(N'CREATE UNIQUE NONCLUSTERED INDEX IX_Uyeler_OkulNo
           ON dbo.Uyeler(OkulNo)
           WHERE OkulNo IS NOT NULL AND OkulNo <> '''';');
END
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
IF OBJECT_ID(N'dbo.Uyeler', N'U') IS NOT NULL
BEGIN
    IF EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'IX_Uyeler_OkulNo'
          AND object_id = OBJECT_ID('dbo.Uyeler')
    )
        DROP INDEX IX_Uyeler_OkulNo ON dbo.Uyeler;

    IF COL_LENGTH('dbo.Uyeler', 'VeliTelefon') IS NOT NULL
        ALTER TABLE dbo.Uyeler DROP COLUMN VeliTelefon;

    IF COL_LENGTH('dbo.Uyeler', 'VeliAdSoyad') IS NOT NULL
        ALTER TABLE dbo.Uyeler DROP COLUMN VeliAdSoyad;

    IF COL_LENGTH('dbo.Uyeler', 'Sube') IS NOT NULL
        ALTER TABLE dbo.Uyeler DROP COLUMN Sube;

    IF COL_LENGTH('dbo.Uyeler', 'Sinif') IS NOT NULL
        ALTER TABLE dbo.Uyeler DROP COLUMN Sinif;

    IF COL_LENGTH('dbo.Uyeler', 'OkulNo') IS NOT NULL
        ALTER TABLE dbo.Uyeler DROP COLUMN OkulNo;
END
");
        }
    }
}
