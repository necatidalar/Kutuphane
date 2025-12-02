namespace Kutuphane.UI
{
    public partial class frmPersonelIslemleri : Form
    {
        public frmPersonelIslemleri()
        {
            InitializeComponent();
        }

        private void frmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.ForeColor = Color.Black;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonelIslemleri_Paint(object sender, PaintEventArgs e)
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
    }
}
