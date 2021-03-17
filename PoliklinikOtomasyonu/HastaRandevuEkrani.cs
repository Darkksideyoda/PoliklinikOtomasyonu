using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace PoliklinikOtomasyonu
{
    public partial class HastaRandevuEkrani : Form
    {
        HastaProvider hastaProvider = new HastaProvider();
        RandevuProvider randevuProvider = new RandevuProvider();
        
     
        public HastaRandevuEkrani()
        {
            InitializeComponent();
            this.Size = new Size(508, 311);
            RandevuTarihidateTimePicker.MinDate = DateTime.Now;

        }

        private void HastaRandevuEkrani_Load(object sender, EventArgs e)
        {
            
        }

        private void randevuyuKaydetButton_Click(object sender, EventArgs e)
        {

            RandevuBilgileri Randevu = new RandevuBilgileri();



            if (string.IsNullOrWhiteSpace(hastaTcKontrolTextBox.Text))
            {

                MessageBox.Show("Lütfen TC EKSIKSIZ GIRINIZ ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(doktorSecimComboBox.Text))
            {

                MessageBox.Show("LÜTFEN DOKTORUNUZU SECİNİZ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (string.IsNullOrWhiteSpace(randevuSaatiTextbox.Text))
            {

                MessageBox.Show("LÜTFEN RANDEVU SAATI SECINIZ ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (string.IsNullOrWhiteSpace(polklinikSecimComboBox.Text))
            {
                MessageBox.Show("LÜTFEN POLIKLINIK SECINIZ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                Randevu.hastaTC = hastaTcKontrolTextBox.Text;
                Randevu.personelAdi = doktorSecimComboBox.Text;
                Randevu.randevuTarihi = RandevuTarihidateTimePicker.Value.ToString("yyyy-MM-dd");
                Randevu.randevuSaati = randevuSaatiTextbox.Text;
                Randevu.poliklinikAdi = polklinikSecimComboBox.Text;
                randevuProvider.randevuEkle(Randevu);
                MessageBox.Show("Randevu Kaydı Başarı İle Oluşturuldu!", "INFO");

            }





        }

        private void randevuKontrolButton_Click(object sender, EventArgs e)
        {
          
            HastaBilgileri Hasta = new HastaBilgileri();
            
            Hasta.hastaTC = hastaTcKontrolTextBox.Text;
            
            hastaProvider.hastaKontrol(Hasta,this);
            
            


        }

        private void button27_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button27.Text;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button28.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button29.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button30.Text;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button31.Text;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button32.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button21.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button22.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button23.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button24.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button25.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button26.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button19.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button20.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button14.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button15.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            randevuSaatiTextbox.Text = button3.Text;
        }

        private void hastaTcKontrolTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
