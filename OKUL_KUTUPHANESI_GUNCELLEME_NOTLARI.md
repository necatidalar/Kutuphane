# Okul Kütüphanesi Güncelleme Notları

## Analiz

Proje, .NET 8 Windows Forms tabanlı katmanlı bir masaüstü kütüphane otomasyonudur.

- `Core`: Ortak entity, repository ve result altyapısı
- `Kutuphane.Model`: Entity ve DTO sınıfları
- `Kutuphane.DAL`: Entity Framework Core, SQL Server bağlantısı, repository/DAL ve migrations
- `Kutuphane.BLL`: İş kuralları ve validasyonlar
- `Kutuphane`: WinForms kullanıcı arayüzü

Veritabanı bağlantısı `Kutuphane.DAL/Contexes/KutuphaneDbContext.cs` içinde SQL Server olarak tanımlıdır. Ana akışta `Uyeler`, `Kitaplar` ve `Oduncler` tabloları kullanılır. Eski `Uye` altyapısı korunmuş, okul kullanımı için öğrenci alanları bu yapının üzerine eklenmiştir.

## Yapılan geliştirmeler

### Öğrenci kayıt ekranı

`frmUyeIslemleri` ekranı öğrenci yönetimine uygun hale getirildi. Yeni alanlar:

- Okul numarası
- Sınıf
- Şube
- Telefon
- E-posta
- Veli adı soyadı
- Veli telefonu
- Adres
- Adres detay

Mevcut `TcPass` alanı tamamen kaldırılmadı; eski veriler ve mevcut veri tabanı yapısı bozulmasın diye opsiyonel bırakıldı. Yeni öğrenci kaydında TC/Pass boşsa otomatik olarak okul numarası kullanılır.

### Ödünç verme ekranı

`frmOduncIslemleri` ekranı okul numarası merkezli çalışacak şekilde düzenlendi.

- Okul numarası yazıldığında öğrenci otomatik seçilir.
- Öğrenci bilgileri, sınıf/şube bilgisiyle gösterilir.
- Kitap arama alanı kitap adı, ISBN veya yazar ile çalışır.
- Arama sonucunda kitap stoğu gösterilir.
- Stok yoksa kitap sepete eklenmez.
- Aynı öğrenci üzerinde aynı kitap zaten ödünçteyse tekrar ödünç verilmez.
- Ödünç verme sonrası kitap stoğu düşürülür.

### İade ekranı

- Okul numarasıyla seçilen öğrencinin sadece aktif ödünç kitapları listelenir.
- Seçilen kitap iade alındığında ödünç kaydı teslim edildi olarak güncellenir.
- İade sonrası kitap stoğu artırılır.
- Tüm aktif ödünçler listesinde okul no, öğrenci adı, sınıf/şube ve gecikme durumu gösterilir.

### Veritabanı güncellemesi

Mevcut verileri silmeden `Uyeler` tablosuna yeni nullable alanlar eklendi:

- `OkulNo`
- `Sinif`
- `Sube`
- `VeliAdSoyad`
- `VeliTelefon`

Ayrıca `OkulNo` için boş olmayan değerlerde benzersiz index eklendi. Böylece aynı okul numarasıyla iki öğrenci kaydı açılması engellenir.

## Veritabanını güncelleme

Visual Studio Package Manager Console üzerinde önerilen komut:

```powershell
Update-Database -Project Kutuphane.DAL -StartupProject Kutuphane
```

EF migration kullanmak istemezseniz alternatif olarak şu dosyadaki SQL scriptini çalıştırabilirsiniz:

```text
Database/OkulKutuphane_Guncelleme.sql
```

Bu script mevcut kayıtları silmez.

## Önemli not

Bu ortamda `.NET SDK` komutu bulunmadığı için proje burada derlenemedi. Kodlar statik olarak düzenlendi ve proje yapısına uygun şekilde dosyalar güncellendi. Visual Studio üzerinde açıp `Restore NuGet Packages`, ardından `Build` ve `Update-Database` çalıştırmanız gerekir.
