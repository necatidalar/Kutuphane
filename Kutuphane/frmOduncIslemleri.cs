using Kutuphane.BLL.Services;
using Kutuphane.Model.Entity;
using System.Windows.Forms;

namespace Kutuphane.UI
{
    public partial class frmOduncIslemleri : Form
    {
        public frmOduncIslemleri()
        {
            InitializeComponent();
            _oduncService = new OduncService();
            _oduncler = new List<Odunc>();
        }
        private readonly OduncService _oduncService;
        private List<Odunc> _oduncler;

        private void frmOduncIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOduncIslemleri_Paint(object sender, PaintEventArgs e)
        {
            int borderSize = 2;
            Color borderColor = Color.DimGray;

            ControlPaint.DrawBorder(e.Graphics,
                                    this.ClientRectangle,
                                    borderColor, borderSize, ButtonBorderStyle.Solid,
                                    borderColor, borderSize, ButtonBorderStyle.Solid,
                                    borderColor, borderSize, ButtonBorderStyle.Solid,
                                    borderColor, borderSize, ButtonBorderStyle.Solid);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (dgvUyeOdunc.CurrentRow == null)
            {
                MessageBox.Show("Lütfen teslim edilecek satırı seçin.");
                return;
            }

            int oduncId = (int)dgvUyeOdunc.CurrentRow.Cells["OduncID"].Value;
            _oduncService.TeslimEt(oduncId);

            MessageBox.Show("Kitap teslim edildi.");

            string deger = txtAra.Text.Trim();
            _oduncler = _oduncService.GetOdunclerByUye(deger);
            dgvUyeOdunc.DataSource = _oduncler.Select(o => new
            {
                o.OduncID,
                Kitap = o.Kitap.KitapAdi,
                o.AlisTarihi,
                TeslimEdildi = o.TeslimEdildi
            }).ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string deger = txtAra.Text.Trim();
            if (string.IsNullOrEmpty(deger))
            {
                MessageBox.Show("Lütfen Üye ID veya TcPass girin.");
                return;
            }

            _oduncler = _oduncService.GetOdunclerByUye(deger);

            if (_oduncler.Count == 0)
            {
                MessageBox.Show("Bu üyeye ait ödünç kitap bulunamadı.");
                dgvUyeOdunc.DataSource = null;
                return;
            }

            dgvUyeOdunc.DataSource = _oduncler.Select(o => new
            {
                o.OduncID,
                Kitap = o.Kitap.KitapAdi,
                o.AlisTarihi,
                TeslimEdildi = o.TeslimEdildi
            }).ToList();
        }
    }
}
