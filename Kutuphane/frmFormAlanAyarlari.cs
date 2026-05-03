using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.DTO;
using Kutuphane.UI.Helpers;

namespace Kutuphane.UI
{
    public class frmFormAlanAyarlari : Form
    {
        private readonly IV2DinamikAlanService _dinamikAlanService;
        private readonly int _girisYapanPersonelId;
        private int _varsayilanKurumId = 1;
        private bool _hazirlaniyor;

        private Panel panelUst = null!;
        private Panel panelFiltre = null!;
        private Panel panelButonlar = null!;
        private Panel panelAlt = null!;
        private Label lblBaslik = null!;
        private Label lblAciklama = null!;
        private Label lblDurum = null!;
        private ComboBox comboBox_FormKodu = null!;
        private ComboBox comboBox_UyeTipi = null!;
        private DataGridView dataGridView_Alanlar = null!;
        private Button btnYenile = null!;
        private Button btnKaydet = null!;
        private Button btnKaydetVeUyeFormu = null!;
        private Button btnYukari = null!;
        private Button btnAsagi = null!;
        private Button btnHepsiniGoster = null!;
        private Button btnVarsayilanSira = null!;
        private Button btnKapat = null!;

        public event EventHandler? AyarlarKaydedildi;
        public event EventHandler? UyeFormunuAcIstendi;

        public frmFormAlanAyarlari() : this(0)
        {
        }

        public frmFormAlanAyarlari(int girisYapanPersonelId)
        {
            _girisYapanPersonelId = girisYapanPersonelId;
            _dinamikAlanService = V2ServiceFactory.DinamikAlanService();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Name = "frmFormAlanAyarlari";
            Text = "Form Alan Ayarları";
            BackColor = Color.FromArgb(236, 240, 241);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(1050, 610);
            Load += frmFormAlanAyarlari_Load;

            panelUst = new Panel
            {
                Dock = DockStyle.Top,
                Height = 82,
                BackColor = Color.FromArgb(44, 62, 80),
                Padding = new Padding(18, 10, 18, 10)
            };

            lblBaslik = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 34,
                Text = "🧩 Form Alan Ayarları",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162),
                ForeColor = Color.White
            };

            lblAciklama = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Fill,
                Text = "Dinamik alanların görünürlük, zorunluluk, düzenlenebilirlik, liste görünürlüğü ve sıra ayarlarını yönet.",
                Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162),
                ForeColor = Color.FromArgb(236, 240, 241)
            };

            panelUst.Controls.Add(lblAciklama);
            panelUst.Controls.Add(lblBaslik);

            panelFiltre = new Panel
            {
                Dock = DockStyle.Top,
                Height = 58,
                BackColor = Color.White,
                Padding = new Padding(12, 9, 12, 8)
            };

            var lblForm = new Label
            {
                AutoSize = true,
                Text = "Form:",
                Location = new Point(14, 18),
                Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80)
            };

            comboBox_FormKodu = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(72, 14),
                Size = new Size(220, 28),
                Font = new Font("Segoe UI", 9.5F)
            };
            comboBox_FormKodu.SelectedIndexChanged += (_, _) =>
            {
                if (!_hazirlaniyor)
                    AyarlariYukle();
            };

            var lblUyeTipi = new Label
            {
                AutoSize = true,
                Text = "Üye Tipi:",
                Location = new Point(320, 18),
                Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80)
            };

            comboBox_UyeTipi = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(405, 14),
                Size = new Size(260, 28),
                Font = new Font("Segoe UI", 9.5F)
            };
            comboBox_UyeTipi.SelectedIndexChanged += (_, _) =>
            {
                if (!_hazirlaniyor)
                    AyarlariYukle();
            };

            panelFiltre.Controls.Add(lblForm);
            panelFiltre.Controls.Add(comboBox_FormKodu);
            panelFiltre.Controls.Add(lblUyeTipi);
            panelFiltre.Controls.Add(comboBox_UyeTipi);

            panelButonlar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 58,
                BackColor = Color.White,
                Padding = new Padding(12, 10, 12, 8)
            };

            btnYenile = ButonOlustur("Yenile", 90, Color.FromArgb(52, 152, 219));
            btnKaydet = ButonOlustur("Kaydet", 95, Color.FromArgb(39, 174, 96));
            btnKaydetVeUyeFormu = ButonOlustur("Kaydet ve Üye Formunu Aç", 230, Color.FromArgb(22, 160, 133));
            btnYukari = ButonOlustur("Yukarı", 90, Color.FromArgb(155, 89, 182));
            btnAsagi = ButonOlustur("Aşağı", 90, Color.FromArgb(155, 89, 182));
            btnHepsiniGoster = ButonOlustur("Hepsini Göster", 140, Color.FromArgb(41, 128, 185));
            btnVarsayilanSira = ButonOlustur("Sırayı Düzelt", 130, Color.FromArgb(230, 126, 34));
            btnKapat = ButonOlustur("Kapat", 90, Color.FromArgb(127, 140, 141));

            btnYenile.Click += (s, e) => AyarlariYukle();
            btnKaydet.Click += (s, e) => AyarlariKaydet(false);
            btnKaydetVeUyeFormu.Click += (s, e) => AyarlariKaydet(true);
            btnYukari.Click += (s, e) => SeciliSatiriTasi(-1);
            btnAsagi.Click += (s, e) => SeciliSatiriTasi(1);
            btnHepsiniGoster.Click += (s, e) => TumAlanlariGorunurYap();
            btnVarsayilanSira.Click += (s, e) => SirayiDuzelt();
            btnKapat.Click += (s, e) => Close();

            var buttons = new[]
            {
                btnYenile,
                btnKaydet,
                btnKaydetVeUyeFormu,
                btnYukari,
                btnAsagi,
                btnHepsiniGoster,
                btnVarsayilanSira,
                btnKapat
            };

            int left = 12;
            foreach (var button in buttons)
            {
                button.Left = left;
                button.Top = 10;
                panelButonlar.Controls.Add(button);
                left += button.Width + 8;
            }

            dataGridView_Alanlar = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                ColumnHeadersHeight = 36,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                EditMode = DataGridViewEditMode.EditOnEnter,
                EnableHeadersVisualStyles = false,
                MultiSelect = false,
                RowHeadersVisible = false,
                RowTemplate = { Height = 36 },
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            dataGridView_Alanlar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dataGridView_Alanlar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Alanlar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridView_Alanlar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(214, 234, 248);
            dataGridView_Alanlar.DefaultCellStyle.SelectionForeColor = Color.FromArgb(44, 62, 80);
            dataGridView_Alanlar.CellValidating += dataGridView_Alanlar_CellValidating;
            dataGridView_Alanlar.CellValueChanged += dataGridView_Alanlar_CellValueChanged;
            dataGridView_Alanlar.CurrentCellDirtyStateChanged += dataGridView_Alanlar_CurrentCellDirtyStateChanged;

            KolonlariOlustur();

            panelAlt = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 34,
                BackColor = Color.White,
                Padding = new Padding(12, 6, 12, 6)
            };

            lblDurum = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Fill,
                Text = "Hazır",
                ForeColor = Color.FromArgb(44, 62, 80)
            };

            panelAlt.Controls.Add(lblDurum);

            Controls.Add(dataGridView_Alanlar);
            Controls.Add(panelAlt);
            Controls.Add(panelButonlar);
            Controls.Add(panelFiltre);
            Controls.Add(panelUst);
        }

        private Button ButonOlustur(string text, int width, Color backColor)
        {
            var button = new Button
            {
                Width = width,
                Height = 38,
                Text = text,
                BackColor = backColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 162),
                Cursor = Cursors.Hand
            };

            button.FlatAppearance.BorderSize = 0;
            return button;
        }

        private void KolonlariOlustur()
        {
            dataGridView_Alanlar.Columns.Clear();

            dataGridView_Alanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FormAlanAyariId",
                HeaderText = "Ayar Id",
                Visible = false
            });

            dataGridView_Alanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AlanTanimId",
                HeaderText = "Alan Id",
                Visible = false
            });

            dataGridView_Alanlar.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "GorunurMu",
                HeaderText = "Görünsün",
                FillWeight = 55
            });

            dataGridView_Alanlar.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "ZorunluMu",
                HeaderText = "Zorunlu",
                FillWeight = 55
            });

            dataGridView_Alanlar.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "DegistirilebilirMi",
                HeaderText = "Değiştirilsin",
                FillWeight = 70
            });

            dataGridView_Alanlar.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "ListedeGorunsunMu",
                HeaderText = "Listede",
                FillWeight = 55
            });

            dataGridView_Alanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SiraNo",
                HeaderText = "Sıra",
                FillWeight = 45
            });

            dataGridView_Alanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AlanAdi",
                HeaderText = "Alan Adı",
                ReadOnly = true,
                FillWeight = 130
            });

            dataGridView_Alanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AlanKodu",
                HeaderText = "Alan Kodu",
                ReadOnly = true,
                FillWeight = 105
            });

            dataGridView_Alanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "VeriTipi",
                HeaderText = "Veri Tipi",
                ReadOnly = true,
                FillWeight = 75
            });

            dataGridView_Alanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaxLength",
                HeaderText = "Max",
                ReadOnly = true,
                FillWeight = 45
            });

            dataGridView_Alanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EntityAdi",
                HeaderText = "Entity",
                ReadOnly = true,
                FillWeight = 65
            });
        }

        private void frmFormAlanAyarlari_Load(object? sender, EventArgs e)
        {
            try
            {
                _hazirlaniyor = true;
                VarsayilanKurumYukle();
                FormSecenekleriniYukle();
                UyeTipleriniYukle();
            }
            catch (Exception ex)
            {
                DurumYaz("Başlatma hatası: " + ex.Message, true);
                MessageBox.Show(ex.Message, "Form Alan Ayarları", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _hazirlaniyor = false;
            }

            AyarlariYukle();
        }

        private void VarsayilanKurumYukle()
        {
            using var db = new KutuphaneDbContext();
            var kurum = db.Kurumlar.FirstOrDefault(x => x.KurumKodu == "VARSAYILAN" && x.AktifMi)
                        ?? db.Kurumlar.FirstOrDefault(x => x.AktifMi);

            _varsayilanKurumId = kurum?.KurumId ?? 1;
        }

        private void FormSecenekleriniYukle()
        {
            comboBox_FormKodu.DataSource = new List<FormSecim>
            {
                new FormSecim { FormKodu = "UYE_FORM", FormAdi = "Üye Formu" }
            };
            comboBox_FormKodu.DisplayMember = nameof(FormSecim.FormAdi);
            comboBox_FormKodu.ValueMember = nameof(FormSecim.FormKodu);
            comboBox_FormKodu.SelectedIndex = 0;
        }

        private void UyeTipleriniYukle()
        {
            using var db = new KutuphaneDbContext();
            var liste = new List<UyeTipiSecim>
            {
                new UyeTipiSecim { UyeTipiId = 0, UyeTipiAdi = "Genel Ayar (Tüm Üye Tipleri)" }
            };

            liste.AddRange(db.UyeTipleri
                .Where(x => x.AktifMi)
                .OrderBy(x => x.UyeTipiId)
                .Select(x => new UyeTipiSecim
                {
                    UyeTipiId = x.UyeTipiId,
                    UyeTipiAdi = x.UyeTipiAdi
                })
                .ToList());

            comboBox_UyeTipi.DataSource = liste;
            comboBox_UyeTipi.DisplayMember = nameof(UyeTipiSecim.UyeTipiAdi);
            comboBox_UyeTipi.ValueMember = nameof(UyeTipiSecim.UyeTipiId);
            comboBox_UyeTipi.SelectedIndex = liste.Count > 1 ? 1 : 0;
        }

        private void AyarlariYukle()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dataGridView_Alanlar.Rows.Clear();

                string formKodu = SeciliFormKoduGetir();
                int? uyeTipiId = SeciliUyeTipiIdGetir();

                var result = _dinamikAlanService.FormAlanAyarlariniGetir(_varsayilanKurumId, uyeTipiId, formKodu);

                if (!result.IsSuccess)
                {
                    DurumYaz("Form alan ayarları alınamadı: " + result.Message, true);
                    MessageBox.Show(result.Message, "Form Alan Ayarları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var alanlar = result.Data ?? new List<FormAlanAyariDto>();

                foreach (var alan in alanlar.OrderBy(x => x.SiraNo).ThenBy(x => x.AlanAdi))
                {
                    dataGridView_Alanlar.Rows.Add(
                        alan.FormAlanAyariId,
                        alan.AlanTanimId,
                        alan.GorunurMu,
                        alan.ZorunluMu,
                        alan.DegistirilebilirMi,
                        alan.ListedeGorunsunMu,
                        alan.SiraNo <= 0 ? 1 : alan.SiraNo,
                        alan.AlanAdi,
                        alan.AlanKodu,
                        alan.VeriTipi,
                        alan.MaxLength?.ToString() ?? string.Empty,
                        alan.EntityAdi
                    );
                }

                string uyeTipiMetni = comboBox_UyeTipi.Text;
                DurumYaz($"{alanlar.Count} form alan ayarı yüklendi. Form: {comboBox_FormKodu.Text}, Üye Tipi: {uyeTipiMetni}", false);
            }
            catch (Exception ex)
            {
                DurumYaz("Hata: " + ex.Message, true);
                MessageBox.Show(ex.Message, "Form Alan Ayarları", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void AyarlariKaydet(bool uyeFormunuAc)
        {
            if (!DataGridKontrolEt())
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                dataGridView_Alanlar.EndEdit();

                string formKodu = SeciliFormKoduGetir();
                int? uyeTipiId = SeciliUyeTipiIdGetir();

                foreach (DataGridViewRow row in dataGridView_Alanlar.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    int alanTanimId = HucreInt(row, "AlanTanimId");
                    bool gorunurMu = HucreBool(row, "GorunurMu");
                    bool zorunluMu = HucreBool(row, "ZorunluMu");
                    bool degistirilebilirMi = HucreBool(row, "DegistirilebilirMi");
                    bool listedeGorunsunMu = HucreBool(row, "ListedeGorunsunMu");
                    int siraNo = HucreInt(row, "SiraNo");

                    var kaydetResult = _dinamikAlanService.FormAlanAyariKaydet(
                        _varsayilanKurumId,
                        uyeTipiId,
                        formKodu,
                        alanTanimId,
                        gorunurMu,
                        zorunluMu,
                        degistirilebilirMi,
                        listedeGorunsunMu,
                        siraNo,
                        _girisYapanPersonelId > 0 ? _girisYapanPersonelId : null);

                    if (!kaydetResult.IsSuccess)
                    {
                        DurumYaz("Kaydetme hatası: " + kaydetResult.Message, true);
                        MessageBox.Show(kaydetResult.Message, "Form Alan Ayarları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DurumYaz("Form alan ayarları kaydedildi.", false);
                AyarlarKaydedildi?.Invoke(this, EventArgs.Empty);

                if (uyeFormunuAc)
                {
                    UyeFormunuAcIstendi?.Invoke(this, EventArgs.Empty);
                    Close();
                }
                else
                {
                    MessageBox.Show("Form alan ayarları kaydedildi. Üye formu yeniden açıldığında yeni ayarlar uygulanacak.",
                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AyarlariYukle();
                }
            }
            catch (Exception ex)
            {
                DurumYaz("Hata: " + ex.Message, true);
                MessageBox.Show(ex.Message, "Form Alan Ayarları", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private bool DataGridKontrolEt()
        {
            dataGridView_Alanlar.EndEdit();
            var siraSet = new HashSet<int>();

            foreach (DataGridViewRow row in dataGridView_Alanlar.Rows)
            {
                if (row.IsNewRow)
                    continue;

                var siraText = Convert.ToString(row.Cells["SiraNo"].Value);

                if (!int.TryParse(siraText, out int siraNo) || siraNo <= 0)
                {
                    MessageBox.Show("Sıra numarası 1 veya daha büyük bir sayı olmalıdır.",
                        "Geçersiz Sıra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView_Alanlar.CurrentCell = row.Cells["SiraNo"];
                    return false;
                }

                if (!siraSet.Add(siraNo))
                {
                    MessageBox.Show("Aynı sıra numarası birden fazla alanda kullanılamaz. 'Sırayı Düzelt' butonuna basabilirsin.",
                        "Tekrarlanan Sıra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView_Alanlar.CurrentCell = row.Cells["SiraNo"];
                    return false;
                }

                bool gorunurMu = HucreBool(row, "GorunurMu");
                bool zorunluMu = HucreBool(row, "ZorunluMu");

                if (!gorunurMu && zorunluMu)
                {
                    MessageBox.Show("Gizli bir alan zorunlu yapılamaz. Önce alanı görünür yap veya zorunlu seçimini kaldır.",
                        "Geçersiz Ayar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView_Alanlar.CurrentCell = row.Cells["GorunurMu"];
                    return false;
                }
            }

            return true;
        }

        private void SeciliSatiriTasi(int yon)
        {
            if (dataGridView_Alanlar.CurrentRow == null)
                return;

            int index = dataGridView_Alanlar.CurrentRow.Index;
            int hedefIndex = index + yon;

            if (hedefIndex < 0 || hedefIndex >= dataGridView_Alanlar.Rows.Count)
                return;

            dataGridView_Alanlar.EndEdit();

            int mevcutSira = HucreInt(dataGridView_Alanlar.Rows[index], "SiraNo");
            int hedefSira = HucreInt(dataGridView_Alanlar.Rows[hedefIndex], "SiraNo");

            dataGridView_Alanlar.Rows[index].Cells["SiraNo"].Value = hedefSira;
            dataGridView_Alanlar.Rows[hedefIndex].Cells["SiraNo"].Value = mevcutSira;

            SirayaGoreYenidenCiz(hedefIndex);
        }

        private void SirayaGoreYenidenCiz(int secilecekIndex = 0)
        {
            var satirlar = SatirlariOku()
                .OrderBy(x => x.SiraNo)
                .ThenBy(x => x.AlanAdi)
                .ToList();

            dataGridView_Alanlar.Rows.Clear();

            foreach (var row in satirlar)
                SatirEkle(row);

            if (dataGridView_Alanlar.Rows.Count > 0)
            {
                secilecekIndex = Math.Max(0, Math.Min(secilecekIndex, dataGridView_Alanlar.Rows.Count - 1));
                dataGridView_Alanlar.CurrentCell = dataGridView_Alanlar.Rows[secilecekIndex].Cells["AlanAdi"];
            }
        }

        private List<FormAlanAyariSatir> SatirlariOku()
        {
            var liste = new List<FormAlanAyariSatir>();

            foreach (DataGridViewRow row in dataGridView_Alanlar.Rows)
            {
                if (row.IsNewRow)
                    continue;

                liste.Add(new FormAlanAyariSatir
                {
                    FormAlanAyariId = HucreInt(row, "FormAlanAyariId"),
                    AlanTanimId = HucreInt(row, "AlanTanimId"),
                    GorunurMu = HucreBool(row, "GorunurMu"),
                    ZorunluMu = HucreBool(row, "ZorunluMu"),
                    DegistirilebilirMi = HucreBool(row, "DegistirilebilirMi"),
                    ListedeGorunsunMu = HucreBool(row, "ListedeGorunsunMu"),
                    SiraNo = HucreInt(row, "SiraNo"),
                    AlanAdi = HucreString(row, "AlanAdi"),
                    AlanKodu = HucreString(row, "AlanKodu"),
                    VeriTipi = HucreString(row, "VeriTipi"),
                    MaxLength = HucreString(row, "MaxLength"),
                    EntityAdi = HucreString(row, "EntityAdi")
                });
            }

            return liste;
        }

        private void SatirEkle(FormAlanAyariSatir row)
        {
            dataGridView_Alanlar.Rows.Add(
                row.FormAlanAyariId,
                row.AlanTanimId,
                row.GorunurMu,
                row.ZorunluMu,
                row.DegistirilebilirMi,
                row.ListedeGorunsunMu,
                row.SiraNo,
                row.AlanAdi,
                row.AlanKodu,
                row.VeriTipi,
                row.MaxLength,
                row.EntityAdi
            );
        }

        private void TumAlanlariGorunurYap()
        {
            foreach (DataGridViewRow row in dataGridView_Alanlar.Rows)
            {
                if (!row.IsNewRow)
                    row.Cells["GorunurMu"].Value = true;
            }

            DurumYaz("Tüm alanlar görünür yapıldı. Kaydetmeyi unutma.", false);
        }

        private void SirayiDuzelt()
        {
            dataGridView_Alanlar.EndEdit();

            var satirlar = SatirlariOku()
                .OrderBy(x => x.SiraNo <= 0 ? int.MaxValue : x.SiraNo)
                .ThenBy(x => x.AlanAdi)
                .ToList();

            for (int i = 0; i < satirlar.Count; i++)
                satirlar[i].SiraNo = i + 1;

            dataGridView_Alanlar.Rows.Clear();

            foreach (var row in satirlar)
                SatirEkle(row);

            DurumYaz("Sıra numaraları 1'den başlayacak şekilde düzeltildi. Kaydetmeyi unutma.", false);
        }

        private string SeciliFormKoduGetir()
        {
            return Convert.ToString(comboBox_FormKodu.SelectedValue) ?? "UYE_FORM";
        }

        private int? SeciliUyeTipiIdGetir()
        {
            if (comboBox_UyeTipi.SelectedValue is int id && id > 0)
                return id;

            if (int.TryParse(comboBox_UyeTipi.SelectedValue?.ToString(), out int parsedId) && parsedId > 0)
                return parsedId;

            return null;
        }

        private void dataGridView_Alanlar_CellValidating(object? sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView_Alanlar.Columns[e.ColumnIndex].Name != "SiraNo")
                return;

            var value = Convert.ToString(e.FormattedValue);

            if (!int.TryParse(value, out int siraNo) || siraNo <= 0)
            {
                e.Cancel = true;
                MessageBox.Show("Sıra numarası 1 veya daha büyük olmalıdır.",
                    "Geçersiz Sıra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_Alanlar_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dataGridView_Alanlar.Columns[e.ColumnIndex].Name == "GorunurMu")
            {
                var row = dataGridView_Alanlar.Rows[e.RowIndex];
                if (!HucreBool(row, "GorunurMu"))
                {
                    row.Cells["ZorunluMu"].Value = false;
                    row.Cells["ListedeGorunsunMu"].Value = false;
                }
            }
        }

        private void dataGridView_Alanlar_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (dataGridView_Alanlar.IsCurrentCellDirty)
                dataGridView_Alanlar.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private int HucreInt(DataGridViewRow row, string columnName)
        {
            var value = row.Cells[columnName].Value;
            if (value == null)
                return 0;

            return int.TryParse(value.ToString(), out int result) ? result : 0;
        }

        private bool HucreBool(DataGridViewRow row, string columnName)
        {
            var value = row.Cells[columnName].Value;
            if (value is bool boolValue)
                return boolValue;

            return bool.TryParse(value?.ToString(), out bool result) && result;
        }

        private string HucreString(DataGridViewRow row, string columnName)
        {
            return Convert.ToString(row.Cells[columnName].Value) ?? string.Empty;
        }

        private void DurumYaz(string mesaj, bool hata)
        {
            lblDurum.Text = mesaj;
            lblDurum.ForeColor = hata ? Color.FromArgb(192, 57, 43) : Color.FromArgb(44, 62, 80);
        }

        private class FormSecim
        {
            public string FormKodu { get; set; } = string.Empty;
            public string FormAdi { get; set; } = string.Empty;
        }

        private class UyeTipiSecim
        {
            public int UyeTipiId { get; set; }
            public string UyeTipiAdi { get; set; } = string.Empty;
        }

        private class FormAlanAyariSatir
        {
            public int FormAlanAyariId { get; set; }
            public int AlanTanimId { get; set; }
            public bool GorunurMu { get; set; }
            public bool ZorunluMu { get; set; }
            public bool DegistirilebilirMi { get; set; }
            public bool ListedeGorunsunMu { get; set; }
            public int SiraNo { get; set; }
            public string AlanAdi { get; set; } = string.Empty;
            public string AlanKodu { get; set; } = string.Empty;
            public string VeriTipi { get; set; } = string.Empty;
            public string MaxLength { get; set; } = string.Empty;
            public string EntityAdi { get; set; } = string.Empty;
        }
    }
}
