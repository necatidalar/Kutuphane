using Kutuphane.Model.DTO;
using Kutuphane.UI.Helpers;

namespace Kutuphane.UI
{
    public partial class frmUyeIslemleri
    {
        private bool _v2ListeDetayHizliAraclariHazirlandi;
        private Button? _v2BtnListeKolonlari;
        private Button? _v2BtnUyeDetay;
        private Button? _v2BtnHizliKayit;

        private void V2ListeDetayHizliAraclariniHazirla()
        {
            if (_v2ListeDetayHizliAraclariHazirlandi)
                return;

            _v2ListeDetayHizliAraclariHazirlandi = true;

            dataGrid_Uye.CellDoubleClick += dataGrid_Uye_CellDoubleClick_DetayAc;

            int top = Math.Max(8, textBox_Ara.Top - 1);
            int left = textBox_Ara.Right + 10;

            _v2BtnListeKolonlari = V2UstButonOlustur("📋 Liste Kolonları", left, top, 145, Color.FromArgb(52, 152, 219));
            _v2BtnListeKolonlari.Click += (_, _) => V2ListeKolonAyarlariAc();
            Controls.Add(_v2BtnListeKolonlari);
            left = _v2BtnListeKolonlari.Right + 7;

            _v2BtnUyeDetay = V2UstButonOlustur("🔎 Detay", left, top, 92, Color.FromArgb(41, 128, 185));
            _v2BtnUyeDetay.Click += (_, _) => V2SeciliUyeDetayiniAc();
            Controls.Add(_v2BtnUyeDetay);
            left = _v2BtnUyeDetay.Right + 7;

            _v2BtnHizliKayit = V2UstButonOlustur("⚡ Hızlı Kayıt", left, top, 118, Color.FromArgb(230, 126, 34));
            _v2BtnHizliKayit.Click += (_, _) => V2HizliKayitModunuDegistir();
            Controls.Add(_v2BtnHizliKayit);
        }

        private Button V2UstButonOlustur(string text, int left, int top, int width, Color color)
        {
            var button = new Button
            {
                Text = text,
                Left = left,
                Top = top,
                Width = width,
                Height = textBox_Ara.Height + 2,
                BackColor = color,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8.8F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            button.FlatAppearance.BorderSize = 0;
            return button;
        }

        private void V2ListeKolonAyarlariAc()
        {
            using var form = new frmFormAlanAyarlari(_personelId);
            form.AyarlarKaydedildi += (_, _) =>
            {
                V2DinamikAlanlariYukle();
                V2ListeKolonAyarlariniYenile();
            };
            form.UyeFormunuAcIstendi += (_, _) =>
            {
                V2DinamikAlanlariYukle();
                V2ListeKolonAyarlariniYenile();
            };

            MessageBox.Show(
                "Gridde görünecek kolonları 'Listede' kutusuyla seçebilirsin.\n\n" +
                "Normal kayıt alanları için 'Üye Formu', hızlı kayıt alanları için 'Hızlı Kayıt Formu' seç.",
                "Liste Kolonları",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            form.ShowDialog(this);
            V2DinamikAlanlariYukle();
            V2ListeKolonAyarlariniYenile();
        }

        private void V2HizliKayitModunuDegistir()
        {
            bool hizliModAcilsin = !V2HizliKayitModuAktifMi();
            V2AktifFormKoduAyarla(hizliModAcilsin ? V2FormKoduHizliKayit : V2FormKoduUye);

            if (_v2BtnHizliKayit != null)
            {
                _v2BtnHizliKayit.Text = hizliModAcilsin ? "🧾 Tüm Alanlar" : "⚡ Hızlı Kayıt";
                _v2BtnHizliKayit.BackColor = hizliModAcilsin ? Color.FromArgb(127, 140, 141) : Color.FromArgb(230, 126, 34);
            }

            KutulariTemizle();
        }

        private void dataGrid_Uye_CellDoubleClick_DetayAc(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dataGrid_Uye.Rows[e.RowIndex].DataBoundItem is UyeDto uye)
                V2UyeDetayPenceresiAc(uye);
        }

        private void V2SeciliUyeDetayiniAc()
        {
            if (dataGrid_Uye.CurrentRow?.DataBoundItem is not UyeDto uye)
            {
                MessageBox.Show("Detay için önce listeden bir üye seç.", "Üye Detay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            V2UyeDetayPenceresiAc(uye);
        }

        private void V2UyeDetayPenceresiAc(UyeDto uye)
        {
            var form = new Form
            {
                Text = $"Üye Detay - {uye.Ad} {uye.Soyad}",
                StartPosition = FormStartPosition.CenterParent,
                MinimumSize = new Size(720, 560),
                Size = new Size(820, 640),
                BackColor = Color.White,
                Font = new Font("Segoe UI", 10F)
            };

            var baslikPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 82,
                BackColor = Color.FromArgb(44, 62, 80),
                Padding = new Padding(18, 12, 18, 8)
            };

            var baslik = new Label
            {
                Dock = DockStyle.Top,
                Height = 34,
                Text = $"🔎 {uye.Ad} {uye.Soyad}",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18F, FontStyle.Bold)
            };

            var aciklama = new Label
            {
                Dock = DockStyle.Fill,
                Text = $"Üye No: {uye.UyeId}    Üye Tipi: {uye.UyeTipiAdi ?? "-"}    Kurum: {uye.KurumAdi ?? "-"}",
                ForeColor = Color.FromArgb(236, 240, 241),
                Font = new Font("Segoe UI", 10F)
            };

            baslikPanel.Controls.Add(aciklama);
            baslikPanel.Controls.Add(baslik);

            var grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                EnableHeadersVisualStyles = false
            };

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Alan", HeaderText = "Alan", FillWeight = 35 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Deger", HeaderText = "Değer", FillWeight = 65 });

            void Ekle(string alan, object? deger)
            {
                grid.Rows.Add(alan, deger?.ToString() ?? string.Empty);
            }

            Ekle("Üye Id", uye.UyeId);
            Ekle("TC / Pasaport No", uye.TcPass);
            Ekle("Ad", uye.Ad);
            Ekle("Soyad", uye.Soyad);
            Ekle("Cinsiyet", uye.Cinsiyet);
            Ekle("Doğum Tarihi", uye.DogumTarihi.ToShortDateString());
            Ekle("Telefon", uye.Telefon);
            Ekle("E-Posta", uye.Eposta);
            Ekle("Adres", uye.Adres);
            Ekle("Adres Detay", uye.AdresDetay);
            Ekle("Kurum", uye.KurumAdi);
            Ekle("Üye Tipi", uye.UyeTipiAdi);
            Ekle("Aktif Ödünç Sayısı", uye.AktifOduncSayisi);
            Ekle("Gecikmiş Kitap Sayısı", uye.GecikmisKitapSayisi);

            var servis = V2ServiceFactory.DinamikAlanService();
            var sonuc = servis.EntityEkAlanDegerleriniGetir("UYE", uye.UyeId);
            if (sonuc.IsSuccess && sonuc.Data != null)
            {
                foreach (var alan in sonuc.Data.OrderBy(x => x.AlanAdi))
                {
                    string deger = alan.DegerGosterim
                                  ?? alan.DegerText
                                  ?? alan.DegerNumber?.ToString()
                                  ?? alan.DegerDecimal?.ToString()
                                  ?? alan.DegerDate?.ToShortDateString()
                                  ?? (alan.DegerBool.HasValue ? (alan.DegerBool.Value ? "Evet" : "Hayır") : string.Empty);

                    Ekle(alan.AlanAdi, deger);
                }
            }

            var altPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 54,
                BackColor = Color.White,
                Padding = new Padding(10)
            };

            var btnKapat = new Button
            {
                Text = "Kapat",
                Width = 110,
                Height = 34,
                Dock = DockStyle.Right,
                BackColor = Color.FromArgb(127, 140, 141),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
            };
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.Click += (_, _) => form.Close();

            altPanel.Controls.Add(btnKapat);

            form.Controls.Add(grid);
            form.Controls.Add(altPanel);
            form.Controls.Add(baslikPanel);
            form.ShowDialog(this);
        }
    }
}
