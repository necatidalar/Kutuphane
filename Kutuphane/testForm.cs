
using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.ComponentModel;

namespace Kutuphane.UI
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
            dataGrid_kitap.DataSource = bilKitap;
            dataGrid_kitapDto.DataSource = bilKitapDto;
        }
        private void testForm_Load(object sender, EventArgs e)
        {

        }

        BindingList<Kitap> bilKitap = new BindingList<Kitap>();
        BindingList<KitapDto> bilKitapDto = new BindingList<KitapDto>();

        private void button_entity_Click(object sender, EventArgs e)
        {
            IKitapService kitapService = new KitapManager(new KitapDal());
            var kitapResult = kitapService.GetListByFilterService(k => k.KitapAdi.Contains(textBox_arama.Text));
            if (!kitapResult.IsSuccess)
            {
                MessageBox.Show(kitapResult.Message, "Hata");
                return;
            }
            bilKitap.Clear();
            //dataGrid_kitap.DataSource = kitapResult.Data;
            bilKitapDto.AllowNew = true;
            foreach (var item in kitapResult.Data)
            {
                bilKitap.Add(item);
            }
        }

        private void button_dto_Click(object sender, EventArgs e)
        {
            IKitapService kitapService = new KitapManager(new KitapDal());
            var kitapResult = kitapService.KitapListeDetayliGetirServis(k => k.KitapAdi.Contains(textBox_arama.Text));
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
    }
}
