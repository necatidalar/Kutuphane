USE [KutuphaneOtomasyonu];
GO

/* =========================================================
   ADIM 34 - Dashboard Ayar Ekranı DB Scripti
   - Ayar ekranı için tüm widgetları getirir
   - Kurum bazlı görünürlük ve sıra kaydeder
   - Dashboard listeleme procedure'ünü ayar tablosuna göre çalıştırır
========================================================= */

IF OBJECT_ID(N'dbo.DashboardWidgetlari', N'U') IS NULL
BEGIN
    RAISERROR(N'DashboardWidgetlari tablosu bulunamadı. Önce ADIM 33 DB scriptini çalıştırın.', 16, 1);
    RETURN;
END;
GO

IF OBJECT_ID(N'dbo.DashboardWidgetAyarlari', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.DashboardWidgetAyarlari
    (
        DashboardWidgetAyariId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        KurumId INT NOT NULL,
        DashboardWidgetId INT NOT NULL,
        GorunurMu BIT NOT NULL CONSTRAINT DF_DashboardWidgetAyarlari_GorunurMu DEFAULT(1),
        SiraNo INT NOT NULL CONSTRAINT DF_DashboardWidgetAyarlari_SiraNo DEFAULT(0),
        AktifMi BIT NOT NULL CONSTRAINT DF_DashboardWidgetAyarlari_AktifMi DEFAULT(1),
        OlusturmaTarihi DATETIME NOT NULL CONSTRAINT DF_DashboardWidgetAyarlari_OlusturmaTarihi DEFAULT(GETDATE()),
        GuncellemeTarihi DATETIME NULL,
        CONSTRAINT UQ_DashboardWidgetAyarlari_Kurum_Widget UNIQUE (KurumId, DashboardWidgetId)
    );
END;
GO

CREATE OR ALTER PROCEDURE dbo.sp_DashboardWidgetAyarlariniGetir
    @KurumId INT = 1
AS
BEGIN
    SET NOCOUNT ON;

    IF @KurumId IS NULL OR @KurumId <= 0
        SET @KurumId = 1;

    SELECT
        dw.DashboardWidgetId,
        dw.WidgetKodu,
        dw.Baslik,
        dw.Aciklama,
        dw.WidgetTipi,
        dw.VeriKaynagi,
        dw.Icon,
        CAST(ISNULL(dwa.GorunurMu, 1) AS BIT) AS GorunurMu,
        CASE
            WHEN ISNULL(dwa.SiraNo, 0) > 0 THEN dwa.SiraNo
            ELSE dw.VarsayilanSiraNo
        END AS SiraNo
    FROM dbo.DashboardWidgetlari dw
    LEFT JOIN dbo.DashboardWidgetAyarlari dwa
        ON dwa.DashboardWidgetId = dw.DashboardWidgetId
       AND dwa.KurumId = @KurumId
       AND dwa.AktifMi = 1
    WHERE dw.AktifMi = 1
    ORDER BY
        CASE
            WHEN ISNULL(dwa.SiraNo, 0) > 0 THEN dwa.SiraNo
            ELSE dw.VarsayilanSiraNo
        END,
        dw.Baslik;
END;
GO

CREATE OR ALTER PROCEDURE dbo.sp_DashboardWidgetAyariKaydet
    @KurumId INT,
    @DashboardWidgetId INT,
    @GorunurMu BIT,
    @SiraNo INT,
    @KullaniciId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @KurumId IS NULL OR @KurumId <= 0
        SET @KurumId = 1;

    IF @DashboardWidgetId IS NULL OR @DashboardWidgetId <= 0
    BEGIN
        RAISERROR(N'DashboardWidgetId geçersiz.', 16, 1);
        RETURN;
    END;

    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.DashboardWidgetlari
        WHERE DashboardWidgetId = @DashboardWidgetId
          AND AktifMi = 1
    )
    BEGIN
        RAISERROR(N'Dashboard widget bulunamadı veya pasif.', 16, 1);
        RETURN;
    END;

    IF @SiraNo IS NULL OR @SiraNo <= 0
    BEGIN
        SELECT @SiraNo = ISNULL(NULLIF(VarsayilanSiraNo, 0), 1)
        FROM dbo.DashboardWidgetlari
        WHERE DashboardWidgetId = @DashboardWidgetId;
    END;

    MERGE dbo.DashboardWidgetAyarlari AS T
    USING
    (
        SELECT
            @KurumId AS KurumId,
            @DashboardWidgetId AS DashboardWidgetId,
            @GorunurMu AS GorunurMu,
            @SiraNo AS SiraNo
    ) AS S
    ON T.KurumId = S.KurumId
   AND T.DashboardWidgetId = S.DashboardWidgetId
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
            DashboardWidgetId,
            GorunurMu,
            SiraNo,
            AktifMi,
            OlusturmaTarihi
        )
        VALUES
        (
            S.KurumId,
            S.DashboardWidgetId,
            S.GorunurMu,
            S.SiraNo,
            1,
            GETDATE()
        );

    IF OBJECT_ID(N'dbo.AuditLoglari', N'U') IS NOT NULL
    BEGIN
        INSERT INTO dbo.AuditLoglari
        (
            TabloAdi,
            IslemTipi,
            KayitId,
            EskiDegerJson,
            YeniDegerJson,
            KullaniciId,
            KullaniciAdi,
            HostAdi,
            UygulamaAdi,
            IslemTarihi
        )
        VALUES
        (
            'DashboardWidgetAyarlari',
            'UPSERT',
            CONVERT(NVARCHAR(100), @DashboardWidgetId),
            NULL,
            CONCAT(N'{"KurumId":', @KurumId, N',"DashboardWidgetId":', @DashboardWidgetId, N',"GorunurMu":', CONVERT(INT, @GorunurMu), N',"SiraNo":', @SiraNo, N'}'),
            @KullaniciId,
            NULL,
            HOST_NAME(),
            APP_NAME(),
            GETDATE()
        );
    END;
END;
GO

CREATE OR ALTER PROCEDURE dbo.sp_DashboardWidgetlariniGetir
    @KurumId INT = 1,
    @RolId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @KurumId IS NULL OR @KurumId <= 0
        SET @KurumId = 1;

    SELECT
        dw.DashboardWidgetId,
        dw.WidgetKodu,
        dw.Baslik,
        dw.Aciklama,
        dw.WidgetTipi,
        dw.VeriKaynagi,
        dw.Icon,
        CAST(ISNULL(dwa.GorunurMu, 1) AS BIT) AS GorunurMu,
        CASE
            WHEN ISNULL(dwa.SiraNo, 0) > 0 THEN dwa.SiraNo
            ELSE dw.VarsayilanSiraNo
        END AS SiraNo
    FROM dbo.DashboardWidgetlari dw
    LEFT JOIN dbo.DashboardWidgetAyarlari dwa
        ON dwa.DashboardWidgetId = dw.DashboardWidgetId
       AND dwa.KurumId = @KurumId
       AND dwa.AktifMi = 1
    WHERE dw.AktifMi = 1
      AND ISNULL(dwa.GorunurMu, 1) = 1
      AND
      (
            @RolId IS NULL
            OR OBJECT_ID(N'dbo.DashboardWidgetRolleri', N'U') IS NULL
            OR NOT EXISTS
            (
                SELECT 1
                FROM dbo.DashboardWidgetRolleri dwr
                WHERE dwr.DashboardWidgetId = dw.DashboardWidgetId
                  AND dwr.AktifMi = 1
            )
            OR EXISTS
            (
                SELECT 1
                FROM dbo.DashboardWidgetRolleri dwr
                WHERE dwr.DashboardWidgetId = dw.DashboardWidgetId
                  AND dwr.RolId = @RolId
                  AND dwr.AktifMi = 1
                  AND dwr.GorunurMu = 1
            )
      )
    ORDER BY
        CASE
            WHEN ISNULL(dwa.SiraNo, 0) > 0 THEN dwa.SiraNo
            ELSE dw.VarsayilanSiraNo
        END,
        dw.Baslik;
END;
GO

/* Mevcut widgetlar için kurum 1 varsayılan ayarlarını garantiye al. */
MERGE dbo.DashboardWidgetAyarlari AS T
USING
(
    SELECT
        1 AS KurumId,
        DashboardWidgetId,
        1 AS GorunurMu,
        ISNULL(NULLIF(VarsayilanSiraNo, 0), ROW_NUMBER() OVER (ORDER BY DashboardWidgetId)) AS SiraNo
    FROM dbo.DashboardWidgetlari
    WHERE AktifMi = 1
) AS S
ON T.KurumId = S.KurumId
AND T.DashboardWidgetId = S.DashboardWidgetId
WHEN NOT MATCHED THEN
    INSERT (KurumId, DashboardWidgetId, GorunurMu, SiraNo, AktifMi, OlusturmaTarihi)
    VALUES (S.KurumId, S.DashboardWidgetId, S.GorunurMu, S.SiraNo, 1, GETDATE());
GO

EXEC dbo.sp_DashboardWidgetAyarlariniGetir 1;
GO
