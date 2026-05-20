/*
    Okul kütüphanesi öğrenci alanları güncelleme scripti
    Mevcut verileri silmez. Uyeler tablosuna okul kütüphanesi için gerekli alanları ekler.

    Not:
    SQL Server aynı batch içinde yeni eklenen bir kolonu CREATE INDEX filtre koşulunda
    derleme anında göremeyebilir. Bu yüzden index oluşturma kısmı dinamik SQL ile yazıldı.
    Script tekrar tekrar çalıştırılabilir.
*/

IF OBJECT_ID(N'dbo.Uyeler', N'U') IS NULL
BEGIN
    RAISERROR('dbo.Uyeler tablosu bulunamadı. Önce ana veritabanı tablolarını oluşturun.', 16, 1);
    RETURN;
END;

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

IF COL_LENGTH('dbo.Uyeler', 'OkulNo') IS NOT NULL
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
END;
