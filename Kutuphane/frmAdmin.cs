using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.Entity;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            dgvRoller.DataSource = bilRoller;
            dgvYetki.DataSource = bilYetki;
            Listele();
            YetkileriYukle();

            dgvYetki.ReadOnly = false;
            Secim.ReadOnly = false;
        }
        BindingList<Rol> bilRoller = new BindingList<Rol>();
        BindingList<Yetki> bilYetki = new BindingList<Yetki>();
        IRolService rolService = new RolManager(new RolDal());
        IYetkiService yetkiService = new YetkiManager(new YetkiDal());
        IRolYetkiService rolYetkiService = new RolYetkiManager(new RolYetkiDal());
        private void Listele()
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
        private void txtRolAra_TextChanged(object sender, EventArgs e)
        {
            Listele();
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
                MessageBox.Show(rolResult.Message, "Başarılı");
                Listele();
            }
            else
            {
                MessageBox.Show(rolResult.Message, "Hata");
            }
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
            MessageBox.Show(result.Message);
            Listele();
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
            MessageBox.Show(result.Message);
            Listele();
        }
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

        Dictionary<string, bool> sortDirectionsRol = new();
        Dictionary<string, bool> sortDirectionsYetki = new();
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
            Listele();
            YetkileriYukle();
            MessageBox.Show("Yetkiler başarıyla kaydedildi.", "Başarılı");
        }
    }
}