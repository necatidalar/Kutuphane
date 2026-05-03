using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using Kutuphane.UI.Helpers;

namespace Kutuphane.UI
{
    public partial class frmUyeIslemleri
    {
        private const string V2FormKoduUye = "UYE_FORM";

        private bool _v2DinamikAlanHazirlaniyor;
        private int _v2VarsayilanKurumId;
        private int _v2VarsayilanUyeTipiId;

        private GroupBox? _v2DinamikGroupBox;
        private ComboBox? _v2ComboBoxUyeTipi;
        private FlowLayoutPanel? _v2FlowDinamikAlanlar;

        private readonly Dictionary<int, Control> _v2DinamikAlanKontrolleri = new();
        private readonly List<FormAlanAyariDto> _v2AktifAlanlar = new();

        private void V2DinamikAlanSisteminiHazirla()
        {
            if (_v2DinamikGroupBox != null)
                return;

            try
            {
                V2VarsayilanKurumVeUyeTipiYukle();
                V2DinamikAlanPaneliniOlustur();
                V2UyeTipiListesiniYukle();
                V2DinamikAlanlariYukle();
                V2DinamikListeKolonlariniEkle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dinamik alan sistemi hazırlanırken hata oluştu:\n" + ex.Message, "V2 Dinamik Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void V2VarsayilanKurumVeUyeTipiYukle()
        {
            using var db = new Kutuphane.DAL.Contexes.KutuphaneDbContext();

            var kurum = db.Kurumlar.FirstOrDefault(x => x.KurumKodu == "VARSAYILAN" && x.AktifMi)
                        ?? db.Kurumlar.FirstOrDefault(x => x.AktifMi);

            if (kurum == null)
                throw new InvalidOperationException("Aktif kurum bulunamadı.");

            _v2VarsayilanKurumId = kurum.KurumId;

            var disUye = db.UyeTipleri.FirstOrDefault(x => x.UyeTipiKodu == "DIS_UYE" && x.AktifMi)
                         ?? db.UyeTipleri.FirstOrDefault(x => x.AktifMi);

            if (disUye == null)
                throw new InvalidOperationException("Aktif üye tipi bulunamadı.");

            _v2VarsayilanUyeTipiId = disUye.UyeTipiId;
        }

        private void V2DinamikAlanPaneliniOlustur()
        {
            _v2DinamikGroupBox = new GroupBox
            {
                Text = "⚙️ Dinamik Üye Alanları",
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Location = dataGrid_Uye.Location,
                Size = new Size(dataGrid_Uye.Width, 150),
                BackColor = Color.White
            };

            var labelUyeTipi = new Label
            {
                Text = "Üye Tipi:",
                AutoSize = true,
                ForeColor = Color.FromArgb(64, 64, 64),
                Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold),
                Location = new Point(14, 30)
            };

            _v2ComboBoxUyeTipi = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 9.5F),
                Location = new Point(90, 26),
                Size = new Size(210, 25)
            };
            _v2ComboBoxUyeTipi.SelectedIndexChanged += (_, _) =>
            {
                if (!_v2DinamikAlanHazirlaniyor)
                    V2DinamikAlanlariYukle();
            };

            _v2FlowDinamikAlanlar = new FlowLayoutPanel
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                Location = new Point(14, 58),
                Size = new Size(_v2DinamikGroupBox.Width - 28, 84),
                AutoScroll = true,
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight,
                BackColor = Color.White
            };

            _v2DinamikGroupBox.Controls.Add(labelUyeTipi);
            _v2DinamikGroupBox.Controls.Add(_v2ComboBoxUyeTipi);
            _v2DinamikGroupBox.Controls.Add(_v2FlowDinamikAlanlar);

            Controls.Add(_v2DinamikGroupBox);
            _v2DinamikGroupBox.BringToFront();

            dataGrid_Uye.Top = _v2DinamikGroupBox.Bottom + 8;
            dataGrid_Uye.Height = ClientSize.Height - dataGrid_Uye.Top - 18;
        }

        private void V2UyeTipiListesiniYukle()
        {
            if (_v2ComboBoxUyeTipi == null)
                return;

            _v2DinamikAlanHazirlaniyor = true;

            using var db = new Kutuphane.DAL.Contexes.KutuphaneDbContext();
            var uyeTipleri = db.UyeTipleri
                .Where(x => x.AktifMi)
                .OrderBy(x => x.UyeTipiId)
                .ToList();

            _v2ComboBoxUyeTipi.DataSource = uyeTipleri;
            _v2ComboBoxUyeTipi.DisplayMember = nameof(UyeTipi.UyeTipiAdi);
            _v2ComboBoxUyeTipi.ValueMember = nameof(UyeTipi.UyeTipiId);

            if (_v2VarsayilanUyeTipiId > 0)
                _v2ComboBoxUyeTipi.SelectedValue = _v2VarsayilanUyeTipiId;

            _v2DinamikAlanHazirlaniyor = false;
        }

        private void V2DinamikAlanlariYukle()
        {
            if (_v2FlowDinamikAlanlar == null)
                return;

            _v2FlowDinamikAlanlar.Controls.Clear();
            _v2DinamikAlanKontrolleri.Clear();
            _v2AktifAlanlar.Clear();

            int uyeTipiId = V2SeciliUyeTipiIdGetir();
            if (_v2VarsayilanKurumId <= 0 || uyeTipiId <= 0)
                return;

            var servis = V2ServiceFactory.DinamikAlanService();
            var sonuc = servis.FormAlanlariniGetir(_v2VarsayilanKurumId, uyeTipiId, V2FormKoduUye);

            if (!sonuc.IsSuccess)
            {
                MessageBox.Show(sonuc.Message, "Dinamik Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var alanlar = (sonuc.Data ?? new List<FormAlanAyariDto>())
                .Where(x => x.GorunurMu)
                .OrderBy(x => x.SiraNo)
                .ToList();

            _v2AktifAlanlar.AddRange(alanlar);

            foreach (var alan in alanlar)
            {
                var satirPanel = V2DinamikAlanKontroluOlustur(alan);
                _v2FlowDinamikAlanlar.Controls.Add(satirPanel);
            }
        }

        private Panel V2DinamikAlanKontroluOlustur(FormAlanAyariDto alan)
        {
            var panel = new Panel
            {
                Width = 250,
                Height = 54,
                Margin = new Padding(4),
                BackColor = Color.White
            };

            var label = new Label
            {
                Text = alan.ZorunluMu ? alan.AlanAdi + " *" : alan.AlanAdi,
                AutoSize = false,
                Location = new Point(0, 0),
                Size = new Size(245, 18),
                Font = new Font("Segoe UI Semibold", 8.7F, FontStyle.Bold),
                ForeColor = alan.ZorunluMu ? Color.FromArgb(192, 57, 43) : Color.FromArgb(64, 64, 64)
            };

            Control input = V2InputKontroluOlustur(alan);
            input.Location = new Point(0, 22);
            input.Size = new Size(238, 25);
            input.Enabled = alan.DegistirilebilirMi;
            input.Tag = alan;

            _v2DinamikAlanKontrolleri[alan.AlanTanimId] = input;

            panel.Controls.Add(label);
            panel.Controls.Add(input);

            return panel;
        }

        private Control V2InputKontroluOlustur(FormAlanAyariDto alan)
        {
            switch ((alan.VeriTipi ?? string.Empty).ToUpperInvariant())
            {
                case "SELECT":
                    var combo = new ComboBox
                    {
                        DropDownStyle = ComboBoxStyle.DropDownList,
                        Font = new Font("Segoe UI", 9F)
                    };

                    var servis = V2ServiceFactory.DinamikAlanService();
                    var secenekSonuc = servis.AlanSecenekleriniGetir(alan.AlanTanimId);
                    var secenekler = secenekSonuc.IsSuccess
                        ? secenekSonuc.Data ?? new List<AlanSecenekDto>()
                        : new List<AlanSecenekDto>();

                    combo.DataSource = secenekler;
                    combo.DisplayMember = nameof(AlanSecenekDto.Etiket);
                    combo.ValueMember = nameof(AlanSecenekDto.Deger);
                    combo.SelectedIndex = -1;
                    return combo;

                case "NUMBER":
                    return new NumericUpDown
                    {
                        Font = new Font("Segoe UI", 9F),
                        Minimum = 0,
                        Maximum = 100000000,
                        DecimalPlaces = 0
                    };

                case "DECIMAL":
                    return new NumericUpDown
                    {
                        Font = new Font("Segoe UI", 9F),
                        Minimum = 0,
                        Maximum = 100000000,
                        DecimalPlaces = 2
                    };

                case "DATE":
                    return new DateTimePicker
                    {
                        Font = new Font("Segoe UI", 9F),
                        Format = DateTimePickerFormat.Short,
                        ShowCheckBox = true,
                        Checked = false
                    };

                case "BOOL":
                    return new CheckBox
                    {
                        Font = new Font("Segoe UI", 9F),
                        Text = "Evet",
                        AutoSize = true
                    };

                default:
                    return new TextBox
                    {
                        Font = new Font("Segoe UI", 9F),
                        MaxLength = alan.MaxLength ?? 32767
                    };
            }
        }

        private bool V2DinamikAlanZorunluKontrol()
        {
            foreach (var alan in _v2AktifAlanlar.Where(x => x.ZorunluMu))
            {
                if (!_v2DinamikAlanKontrolleri.TryGetValue(alan.AlanTanimId, out var kontrol))
                    continue;

                if (V2KontrolBosMu(kontrol))
                {
                    MessageBox.Show($"{alan.AlanAdi} boş bırakılamaz.", "Zorunlu Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    kontrol.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool V2KontrolBosMu(Control kontrol)
        {
            return kontrol switch
            {
                TextBox textBox => string.IsNullOrWhiteSpace(textBox.Text),
                ComboBox comboBox => comboBox.SelectedIndex < 0 || comboBox.SelectedValue == null,
                DateTimePicker dateTimePicker => dateTimePicker.ShowCheckBox && !dateTimePicker.Checked,
                _ => false
            };
        }

        private int V2UyeIdGuvenliGetir(Uye uye)
        {
            if (uye.UyeId > 0)
                return uye.UyeId;

            using var db = new Kutuphane.DAL.Contexes.KutuphaneDbContext();

            return db.Uyeler
                .Where(x => x.TcPass == uye.TcPass && x.Ad == uye.Ad && x.Soyad == uye.Soyad)
                .OrderByDescending(x => x.UyeId)
                .Select(x => x.UyeId)
                .FirstOrDefault();
        }

        private void V2DinamikAlanDegerleriniKaydet(int uyeId)
        {
            if (uyeId <= 0 || _v2AktifAlanlar.Count == 0)
                return;

            var servis = V2ServiceFactory.DinamikAlanService();
            var hatalar = new List<string>();

            foreach (var alan in _v2AktifAlanlar)
            {
                if (!_v2DinamikAlanKontrolleri.TryGetValue(alan.AlanTanimId, out var kontrol))
                    continue;

                var deger = V2KontrolDegeriAl(alan, kontrol);

                var sonuc = servis.EntityEkAlanDegeriKaydet(
                    "UYE",
                    uyeId,
                    alan.AlanTanimId,
                    deger.DegerText,
                    deger.DegerNumber,
                    deger.DegerDecimal,
                    deger.DegerDate,
                    deger.DegerBool
                );

                if (!sonuc.IsSuccess)
                    hatalar.Add($"{alan.AlanAdi}: {sonuc.Message}");
            }

            if (hatalar.Count > 0)
            {
                MessageBox.Show("Bazı dinamik alanlar kaydedilemedi:\n" + string.Join("\n", hatalar), "Dinamik Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private (string? DegerText, int? DegerNumber, decimal? DegerDecimal, DateTime? DegerDate, bool? DegerBool) V2KontrolDegeriAl(FormAlanAyariDto alan, Control kontrol)
        {
            switch ((alan.VeriTipi ?? string.Empty).ToUpperInvariant())
            {
                case "SELECT":
                    return ((kontrol as ComboBox)?.SelectedValue?.ToString(), null, null, null, null);

                case "NUMBER":
                    return (null, Convert.ToInt32((kontrol as NumericUpDown)?.Value ?? 0), null, null, null);

                case "DECIMAL":
                    return (null, null, (kontrol as NumericUpDown)?.Value, null, null);

                case "DATE":
                    var dt = kontrol as DateTimePicker;
                    return (null, null, null, dt != null && (!dt.ShowCheckBox || dt.Checked) ? dt.Value : null, null);

                case "BOOL":
                    return (null, null, null, null, (kontrol as CheckBox)?.Checked);

                default:
                    return ((kontrol as TextBox)?.Text.Trim(), null, null, null, null);
            }
        }

        private void V2DinamikAlanDegerleriniYukle(int uyeId)
        {
            if (uyeId <= 0 || _v2AktifAlanlar.Count == 0)
                return;

            V2DinamikAlanlariTemizle(false);

            var servis = V2ServiceFactory.DinamikAlanService();
            var sonuc = servis.EntityEkAlanDegerleriniGetir("UYE", uyeId);

            if (!sonuc.IsSuccess || sonuc.Data == null)
                return;

            foreach (var deger in sonuc.Data)
            {
                if (!_v2DinamikAlanKontrolleri.TryGetValue(deger.AlanTanimId, out var kontrol))
                    continue;

                V2KontrolDegeriYaz(kontrol, deger);
            }
        }

        private void V2KontrolDegeriYaz(Control kontrol, EntityEkAlanDegeriDto deger)
        {
            switch (kontrol)
            {
                case TextBox textBox:
                    textBox.Text = deger.DegerText ?? string.Empty;
                    break;

                case ComboBox comboBox:
                    comboBox.SelectedValue = deger.DegerText ?? string.Empty;
                    break;

                case NumericUpDown numeric when deger.DegerNumber.HasValue:
                    numeric.Value = Math.Min(numeric.Maximum, Math.Max(numeric.Minimum, deger.DegerNumber.Value));
                    break;

                case NumericUpDown numeric when deger.DegerDecimal.HasValue:
                    numeric.Value = Math.Min(numeric.Maximum, Math.Max(numeric.Minimum, deger.DegerDecimal.Value));
                    break;

                case DateTimePicker dateTimePicker:
                    if (deger.DegerDate.HasValue)
                    {
                        dateTimePicker.Checked = true;
                        dateTimePicker.Value = deger.DegerDate.Value;
                    }
                    else
                    {
                        dateTimePicker.Checked = false;
                    }
                    break;

                case CheckBox checkBox:
                    checkBox.Checked = deger.DegerBool ?? false;
                    break;
            }
        }

        private void V2DinamikAlanlariTemizle(bool uyeTipiVarsayilanaDon = true)
        {
            foreach (var kontrol in _v2DinamikAlanKontrolleri.Values)
            {
                switch (kontrol)
                {
                    case TextBox textBox:
                        textBox.Clear();
                        break;
                    case ComboBox comboBox:
                        comboBox.SelectedIndex = -1;
                        break;
                    case NumericUpDown numeric:
                        numeric.Value = numeric.Minimum;
                        break;
                    case DateTimePicker dateTimePicker:
                        dateTimePicker.Checked = false;
                        dateTimePicker.Value = DateTime.Today;
                        break;
                    case CheckBox checkBox:
                        checkBox.Checked = false;
                        break;
                }
            }

            if (uyeTipiVarsayilanaDon)
                V2UyeTipiSec(_v2VarsayilanUyeTipiId);
        }

        private int V2SeciliKurumIdGetir()
        {
            return _v2VarsayilanKurumId > 0 ? _v2VarsayilanKurumId : 1;
        }

        private int V2SeciliUyeTipiIdGetir()
        {
            if (_v2ComboBoxUyeTipi?.SelectedValue is int id && id > 0)
                return id;

            if (int.TryParse(_v2ComboBoxUyeTipi?.SelectedValue?.ToString(), out int parsedId) && parsedId > 0)
                return parsedId;

            return _v2VarsayilanUyeTipiId > 0 ? _v2VarsayilanUyeTipiId : 1;
        }

        private void V2UyeTipiSec(int uyeTipiId)
        {
            if (_v2ComboBoxUyeTipi == null || uyeTipiId <= 0)
                return;

            try
            {
                _v2DinamikAlanHazirlaniyor = true;
                _v2ComboBoxUyeTipi.SelectedValue = uyeTipiId;
            }
            finally
            {
                _v2DinamikAlanHazirlaniyor = false;
            }

            V2DinamikAlanlariYukle();
        }

        private void V2DinamikListeKolonlariniEkle()
        {
            var servis = V2ServiceFactory.DinamikAlanService();
            var kolonAlanlari = new List<FormAlanAyariDto>();

            using (var db = new Kutuphane.DAL.Contexes.KutuphaneDbContext())
            {
                var uyeTipiIdleri = db.UyeTipleri
                    .Where(x => x.AktifMi)
                    .Select(x => x.UyeTipiId)
                    .ToList();

                foreach (var uyeTipiId in uyeTipiIdleri)
                {
                    var sonuc = servis.FormListeKolonlariniGetir(_v2VarsayilanKurumId, uyeTipiId, V2FormKoduUye);
                    if (sonuc.IsSuccess && sonuc.Data != null)
                        kolonAlanlari.AddRange(sonuc.Data);
                }
            }

            foreach (var alan in kolonAlanlari
                         .GroupBy(x => x.AlanKodu)
                         .Select(g => g.OrderBy(x => x.SiraNo).First())
                         .OrderBy(x => x.SiraNo))
            {
                string propertyName = alan.AlanKodu switch
                {
                    "OKUL_NO" => "OkulNo",
                    "SINIF" => "Sinif",
                    "SUBE" => "Sube",
                    "VELI_ADI" => "VeliAdi",
                    "VELI_TELEFONU" => "VeliTelefonu",
                    "BRANS" => "Brans",
                    _ => string.Empty
                };

                if (string.IsNullOrWhiteSpace(propertyName))
                    continue;

                if (dataGrid_Uye.Columns.Contains(propertyName))
                    continue;

                dataGrid_Uye.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = propertyName,
                    DataPropertyName = propertyName,
                    HeaderText = alan.AlanAdi,
                    Width = 120
                });
            }
        }
    }
}
