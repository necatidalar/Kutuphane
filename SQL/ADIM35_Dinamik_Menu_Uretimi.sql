USE [KutuphaneOtomasyonu];
GO

/* =========================================================
   ADIM 35 - Menüleri veritabanından dinamik üretme
   MenuTanimlari + MenuAyarlari + seed + sp_MenuTanimlariniGetir
========================================================= */

IF OBJECT_ID(N'dbo.MenuTanimlari', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.MenuTanimlari
    (
        MenuTanimId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_MenuTanimlari PRIMARY KEY,
        UstMenuId INT NULL,
        MenuKodu VARCHAR(100) NOT NULL,
        MenuAdi NVARCHAR(200) NOT NULL,
        FormAdi VARCHAR(200) NULL,
        YetkiKodu VARCHAR(500) NULL,
        Icon NVARCHAR(100) NULL,
        SiraNo INT NOT NULL CONSTRAINT DF_MenuTanimlari_SiraNo DEFAULT(0),
        SistemMenusuMu BIT NOT NULL CONSTRAINT DF_MenuTanimlari_SistemMenusuMu DEFAULT(0),
        AktifMi BIT NOT NULL CONSTRAINT DF_MenuTanimlari_AktifMi DEFAULT(1),
        OlusturmaTarihi DATETIME NOT NULL CONSTRAINT DF_MenuTanimlari_OlusturmaTarihi DEFAULT(GETDATE()),
        GuncellemeTarihi DATETIME NULL,
        CONSTRAINT UQ_MenuTanimlari_MenuKodu UNIQUE(MenuKodu),
        CONSTRAINT FK_MenuTanimlari_UstMenu FOREIGN KEY(UstMenuId) REFERENCES dbo.MenuTanimlari(MenuTanimId)
    );
END;
GO

IF COL_LENGTH('dbo.MenuTanimlari', 'YetkiKodu') IS NOT NULL
BEGIN
    DECLARE @yetkiMaxLen INT;

    SELECT @yetkiMaxLen = c.max_length
    FROM sys.columns c
    WHERE c.object_id = OBJECT_ID('dbo.MenuTanimlari')
      AND c.name = 'YetkiKodu';

    IF ISNULL(@yetkiMaxLen, 0) < 500
        ALTER TABLE dbo.MenuTanimlari ALTER COLUMN YetkiKodu VARCHAR(500) NULL;
END;
GO

IF COL_LENGTH('dbo.MenuTanimlari', 'Icon') IS NULL
    ALTER TABLE dbo.MenuTanimlari ADD Icon NVARCHAR(100) NULL;
GO

IF OBJECT_ID(N'dbo.MenuAyarlari', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.MenuAyarlari
    (
        MenuAyariId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_MenuAyarlari PRIMARY KEY,
        KurumId INT NOT NULL,
        MenuTanimId INT NOT NULL,
        GorunurMu BIT NOT NULL CONSTRAINT DF_MenuAyarlari_GorunurMu DEFAULT(1),
        SiraNo INT NOT NULL CONSTRAINT DF_MenuAyarlari_SiraNo DEFAULT(0),
        AktifMi BIT NOT NULL CONSTRAINT DF_MenuAyarlari_AktifMi DEFAULT(1),
        OlusturmaTarihi DATETIME NOT NULL CONSTRAINT DF_MenuAyarlari_OlusturmaTarihi DEFAULT(GETDATE()),
        GuncellemeTarihi DATETIME NULL,
        CONSTRAINT UQ_MenuAyarlari_Kurum_Menu UNIQUE(KurumId, MenuTanimId),
        CONSTRAINT FK_MenuAyarlari_MenuTanimlari FOREIGN KEY(MenuTanimId) REFERENCES dbo.MenuTanimlari(MenuTanimId)
    );
END;
GO

DECLARE @MenuSeed TABLE
(
    MenuKodu VARCHAR(100) NOT NULL PRIMARY KEY,
    UstMenuKodu VARCHAR(100) NULL,
    MenuAdi NVARCHAR(200) NOT NULL,
    FormAdi VARCHAR(200) NULL,
    YetkiKodu VARCHAR(500) NULL,
    Icon NVARCHAR(100) NULL,
    SiraNo INT NOT NULL,
    SistemMenusuMu BIT NOT NULL
);

INSERT INTO @MenuSeed
(
    MenuKodu,
    UstMenuKodu,
    MenuAdi,
    FormAdi,
    YetkiKodu,
    Icon,
    SiraNo,
    SistemMenusuMu
)
VALUES
('GOSTERGE_PANELI',      NULL,               N'Gösterge Paneli',      '__DASHBOARD__',        'DASHBOARD',                                                     N'📊', 1, 1),
('YERLESIM_AYARLARI',    NULL,               N'Yerleşim Ayarları',    'frmYeslesimAyarlari',  'YERLESIM_AYARLARI',                                            N'⚙',  2, 1),

('KITAP_ISLEMLERI',      NULL,               N'Kitap İşlemleri',      NULL,                   NULL,                                                          N'📚', 3, 1),
('KITAP_LISTE',          'KITAP_ISLEMLERI',  N'Kitap İşlemleri',      'frmKitapIslemleri',    'KITAP_LISTELE,KITAP_EKLE,KITAP_GUNCELLE,KITAP_SIL',              N'📚', 1, 1),
('KATEGORI_LISTE',       'KITAP_ISLEMLERI',  N'Kategori İşlemleri',   'frmKategoriIslemleri', 'KATEGORI_LISTELE,KATEGORI_EKLE,KATEGORI_GUNCELLE,KATEGORI_SIL',  N'🗂', 2, 1),
('YAZAR_LISTE',          'KITAP_ISLEMLERI',  N'Yazar İşlemleri',      'frmYazarIslemleri',    'YAZAR_LISTELE,YAZAR_EKLE,YAZAR_GUNCELLE,YAZAR_SIL',              N'✍️', 3, 1),
('YAYINEVI_LISTE',       'KITAP_ISLEMLERI',  N'Yayınevi İşlemleri',   'frmYayineviIslemleri', 'YAYINEVI_LISTELE,YAYINEVI_EKLE,YAYINEVI_GUNCELLE,YAYINEVI_SIL',  N'🏢', 4, 1),
('DIL_LISTE',            'KITAP_ISLEMLERI',  N'Dil İşlemleri',        'frmDilIslemleri',      'DIL_LISTELE,DIL_EKLE,DIL_GUNCELLE,DIL_SIL',                      N'🌐', 5, 1),

('ODUNC_ISLEMLERI',      NULL,               N'Ödünç İşlemleri',      'frmOduncIslemleri',    'ODUNC_LISTELE,ODUNC_VER,IADE_AL',                                N'🔄', 4, 1),
('UYE_ISLEMLERI',        NULL,               N'Üye İşlemleri',        'frmUyeIslemleri',      'UYE_LISTELE,UYE_EKLE,UYE_GUNCELLE,UYE_SIL',                      N'👥', 5, 1),
('PERSONEL_ISLEMLERI',   NULL,               N'Personel İşlemleri',   'frmPersonelIslemleri', 'PERSONEL_LISTELE,PERSONEL_EKLE,PERSONEL_GUNCELLE,PERSONEL_SIL',  N'👔', 6, 1),
('RAPORLAMA',            NULL,               N'Raporlama',            NULL,                   'RAPORLAMA',                                                     N'📝', 7, 1),
('YONETIM_AYARLARI',     NULL,               N'Yönetim Ayarları',     'frmAdmin',             'YONETIM_LISTELE,YONETIM_EKLE,YONETIM_GUNCELLE,YONETIM_SIL',      N'🔐', 8, 1),

('AYARLAR',              NULL,               N'Ayarlar',              NULL,                   'AYARLAR',                                                       N'⚙',  9, 1),
('DASHBOARD_AYARLARI',   'AYARLAR',          N'Dashboard Ayarları',   'frmDashboardAyarlari', 'AYARLAR',                                                       N'📊', 1, 1),

('CIKIS_YAP',            NULL,               N'Çıkış Yap',            '__CIKIS__',             NULL,                                                          N'🔒', 99, 1);

MERGE dbo.MenuTanimlari AS T
USING @MenuSeed AS S
    ON T.MenuKodu = S.MenuKodu
WHEN MATCHED THEN
    UPDATE SET
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
        NULL,
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

UPDATE child
SET child.UstMenuId = parent.MenuTanimId,
    child.GuncellemeTarihi = GETDATE()
FROM dbo.MenuTanimlari child
INNER JOIN @MenuSeed seed ON seed.MenuKodu = child.MenuKodu
LEFT JOIN dbo.MenuTanimlari parent ON parent.MenuKodu = seed.UstMenuKodu
WHERE ISNULL(child.UstMenuId, -1) <> ISNULL(parent.MenuTanimId, -1);
GO

MERGE dbo.MenuAyarlari AS T
USING
(
    SELECT
        1 AS KurumId,
        mt.MenuTanimId,
        1 AS GorunurMu,
        mt.SiraNo
    FROM dbo.MenuTanimlari mt
    WHERE mt.AktifMi = 1
) AS S
    ON T.KurumId = S.KurumId
   AND T.MenuTanimId = S.MenuTanimId
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
GO

CREATE OR ALTER PROCEDURE dbo.sp_MenuTanimlariniGetir
    @KurumId INT = 1,
    @RolId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @KurumId IS NULL OR @KurumId <= 0
        SET @KurumId = 1;

    SELECT
        mt.MenuTanimId,
        mt.UstMenuId,
        ust.MenuKodu AS UstMenuKodu,
        ust.MenuAdi AS UstMenuAdi,
        mt.MenuKodu,
        mt.MenuAdi,
        mt.FormAdi,
        mt.YetkiKodu,
        mt.Icon,
        CAST(ISNULL(ma.GorunurMu, 1) AS BIT) AS GorunurMu,
        CASE
            WHEN ISNULL(ma.SiraNo, 0) > 0 THEN ma.SiraNo
            ELSE mt.SiraNo
        END AS SiraNo,
        mt.SistemMenusuMu,
        mt.AktifMi
    FROM dbo.MenuTanimlari mt
    LEFT JOIN dbo.MenuTanimlari ust ON ust.MenuTanimId = mt.UstMenuId
    LEFT JOIN dbo.MenuAyarlari ma
        ON ma.MenuTanimId = mt.MenuTanimId
       AND ma.KurumId = @KurumId
       AND ma.AktifMi = 1
    WHERE mt.AktifMi = 1
      AND ISNULL(ma.GorunurMu, 1) = 1
    ORDER BY
        CASE
            WHEN mt.UstMenuId IS NULL THEN 0
            ELSE 1
        END,
        CASE
            WHEN ISNULL(ma.SiraNo, 0) > 0 THEN ma.SiraNo
            ELSE mt.SiraNo
        END,
        mt.MenuAdi;
END;
GO

CREATE OR ALTER PROCEDURE dbo.sp_MenuAyariKaydet
    @KurumId INT,
    @MenuTanimId INT,
    @GorunurMu BIT,
    @SiraNo INT,
    @KullaniciId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @KurumId IS NULL OR @KurumId <= 0
        SET @KurumId = 1;

    IF @MenuTanimId IS NULL OR @MenuTanimId <= 0
    BEGIN
        RAISERROR(N'MenuTanimId geçersiz.', 16, 1);
        RETURN;
    END;

    IF @SiraNo IS NULL OR @SiraNo <= 0
        SET @SiraNo = 1;

    MERGE dbo.MenuAyarlari AS T
    USING
    (
        SELECT
            @KurumId AS KurumId,
            @MenuTanimId AS MenuTanimId,
            @GorunurMu AS GorunurMu,
            @SiraNo AS SiraNo
    ) AS S
        ON T.KurumId = S.KurumId
       AND T.MenuTanimId = S.MenuTanimId
    WHEN MATCHED THEN
        UPDATE SET
            T.GorunurMu = S.GorunurMu,
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
GO

EXEC dbo.sp_MenuTanimlariniGetir 1, NULL;
GO

/* =========================================================
   ADIM 35 EK ONARIM
   Daha önce oluşmuş eski dinamik menü kayıtlarını pasifleştirir.
   Ayrı dosya: SQL/ADIM35_Menu_Tekrarlari_Onarim.sql
========================================================= */
USE [KutuphaneOtomasyonu];
GO

/* =========================================================
   ADIM 35 ONARIM - Tekrarlayan Menüleri Temizleme
   Sorun: Daha önceki MenuTanimlari kayıtları aktif kaldığı için
   üst menüde hem eski hem yeni dinamik menüler birlikte görünür.
========================================================= */

IF OBJECT_ID(N'dbo.MenuTanimlari', N'U') IS NULL
BEGIN
    RAISERROR(N'MenuTanimlari tablosu yok. Önce ADIM 35 scripti çalışmalı.', 16, 1);
    RETURN;
END;
GO

IF OBJECT_ID(N'dbo.MenuAyarlari', N'U') IS NULL
BEGIN
    RAISERROR(N'MenuAyarlari tablosu yok. Önce ADIM 35 scripti çalışmalı.', 16, 1);
    RETURN;
END;
GO

DECLARE @Canonical TABLE(MenuKodu VARCHAR(100) NOT NULL PRIMARY KEY);

INSERT INTO @Canonical(MenuKodu)
VALUES
('GOSTERGE_PANELI'),
('YERLESIM_AYARLARI'),
('KITAP_ISLEMLERI'),
('KITAP_LISTE'),
('KATEGORI_LISTE'),
('YAZAR_LISTE'),
('YAYINEVI_LISTE'),
('DIL_LISTE'),
('ODUNC_ISLEMLERI'),
('UYE_ISLEMLERI'),
('PERSONEL_ISLEMLERI'),
('RAPORLAMA'),
('YONETIM_AYARLARI'),
('AYARLAR'),
('DASHBOARD_AYARLARI'),
('FORM_ALAN_AYARLARI'),
('CIKIS_YAP');

/* 1) ADIM 35 standart menüleri dışındaki eski/tekrar kök menüleri pasifleştir */
UPDATE mt
SET
    mt.AktifMi = 0,
    mt.GuncellemeTarihi = GETDATE()
FROM dbo.MenuTanimlari mt
LEFT JOIN @Canonical c ON c.MenuKodu = mt.MenuKodu
WHERE c.MenuKodu IS NULL
  AND mt.UstMenuId IS NULL
  AND
  (
        UPPER(LTRIM(RTRIM(ISNULL(mt.MenuAdi, N'')))) IN
        (
            N'DASHBOARD',
            N'GÖSTERGE',
            N'GOSTERGE',
            N'KITAP YÖNETİMİ',
            N'KITAP YONETIMI',
            N'KİTAP YÖNETİMİ',
            N'ÜYE YÖNETİMİ',
            N'UYE YONETIMI',
            N'ÖDÜNÇ / İADE',
            N'ODUNC / IADE',
            N'ÖDÜNÇ/İADE',
            N'ODUNC/IADE',
            N'AYARLAR',
            N'ÇIKIŞ YAP',
            N'CIKIS YAP'
        )
        OR UPPER(LTRIM(RTRIM(ISNULL(mt.FormAdi, '')))) IN
        (
            '__DASHBOARD__',
            '__CIKIS__',
            'FRMKITAPISLEMLERI',
            'FRMUYEISLEMLERI',
            'FRMODUNCISLEMLERI',
            'FRMPERSONELISLEMLERI',
            'FRMADMIN'
        )
  );

/* 2) Pasifleştirilen menülerin kurum ayarlarını da kapat */
UPDATE ma
SET
    ma.AktifMi = 0,
    ma.GorunurMu = 0,
    ma.GuncellemeTarihi = GETDATE()
FROM dbo.MenuAyarlari ma
INNER JOIN dbo.MenuTanimlari mt ON mt.MenuTanimId = ma.MenuTanimId
LEFT JOIN @Canonical c ON c.MenuKodu = mt.MenuKodu
WHERE c.MenuKodu IS NULL
  AND mt.AktifMi = 0;

/* 3) Standart ADIM 35 menülerini aktif tut ve sıralarını düzelt */
UPDATE mt
SET
    mt.AktifMi = 1,
    mt.GuncellemeTarihi = GETDATE()
FROM dbo.MenuTanimlari mt
INNER JOIN @Canonical c ON c.MenuKodu = mt.MenuKodu;

UPDATE dbo.MenuTanimlari SET SiraNo = 1,  MenuAdi = N'Gösterge Paneli',    FormAdi = '__DASHBOARD__',       Icon = N'📊' WHERE MenuKodu = 'GOSTERGE_PANELI';
UPDATE dbo.MenuTanimlari SET SiraNo = 2,  MenuAdi = N'Yerleşim Ayarları',  FormAdi = 'frmYeslesimAyarlari', Icon = N'⚙'  WHERE MenuKodu = 'YERLESIM_AYARLARI';
UPDATE dbo.MenuTanimlari SET SiraNo = 3,  MenuAdi = N'Kitap İşlemleri',    FormAdi = NULL,                  Icon = N'📚' WHERE MenuKodu = 'KITAP_ISLEMLERI';
UPDATE dbo.MenuTanimlari SET SiraNo = 4,  MenuAdi = N'Ödünç İşlemleri',    FormAdi = 'frmOduncIslemleri',   Icon = N'🔄' WHERE MenuKodu = 'ODUNC_ISLEMLERI';
UPDATE dbo.MenuTanimlari SET SiraNo = 5,  MenuAdi = N'Üye İşlemleri',      FormAdi = 'frmUyeIslemleri',     Icon = N'👥' WHERE MenuKodu = 'UYE_ISLEMLERI';
UPDATE dbo.MenuTanimlari SET SiraNo = 6,  MenuAdi = N'Personel İşlemleri', FormAdi = 'frmPersonelIslemleri',Icon = N'👔' WHERE MenuKodu = 'PERSONEL_ISLEMLERI';
UPDATE dbo.MenuTanimlari SET SiraNo = 7,  MenuAdi = N'Raporlama',          FormAdi = NULL,                  Icon = N'📝' WHERE MenuKodu = 'RAPORLAMA';
UPDATE dbo.MenuTanimlari SET SiraNo = 8,  MenuAdi = N'Yönetim Ayarları',   FormAdi = 'frmAdmin',            Icon = N'🔐' WHERE MenuKodu = 'YONETIM_AYARLARI';
UPDATE dbo.MenuTanimlari SET SiraNo = 9,  MenuAdi = N'Ayarlar',            FormAdi = NULL,                  Icon = N'⚙'  WHERE MenuKodu = 'AYARLAR';
UPDATE dbo.MenuTanimlari SET SiraNo = 99, MenuAdi = N'Çıkış Yap',          FormAdi = '__CIKIS__',           Icon = N'🔒' WHERE MenuKodu = 'CIKIS_YAP';

/* 4) Ayar kayıtlarını standart menülere göre tekrar aktif et */
MERGE dbo.MenuAyarlari AS T
USING
(
    SELECT
        1 AS KurumId,
        mt.MenuTanimId,
        1 AS GorunurMu,
        mt.SiraNo AS SiraNo
    FROM dbo.MenuTanimlari mt
    INNER JOIN @Canonical c ON c.MenuKodu = mt.MenuKodu
    WHERE mt.AktifMi = 1
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
GO

EXEC dbo.sp_MenuTanimlariniGetir 1, NULL;
GO
