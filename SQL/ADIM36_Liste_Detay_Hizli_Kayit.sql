USE [KutuphaneOtomasyonu];
GO

/* =========================================================
   ADIM 36 EK - Liste Kolonları + Detay + Hızlı Kayıt
   - Gridde görünecek kolonlar: UYE_FORM > ListedeGorunsunMu
   - Hızlı kayıt alanları: UYE_HIZLI_KAYIT form ayarları
   - Detay penceresi kod tarafında çalışır, DB şema değişikliği gerekmez.
========================================================= */

IF OBJECT_ID(N'dbo.AlanTanimlari', N'U') IS NULL
BEGIN
    RAISERROR(N'AlanTanimlari tablosu yok. Önce ADIM 36 ana scriptleri çalışmalı.', 16, 1);
    RETURN;
END;
GO

IF OBJECT_ID(N'dbo.FormAlanAyarlari', N'U') IS NULL
BEGIN
    RAISERROR(N'FormAlanAyarlari tablosu yok. Önce ADIM 36 ana scriptleri çalışmalı.', 16, 1);
    RETURN;
END;
GO

DECLARE @KurumId INT = 1;
DECLARE @HizliFormKodu VARCHAR(100) = 'UYE_HIZLI_KAYIT';

/* ---------------------------------------------------------
   1) Genel hızlı kayıt ayarı
   Dış üye / genel kullanım için minimum kayıt alanları.
--------------------------------------------------------- */
;WITH GenelHizli AS
(
    SELECT
        @KurumId AS KurumId,
        CAST(NULL AS INT) AS UyeTipiId,
        @HizliFormKodu AS FormKodu,
        at.AlanTanimId,
        CASE
            WHEN at.AlanKodu IN ('TC_PASS', 'AD', 'SOYAD', 'TELEFON', 'CINSIYET', 'DOGUM_TARIHI', 'UYE_NOTU') THEN 1
            ELSE 0
        END AS GorunurMu,
        CASE
            WHEN at.AlanKodu IN ('TC_PASS', 'AD', 'SOYAD') THEN 1
            ELSE 0
        END AS ZorunluMu,
        1 AS DegistirilebilirMi,
        0 AS ListedeGorunsunMu,
        CASE at.AlanKodu
            WHEN 'TC_PASS' THEN 10
            WHEN 'AD' THEN 20
            WHEN 'SOYAD' THEN 30
            WHEN 'TELEFON' THEN 40
            WHEN 'CINSIYET' THEN 50
            WHEN 'DOGUM_TARIHI' THEN 60
            WHEN 'UYE_NOTU' THEN 90
            ELSE 200 + ROW_NUMBER() OVER (ORDER BY at.AlanTanimId)
        END AS SiraNo
    FROM dbo.AlanTanimlari at
    WHERE at.EntityAdi = 'UYE'
      AND at.AktifMi = 1
)
MERGE dbo.FormAlanAyarlari AS T
USING GenelHizli AS S
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
        KurumId, UyeTipiId, FormKodu, AlanTanimId,
        GorunurMu, ZorunluMu, DegistirilebilirMi, ListedeGorunsunMu,
        SiraNo, AktifMi, OlusturmaTarihi
    )
    VALUES
    (
        S.KurumId, S.UyeTipiId, S.FormKodu, S.AlanTanimId,
        S.GorunurMu, S.ZorunluMu, S.DegistirilebilirMi, S.ListedeGorunsunMu,
        S.SiraNo, 1, GETDATE()
    );
GO

/* ---------------------------------------------------------
   2) Öğrenci hızlı kayıt ayarı
   Öğrenci için okul bilgileri hızlı kayıt alanlarına girer.
--------------------------------------------------------- */
DECLARE @KurumIdOgrenci INT = 1;
DECLARE @HizliFormKoduOgrenci VARCHAR(100) = 'UYE_HIZLI_KAYIT';
DECLARE @OgrenciUyeTipiId INT;

SELECT TOP 1 @OgrenciUyeTipiId = UyeTipiId
FROM dbo.UyeTipleri
WHERE UyeTipiKodu = 'OGRENCI'
  AND AktifMi = 1;

IF @OgrenciUyeTipiId IS NOT NULL
BEGIN
    ;WITH OgrenciHizli AS
    (
        SELECT
            @KurumIdOgrenci AS KurumId,
            @OgrenciUyeTipiId AS UyeTipiId,
            @HizliFormKoduOgrenci AS FormKodu,
            at.AlanTanimId,
            CASE
                WHEN at.AlanKodu IN ('TC_PASS', 'AD', 'SOYAD', 'TELEFON', 'CINSIYET', 'DOGUM_TARIHI', 'OKUL_NO', 'SINIF', 'SUBE', 'VELI_TELEFONU') THEN 1
                ELSE 0
            END AS GorunurMu,
            CASE
                WHEN at.AlanKodu IN ('TC_PASS', 'AD', 'SOYAD', 'OKUL_NO', 'SINIF') THEN 1
                ELSE 0
            END AS ZorunluMu,
            1 AS DegistirilebilirMi,
            0 AS ListedeGorunsunMu,
            CASE at.AlanKodu
                WHEN 'TC_PASS' THEN 10
                WHEN 'AD' THEN 20
                WHEN 'SOYAD' THEN 30
                WHEN 'TELEFON' THEN 40
                WHEN 'CINSIYET' THEN 50
                WHEN 'DOGUM_TARIHI' THEN 60
                WHEN 'OKUL_NO' THEN 70
                WHEN 'SINIF' THEN 80
                WHEN 'SUBE' THEN 90
                WHEN 'VELI_TELEFONU' THEN 100
                ELSE 200 + ROW_NUMBER() OVER (ORDER BY at.AlanTanimId)
            END AS SiraNo
        FROM dbo.AlanTanimlari at
        WHERE at.EntityAdi = 'UYE'
          AND at.AktifMi = 1
    )
    MERGE dbo.FormAlanAyarlari AS T
    USING OgrenciHizli AS S
    ON T.KurumId = S.KurumId
    AND T.UyeTipiId = S.UyeTipiId
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
            KurumId, UyeTipiId, FormKodu, AlanTanimId,
            GorunurMu, ZorunluMu, DegistirilebilirMi, ListedeGorunsunMu,
            SiraNo, AktifMi, OlusturmaTarihi
        )
        VALUES
        (
            S.KurumId, S.UyeTipiId, S.FormKodu, S.AlanTanimId,
            S.GorunurMu, S.ZorunluMu, S.DegistirilebilirMi, S.ListedeGorunsunMu,
            S.SiraNo, 1, GETDATE()
        );
END;
GO

/* ---------------------------------------------------------
   3) Öğretmen hızlı kayıt ayarı
--------------------------------------------------------- */
DECLARE @KurumIdOgretmen INT = 1;
DECLARE @HizliFormKoduOgretmen VARCHAR(100) = 'UYE_HIZLI_KAYIT';
DECLARE @OgretmenUyeTipiId INT;

SELECT TOP 1 @OgretmenUyeTipiId = UyeTipiId
FROM dbo.UyeTipleri
WHERE UyeTipiKodu = 'OGRETMEN'
  AND AktifMi = 1;

IF @OgretmenUyeTipiId IS NOT NULL
BEGIN
    ;WITH OgretmenHizli AS
    (
        SELECT
            @KurumIdOgretmen AS KurumId,
            @OgretmenUyeTipiId AS UyeTipiId,
            @HizliFormKoduOgretmen AS FormKodu,
            at.AlanTanimId,
            CASE
                WHEN at.AlanKodu IN ('TC_PASS', 'AD', 'SOYAD', 'TELEFON', 'CINSIYET', 'DOGUM_TARIHI', 'BRANS', 'SICIL_NO') THEN 1
                ELSE 0
            END AS GorunurMu,
            CASE
                WHEN at.AlanKodu IN ('TC_PASS', 'AD', 'SOYAD', 'BRANS') THEN 1
                ELSE 0
            END AS ZorunluMu,
            1 AS DegistirilebilirMi,
            0 AS ListedeGorunsunMu,
            CASE at.AlanKodu
                WHEN 'TC_PASS' THEN 10
                WHEN 'AD' THEN 20
                WHEN 'SOYAD' THEN 30
                WHEN 'TELEFON' THEN 40
                WHEN 'CINSIYET' THEN 50
                WHEN 'DOGUM_TARIHI' THEN 60
                WHEN 'BRANS' THEN 70
                WHEN 'SICIL_NO' THEN 80
                ELSE 200 + ROW_NUMBER() OVER (ORDER BY at.AlanTanimId)
            END AS SiraNo
        FROM dbo.AlanTanimlari at
        WHERE at.EntityAdi = 'UYE'
          AND at.AktifMi = 1
    )
    MERGE dbo.FormAlanAyarlari AS T
    USING OgretmenHizli AS S
    ON T.KurumId = S.KurumId
    AND T.UyeTipiId = S.UyeTipiId
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
            KurumId, UyeTipiId, FormKodu, AlanTanimId,
            GorunurMu, ZorunluMu, DegistirilebilirMi, ListedeGorunsunMu,
            SiraNo, AktifMi, OlusturmaTarihi
        )
        VALUES
        (
            S.KurumId, S.UyeTipiId, S.FormKodu, S.AlanTanimId,
            S.GorunurMu, S.ZorunluMu, S.DegistirilebilirMi, S.ListedeGorunsunMu,
            S.SiraNo, 1, GETDATE()
        );
END;
GO

/* ---------------------------------------------------------
   4) Kontrol çıktısı
--------------------------------------------------------- */
SELECT
    faa.FormKodu,
    ISNULL(ut.UyeTipiKodu, 'GENEL') AS UyeTipiKodu,
    at.AlanKodu,
    at.AlanAdi,
    faa.GorunurMu,
    faa.ZorunluMu,
    faa.DegistirilebilirMi,
    faa.ListedeGorunsunMu,
    faa.SiraNo
FROM dbo.FormAlanAyarlari faa
INNER JOIN dbo.AlanTanimlari at ON at.AlanTanimId = faa.AlanTanimId
LEFT JOIN dbo.UyeTipleri ut ON ut.UyeTipiId = faa.UyeTipiId
WHERE faa.KurumId = 1
  AND faa.FormKodu IN ('UYE_FORM', 'UYE_HIZLI_KAYIT')
  AND at.EntityAdi = 'UYE'
ORDER BY
    faa.FormKodu,
    ISNULL(ut.UyeTipiKodu, 'GENEL'),
    faa.SiraNo,
    at.AlanAdi;
GO
