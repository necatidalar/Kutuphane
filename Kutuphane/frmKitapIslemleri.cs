namespace Kutuphane.UI
{
    public partial class frmKitapIslemleri : Form
    {
        public frmKitapIslemleri()
        {
            InitializeComponent();
        }

        private void frmKitapIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            
        }

        private void ComboDoldur()
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            
        }

        private void KutulariTemizle()
        {
            textBox_KitapId.Clear();
            textBox_ISBN.Clear();
            textBox_KitapAdi.Clear();
            comboBox_Kategori.SelectedIndex = -1;
            comboBox_Yazar.SelectedIndex = -1;
            comboBox_Yayinevi.SelectedIndex = -1;
            comboBox_Dil.SelectedIndex = -1;
            textBox_BasimYili.Clear();
            textBox_SayfaSayisi.Clear();
            textBox_StokMiktari.Clear();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Kitap.ClearSelection();
            KutulariTemizle();
        }
        private void PasifUyeKontrol()
        {

        }
        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {

        }
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
            dataGrid_Kitap.ClearSelection();
        }
        private void kategoriİşlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategoriIslemleri frm = new frmKategoriIslemleri();
            frm.ShowDialog();
        }
        private void yazarİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYazarIslemleri frm = new frmYazarIslemleri();
            frm.ShowDialog();
        }
        private void dilİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDilIslemleri frm = new frmDilIslemleri();
            frm.ShowDialog();
        }
        private void yayıneviİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYayineviIslemleri frm = new frmYayineviIslemleri();
            frm.ShowDialog();
        }
    }
}
