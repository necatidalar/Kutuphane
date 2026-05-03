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
