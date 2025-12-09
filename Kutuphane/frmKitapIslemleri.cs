using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.DTO;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class frmKitapIslemleri : Form
    {
        public frmKitapIslemleri()
        {
            InitializeComponent();
            dataGrid_Kitap.DataSource = bilKitapDto;
        }

        private void frmKitapIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        IKitapService kitapService = new KitapManager(new KitapDal());

        BindingList<KitapDto> bilKitapDto = new BindingList<KitapDto>();
        private void Listele()
        {
            var kitapResult = kitapService.KitapListeDetayliGetirServis(k => k.KitapAdi.Contains(textBox_Ara.Text));
            if (!kitapResult.IsSuccess)
            {
                MessageBox.Show(kitapResult.Message, "Hata");
                return;
            }
            bilKitapDto.Clear();
            bilKitapDto.AllowNew = true;
            foreach (var item in kitapResult.Data)
            {
                bilKitapDto.Add(item);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
