using Kutuphane.BLL.Abstract;
using Kutuphane.Model.DTO;
using Kutuphane.UI.Helpers;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public class frmDashboardAyarlari : Form
    {
        private readonly IV2DashboardMenuService _dashboardMenuService;
        private readonly int _girisYapanPersonelId;
        private const int VarsayilanKurumId = 1;

        private DataGridView dataGridView_Widgetlar = null!;
        private Button btnYenile = null!;
        private Button btnKaydet = null!;
        private Button btnKaydetVeDon = null!;
        private Button btnYukari = null!;
        private Button btnAsagi = null!;
        private Button btnHepsiniGoster = null!;
        private Button btnVarsayilanSira = null!;
        private Button btnKapat = null!;
        private Label lblBaslik = null!;
        private Label lblAciklama = null!;
        private Label lblDurum = null!;
        private Panel panelUst = null!;
        private Panel panelButonlar = null!;
        private Panel panelAlt = null!;

        public event EventHandler? AyarlarKaydedildi;
        public event EventHandler? DashboardaDonIstendi;

        public frmDashboardAyarlari() : this(0)
        {
        }

        public frmDashboardAyarlari(int girisYapanPersonelId)
        {
            _girisYapanPersonelId = girisYapanPersonelId;
            _dashboardMenuService = V2ServiceFactory.DashboardMenuService();

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Name = "frmDashboardAyarlari";
            Text = "Dashboard Ayarları";
            BackColor = Color.FromArgb(236, 240, 241);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(950, 560);
            Load += frmDashboardAyarlari_Load;

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
                Text = "📊 Dashboard Ayarları",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162),
                ForeColor = Color.White
            };

            lblAciklama = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Fill,
                Text = "Kartları görünür/gizli yap, sıra numarasını değiştir ve dashboard görünümünü kurum bazlı kaydet.",
                Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162),
                ForeColor = Color.FromArgb(236, 240, 241)
            };

            panelUst.Controls.Add(lblAciklama);
            panelUst.Controls.Add(lblBaslik);

            panelButonlar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 58,
                BackColor = Color.White,
                Padding = new Padding(12, 10, 12, 8)
            };

            btnYenile = ButonOlustur("Yenile", 90, Color.FromArgb(52, 152, 219));
            btnKaydet = ButonOlustur("Kaydet", 95, Color.FromArgb(39, 174, 96));
            btnKaydetVeDon = ButonOlustur("Kaydet ve Dashboard'a Dön", 220, Color.FromArgb(22, 160, 133));
            btnYukari = ButonOlustur("Yukarı", 90, Color.FromArgb(155, 89, 182));
            btnAsagi = ButonOlustur("Aşağı", 90, Color.FromArgb(155, 89, 182));
            btnHepsiniGoster = ButonOlustur("Hepsini Göster", 140, Color.FromArgb(41, 128, 185));
            btnVarsayilanSira = ButonOlustur("Sırayı Düzelt", 130, Color.FromArgb(230, 126, 34));
            btnKapat = ButonOlustur("Kapat", 90, Color.FromArgb(127, 140, 141));

            btnYenile.Click += (s, e) => AyarlariYukle();
            btnKaydet.Click += (s, e) => AyarlariKaydet(false);
            btnKaydetVeDon.Click += (s, e) => AyarlariKaydet(true);
            btnYukari.Click += (s, e) => SeciliSatiriTasi(-1);
            btnAsagi.Click += (s, e) => SeciliSatiriTasi(1);
            btnHepsiniGoster.Click += (s, e) => TumWidgetlariGorunurYap();
            btnVarsayilanSira.Click += (s, e) => SirayiDuzelt();
            btnKapat.Click += (s, e) => Close();

            var buttons = new[]
            {
                btnYenile,
                btnKaydet,
                btnKaydetVeDon,
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

            dataGridView_Widgetlar = new DataGridView
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

            dataGridView_Widgetlar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dataGridView_Widgetlar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Widgetlar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridView_Widgetlar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(214, 234, 248);
            dataGridView_Widgetlar.DefaultCellStyle.SelectionForeColor = Color.FromArgb(44, 62, 80);
            dataGridView_Widgetlar.CellValidating += dataGridView_Widgetlar_CellValidating;
            dataGridView_Widgetlar.CellValueChanged += dataGridView_Widgetlar_CellValueChanged;
            dataGridView_Widgetlar.CurrentCellDirtyStateChanged += dataGridView_Widgetlar_CurrentCellDirtyStateChanged;

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

            Controls.Add(dataGridView_Widgetlar);
            Controls.Add(panelAlt);
            Controls.Add(panelButonlar);
            Controls.Add(panelUst);
        }

        private Button ButonOlustur(string text, int width, Color backColor)
        {
            return new Button
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
        }

        private void KolonlariOlustur()
        {
            dataGridView_Widgetlar.Columns.Clear();

            dataGridView_Widgetlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DashboardWidgetId",
                HeaderText = "Id",
                Visible = false
            });

            dataGridView_Widgetlar.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "GorunurMu",
                HeaderText = "Görünsün",
                Width = 85,
                FillWeight = 55
            });

            dataGridView_Widgetlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SiraNo",
                HeaderText = "Sıra",
                Width = 65,
                FillWeight = 45
            });

            dataGridView_Widgetlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Baslik",
                HeaderText = "Kart Başlığı",
                ReadOnly = true,
                FillWeight = 140
            });

            dataGridView_Widgetlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "WidgetKodu",
                HeaderText = "Widget Kodu",
                ReadOnly = true,
                FillWeight = 115
            });

            dataGridView_Widgetlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "VeriKaynagi",
                HeaderText = "Veri Kaynağı",
                ReadOnly = true,
                FillWeight = 115
            });

            dataGridView_Widgetlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "WidgetTipi",
                HeaderText = "Tip",
                ReadOnly = true,
                FillWeight = 70
            });

            dataGridView_Widgetlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Aciklama",
                HeaderText = "Açıklama",
                ReadOnly = true,
                FillWeight = 160
            });
        }

        private void frmDashboardAyarlari_Load(object? sender, EventArgs e)
        {
            AyarlariYukle();
        }

        private void AyarlariYukle()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dataGridView_Widgetlar.Rows.Clear();

                var result = _dashboardMenuService.DashboardWidgetAyarlariniGetir(VarsayilanKurumId);

                if (!result.IsSuccess)
                {
                    DurumYaz("Dashboard ayarları alınamadı: " + result.Message, true);
                    MessageBox.Show(result.Message, "Dashboard Ayarları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var widgetlar = result.Data ?? new List<DashboardWidgetDto>();

                foreach (var widget in widgetlar.OrderBy(x => x.SiraNo).ThenBy(x => x.Baslik))
                {
                    dataGridView_Widgetlar.Rows.Add(
                        widget.DashboardWidgetId,
                        widget.GorunurMu,
                        widget.SiraNo <= 0 ? 1 : widget.SiraNo,
                        widget.Baslik,
                        widget.WidgetKodu,
                        widget.VeriKaynagi,
                        widget.WidgetTipi,
                        widget.Aciklama ?? string.Empty
                    );
                }

                DurumYaz($"{widgetlar.Count} dashboard kart ayarı yüklendi.", false);
            }
            catch (Exception ex)
            {
                DurumYaz("Hata: " + ex.Message, true);
                MessageBox.Show(ex.Message, "Dashboard Ayarları", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void AyarlariKaydet(bool dashboardaDon)
        {
            if (!DataGridKontrolEt())
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                dataGridView_Widgetlar.EndEdit();

                foreach (DataGridViewRow row in dataGridView_Widgetlar.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    int dashboardWidgetId = HucreInt(row, "DashboardWidgetId");
                    bool gorunurMu = HucreBool(row, "GorunurMu");
                    int siraNo = HucreInt(row, "SiraNo");

                    var kaydetResult = _dashboardMenuService.DashboardWidgetAyariKaydet(
                        VarsayilanKurumId,
                        dashboardWidgetId,
                        gorunurMu,
                        siraNo,
                        _girisYapanPersonelId > 0 ? _girisYapanPersonelId : null);

                    if (!kaydetResult.IsSuccess)
                    {
                        DurumYaz("Kaydetme hatası: " + kaydetResult.Message, true);
                        MessageBox.Show(kaydetResult.Message, "Dashboard Ayarları", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DurumYaz("Dashboard ayarları kaydedildi.", false);
                AyarlarKaydedildi?.Invoke(this, EventArgs.Empty);

                if (dashboardaDon)
                {
                    DashboardaDonIstendi?.Invoke(this, EventArgs.Empty);
                    Close();
                }
                else
                {
                    MessageBox.Show("Dashboard ayarları kaydedildi. Gösterge Paneli açıldığında yeni sıralama uygulanacak.",
                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                DurumYaz("Hata: " + ex.Message, true);
                MessageBox.Show(ex.Message, "Dashboard Ayarları", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private bool DataGridKontrolEt()
        {
            dataGridView_Widgetlar.EndEdit();

            var siraSet = new HashSet<int>();

            foreach (DataGridViewRow row in dataGridView_Widgetlar.Rows)
            {
                if (row.IsNewRow)
                    continue;

                var siraText = Convert.ToString(row.Cells["SiraNo"].Value);

                if (!int.TryParse(siraText, out int siraNo) || siraNo <= 0)
                {
                    MessageBox.Show("Sıra numarası 1 veya daha büyük bir sayı olmalıdır.",
                        "Geçersiz Sıra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView_Widgetlar.CurrentCell = row.Cells["SiraNo"];
                    return false;
                }

                if (!siraSet.Add(siraNo))
                {
                    MessageBox.Show("Aynı sıra numarası birden fazla kartta kullanılamaz. 'Sırayı Düzelt' butonuna basabilirsin.",
                        "Tekrarlanan Sıra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView_Widgetlar.CurrentCell = row.Cells["SiraNo"];
                    return false;
                }
            }

            return true;
        }

        private void SeciliSatiriTasi(int yon)
        {
            if (dataGridView_Widgetlar.CurrentRow == null)
                return;

            int index = dataGridView_Widgetlar.CurrentRow.Index;
            int hedefIndex = index + yon;

            if (hedefIndex < 0 || hedefIndex >= dataGridView_Widgetlar.Rows.Count)
                return;

            dataGridView_Widgetlar.EndEdit();

            int mevcutSira = HucreInt(dataGridView_Widgetlar.Rows[index], "SiraNo");
            int hedefSira = HucreInt(dataGridView_Widgetlar.Rows[hedefIndex], "SiraNo");

            dataGridView_Widgetlar.Rows[index].Cells["SiraNo"].Value = hedefSira;
            dataGridView_Widgetlar.Rows[hedefIndex].Cells["SiraNo"].Value = mevcutSira;

            SirayaGoreYenidenCiz(hedefIndex);
        }

        private void SirayaGoreYenidenCiz(int secilecekIndex = 0)
        {
            var satirlar = SatirlariOku()
                .OrderBy(x => x.SiraNo)
                .ThenBy(x => x.Baslik)
                .ToList();

            dataGridView_Widgetlar.Rows.Clear();

            foreach (var row in satirlar)
            {
                dataGridView_Widgetlar.Rows.Add(
                    row.DashboardWidgetId,
                    row.GorunurMu,
                    row.SiraNo,
                    row.Baslik,
                    row.WidgetKodu,
                    row.VeriKaynagi,
                    row.WidgetTipi,
                    row.Aciklama
                );
            }

            if (dataGridView_Widgetlar.Rows.Count > 0)
            {
                secilecekIndex = Math.Max(0, Math.Min(secilecekIndex, dataGridView_Widgetlar.Rows.Count - 1));
                dataGridView_Widgetlar.CurrentCell = dataGridView_Widgetlar.Rows[secilecekIndex].Cells["Baslik"];
            }
        }

        private List<DashboardWidgetSatir> SatirlariOku()
        {
            var liste = new List<DashboardWidgetSatir>();

            foreach (DataGridViewRow row in dataGridView_Widgetlar.Rows)
            {
                if (row.IsNewRow)
                    continue;

                liste.Add(new DashboardWidgetSatir
                {
                    DashboardWidgetId = HucreInt(row, "DashboardWidgetId"),
                    GorunurMu = HucreBool(row, "GorunurMu"),
                    SiraNo = HucreInt(row, "SiraNo"),
                    Baslik = HucreString(row, "Baslik"),
                    WidgetKodu = HucreString(row, "WidgetKodu"),
                    VeriKaynagi = HucreString(row, "VeriKaynagi"),
                    WidgetTipi = HucreString(row, "WidgetTipi"),
                    Aciklama = HucreString(row, "Aciklama")
                });
            }

            return liste;
        }

        private void TumWidgetlariGorunurYap()
        {
            foreach (DataGridViewRow row in dataGridView_Widgetlar.Rows)
            {
                if (!row.IsNewRow)
                    row.Cells["GorunurMu"].Value = true;
            }

            DurumYaz("Tüm kartlar görünür yapıldı. Kaydetmeyi unutma.", false);
        }

        private void SirayiDuzelt()
        {
            dataGridView_Widgetlar.EndEdit();

            var satirlar = SatirlariOku()
                .OrderBy(x => x.SiraNo <= 0 ? int.MaxValue : x.SiraNo)
                .ThenBy(x => x.Baslik)
                .ToList();

            for (int i = 0; i < satirlar.Count; i++)
                satirlar[i].SiraNo = i + 1;

            dataGridView_Widgetlar.Rows.Clear();

            foreach (var row in satirlar)
            {
                dataGridView_Widgetlar.Rows.Add(
                    row.DashboardWidgetId,
                    row.GorunurMu,
                    row.SiraNo,
                    row.Baslik,
                    row.WidgetKodu,
                    row.VeriKaynagi,
                    row.WidgetTipi,
                    row.Aciklama
                );
            }

            DurumYaz("Sıra numaraları 1'den başlayacak şekilde düzeltildi. Kaydetmeyi unutma.", false);
        }

        private void dataGridView_Widgetlar_CellValidating(object? sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView_Widgetlar.Columns[e.ColumnIndex].Name != "SiraNo")
                return;

            var value = Convert.ToString(e.FormattedValue);

            if (!int.TryParse(value, out int siraNo) || siraNo <= 0)
            {
                e.Cancel = true;
                dataGridView_Widgetlar.Rows[e.RowIndex].ErrorText = "Sıra numarası 1 veya daha büyük olmalıdır.";
                DurumYaz("Sıra numarası 1 veya daha büyük olmalıdır.", true);
            }
        }

        private void dataGridView_Widgetlar_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dataGridView_Widgetlar.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void dataGridView_Widgetlar_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (dataGridView_Widgetlar.IsCurrentCellDirty)
                dataGridView_Widgetlar.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private int HucreInt(DataGridViewRow row, string columnName)
        {
            var value = row.Cells[columnName].Value;
            return int.TryParse(Convert.ToString(value), out int sonuc) ? sonuc : 0;
        }

        private bool HucreBool(DataGridViewRow row, string columnName)
        {
            var value = row.Cells[columnName].Value;

            if (value is bool boolValue)
                return boolValue;

            return bool.TryParse(Convert.ToString(value), out bool result) && result;
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

        private class DashboardWidgetSatir
        {
            public int DashboardWidgetId { get; set; }
            public bool GorunurMu { get; set; }
            public int SiraNo { get; set; }
            public string Baslik { get; set; } = string.Empty;
            public string WidgetKodu { get; set; } = string.Empty;
            public string VeriKaynagi { get; set; } = string.Empty;
            public string WidgetTipi { get; set; } = string.Empty;
            public string Aciklama { get; set; } = string.Empty;
        }
    }
}
