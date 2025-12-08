using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.BLL.Services;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmUyeIslemleri : Form
    {
        public frmUyeIslemleri()
        {
            InitializeComponent();
            dataGrid_Uye.DataSource = bilUyeDto;
        }


        BindingList<UyeDto> bilUyeDto = new BindingList<UyeDto>();

        private void frmUyeIslemleri_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in dataGrid_Uye.Columns)
            {
                Console.WriteLine(col.Name);
            }

            Listele();
        }

        IUyeService uyeService = new UyeManager(new UyeDal());

        private void Listele()
        {
            var uyeResult = uyeService.UyeListeDetayliGetirServis(x => x.TcPass.Contains(textBox_Ara.Text));
            if (!uyeResult.IsSuccess)
            {
                MessageBox.Show(uyeResult.Message, "Hata");
                return;
            }
            bilUyeDto.Clear();
            bilUyeDto.AllowNew = true;
            foreach (var item in uyeResult.Data)
            {
                bilUyeDto.Add(item);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
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

        private void dataGrid_Uye_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
