using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.UI
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            
        }
        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapIslemleri kitapIslemleriForm = new frmKitapIslemleri();
            kitapIslemleriForm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
