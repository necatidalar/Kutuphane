using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using Kutuphane.UI.Theme;
using Kutuphane.UI.UIMetodlar;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmAdmin : Form
    {
        BindingList<Rol> bilRoller = new BindingList<Rol>();
        BindingList<Yetki> bilYetki = new BindingList<Yetki>();
        BindingList<Personel> bilPersonel = new BindingList<Personel>();
        BindingList<PersonelRolDto> bilPersonelRolleri = new BindingList<PersonelRolDto>();

        IRolService rolService = new RolManager(new RolDal());
        IYetkiService yetkiService = new YetkiManager(new YetkiDal());
        IRolYetkiService rolYetkiService = new RolYetkiManager(new RolYetkiDal());
        IPersonelService personelService = new PersonelManager(new PersonelDal());
        IPersonelRolService personelRolService = new PersonelRolManager(new PersonelRolDal());

        private readonly YetkiKontrol _yetkiKontrol;
        private readonly int _personelId;
        private HashSet<string> _userPermissions;
        public frmAdmin(int personelId)
        {
            InitializeComponent();
            dgvRoller.DataSource = bilRoller;
            dgvYetki.DataSource = bilYetki;
            dgvPersonel.DataSource = bilPersonel;
            dgvPersonelRolleri.DataSource = bilPersonelRolleri;

            _personelId = personelId;
            _yetkiKontrol = new YetkiKontrol(new KutuphaneDbContext());
            _userPermissions = _yetkiKontrol.KullaniciYetkileriniAl(_personelId);
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            DataGridThemeManager.Apply(dgvRoller);
            DataGridThemeManager.Apply(dgvYetki);
            DataGridThemeManager.Apply(dgvPersonel);
            DataGridThemeManager.Apply(dgvPersonelRolleri);

            YetkiKontrol();
            bool listeYetkisi =
                _userPermissions.Contains("YONETIM_LISTELE") ||
                _userPermissions.Contains("YONETIM_EKLE") ||
                _userPermissions.Contains("YONETIM_GUNCELLE") ||
                _userPermissions.Contains("YONETIM_SIL");

            if (listeYetkisi)
            {
                RolleriYukle();
                YetkileriYukle();
                PersonelleriYukle();
            }
            dgvYetki.ReadOnly = false;
            Secim.ReadOnly = false;
        }
        private void YetkiKontrol()
        {
            bool ekle = _userPermissions.Contains("YONETIM_EKLE");
            bool guncelle = _userPermissions.Contains("YONETIM_GUNCELLE");
            bool sil = _userPermissions.Contains("YONETIM_SIL");
            bool listele = _userPermissions.Contains("YONETIM_LISTELE");

            bool listeYetkisi = listele || ekle || guncelle || sil;

            dgvRoller.Enabled = listeYetkisi;
            dgvYetki.Enabled = listeYetkisi;
            dgvPersonel.Enabled = listeYetkisi;
            dgvPersonelRolleri.Enabled = listeYetkisi;

            btnRolEkle.Enabled = ekle;
            btnRolGuncelle.Enabled = guncelle;
            btnRolSil.Enabled = sil;

            bool yetkiDagitabilir = ekle;
            btnYetkiKaydet.Enabled = yetkiDagitabilir;
            btnPersonelRolKaydet.Enabled = yetkiDagitabilir;

            panelRolIslemleri.Enabled = ekle || guncelle || sil;
        }
        private void RolleriYukle()
        {
            var rolResult = rolService.GetListByFilterService(x => x.AktifMi == true &&
            (x.RolAdi.Contains(txtRolAra.Text)));

            if (!rolResult.IsSuccess)
            {
                MessageBox.Show(rolResult.Message, "Hata");
                return;
            }

            bilRoller.Clear();
            foreach (var item in rolResult.Data)
                bilRoller.Add(item);

            dgvRoller.ClearSelection();
        }
        private void YetkileriYukle()
        {
            var yetkiler = yetkiService.GetListByFilterService(x => x.YetkiAdi.Contains(txtYetkiAra.Text) ||
            x.YetkiKodu.Contains(txtYetkiAra.Text));

            bilYetki.Clear();
            foreach (var item in yetkiler.Data)
                bilYetki.Add(item);

            dgvYetki.AutoGenerateColumns = false;
            dgvYetki.DataSource = bilYetki;
        }
        private void PersonelleriYukle()
        {
            var result = personelService.GetListByFilterService(x =>
                x.AktifMi == true &&
                (x.Ad.Contains(txtPersonelAra.Text)) || (x.Soyad.Contains(txtPersonelAra.Text)));

            bilPersonel.Clear();
            foreach (var item in result.Data)
                bilPersonel.Add(item);
        }
        private void PersonelRolleriniYukle(int personelId)
        {
            var result = personelRolService.PersonelRolleriniGetir();

            bilPersonelRolleri.Clear();
            foreach (var item in result.Data)
                bilPersonelRolleri.Add(item);

            dgvPersonelRolleri.DataSource = bilPersonelRolleri;
        }
        private void txtRolAra_TextChanged(object sender, EventArgs e)
        {
            RolleriYukle();
        }
        private void txtYetkiAra_TextChanged(object sender, EventArgs e)
        {
            YetkileriYukle();
        }
        private void btnRolEkle_Click(object sender, EventArgs e)
        {
            Rol yeniRol = new Rol
            {
                RolAdi = txtRolAdi.Text,
                RolKodu = txtRolKodu.Text,
                AktifMi = true
            };
            var rolResult = rolService.AddService(yeniRol);
            if (rolResult.IsSuccess)
            {
                MessageBox.Show(rolResult.Message + "Rol başarıyla kaydedildi.", "Başarılı");
                RolleriYukle();
            }
            else
            {
                MessageBox.Show(rolResult.Message, "Hata");
            }
        }
        private void btnYetkiKaydet_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRolId.Text, out int rolId))
            {
                MessageBox.Show("Lütfen önce bir rol seçiniz.", "Uyarı");
                return;
            }

            var eskiYetkiler = rolYetkiService.GetListByFilterService(x => x.RolId == rolId);
            if (eskiYetkiler.Data != null)
            {
                foreach (var item in eskiYetkiler.Data)
                {
                    rolYetkiService.DeleteService(item);
                }
            }

            foreach (DataGridViewRow row in dgvYetki.Rows)
            {
                bool secili = row.Cells["Secim"].Value != null && Convert.ToBoolean(row.Cells["Secim"].Value);

                if (!secili)
                    continue;

                int yetkiId = (int)row.Cells["yetkiIdDataGridViewTextBoxColumn"].Value;

                RolYetki yeniRolYetki = new RolYetki
                {
                    RolId = rolId,
                    YetkiId = yetkiId
                };

                rolYetkiService.AddService(yeniRolYetki);
            }
            RolleriYukle();
            YetkileriYukle();
            MessageBox.Show("Yetkiler başarıyla kaydedildi.", "Başarılı");
        }
        private void btnRolGuncelle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRolId.Text, out int rolId))
            {
                MessageBox.Show("Geçerli bir Rol Id giriniz.", "Uyarı");
                return;
            }

            var dbRol = rolService.GetByFilterService(x => x.RolId == rolId);
            if (dbRol.Data == null)
            {
                MessageBox.Show("Bu Id’ye ait rol bulunamadı.", "Hata");
                return;
            }

            dbRol.Data.RolAdi = txtRolAdi.Text;
            dbRol.Data.RolKodu = txtRolKodu.Text;

            var result = rolService.UpdateService(dbRol.Data);
            MessageBox.Show(result.Message + "Rol başarıyla güncellendi.", "Başarılı");
            RolleriYukle();
        }
        private void btnPersonelRolKaydet_Click(object sender, EventArgs e)
        {
            if (dgvPersonel.CurrentRow == null || dgvRoller.CurrentRow == null)
            {
                MessageBox.Show("Personel ve Rol seçmelisiniz");
                return;
            }

            Personel personel = (Personel)dgvPersonel.CurrentRow.DataBoundItem;
            Rol rol = (Rol)dgvRoller.CurrentRow.DataBoundItem;

            PersonelRol yeni = new PersonelRol
            {
                PersonelId = personel.PersonelId,
                RolId = rol.RolId
            };

            var result = personelRolService.AddService(yeni);
            MessageBox.Show(result.Message);

            if (result.IsSuccess)
                PersonelRolleriniYukle(personel.PersonelId);
        }
        private void btnRolSil_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRolId.Text, out int rolId))
            {
                MessageBox.Show("Geçerli bir Rol Id giriniz.", "Uyarı");
                return;
            }

            var dbRol = rolService.GetByFilterService(x => x.RolId == rolId);
            if (dbRol.Data == null)
            {
                MessageBox.Show("Bu Id’ye ait rol bulunamadı.", "Hata");
                return;
            }

            dbRol.Data.AktifMi = false;
            var result = rolService.UpdateService(dbRol.Data);
            MessageBox.Show(result.Message + "Rol başarıyla kaydedildi.", "Başarılı");
            RolleriYukle();
        }
        private void btnRolKaldir_Click(object sender, EventArgs e)
        {
            if (dgvPersonelRolleri.CurrentRow == null)
            {
                MessageBox.Show("Lütfen kaldırılacak personel rolünü seçin.");
                return;
            }

            PersonelRolDto secilen = (PersonelRolDto)dgvPersonelRolleri.CurrentRow.DataBoundItem;

            var onay = MessageBox.Show(
                $"{secilen.PersonelAd} {secilen.PersonelSoyad} kullanıcısından '{secilen.RolAdi}' rolünü kaldırmak istiyor musunuz?",
                "Rol Kaldırma Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (onay != DialogResult.Yes)
                return;

            var dbKayit = personelRolService.GetByFilterService(x =>
                x.PersonelId == secilen.PersonelId &&
                x.RolId == secilen.RolId);

            if (dbKayit.Data == null)
            {
                MessageBox.Show("Seçilen personele ait rol bulunamadı.");
                return;
            }

            var result = personelRolService.DeleteService(dbKayit.Data);
            MessageBox.Show(result.Message);

            if (result.IsSuccess)
                PersonelRolleriniYukle(secilen.PersonelId);
        }
        Dictionary<string, bool> sortDirectionsRol = new();
        Dictionary<string, bool> sortDirectionsYetki = new();
        Dictionary<string, bool> sortDirectionsPersonel = new();
        Dictionary<string, bool> sortDirectionsPersonelRol = new();
        private void dgvRoller_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoller.CurrentRow == null || dgvRoller.CurrentRow.IsNewRow)
                return;

            Rol secilenRol = (Rol)dgvRoller.CurrentRow.DataBoundItem;

            txtRolId.Text = secilenRol.RolId.ToString();
            txtRolAdi.Text = secilenRol.RolAdi;
            txtRolKodu.Text = secilenRol.RolKodu;

            foreach (DataGridViewRow row in dgvYetki.Rows)
                row.Cells["Secim"].Value = false;

            var rolYetkileri = rolYetkiService.GetListByFilterService(x => x.RolId == secilenRol.RolId);
            if (rolYetkileri.Data == null)
                return;

            foreach (var item in rolYetkileri.Data)
            {
                foreach (DataGridViewRow row in dgvYetki.Rows)
                {
                    int yetkiId = (int)row.Cells["yetkiIdDataGridViewTextBoxColumn"].Value;
                    if (yetkiId == item.YetkiId)
                    {
                        row.Cells["Secim"].Value = true;
                        break;
                    }
                }
            }
            YetkiSatirlariniRenklendir();
        }
        private void dgvRoller_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridSortHelper.SortByColumn<Rol>(dgvRoller, bilRoller, e.ColumnIndex, sortDirectionsRol);
            dgvRoller.ClearSelection();
        }
        private void dgvYetki_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridSortHelper.SortByColumn<Yetki>(dgvYetki, bilYetki, e.ColumnIndex, sortDirectionsYetki);
            dgvYetki.ClearSelection();
        }
        private void dgvPersonel_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridSortHelper.SortByColumn<Personel>(dgvPersonel, bilPersonel, e.ColumnIndex, sortDirectionsPersonel);
            dgvPersonel.ClearSelection();
        }
        private void dgvPersonelRolleri_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridSortHelper.SortByColumn<PersonelRolDto>(dgvPersonelRolleri, bilPersonelRolleri, e.ColumnIndex, sortDirectionsPersonelRol);
            dgvPersonelRolleri.ClearSelection();
        }
        private void dgvPersonel_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonel.CurrentRow == null) return;
            Personel secilen = (Personel)dgvPersonel.CurrentRow.DataBoundItem;
            PersonelRolleriniYukle(secilen.PersonelId);
        }
        private void YetkiSatirlariniRenklendir()
        {
            foreach (DataGridViewRow row in dgvYetki.Rows)
            {
                bool secili = row.Cells["Secim"].Value != null &&
                              Convert.ToBoolean(row.Cells["Secim"].Value);

                if (secili)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.SelectionBackColor = Color.Green;
                    row.DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = dgvYetki.DefaultCellStyle.SelectionBackColor;
                    row.DefaultCellStyle.SelectionForeColor = dgvYetki.DefaultCellStyle.SelectionForeColor;
                }
            }
        }
        private void txtPersonelAra_TextChanged(object sender, EventArgs e)
        {
            PersonelleriYukle();
        }
    }
}