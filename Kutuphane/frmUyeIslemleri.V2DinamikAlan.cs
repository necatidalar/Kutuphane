using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using Kutuphane.UI.Helpers;

namespace Kutuphane.UI
{
    public partial class frmUyeIslemleri
    {
        private const string V2FormKoduUye = "UYE_FORM";
        private const string V2FormKoduHizliKayit = "UYE_HIZLI_KAYIT";
        private const string V2DinamikListeKolonPrefix = "V2_EK_ALAN_";
        private const string V2DinamikListeKolonTagPrefix = "V2_EK_ALAN:";

        private bool _v2DinamikAlanHazirlaniyor;
        private string _v2AktifFormKodu = V2FormKoduUye;
        private int _v2VarsayilanKurumId;
        private int _v2VarsayilanUyeTipiId;

        private GroupBox? _v2DinamikGroupBox;
        private ComboBox? _v2ComboBoxUyeTipi;
        private FlowLayoutPanel? _v2FlowDinamikAlanlar;

        private readonly Dictionary<int, Control> _v2DinamikAlanKontrolleri = new();
        private readonly List<FormAlanAyariDto> _v2AktifAlanlar = new();
        private readonly Dictionary<string, FormAlanAyariDto> _v2FormAlanAyarMap = new(StringComparer.OrdinalIgnoreCase);
        private readonly Dictionary<int, Dictionary<string, string>> _v2ListeEkAlanDegerleri = new();

        private readonly HashSet<string> _v2SabitAlanKodlari = new(StringComparer.OrdinalIgnoreCase)
        {
            "TC_PASS",
            "AD",
            "SOYAD",
            "CINSIYET",
            "DOGUM_TARIHI",
            "TELEFON",
            "EPOSTA",
            "ADRES",
            "ADRES_DETAY"
        };

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
                V2DinamikListeDegerleriniYukle(_tumUyeler);
                dataGrid_Uye.Refresh();
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
            _v2FormAlanAyarMap.Clear();

            int uyeTipiId = V2SeciliUyeTipiIdGetir();
            if (_v2VarsayilanKurumId <= 0 || uyeTipiId <= 0)
                return;

            var servis = V2ServiceFactory.DinamikAlanService();
            var sonuc = servis.FormAlanlariniGetir(_v2VarsayilanKurumId, uyeTipiId, _v2AktifFormKodu);

            if (!sonuc.IsSuccess)
            {
                MessageBox.Show(sonuc.Message, "Dinamik Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tumAlanlar = (sonuc.Data ?? new List<FormAlanAyariDto>())
                .Where(x => x.AktifMi)
                .OrderBy(x => x.SiraNo)
                .ThenBy(x => x.AlanAdi)
                .ToList();

            foreach (var alan in tumAlanlar)
                _v2FormAlanAyarMap[alan.AlanKodu] = alan;

            V2SabitAlanAyarlariniUygula(tumAlanlar);

            var ekAlanlar = tumAlanlar
                .Where(x => x.GorunurMu)
                .Where(x => !V2SabitAlanMi(x.AlanKodu))
                .OrderBy(x => x.SiraNo)
                .ThenBy(x => x.AlanAdi)
                .ToList();

            _v2AktifAlanlar.AddRange(ekAlanlar);

            foreach (var alan in ekAlanlar)
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

        private bool V2SabitAlanMi(string? alanKodu)
        {
            return !string.IsNullOrWhiteSpace(alanKodu) && _v2SabitAlanKodlari.Contains(alanKodu);
        }

        private Control? V2SabitAlanKontroluGetir(string alanKodu)
        {
            return alanKodu.ToUpperInvariant() switch
            {
                "TC_PASS" => textBox_TcPass,
                "AD" => textBox_Ad,
                "SOYAD" => textBox_Soyad,
                "CINSIYET" => comboBox_Cinsiyet,
                "DOGUM_TARIHI" => dateTimePicker1,
                "TELEFON" => textBox_Telefon,
                "EPOSTA" => textBox_Eposta,
                "ADRES" => textBox_Adres,
                "ADRES_DETAY" => richTextBox_AdresDetay,
                _ => null
            };
        }

        private Label? V2SabitAlanEtiketiGetir(string alanKodu)
        {
            return alanKodu.ToUpperInvariant() switch
            {
                "TC_PASS" => label3,
                "AD" => label4,
                "SOYAD" => label5,
                "CINSIYET" => label6,
                "DOGUM_TARIHI" => label7,
                "TELEFON" => label8,
                "EPOSTA" => label9,
                "ADRES" => label10,
                "ADRES_DETAY" => label11,
                _ => null
            };
        }

        private void V2SabitAlanAyarlariniUygula(List<FormAlanAyariDto> tumAlanlar)
        {
            var sabitAlanlar = tumAlanlar
                .Where(x => V2SabitAlanMi(x.AlanKodu))
                .OrderBy(x => x.SiraNo)
                .ThenBy(x => x.AlanAdi)
                .ToList();

            if (sabitAlanlar.Count == 0)
                return;

            foreach (var kod in _v2SabitAlanKodlari)
            {
                var kontrol = V2SabitAlanKontroluGetir(kod);
                var etiket = V2SabitAlanEtiketiGetir(kod);

                if (kontrol != null)
                {
                    kontrol.Visible = false;
                    kontrol.Enabled = true;
                }

                if (etiket != null)
                    etiket.Visible = false;
            }

            int y = 40;
            int inputLeft = 101;
            int labelRight = 98;

            foreach (var alan in sabitAlanlar)
            {
                var kontrol = V2SabitAlanKontroluGetir(alan.AlanKodu);
                var etiket = V2SabitAlanEtiketiGetir(alan.AlanKodu);

                if (kontrol == null || etiket == null)
                    continue;

                bool gorunur = alan.GorunurMu;
                kontrol.Visible = gorunur;
                etiket.Visible = gorunur;
                kontrol.Enabled = alan.DegistirilebilirMi;
                etiket.Text = alan.ZorunluMu ? alan.AlanAdi + ": *" : alan.AlanAdi + ":";
                etiket.ForeColor = alan.ZorunluMu ? Color.FromArgb(192, 57, 43) : Color.FromArgb(64, 64, 64);

                if (!gorunur)
                    continue;

                etiket.Left = Math.Max(4, labelRight - etiket.Width);
                etiket.Top = y + 3;
                kontrol.Left = inputLeft;
                kontrol.Top = y;
                kontrol.Width = 201;

                if (kontrol is RichTextBox)
                {
                    kontrol.Height = 53;
                    y += 62;
                }
                else
                {
                    kontrol.Height = 25;
                    y += 30;
                }
            }

            label2.Visible = true;
            textBox_UyeId.Visible = true;
            textBox_UyeId.Enabled = false;
            label2.Text = "Üye Id:";
            label2.Left = Math.Max(4, labelRight - label2.Width);
            label2.Top = 14;
            textBox_UyeId.Left = inputLeft;
            textBox_UyeId.Top = 11;

            panel1.Height = Math.Max(95, y + 10);
        }

        private bool V2SabitAlanZorunluKontrol()
        {
            if (_v2FormAlanAyarMap.Count == 0)
                return V2SabitAlanKlasikZorunluKontrol();

            foreach (var alan in _v2FormAlanAyarMap.Values
                         .Where(x => V2SabitAlanMi(x.AlanKodu))
                         .Where(x => x.GorunurMu && x.ZorunluMu)
                         .OrderBy(x => x.SiraNo))
            {
                var kontrol = V2SabitAlanKontroluGetir(alan.AlanKodu);
                if (kontrol == null)
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

        private bool V2SabitAlanKlasikZorunluKontrol()
        {
            if (string.IsNullOrWhiteSpace(textBox_TcPass.Text))
            {
                MessageBox.Show("Tc Pass boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Ad.Text))
            {
                MessageBox.Show("Ad boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Soyad.Text))
            {
                MessageBox.Show("Soyad boş bırakılamaz.");
                return false;
            }
            if (comboBox_Cinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir cinsiyet seçiniz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Telefon.Text))
            {
                MessageBox.Show("Telefon boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Eposta.Text))
            {
                MessageBox.Show("Eposta boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Adres.Text))
            {
                MessageBox.Show("Adres boş bırakılamaz.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(richTextBox_AdresDetay.Text))
            {
                MessageBox.Show("Adres Detay boş bırakılamaz.");
                return false;
            }

            return true;
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
                RichTextBox richTextBox => string.IsNullOrWhiteSpace(richTextBox.Text),
                ComboBox comboBox => comboBox.SelectedIndex < 0 || comboBox.SelectedValue == null,
                DateTimePicker dateTimePicker => dateTimePicker.ShowCheckBox && !dateTimePicker.Checked,
                _ => false
            };
        }

        private int V2CinsiyetIdGuvenliAl()
        {
            if (comboBox_Cinsiyet.SelectedItem is Cinsiyet secili)
                return secili.Id;

            if (comboBox_Cinsiyet.SelectedValue is byte byteId)
                return byteId;

            if (comboBox_Cinsiyet.SelectedValue is int intId)
                return intId;

            if (byte.TryParse(comboBox_Cinsiyet.SelectedValue?.ToString(), out byte parsedByte))
                return parsedByte;

            using var db = new Kutuphane.DAL.Contexes.KutuphaneDbContext();
            return db.Cinsiyetler.OrderBy(x => x.Id).Select(x => (int)x.Id).FirstOrDefault();
        }

        private DateTime V2DogumTarihiGuvenliAl()
        {
            return dateTimePicker1.Value;
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

        private void V2AktifFormKoduAyarla(string formKodu)
        {
            formKodu = string.IsNullOrWhiteSpace(formKodu) ? V2FormKoduUye : formKodu.Trim().ToUpperInvariant();
            if (!string.Equals(_v2AktifFormKodu, formKodu, StringComparison.OrdinalIgnoreCase))
                _v2AktifFormKodu = formKodu;

            if (_v2DinamikGroupBox != null)
            {
                _v2DinamikGroupBox.Text = V2HizliKayitModuAktifMi()
                    ? "⚡ Hızlı Üye Kayıt Alanları"
                    : "⚙️ Dinamik Üye Alanları";
            }

            V2DinamikAlanlariYukle();
            V2DinamikAlanlariTemizle(false);
        }

        private bool V2HizliKayitModuAktifMi()
        {
            return string.Equals(_v2AktifFormKodu, V2FormKoduHizliKayit, StringComparison.OrdinalIgnoreCase);
        }

        private void V2ListeKolonAyarlariniYenile()
        {
            V2DinamikListeKolonlariniEkle();
            V2DinamikListeDegerleriniYukle(bilUyeDto);
            dataGrid_Uye.Refresh();
        }

        private DataGridViewColumn? V2SabitListeKolonuGetir(string alanKodu)
        {
            return alanKodu.ToUpperInvariant() switch
            {
                "TC_PASS" => tcPassDataGridViewTextBoxColumn,
                "AD" => adDataGridViewTextBoxColumn,
                "SOYAD" => soyadDataGridViewTextBoxColumn,
                "CINSIYET" => cinsiyetDataGridViewTextBoxColumn,
                "DOGUM_TARIHI" => dogumTarihiDataGridViewTextBoxColumn,
                "TELEFON" => telefonDataGridViewTextBoxColumn,
                "EPOSTA" => epostaDataGridViewTextBoxColumn,
                "ADRES" => adresDataGridViewTextBoxColumn,
                "ADRES_DETAY" => adresDetayDataGridViewTextBoxColumn,
                _ => null
            };
        }

        private string? V2BilinenEkAlanPropertyGetir(string alanKodu)
        {
            return alanKodu.ToUpperInvariant() switch
            {
                "OKUL_NO" => "OkulNo",
                "SINIF" => "Sinif",
                "SUBE" => "Sube",
                "VELI_ADI" => "VeliAdi",
                "VELI_TELEFONU" => "VeliTelefonu",
                "BRANS" => "Brans",
                _ => null
            };
        }

        private string V2DinamikKolonAdiOlustur(string alanKodu)
        {
            var temizKod = new string((alanKodu ?? string.Empty).Select(ch => char.IsLetterOrDigit(ch) ? ch : '_').ToArray());
            return V2DinamikListeKolonPrefix + temizKod.ToUpperInvariant();
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

            var tekilKolonlar = kolonAlanlari
                .Where(x => x.GorunurMu && x.ListedeGorunsunMu)
                .GroupBy(x => x.AlanKodu, StringComparer.OrdinalIgnoreCase)
                .Select(g => g.OrderBy(x => x.SiraNo).First())
                .OrderBy(x => x.SiraNo)
                .ThenBy(x => x.AlanAdi)
                .ToList();

            var bilinenEkAlanPropertyleri = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "OkulNo",
                "Sinif",
                "Sube",
                "VeliAdi",
                "VeliTelefonu",
                "Brans"
            };

            foreach (DataGridViewColumn kolon in dataGrid_Uye.Columns)
            {
                if (kolon.Name.StartsWith(V2DinamikListeKolonPrefix, StringComparison.OrdinalIgnoreCase))
                {
                    kolon.Visible = false;
                    continue;
                }

                if (!string.IsNullOrWhiteSpace(kolon.DataPropertyName) && bilinenEkAlanPropertyleri.Contains(kolon.DataPropertyName))
                {
                    kolon.Visible = false;
                    continue;
                }
            }

            foreach (var kod in _v2SabitAlanKodlari)
            {
                var sabitKolon = V2SabitListeKolonuGetir(kod);
                if (sabitKolon != null)
                    sabitKolon.Visible = false;
            }

            int displayIndex = 0;
            foreach (var alan in tekilKolonlar)
            {
                DataGridViewColumn? kolon = null;

                if (V2SabitAlanMi(alan.AlanKodu))
                {
                    kolon = V2SabitListeKolonuGetir(alan.AlanKodu);
                }
                else
                {
                    var propertyName = V2BilinenEkAlanPropertyGetir(alan.AlanKodu);

                    if (!string.IsNullOrWhiteSpace(propertyName))
                    {
                        kolon = dataGrid_Uye.Columns
                            .Cast<DataGridViewColumn>()
                            .FirstOrDefault(x => string.Equals(x.DataPropertyName, propertyName, StringComparison.OrdinalIgnoreCase));

                        if (kolon == null)
                        {
                            kolon = new DataGridViewTextBoxColumn
                            {
                                Name = propertyName,
                                DataPropertyName = propertyName,
                                HeaderText = alan.AlanAdi,
                                Width = 120
                            };
                            dataGrid_Uye.Columns.Add(kolon);
                        }
                    }
                    else
                    {
                        string kolonAdi = V2DinamikKolonAdiOlustur(alan.AlanKodu);
                        if (!dataGrid_Uye.Columns.Contains(kolonAdi))
                        {
                            kolon = new DataGridViewTextBoxColumn
                            {
                                Name = kolonAdi,
                                HeaderText = alan.AlanAdi,
                                Width = 130,
                                Tag = V2DinamikListeKolonTagPrefix + alan.AlanKodu
                            };
                            dataGrid_Uye.Columns.Add(kolon);
                        }
                        else
                        {
                            kolon = dataGrid_Uye.Columns[kolonAdi];
                            kolon.Tag = V2DinamikListeKolonTagPrefix + alan.AlanKodu;
                        }
                    }
                }

                if (kolon == null)
                    continue;

                kolon.HeaderText = alan.AlanAdi;
                kolon.Visible = true;
                try
                {
                    kolon.DisplayIndex = Math.Min(displayIndex, dataGrid_Uye.Columns.Count - 1);
                }
                catch
                {
                    // DisplayIndex çakışmalarında grid kendi sırasını korusun.
                }
                displayIndex++;
            }

            uyeIdDataGridViewTextBoxColumn.Visible = false;
            cinsiyetIdDataGridViewTextBoxColumn.Visible = false;
            aktifMiDataGridViewCheckBoxColumn.Visible = false;
        }

        private void V2DinamikListeDegerleriniYukle(IEnumerable<UyeDto>? uyeler)
        {
            _v2ListeEkAlanDegerleri.Clear();

            if (uyeler == null)
                return;

            bool ekDinamikKolonVar = dataGrid_Uye.Columns
                .Cast<DataGridViewColumn>()
                .Any(x => x.Name.StartsWith(V2DinamikListeKolonPrefix, StringComparison.OrdinalIgnoreCase));

            if (!ekDinamikKolonVar)
                return;

            var servis = V2ServiceFactory.DinamikAlanService();

            foreach (var uye in uyeler.Where(x => x.UyeId > 0))
            {
                var sonuc = servis.EntityEkAlanDegerleriniGetir("UYE", uye.UyeId);
                if (!sonuc.IsSuccess || sonuc.Data == null)
                    continue;

                _v2ListeEkAlanDegerleri[uye.UyeId] = sonuc.Data
                    .GroupBy(x => x.AlanKodu, StringComparer.OrdinalIgnoreCase)
                    .ToDictionary(
                        g => g.Key,
                        g => g.First().DegerGosterim
                             ?? g.First().DegerText
                             ?? g.First().DegerNumber?.ToString()
                             ?? g.First().DegerDecimal?.ToString()
                             ?? g.First().DegerDate?.ToShortDateString()
                             ?? (g.First().DegerBool.HasValue ? (g.First().DegerBool.Value ? "Evet" : "Hayır") : string.Empty),
                        StringComparer.OrdinalIgnoreCase);
            }
        }

        private object? V2DinamikListeHucreDegeriniAl(int rowIndex, int columnIndex)
        {
            if (rowIndex < 0 || columnIndex < 0 || rowIndex >= dataGrid_Uye.Rows.Count || columnIndex >= dataGrid_Uye.Columns.Count)
                return null;

            var kolon = dataGrid_Uye.Columns[columnIndex];
            if (kolon.Tag is not string tag || !tag.StartsWith(V2DinamikListeKolonTagPrefix, StringComparison.OrdinalIgnoreCase))
                return null;

            if (dataGrid_Uye.Rows[rowIndex].DataBoundItem is not UyeDto uye)
                return null;

            string alanKodu = tag.Substring(V2DinamikListeKolonTagPrefix.Length);
            if (_v2ListeEkAlanDegerleri.TryGetValue(uye.UyeId, out var degerler) && degerler.TryGetValue(alanKodu, out var deger))
                return deger;

            return string.Empty;
        }

        private void V2DinamikListeHucreDegeriniYaz(DataGridViewCellFormattingEventArgs e)
        {
            var deger = V2DinamikListeHucreDegeriniAl(e.RowIndex, e.ColumnIndex);
            if (deger == null)
                return;

            e.Value = deger;
            e.FormattingApplied = true;
        }

        private bool V2DinamikListeDegerlerindeAra(int uyeId, string arama)
        {
            if (uyeId <= 0 || string.IsNullOrWhiteSpace(arama))
                return false;

            if (!_v2ListeEkAlanDegerleri.TryGetValue(uyeId, out var degerler))
                return false;

            return degerler.Values.Any(x => !string.IsNullOrWhiteSpace(x) && x.ToLower().Contains(arama));
        }
    }
}
