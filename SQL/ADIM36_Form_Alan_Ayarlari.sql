USE [KutuphaneOtomasyonu];
GO

/* =========================================================
   ADIM 36 - Form Alan Ayarları Ekranı
   FormAlanAyarlari yönetimi + procedure + menü kaydı
========================================================= */

IF OBJECT_ID(N'dbo.AlanTanimlari', N'U') IS NULL
BEGIN
    RAISERROR(N'AlanTanimlari tablosu yok. Önce dinamik alan DB adımları çalışmalı.', 16, 1);
    RETURN;
END;
GO

IF OBJECT_ID(N'dbo.FormAlanAyarlari', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.FormAlanAyarlari
    (
        FormAlanAyariId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_FormAlanAyarlari PRIMARY KEY,
        KurumId INT NOT NULL,
        UyeTipiId INT NULL,
        FormKodu VARCHAR(100) NOT NULL,
        AlanTanimId INT NOT NULL,
        GorunurMu BIT NOT NULL CONSTRAINT DF_FormAlanAyarlari_GorunurMu DEFAULT(1),
        ZorunluMu BIT NOT NULL CONSTRAINT DF_FormAlanAyarlari_ZorunluMu DEFAULT(0),
        DegistirilebilirMi BIT NOT NULL CONSTRAINT DF_FormAlanAyarlari_DegistirilebilirMi DEFAULT(1),
        ListedeGorunsunMu BIT NOT NULL CONSTRAINT DF_FormAlanAyarlari_ListedeGorunsunMu DEFAULT(0),
        SiraNo INT NOT NULL CONSTRAINT DF_FormAlanAyarlari_SiraNo DEFAULT(0),
        AktifMi BIT NOT NULL CONSTRAINT DF_FormAlanAyarlari_AktifMi DEFAULT(1),
        OlusturmaTarihi DATETIME NOT NULL CONSTRAINT DF_FormAlanAyarlari_OlusturmaTarihi DEFAULT(GETDATE()),
        GuncellemeTarihi DATETIME NULL
    );
END;
GO

IF COL_LENGTH('dbo.FormAlanAyarlari', 'GorunurMu') IS NULL
    ALTER TABLE dbo.FormAlanAyarlari ADD GorunurMu BIT NOT NULL CONSTRAINT DF_FormAlanAyarlari_GorunurMu2 DEFAULT(1);
GO

IF COL_LENGTH('dbo.FormAlanAyarlari', 'ZorunluMu') IS NULL
    ALTER TABLE dbo.FormAlanAyarlari ADD ZorunluMu BIT NOT NULL CONSTRAINT DF_FormAlanAyarlari_ZorunluMu2 DEFAULT(0);
GO

IF COL_LENGTH('dbo.FormAlanAyarlari', 'DegistirilebilirMi') IS NULL
    ALTER TABLE dbo.FormAlanAyarlari ADD DegistirilebilirMi BIT NOT NULL CONSTRAINT DF_FormAlanAyarlari_DegistirilebilirMi2 DEFAULT(1);
GO

IF COL_LENGTH('dbo.FormAlanAyarlari', 'ListedeGorunsunMu') IS NULL
    ALTER TABLE dbo.FormAlanAyarlari ADD ListedeGorunsunMu BIT NOT NULL CONSTRAINT DF_FormAlanAyarlari_ListedeGorunsunMu2 DEFAULT(0);
GO

IF COL_LENGTH('dbo.FormAlanAyarlari', 'SiraNo') IS NULL
    ALTER TABLE dbo.FormAlanAyarlari ADD SiraNo INT NOT NULL CONSTRAINT DF_FormAlanAyarlari_SiraNo2 DEFAULT(0);
GO

IF COL_LENGTH('dbo.FormAlanAyarlari', 'AktifMi') IS NULL
    ALTER TABLE dbo.FormAlanAyarlari ADD AktifMi BIT NOT NULL CONSTRAINT DF_FormAlanAyarlari_AktifMi2 DEFAULT(1);
GO

/* Varsayılan form alan ayar kayıtları: genel + aktif üye tipleri */
;WITH Alanlar AS
(
    SELECT
        at.AlanTanimId,
        ROW_NUMBER() OVER (ORDER BY at.AlanTanimId) AS SiraNo,
        CASE WHEN at.AlanKodu IN ('OKUL_NO', 'SINIF', 'SUBE', 'VELI_TELEFONU', 'BRANS') THEN 1 ELSE 0 END AS ListedeGorunsunMu
    FROM dbo.AlanTanimlari at
    WHERE at.EntityAdi = 'UYE'
      AND at.AktifMi = 1
),
Hedefler AS
(
    SELECT 1 AS KurumId, CAST(NULL AS INT) AS UyeTipiId, 'UYE_FORM' AS FormKodu, a.AlanTanimId, a.SiraNo, a.ListedeGorunsunMu
    FROM Alanlar a

    UNION ALL

    SELECT 1 AS KurumId, ut.UyeTipiId, 'UYE_FORM' AS FormKodu, a.AlanTanimId, a.SiraNo, a.ListedeGorunsunMu
    FROM Alanlar a
    INNER JOIN dbo.UyeTipleri ut ON ut.AktifMi = 1
)
MERGE dbo.FormAlanAyarlari AS T
USING Hedefler AS S
ON T.KurumId = S.KurumId
AND ((T.UyeTipiId = S.UyeTipiId) OR (T.UyeTipiId IS NULL AND S.UyeTipiId IS NULL))
AND T.FormKodu = S.FormKodu
AND T.AlanTanimId = S.AlanTanimId
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
        1,
        0,
        1,
        S.ListedeGorunsunMu,
        S.SiraNo,
        1,
        GETDATE()
    );
GO

CREATE OR ALTER PROCEDURE dbo.sp_FormAlanAyarlariniGetir
    @KurumId INT = 1,
    @UyeTipiId INT = NULL,
    @FormKodu VARCHAR(100) = 'UYE_FORM'
AS
BEGIN
    SET NOCOUNT ON;

    IF @KurumId IS NULL OR @KurumId <= 0
        SET @KurumId = 1;

    SET @FormKodu = UPPER(LTRIM(RTRIM(ISNULL(@FormKodu, 'UYE_FORM'))));

    DECLARE @EntityAdi VARCHAR(50) = 'UYE';

    IF @FormKodu IN ('UYE_FORM', 'UYE_FORMU', 'FRMUYEISLEMLERI')
        SET @EntityAdi = 'UYE';

    SELECT
        ISNULL(faa.FormAlanAyariId, 0) AS FormAlanAyariId,
        @KurumId AS KurumId,
        k.KurumAdi,
        CASE WHEN @UyeTipiId IS NULL THEN faa.UyeTipiId ELSE @UyeTipiId END AS UyeTipiId,
        ut.UyeTipiAdi,
        @FormKodu AS FormKodu,
        at.AlanTanimId,
        at.EntityAdi,
        at.AlanKodu,
        at.AlanAdi,
        at.VeriTipi,
        at.MaxLength,
        CAST(ISNULL(faa.GorunurMu, 1) AS BIT) AS GorunurMu,
        CAST(ISNULL(faa.ZorunluMu, 0) AS BIT) AS ZorunluMu,
        CAST(ISNULL(faa.DegistirilebilirMi, 1) AS BIT) AS DegistirilebilirMi,
        CAST(ISNULL(faa.ListedeGorunsunMu, 0) AS BIT) AS ListedeGorunsunMu,
        ISNULL(NULLIF(faa.SiraNo, 0), ROW_NUMBER() OVER (ORDER BY at.AlanTanimId)) AS SiraNo,
        CAST(ISNULL(faa.AktifMi, 1) AS BIT) AS AktifMi
    FROM dbo.AlanTanimlari at
    LEFT JOIN dbo.Kurumlar k ON k.KurumId = @KurumId
    LEFT JOIN dbo.UyeTipleri ut ON ut.UyeTipiId = @UyeTipiId
    OUTER APPLY
    (
        SELECT TOP 1 f.*
        FROM dbo.FormAlanAyarlari f
        WHERE f.KurumId = @KurumId
          AND f.FormKodu = @FormKodu
          AND f.AlanTanimId = at.AlanTanimId
          AND f.AktifMi = 1
          AND
          (
                (@UyeTipiId IS NULL AND f.UyeTipiId IS NULL)
                OR
                (@UyeTipiId IS NOT NULL AND (f.UyeTipiId = @UyeTipiId OR f.UyeTipiId IS NULL))
          )
        ORDER BY
            CASE
                WHEN @UyeTipiId IS NOT NULL AND f.UyeTipiId = @UyeTipiId THEN 0
                WHEN f.UyeTipiId IS NULL THEN 1
                ELSE 2
            END,
            f.FormAlanAyariId DESC
    ) faa
    WHERE at.EntityAdi = @EntityAdi
      AND at.AktifMi = 1
    ORDER BY
        ISNULL(NULLIF(faa.SiraNo, 0), at.AlanTanimId),
        at.AlanAdi;
END;
GO

CREATE OR ALTER PROCEDURE dbo.sp_FormAlanAyariKaydet
    @KurumId INT,
    @UyeTipiId INT = NULL,
    @FormKodu VARCHAR(100),
    @AlanTanimId INT,
    @GorunurMu BIT,
    @ZorunluMu BIT,
    @DegistirilebilirMi BIT,
    @ListedeGorunsunMu BIT,
    @SiraNo INT,
    @KullaniciId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @KurumId IS NULL OR @KurumId <= 0
        SET @KurumId = 1;

    SET @FormKodu = UPPER(LTRIM(RTRIM(ISNULL(@FormKodu, 'UYE_FORM'))));

    IF @AlanTanimId IS NULL OR @AlanTanimId <= 0
    BEGIN
        RAISERROR(N'AlanTanimId geçersiz.', 16, 1);
        RETURN;
    END;

    IF @SiraNo IS NULL OR @SiraNo <= 0
        SET @SiraNo = 1;

    IF @GorunurMu = 0
    BEGIN
        SET @ZorunluMu = 0;
        SET @ListedeGorunsunMu = 0;
    END;

    MERGE dbo.FormAlanAyarlari AS T
    USING
    (
        SELECT
            @KurumId AS KurumId,
            @UyeTipiId AS UyeTipiId,
            @FormKodu AS FormKodu,
            @AlanTanimId AS AlanTanimId,
            @GorunurMu AS GorunurMu,
            @ZorunluMu AS ZorunluMu,
            @DegistirilebilirMi AS DegistirilebilirMi,
            @ListedeGorunsunMu AS ListedeGorunsunMu,
            @SiraNo AS SiraNo
    ) AS S
    ON T.KurumId = S.KurumId
   AND ((T.UyeTipiId = S.UyeTipiId) OR (T.UyeTipiId IS NULL AND S.UyeTipiId IS NULL))
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
END;
GO

CREATE OR ALTER PROCEDURE dbo.sp_FormAlanlariniGetir
    @KurumId INT = 1,
    @UyeTipiId INT = NULL,
    @FormKodu VARCHAR(100) = 'UYE_FORM'
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Alanlar TABLE
    (
        FormAlanAyariId INT,
        KurumId INT,
        KurumAdi NVARCHAR(200) NULL,
        UyeTipiId INT NULL,
        UyeTipiAdi NVARCHAR(100) NULL,
        FormKodu VARCHAR(100),
        AlanTanimId INT,
        EntityAdi VARCHAR(50),
        AlanKodu VARCHAR(100),
        AlanAdi NVARCHAR(200),
        VeriTipi VARCHAR(30),
        MaxLength INT NULL,
        GorunurMu BIT,
        ZorunluMu BIT,
        DegistirilebilirMi BIT,
        ListedeGorunsunMu BIT,
        SiraNo INT,
        AktifMi BIT
    );

    INSERT INTO @Alanlar
    EXEC dbo.sp_FormAlanAyarlariniGetir @KurumId, @UyeTipiId, @FormKodu;

    SELECT *
    FROM @Alanlar
    WHERE GorunurMu = 1
      AND AktifMi = 1
    ORDER BY SiraNo, AlanAdi;
END;
GO

CREATE OR ALTER PROCEDURE dbo.sp_FormListeKolonlariniGetir
    @KurumId INT = 1,
    @UyeTipiId INT = NULL,
    @FormKodu VARCHAR(100) = 'UYE_FORM'
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Alanlar TABLE
    (
        FormAlanAyariId INT,
        KurumId INT,
        KurumAdi NVARCHAR(200) NULL,
        UyeTipiId INT NULL,
        UyeTipiAdi NVARCHAR(100) NULL,
        FormKodu VARCHAR(100),
        AlanTanimId INT,
        EntityAdi VARCHAR(50),
        AlanKodu VARCHAR(100),
        AlanAdi NVARCHAR(200),
        VeriTipi VARCHAR(30),
        MaxLength INT NULL,
        GorunurMu BIT,
        ZorunluMu BIT,
        DegistirilebilirMi BIT,
        ListedeGorunsunMu BIT,
        SiraNo INT,
        AktifMi BIT
    );

    INSERT INTO @Alanlar
    EXEC dbo.sp_FormAlanAyarlariniGetir @KurumId, @UyeTipiId, @FormKodu;

    SELECT *
    FROM @Alanlar
    WHERE GorunurMu = 1
      AND ListedeGorunsunMu = 1
      AND AktifMi = 1
    ORDER BY SiraNo, AlanAdi;
END;
GO

/* Menüye Ayarlar > Form Alan Ayarları ekle */
IF OBJECT_ID(N'dbo.MenuTanimlari', N'U') IS NOT NULL
   AND OBJECT_ID(N'dbo.MenuAyarlari', N'U') IS NOT NULL
BEGIN
    DECLARE @AyarlarMenuId INT;
    SELECT @AyarlarMenuId = MenuTanimId
    FROM dbo.MenuTanimlari
    WHERE MenuKodu = 'AYARLAR';

    IF @AyarlarMenuId IS NOT NULL
    BEGIN
        MERGE dbo.MenuTanimlari AS T
        USING
        (
            SELECT
                'FORM_ALAN_AYARLARI' AS MenuKodu,
                @AyarlarMenuId AS UstMenuId,
                N'Form Alan Ayarları' AS MenuAdi,
                'frmFormAlanAyarlari' AS FormAdi,
                'AYARLAR' AS YetkiKodu,
                N'🧩' AS Icon,
                2 AS SiraNo,
                1 AS SistemMenusuMu
        ) AS S
        ON T.MenuKodu = S.MenuKodu
        WHEN MATCHED THEN
            UPDATE SET
                T.UstMenuId = S.UstMenuId,
                T.MenuAdi = S.MenuAdi,
                T.FormAdi = S.FormAdi,
                T.YetkiKodu = S.YetkiKodu,
                T.Icon = S.Icon,
                T.SiraNo = S.SiraNo,
                T.SistemMenusuMu = S.SistemMenusuMu,
                T.AktifMi = 1,
                T.GuncellemeTarihi = GETDATE()
        WHEN NOT MATCHED THEN
            INSERT
            (
                UstMenuId,
                MenuKodu,
                MenuAdi,
                FormAdi,
                YetkiKodu,
                Icon,
                SiraNo,
                SistemMenusuMu,
                AktifMi,
                OlusturmaTarihi
            )
            VALUES
            (
                S.UstMenuId,
                S.MenuKodu,
                S.MenuAdi,
                S.FormAdi,
                S.YetkiKodu,
                S.Icon,
                S.SiraNo,
                S.SistemMenusuMu,
                1,
                GETDATE()
            );

        MERGE dbo.MenuAyarlari AS T
        USING
        (
            SELECT
                1 AS KurumId,
                mt.MenuTanimId,
                1 AS GorunurMu,
                mt.SiraNo AS SiraNo
            FROM dbo.MenuTanimlari mt
            WHERE mt.MenuKodu = 'FORM_ALAN_AYARLARI'
        ) AS S
        ON T.KurumId = S.KurumId
        AND T.MenuTanimId = S.MenuTanimId
        WHEN MATCHED THEN
            UPDATE SET
                T.GorunurMu = 1,
                T.SiraNo = S.SiraNo,
                T.AktifMi = 1,
                T.GuncellemeTarihi = GETDATE()
        WHEN NOT MATCHED THEN
            INSERT
            (
                KurumId,
                MenuTanimId,
                GorunurMu,
                SiraNo,
                AktifMi,
                OlusturmaTarihi
            )
            VALUES
            (
                S.KurumId,
                S.MenuTanimId,
                S.GorunurMu,
                S.SiraNo,
                1,
                GETDATE()
            );
    END;
END;
GO

EXEC dbo.sp_FormAlanAyarlariniGetir 1, NULL, 'UYE_FORM';
GO
