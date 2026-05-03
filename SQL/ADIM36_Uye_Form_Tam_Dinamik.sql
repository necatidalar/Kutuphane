USE [KutuphaneOtomasyonu];
GO

/* =========================================================
   ADIM 36 EK - Üye formundaki TÜM alanları ayarlanabilir yapma
   Amaç:
   - Sabit üye alanlarını AlanTanimlari içine sistem alanı olarak ekler.
   - FormAlanAyarlari ekranında TC, Ad, Soyad, Cinsiyet, Doğum Tarihi,
     Telefon, E-Posta, Adres, Adres Detay dahil tüm alanlar yönetilir.
   - Görünür, zorunlu, değiştirilebilir, listede görünsün ve sıra ayarları
     hem sabit alanlara hem dinamik ek alanlara uygulanabilir.
========================================================= */

IF OBJECT_ID(N'dbo.AlanTanimlari', N'U') IS NULL
BEGIN
    RAISERROR(N'AlanTanimlari tablosu yok. Önce dinamik alan altyapısı kurulmalı.', 16, 1);
    RETURN;
END;
GO

IF OBJECT_ID(N'dbo.FormAlanAyarlari', N'U') IS NULL
BEGIN
    RAISERROR(N'FormAlanAyarlari tablosu yok. Önce ADIM 36 SQL scripti çalışmalı.', 16, 1);
    RETURN;
END;
GO

IF OBJECT_ID(N'dbo.UyeTipleri', N'U') IS NULL
BEGIN
    RAISERROR(N'UyeTipleri tablosu yok.', 16, 1);
    RETURN;
END;
GO

DECLARE @KurumId INT = 1;
DECLARE @FormKodu VARCHAR(100) = 'UYE_FORM';

/* ---------------------------------------------------------
   1) Sabit üye alanlarını sistem alanı olarak tanımla
--------------------------------------------------------- */
MERGE dbo.AlanTanimlari AS T
USING
(
    VALUES
    ('UYE', 'TC_PASS',       N'TC/Pas No',      'TEXT',   20, 1, 1, 10),
    ('UYE', 'AD',            N'Ad',             'TEXT',   50, 1, 1, 20),
    ('UYE', 'SOYAD',         N'Soyad',          'TEXT',   50, 1, 1, 30),
    ('UYE', 'CINSIYET',      N'Cinsiyet',       'SELECT', 15, 1, 1, 40),
    ('UYE', 'DOGUM_TARIHI',  N'Doğum Tarihi',   'DATE', NULL, 1, 1, 50),
    ('UYE', 'TELEFON',       N'Telefon',        'TEXT',   15, 1, 1, 60),
    ('UYE', 'EPOSTA',        N'E-Posta',        'TEXT',  100, 1, 1, 70),
    ('UYE', 'ADRES',         N'Adres',          'TEXT',  200, 1, 1, 80),
    ('UYE', 'ADRES_DETAY',   N'Adres Detay',    'TEXT',  500, 1, 1, 90)
) AS S(EntityAdi, AlanKodu, AlanAdi, VeriTipi, MaxLength, SistemAlaniMi, AktifMi, VarsayilanSiraNo)
ON T.EntityAdi = S.EntityAdi
AND T.AlanKodu = S.AlanKodu
WHEN MATCHED THEN
    UPDATE SET
        T.AlanAdi = S.AlanAdi,
        T.VeriTipi = S.VeriTipi,
        T.MaxLength = S.MaxLength,
        T.SistemAlaniMi = S.SistemAlaniMi,
        T.AktifMi = S.AktifMi,
        T.GuncellemeTarihi = GETDATE()
WHEN NOT MATCHED THEN
    INSERT
    (
        EntityAdi,
        AlanKodu,
        AlanAdi,
        VeriTipi,
        MaxLength,
        SistemAlaniMi,
        AktifMi,
        OlusturmaTarihi
    )
    VALUES
    (
        S.EntityAdi,
        S.AlanKodu,
        S.AlanAdi,
        S.VeriTipi,
        S.MaxLength,
        S.SistemAlaniMi,
        S.AktifMi,
        GETDATE()
    );
GO

/* ---------------------------------------------------------
   2) Genel ayarlar: UyeTipiId NULL
--------------------------------------------------------- */
DECLARE @KurumIdGenel INT = 1;
DECLARE @FormKoduGenel VARCHAR(100) = 'UYE_FORM';

;WITH Alanlar AS
(
    SELECT
        @KurumIdGenel AS KurumId,
        CAST(NULL AS INT) AS UyeTipiId,
        @FormKoduGenel AS FormKodu,
        at.AlanTanimId,
        at.AlanKodu,
        1 AS GorunurMu,
        CASE
            WHEN at.AlanKodu IN ('TC_PASS', 'AD', 'SOYAD', 'CINSIYET', 'DOGUM_TARIHI', 'TELEFON', 'EPOSTA', 'ADRES', 'ADRES_DETAY') THEN 1
            ELSE 0
        END AS ZorunluMu,
        1 AS DegistirilebilirMi,
        CASE
            WHEN at.AlanKodu IN ('TC_PASS', 'AD', 'SOYAD', 'CINSIYET', 'DOGUM_TARIHI', 'TELEFON', 'EPOSTA', 'ADRES') THEN 1
            WHEN at.AlanKodu IN ('OKUL_NO', 'SINIF', 'SUBE', 'VELI_ADI', 'VELI_TELEFONU', 'BRANS', 'SICIL_NO') THEN 1
            ELSE 0
        END AS ListedeGorunsunMu,
        CASE at.AlanKodu
            WHEN 'TC_PASS' THEN 10
            WHEN 'AD' THEN 20
            WHEN 'SOYAD' THEN 30
            WHEN 'CINSIYET' THEN 40
            WHEN 'DOGUM_TARIHI' THEN 50
            WHEN 'TELEFON' THEN 60
            WHEN 'EPOSTA' THEN 70
            WHEN 'ADRES' THEN 80
            WHEN 'ADRES_DETAY' THEN 90
            WHEN 'OKUL_NO' THEN 110
            WHEN 'SINIF' THEN 120
            WHEN 'SUBE' THEN 130
            WHEN 'VELI_ADI' THEN 140
            WHEN 'VELI_TELEFONU' THEN 150
            WHEN 'BRANS' THEN 160
            WHEN 'SICIL_NO' THEN 170
            WHEN 'UYE_NOTU' THEN 180
            ELSE 300 + ROW_NUMBER() OVER (ORDER BY at.AlanTanimId)
        END AS SiraNo
    FROM dbo.AlanTanimlari at
    WHERE at.EntityAdi = 'UYE'
      AND at.AktifMi = 1
)
MERGE dbo.FormAlanAyarlari AS T
USING Alanlar AS S
ON T.KurumId = S.KurumId
AND T.UyeTipiId IS NULL
AND T.FormKodu = S.FormKodu
AND T.AlanTanimId = S.AlanTanimId
WHEN MATCHED THEN
    UPDATE SET
        T.GorunurMu = S.GorunurMu,
        T.ZorunluMu = S.ZorunluMu,
        T.DegistirilebilirMi = S.DegistirilebilirMi,
        T.ListedeGorunsunMu = S.ListedeGorunsunMu,
        T.SiraNo = S.SiraNo,
        T.AktifMi = 1,
        T.GuncellemeTarihi = GETDATE()
WHEN NOT MATCHED THEN
    INSERT
    (
        KurumId,
        UyeTipiId,
        FormKodu,
        AlanTanimId,
        GorunurMu,
        ZorunluMu,
        DegistirilebilirMi,
        ListedeGorunsunMu,
        SiraNo,
        AktifMi,
        OlusturmaTarihi
    )
    VALUES
    (
        S.KurumId,
        S.UyeTipiId,
        S.FormKodu,
        S.AlanTanimId,
        S.GorunurMu,
        S.ZorunluMu,
        S.DegistirilebilirMi,
        S.ListedeGorunsunMu,
        S.SiraNo,
        1,
        GETDATE()
    );
GO

/* ---------------------------------------------------------
   3) Öğrenci özel ayarı
--------------------------------------------------------- */
DECLARE @KurumIdOgrenci INT = 1;
DECLARE @FormKoduOgrenci VARCHAR(100) = 'UYE_FORM';
DECLARE @OgrenciUyeTipiId INT;

SELECT TOP 1 @OgrenciUyeTipiId = UyeTipiId
FROM dbo.UyeTipleri
WHERE AktifMi = 1
  AND UyeTipiKodu = 'OGRENCI';

IF @OgrenciUyeTipiId IS NOT NULL
BEGIN
    ;WITH Alanlar AS
    (
        SELECT
            @KurumIdOgrenci AS KurumId,
            @OgrenciUyeTipiId AS UyeTipiId,
            @FormKoduOgrenci AS FormKodu,
            at.AlanTanimId,
            at.AlanKodu,
            CASE
                WHEN at.AlanKodu IN ('BRANS', 'SICIL_NO') THEN 0
                ELSE 1
            END AS GorunurMu,
            CASE
                WHEN at.AlanKodu IN ('TC_PASS', 'AD', 'SOYAD', 'CINSIYET', 'DOGUM_TARIHI', 'TELEFON', 'EPOSTA', 'ADRES', 'ADRES_DETAY', 'OKUL_NO', 'SINIF', 'SUBE') THEN 1
                ELSE 0
            END AS ZorunluMu,
            1 AS DegistirilebilirMi,
            CASE
                WHEN at.AlanKodu IN ('TC_PASS', 'AD', 'SOYAD', 'CINSIYET', 'DOGUM_TARIHI', 'TELEFON', 'EPOSTA', 'OKUL_NO', 'SINIF', 'SUBE', 'VELI_ADI', 'VELI_TELEFONU') THEN 1
                ELSE 0
            END AS ListedeGorunsunMu,
            CASE at.AlanKodu
                WHEN 'TC_PASS' THEN 10
                WHEN 'AD' THEN 20
                WHEN 'SOYAD' THEN 30
                WHEN 'CINSIYET' THEN 40
                WHEN 'DOGUM_TARIHI' THEN 50
                WHEN 'TELEFON' THEN 60
                WHEN 'EPOSTA' THEN 70
                WHEN 'ADRES' THEN 80
                WHEN 'ADRES_DETAY' THEN 90
                WHEN 'OKUL_NO' THEN 110
                WHEN 'SINIF' THEN 120
                WHEN 'SUBE' THEN 130
                WHEN 'VELI_ADI' THEN 140
                WHEN 'VELI_TELEFONU' THEN 150
                WHEN 'UYE_NOTU' THEN 160
                WHEN 'BRANS' THEN 900
                WHEN 'SICIL_NO' THEN 910
                ELSE 300 + ROW_NUMBER() OVER (ORDER BY at.AlanTanimId)
            END AS SiraNo
        FROM dbo.AlanTanimlari at
        WHERE at.EntityAdi = 'UYE'
          AND at.AktifMi = 1
    )
    MERGE dbo.FormAlanAyarlari AS T
    USING Alanlar AS S
    ON T.KurumId = S.KurumId
    AND T.UyeTipiId = S.UyeTipiId
    AND T.FormKodu = S.FormKodu
    AND T.AlanTanimId = S.AlanTanimId
    WHEN MATCHED THEN
        UPDATE SET
            T.GorunurMu = S.GorunurMu,
            T.ZorunluMu = CASE WHEN S.GorunurMu = 0 THEN 0 ELSE S.ZorunluMu END,
            T.DegistirilebilirMi = S.DegistirilebilirMi,
            T.ListedeGorunsunMu = CASE WHEN S.GorunurMu = 0 THEN 0 ELSE S.ListedeGorunsunMu END,
            T.SiraNo = S.SiraNo,
            T.AktifMi = 1,
            T.GuncellemeTarihi = GETDATE()
    WHEN NOT MATCHED THEN
        INSERT
        (
            KurumId,
            UyeTipiId,
            FormKodu,
            AlanTanimId,
            GorunurMu,
            ZorunluMu,
            DegistirilebilirMi,
            ListedeGorunsunMu,
            SiraNo,
            AktifMi,
            OlusturmaTarihi
        )
        VALUES
        (
            S.KurumId,
            S.UyeTipiId,
            S.FormKodu,
            S.AlanTanimId,
            S.GorunurMu,
            CASE WHEN S.GorunurMu = 0 THEN 0 ELSE S.ZorunluMu END,
            S.DegistirilebilirMi,
            CASE WHEN S.GorunurMu = 0 THEN 0 ELSE S.ListedeGorunsunMu END,
            S.SiraNo,
            1,
            GETDATE()
        );
END;
GO

/* ---------------------------------------------------------
   4) Öğretmen özel ayarı
--------------------------------------------------------- */
DECLARE @KurumIdOgretmen INT = 1;
DECLARE @FormKoduOgretmen VARCHAR(100) = 'UYE_FORM';
DECLARE @OgretmenUyeTipiId INT;

SELECT TOP 1 @OgretmenUyeTipiId = UyeTipiId
FROM dbo.UyeTipleri
WHERE AktifMi = 1
  AND UyeTipiKodu = 'OGRETMEN';

IF @OgretmenUyeTipiId IS NOT NULL
BEGIN
    ;WITH Alanlar AS
    (
        SELECT
            @KurumIdOgretmen AS KurumId,
            @OgretmenUyeTipiId AS UyeTipiId,
            @FormKoduOgretmen AS FormKodu,
            at.AlanTanimId,
            at.AlanKodu,
            CASE
                WHEN at.AlanKodu IN ('OKUL_NO', 'SINIF', 'SUBE', 'VELI_ADI', 'VELI_TELEFONU') THEN 0
                ELSE 1
            END AS GorunurMu,
            CASE
                WHEN at.AlanKodu IN ('TC_PASS', 'AD', 'SOYAD', 'CINSIYET', 'DOGUM_TARIHI', 'TELEFON', 'EPOSTA', 'ADRES', 'ADRES_DETAY', 'BRANS', 'SICIL_NO') THEN 1
                ELSE 0
            END AS ZorunluMu,
            1 AS DegistirilebilirMi,
            CASE
                WHEN at.AlanKodu IN ('TC_PASS', 'AD', 'SOYAD', 'CINSIYET', 'DOGUM_TARIHI', 'TELEFON', 'EPOSTA', 'BRANS', 'SICIL_NO') THEN 1
                ELSE 0
            END AS ListedeGorunsunMu,
            CASE at.AlanKodu
                WHEN 'TC_PASS' THEN 10
                WHEN 'AD' THEN 20
                WHEN 'SOYAD' THEN 30
                WHEN 'CINSIYET' THEN 40
                WHEN 'DOGUM_TARIHI' THEN 50
                WHEN 'TELEFON' THEN 60
                WHEN 'EPOSTA' THEN 70
                WHEN 'ADRES' THEN 80
                WHEN 'ADRES_DETAY' THEN 90
                WHEN 'BRANS' THEN 110
                WHEN 'SICIL_NO' THEN 120
                WHEN 'UYE_NOTU' THEN 130
                WHEN 'OKUL_NO' THEN 900
                WHEN 'SINIF' THEN 910
                WHEN 'SUBE' THEN 920
                WHEN 'VELI_ADI' THEN 930
                WHEN 'VELI_TELEFONU' THEN 940
                ELSE 300 + ROW_NUMBER() OVER (ORDER BY at.AlanTanimId)
            END AS SiraNo
        FROM dbo.AlanTanimlari at
        WHERE at.EntityAdi = 'UYE'
          AND at.AktifMi = 1
    )
    MERGE dbo.FormAlanAyarlari AS T
    USING Alanlar AS S
    ON T.KurumId = S.KurumId
    AND T.UyeTipiId = S.UyeTipiId
    AND T.FormKodu = S.FormKodu
    AND T.AlanTanimId = S.AlanTanimId
    WHEN MATCHED THEN
        UPDATE SET
            T.GorunurMu = S.GorunurMu,
            T.ZorunluMu = CASE WHEN S.GorunurMu = 0 THEN 0 ELSE S.ZorunluMu END,
            T.DegistirilebilirMi = S.DegistirilebilirMi,
            T.ListedeGorunsunMu = CASE WHEN S.GorunurMu = 0 THEN 0 ELSE S.ListedeGorunsunMu END,
            T.SiraNo = S.SiraNo,
            T.AktifMi = 1,
            T.GuncellemeTarihi = GETDATE()
    WHEN NOT MATCHED THEN
        INSERT
        (
            KurumId,
            UyeTipiId,
            FormKodu,
            AlanTanimId,
            GorunurMu,
            ZorunluMu,
            DegistirilebilirMi,
            ListedeGorunsunMu,
            SiraNo,
            AktifMi,
            OlusturmaTarihi
        )
        VALUES
        (
            S.KurumId,
            S.UyeTipiId,
            S.FormKodu,
            S.AlanTanimId,
            S.GorunurMu,
            CASE WHEN S.GorunurMu = 0 THEN 0 ELSE S.ZorunluMu END,
            S.DegistirilebilirMi,
            CASE WHEN S.GorunurMu = 0 THEN 0 ELSE S.ListedeGorunsunMu END,
            S.SiraNo,
            1,
            GETDATE()
        );
END;
GO

/* ---------------------------------------------------------
   5) Kontrol çıktısı
--------------------------------------------------------- */
SELECT
    ISNULL(ut.UyeTipiKodu, 'GENEL') AS UyeTipiKodu,
    ISNULL(ut.UyeTipiAdi, N'Genel') AS UyeTipiAdi,
    at.AlanKodu,
    at.AlanAdi,
    at.SistemAlaniMi,
    faa.GorunurMu,
    faa.ZorunluMu,
    faa.DegistirilebilirMi,
    faa.ListedeGorunsunMu,
    faa.SiraNo
FROM dbo.FormAlanAyarlari faa
INNER JOIN dbo.AlanTanimlari at ON at.AlanTanimId = faa.AlanTanimId
LEFT JOIN dbo.UyeTipleri ut ON ut.UyeTipiId = faa.UyeTipiId
WHERE faa.KurumId = 1
  AND faa.FormKodu = 'UYE_FORM'
  AND at.EntityAdi = 'UYE'
ORDER BY
    CASE
        WHEN ut.UyeTipiKodu IS NULL THEN 0
        WHEN ut.UyeTipiKodu = 'OGRENCI' THEN 1
        WHEN ut.UyeTipiKodu = 'OGRETMEN' THEN 2
        ELSE 3
    END,
    faa.SiraNo,
    at.AlanAdi;
GO
