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
            ComboDoldur();
            dataGrid_Uye.ClearSelection();
            KutulariTemizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Uye yeniUye = new Uye
            {
                TcPass = textBox_TcPass.Text,
                Ad = textBox_Ad.Text,
                Soyad = textBox_Soyad.Text,
                CinsiyetId = ((Cinsiyet)comboBox_Cinsiyet.SelectedItem).Id,
                Telefon = textBox_Telefon.Text,
                Eposta = textBox_Eposta.Text,
                Adres = textBox_Adres.Text,
                AdresDetay = richTextBox_AdresDetay.Text,
                DogumTarihi = dateTimePicker1.Value,
                AktifMi = true
            };
            var uyeResult = uyeService.AddService(yeniUye);
            if (uyeResult.IsSuccess)
            {
                MessageBox.Show("Üye başarıyla kaydedildi.", "Başarılı");
                Listele();
            }
            else
            {
                MessageBox.Show(uyeResult.Message, "Hata");
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int idResult;
            int.TryParse(textBox_Uye.Text, out idResult);
            Uye yeniUye = new Uye
            {
                UyeId = idResult,
                TcPass = textBox_TcPass.Text,
                Ad = textBox_Ad.Text,
                Soyad = textBox_Soyad.Text,
                CinsiyetId = ((Cinsiyet)comboBox_Cinsiyet.SelectedItem).Id,
                Telefon = textBox_Telefon.Text,
                Eposta = textBox_Eposta.Text,
                Adres = textBox_Adres.Text,
                AdresDetay = richTextBox_AdresDetay.Text,
                DogumTarihi = dateTimePicker1.Value,
                AktifMi = true
            };

            var uyeResult = uyeService.UpdateService(yeniUye);
            if (uyeResult.IsSuccess)
            {
                MessageBox.Show("Üye başarıyla updatelendi.", "Başarılı");
                Listele();
            }
            else
            {
                MessageBox.Show(uyeResult.Message, "Hata");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void ComboDoldur()
        {
            ICinsiyetService cinsiyetService = new CinsiyetManager(new CinsiyetDal());
            var cinsiyetResult = cinsiyetService.GetListByFilterService();
            if (!cinsiyetResult.IsSuccess)
            {
                MessageBox.Show(cinsiyetResult.Message, "Hata");
                return;
            }
            comboBox_Cinsiyet.DataSource = cinsiyetResult.Data;
            comboBox_Cinsiyet.DisplayMember = "CinsiyetAdi";
            comboBox_Cinsiyet.ValueMember = "Id";
            comboBox_Cinsiyet.SelectedIndex = -1;
        }

        private void dataGrid_Uye_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView view = sender as DataGridView;

            if (view.CurrentRow != null)
            {
                UyeDto row = (UyeDto)view.CurrentRow.DataBoundItem;
                textBox_Uye.Text = row.UyeId.ToString();
                textBox_TcPass.Text = row.TcPass;
                textBox_Ad.Text = row.Ad;
                textBox_Soyad.Text = row.Soyad;
                comboBox_Cinsiyet.SelectedValue =row.CinsiyetId ;
                textBox_Telefon.Text = row.Telefon;
                textBox_Eposta.Text = row.Eposta;
                textBox_Adres.Text = row.Adres;
                richTextBox_AdresDetay.Text = row.AdresDetay;
                dateTimePicker1.Value =DateTime.Now;
                return;
            }
            KutulariTemizle();
        }

        private void KutulariTemizle()
        {
            
            textBox_Uye.Text = string.Empty;
            textBox_TcPass.Text = string.Empty;
            textBox_Ad.Text = string.Empty;
            textBox_Soyad.Text = string.Empty;
            comboBox_Cinsiyet.SelectedValue = (object)DBNull.Value;
            textBox_Telefon.Text = string.Empty;
            textBox_Eposta.Text = string.Empty;
            textBox_Adres.Text = string.Empty;
            richTextBox_AdresDetay.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            comboBox_Cinsiyet.SelectedIndex = -1;   
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGrid_Uye.ClearSelection();
            KutulariTemizle();
        }
    }
}
