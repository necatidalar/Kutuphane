using Kutuphane.BLL.Services;
using Kutuphane.Model.Entity;

namespace Kutuphane.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
        }

        private readonly PersonelService _service;

        private void btnGiris_Click(object sender, EventArgs e)
        {


            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
            this.Hide();

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
