using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliklinikOtomasyonu
{
    public partial class MainPage : Form
    {
        public string gelecekDeger;
        PersonelProvider personelProvider = new PersonelProvider();
        HastaProvider hastaProvider = new HastaProvider();
        RandevuProvider randevuProvider = new RandevuProvider();
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-JD2HKS3;Initial Catalog=PoliklinikOtomasyonu; Integrated Security=True");
        SqlCommand SqlCommand;
        public string personelAd;
        public string personeGelenTC;
        public string today = DateTime.Today.ToString("yyyy-MM-dd");
        public string kabulekraniHastaAdi;


    
       
         

        public MainPage()
        {
            InitializeComponent();
            //ConnectionSql();

        }



        //public void ConnectionSql()
        //{
        //    SqlConnection = new SqlConnection(@"Data Source=DESKTOP-JD2HKS3;Initial Catalog=PoliklinikOtomasyonu; Integrated Security=True");
        //    SqlCommand = new SqlCommand();
        //    SqlCommand.Connection = SqlConnection;


        //}



        void PersonelListele() 
        {

            presonelDatagrid.DataSource = personelProvider.Listele();
            foreach (DataGridViewColumn column in presonelDatagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        void hastaListeleGrid()
        {



            hastaDatagrid.DataSource = hastaProvider.ListeleShowgrid();
            foreach (DataGridViewColumn column in hastaDatagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        void randevuListeleGrid()
        {
            randevuDatagrid.DataSource = randevuProvider.ListeleShowgrid();
            foreach (DataGridViewColumn column in randevuDatagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }





        private void MainPage_Load(object sender, EventArgs e)
        {
           
            MessageBox.Show("Deger" + gelecekDeger);
            PersonelListele();
            hastaListeleGrid();
            randevuListeleGrid();
           

            if (gelecekDeger == "DOKTOR")
            {
                TabControl.TabPages.Remove(PoliklinikBulgu);
                TabControl.TabPages.Remove(PersonelKayit);
                TabControl.TabPages.Remove(HastaKayit);
                TabControl.TabPages.Remove(HastaGuncelle);
                TabControl.TabPages.Remove(PersonelGuncelle);
                TabControl.TabPages.Remove(randevuGuncelle);
                /////////////////////////////////////
                TabControl.TabPages.Add(PoliklinikBulgu);


                bekleyenHastadataGridView.DataSource = personelProvider.personelHastasi(personelAd);
                hastaSayisiCount();


                bekleyenHastadataGridView.Columns[1].Visible = false;
                bekleyenHastadataGridView.Columns[4].Visible = false;
                bekleyenHastadataGridView.EnableHeadersVisualStyles = false;


            }

            if (gelecekDeger == "SEKRETERLIK")
            {

                TabControl.TabPages.Remove(PoliklinikBulgu);
                TabControl.TabPages.Remove(PersonelKayit);
                TabControl.TabPages.Remove(HastaKayit);
                TabControl.TabPages.Remove(HastaGuncelle);
                TabControl.TabPages.Remove(PersonelGuncelle);
                TabControl.TabPages.Remove(randevuGuncelle);
                //////////////////////////////////////
                TabControl.TabPages.Add(PersonelKayit);
                TabControl.TabPages.Add(HastaKayit);
                TabControl.TabPages.Add(randevuGuncelle);
                TabControl.TabPages.Add(HastaGuncelle);
                TabControl.TabPages.Add(PersonelGuncelle);

                this.Size = new Size(714, 750);


            }

            if (gelecekDeger == "ADMIN")
            {

                TabControl.TabPages.Remove(PoliklinikBulgu);
                TabControl.TabPages.Remove(PersonelKayit);
                TabControl.TabPages.Remove(HastaKayit);
                TabControl.TabPages.Remove(HastaGuncelle);
                TabControl.TabPages.Remove(PersonelGuncelle);
                TabControl.TabPages.Remove(randevuGuncelle);

                //////////////////////////////////////
                TabControl.TabPages.Add(randevuGuncelle);
                TabControl.TabPages.Add(PoliklinikBulgu);
                TabControl.TabPages.Add(PersonelKayit);
                TabControl.TabPages.Add(HastaKayit);
                TabControl.TabPages.Add(HastaGuncelle);
                TabControl.TabPages.Add(PersonelGuncelle);
               
              
            }

          

        }


        public void hastaSayisiCount()
        {
            int bekleyenHastasayisi = 0;
            for (int i = 1; i < bekleyenHastadataGridView.Rows.Count; i++)
            {
                bekleyenHastasayisi += i;
            }

            hastaSayisiTextBox.Text = bekleyenHastasayisi.ToString();

        }



        private static Random random = new Random();
        public static string RandomID_SIFRE(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        private void labButon_Click(object sender, EventArgs e)
        {
            Biyokimya bioScreen = new Biyokimya();
            bioScreen.Show();
        }

        private void hastaGecmisiButton_Click(object sender, EventArgs e)
        {
           
             HastaGecmisi hastaGecmisiScreen = new HastaGecmisi();
            hastaGecmisiScreen.hastaTC = HastaTCTextBox.Text;
             hastaGecmisiScreen.Show();
        }

        private void personelKayitButton_Click(object sender, EventArgs e)
        {



            PersonelBilgileri Personel = new PersonelBilgileri();


            if (string.IsNullOrWhiteSpace(personelTurucomboBox.Text))
            {

                MessageBox.Show("Lütfen PERSONEL TURUNU SECINIZ ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (string.IsNullOrWhiteSpace(personelTCTextBox.Text))
            {

                MessageBox.Show("Lütfen Personelin TC Numarasını Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(personelAdiTextBox.Text))
            {

                MessageBox.Show("Lütfen Personelin Adını Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(personelSoyadiTextBox.Text))
            {

                MessageBox.Show("Lütfen Personelin Soyadını Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(personelPoliklinikComboBox.Text))
            {

                MessageBox.Show("Lütfen Personelin Bağlı Olduğu Polikliniği Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(personelTelefonTextBox.Text))
            {

                MessageBox.Show("Lütfen Personelin Telefon Numarasını Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(personelUnvanTextBox.Text))
            {

                MessageBox.Show("Lütfen Personelin Ünvanını Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(personelEpostaTextBox.Text))
            {

                MessageBox.Show("Lütfen Personelin E-Posta Adresini Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(string.IsNullOrWhiteSpace(personelAdresTextBox.Text))
            {

                MessageBox.Show("Lütfen Lütfen Personelin Adresini Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
            else
            {
                Personel.personelTuru = personelTurucomboBox.Text;
                Personel.personelTC = personelTCTextBox.Text;
                Personel.personelAdi = personelAdiTextBox.Text;
                Personel.personelSoyadi = personelSoyadiTextBox.Text;
                Personel.personelPoliklinik = personelPoliklinikComboBox.Text;
                Personel.personelTelefon = personelTelefonTextBox.Text;
                Personel.personelUnvan = personelUnvanTextBox.Text;
                Personel.personelEposta = personelEpostaTextBox.Text;
                Personel.personelAdres = personelAdresTextBox.Text;
                Personel.personelID = RandomID_SIFRE(5);//ID
                Personel.personelSifre = RandomID_SIFRE(5);//SIFRE
                personelProvider.personelEkle(Personel);


                MessageBox.Show("Personel Kaydı Başarı İle Oluşturuldu!", "INFO");

                personelTurucomboBox.Text = String.Empty;
                personelTCTextBox.Text = String.Empty;
                personelAdiTextBox.Text = String.Empty;
                personelSoyadiTextBox.Text = String.Empty;
                personelPoliklinikComboBox.Text = String.Empty;
                personelTelefonTextBox.Text = String.Empty;
                personelUnvanTextBox.Text = String.Empty;
                personelEpostaTextBox.Text = String.Empty;
                personelAdresTextBox.Text = String.Empty;



            }












        }

        private void hastaKayitButton_Click(object sender, EventArgs e)
        {

            HastaBilgileri Hasta = new HastaBilgileri();


            if (string.IsNullOrWhiteSpace(hastaKayitTCTextbox.Text)){

                MessageBox.Show("Lütfen Hastanın TC Numarasını Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }

           else if (string.IsNullOrWhiteSpace(hastaKayitADITextbox.Text))
            {

                MessageBox.Show("Lütfen Hastanın ADINI Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            else if (string.IsNullOrWhiteSpace(hastaKayitSOYADITextbox.Text))
            {

                MessageBox.Show("Lütfen Hastanın SOYADINI Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(hastaKayitDogumYeriComboBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın  DOGUM YERINI Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (string.IsNullOrWhiteSpace(hastaKayitDogumTarihiDatetimePicker.Text))
            {

                MessageBox.Show("Lütfen Hastanın DOGUM TARIHINI Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(string.IsNullOrWhiteSpace(hastaKayitCinsiyetComboBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın Cinsiyetini Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(hastaKayitSosyalGuvenceTuruComboBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın SOSYAL GUVENCE TURUNU Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (string.IsNullOrWhiteSpace(hastaKayitSosyalGuvenceNoTextBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın SOSYAL GUVENCE Numarasını Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(hastaKayitKanGrubuTextbox.Text))
            {

                MessageBox.Show("Lütfen Hastanın Kan Grubunu Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (string.IsNullOrWhiteSpace(hastaKayitTelefonTextbox.Text))
            {

                MessageBox.Show("Lütfen Hastanın Telefon Numarasını Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (string.IsNullOrWhiteSpace(hastaKayitEpostaTextbox.Text))
            {

                MessageBox.Show("Lütfen Hastanın Eposta Adresini Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                Hasta.hastaTC = hastaKayitTCTextbox.Text;


                Hasta.hastaAdi = hastaKayitADITextbox.Text;

                Hasta.hastaSoyadi = hastaKayitSOYADITextbox.Text;

                Hasta.hastaDogumyeri = hastaKayitDogumYeriComboBox.Text;


                Hasta.hastaDogumtarihi = hastaKayitDogumTarihiDatetimePicker.Value.ToString("yyyy-MM-dd");


                Hasta.hastaCinsiyet = hastaKayitCinsiyetComboBox.Text;

                Hasta.hastaSosyalGuvenceturu = hastaKayitSosyalGuvenceTuruComboBox.Text;


                Hasta.hastaSosyalguvenceNO = hastaKayitSosyalGuvenceNoTextBox.Text;


                Hasta.hastaKangrubu = hastaKayitKanGrubuTextbox.Text;

                Hasta.hastaTelefon = hastaKayitTelefonTextbox.Text;


                Hasta.hastaEposta = hastaKayitEpostaTextbox.Text;

                Hasta.hastaKayitNO = RandomID_SIFRE(3);

                Hasta.hastaNo = RandomID_SIFRE(10);


                hastaProvider.hastaEkle(Hasta);

                MessageBox.Show("Hasta Kaydı Başarı İle Oluşturuldu!", "INFO");

                hastaKayitTCTextbox.Text = String.Empty;
                hastaKayitADITextbox.Text = String.Empty;
                hastaKayitSOYADITextbox.Text = String.Empty;
                hastaKayitDogumYeriComboBox.Text = String.Empty;
                hastaKayitCinsiyetComboBox.Text = String.Empty;
                hastaKayitSosyalGuvenceTuruComboBox.Text = String.Empty;
                hastaKayitSosyalGuvenceNoTextBox.Text = String.Empty;
                hastaKayitKanGrubuTextbox.Text = String.Empty;
                hastaKayitTelefonTextbox.Text = String.Empty;
                hastaKayitEpostaTextbox.Text = String.Empty;

            }

         

        }

        private void tetkikAramaButton_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in TetkikCheckedListBox.CheckedItems)
            {
               
                MessageBox.Show("ID: \"" + itemChecked.ToString());
            }
        }

        private void bekleyenHastadataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(bekleyenHastadataGridView.CurrentRow == null)
            {
                MessageBox.Show("Secili Deger Bulunamadi");

            }
            else
            {

           
            

                foreach (DataGridViewColumn c in bekleyenHastadataGridView.Columns)
                {
                    seciliHastadataGridView.Columns.Add(c.Clone() as DataGridViewColumn);
                }
            
            foreach (DataGridViewRow r in bekleyenHastadataGridView.SelectedRows)
            {
                int index = seciliHastadataGridView.Rows.Add(r.Clone() as DataGridViewRow);
                foreach (DataGridViewCell o in r.Cells)
                {
                    seciliHastadataGridView.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                }
            }


            seciliHastadataGridView.Columns[1].Visible = false;
            seciliHastadataGridView.Columns[4].Visible = false;
            seciliHastadataGridView.EnableHeadersVisualStyles = false;
            }

        }

       

        private void personelKayitDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (personelKayitDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    MessageBox.Show(personelKayitDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            //}
            //else
            //{
            //    DataGridViewSelectedRowCollection rows = personelKayitDataGrid.SelectedRows;

            //}

        }

        private void seciliHastadataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void muayneBaslatButton_Click(object sender, EventArgs e)
        {
          
            DoktorHastaKabulEkrani kabulEkrani = new DoktorHastaKabulEkrani();
            kabulEkrani.ISIM = kabulekraniHastaAdi = hastaAdiTextBox.Text+" "+hastaSoyadiTextBox.Text;
            kabulEkrani.Show();
           
        }



        private void muayneKaydetButton_Click(object sender, EventArgs e)
        {
            muayneBilgileri muayneBilgileri = new muayneBilgileri();


            if (string.IsNullOrWhiteSpace(hastaAtesiTextBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın ATEŞİNİ Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            else if(string.IsNullOrWhiteSpace(hastaKiloTextBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın KİLOSUNU Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(string.IsNullOrWhiteSpace(hastaBoyTextBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın BOYUNU Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(hastaNabizTextBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın NABIZ BILGISINI Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(tansiyonBuyukTextBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın TANSIYON(BUYUK) DEGERINI Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(string.IsNullOrWhiteSpace(tansiyonKucukTextBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın TANSIYON(KUCUK) DEGERINI Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(string.IsNullOrWhiteSpace(hastaHikayesiTextBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın HİKAYESİNİ Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(hastaBulgulariTextBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın BULGULARINI Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(string.IsNullOrWhiteSpace(hastaKararTextBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın KARAR AŞAMASINI Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(string.IsNullOrWhiteSpace(muayneBitisTextBox.Text))
            {

                MessageBox.Show("Lütfen Hastanın MUAYNE BITIS SAATINI Eksiksiz Ve Doğru Giriniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            else
            {



                List<string> tani = new List<string>();
                List<string> tetkik = new List<string>();


                muayneBilgileri.hastaTC = HastaTCTextBox.Text;

               
                muayneBilgileri.hastaAtesi = Int32.Parse(hastaAtesiTextBox.Text);
                muayneBilgileri.hastaKilo = Int32.Parse(hastaKiloTextBox.Text);
                muayneBilgileri.hastaBoy = Int32.Parse(hastaBoyTextBox.Text);
                muayneBilgileri.hastaNabiz = Int32.Parse(hastaNabizTextBox.Text);
                muayneBilgileri.tansiyonBuyuk = Int32.Parse(tansiyonBuyukTextBox.Text);
                muayneBilgileri.tansiyonKucuk = Int32.Parse(tansiyonKucukTextBox.Text);

                muayneBilgileri.hastaMuaynePersonel = personeGelenTC;
                muayneBilgileri.hastaHikayesi = hastaHikayesiTextBox.Text;
                muayneBilgileri.hastaBulgulari = hastaBulgulariTextBox.Text;
                muayneBilgileri.hastaKarar = hastaKararTextBox.Text;
                muayneBilgileri.hastaMuayneTarihi = muayneBitisDateTimePicker.Value.ToString("yyyy-MM-dd");
                muayneBilgileri.muayneSaat = muayneBitisTextBox.Text;

                foreach (object itemChecked in TetkikCheckedListBox.CheckedItems)
                {
                   tetkik.Add(itemChecked.ToString());
                }
                muayneBilgileri.hastaTetkik = String.Join("", tetkik);


                foreach (object itemChecked in TaniCheckedListBox.CheckedItems)
                {

                    
                    tani.Add(itemChecked.ToString());
                }
                muayneBilgileri.hastaTanisi = String.Join("", tani);


                hastaProvider.muayneEkle(muayneBilgileri);

                MessageBox.Show("Muayne Kaydı Başarı İle Oluşturuldu!", "INFO");

                hastaKayitNoTextBox.Text = String.Empty;
                HastaTCTextBox.Text = String.Empty;
                hastaNoTextBox.Text = String.Empty;
                hastaSayisiTextBox.Text = String.Empty;
                hastaAdiTextBox.Text = String.Empty;
                hastaSoyadiTextBox.Text = String.Empty;
                hastaCinsiyetTextBox.Text = String.Empty;
                hastaKangrubuTextBox.Text = String.Empty;
                muayneBitisTextBox.Text = String.Empty;




                hastaAtesiTextBox.Text = String.Empty;
                hastaKiloTextBox.Text = String.Empty;
                hastaBoyTextBox.Text = String.Empty;
                hastaNabizTextBox.Text = String.Empty;
                tansiyonBuyukTextBox.Text = String.Empty;
                tansiyonKucukTextBox.Text = String.Empty;
                hastaHikayesiTextBox.Text = String.Empty;
                hastaBulgulariTextBox.Text = String.Empty;
                hastaKararTextBox.Text = String.Empty;
                muayneBitisDateTimePicker.Text = String.Empty;
                muayneBitisTextBox.Text = String.Empty;




            }




        }
                                /**/
        private void seciliHastadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(seciliHastadataGridView.CurrentRow.Cells == null)
            {
                MessageBox.Show("Secili Deger Bulunamadi !");
            }
            else
            {

            
            string index = seciliHastadataGridView.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show("secilirow" + index);
            hastaProvider.hastaListele(index, HastaTCTextBox, hastaAdiTextBox, hastaSoyadiTextBox, hastaCinsiyetTextBox, hastaKangrubuTextBox, hastaKayitNoTextBox, hastaNoTextBox);

               




                hastaAtesiTextBox.Text = String.Empty;
                hastaKiloTextBox.Text = String.Empty;
                hastaBoyTextBox.Text = String.Empty;
                hastaNabizTextBox.Text = String.Empty;
                tansiyonBuyukTextBox.Text = String.Empty;
                tansiyonKucukTextBox.Text = String.Empty;
                hastaHikayesiTextBox.Text = String.Empty;
                hastaBulgulariTextBox.Text = String.Empty;
                hastaKararTextBox.Text = String.Empty;
                muayneBitisDateTimePicker.Text = String.Empty;
                muayneBitisTextBox.Text = String.Empty;



            }
        }


        ////////////////////////////////////////////////////////////////////////////
        private void hastaAtesiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void hastaKiloTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void tansiyonBuyukTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void tansiyonKucukTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void hastaNabizTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void hastaBoyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void personelTCTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void personelTelefonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void personelAdiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void personelSoyadiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void personelUnvanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void hastaKayitTCTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void hastaKayitADITextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void hastaKayitSOYADITextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void hastaKayitSosyalGuvenceNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        
        private void hastaSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void HastaGuncelleTabAdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void HastaGuncelleTabSoyadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void HastaGuncelleTabTCTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void HastaGuncelleTabTelefonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void HastaGuncelleTabSosyalGuvenceNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PersonelGuncelleTabAramaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void PersonelGuncelleTabTCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void PersonelGuncelleTabAdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void PersonelGuncelleTabSoyadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void PersonelGuncelleTabTelefonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }



        private void PersonelGuncelleTabUnvan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }


        private void randevuGuncelleTabAramaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }


        /////////////////////////////////////////////////////////////////////////////////////////
        private void hastaKayitTelefonTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void personelKayitDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
        
        private void hastaSearchTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        public void ara_Click(object sender, EventArgs e)
        {
            
        }

       
        private void updateHastaButton_Click(object sender, EventArgs e)
        {
            hastaListeleGrid();
            HastaGuncelleTabAdTextBox.Text = String.Empty;
            HastaGuncelleTabSoyadTextBox.Text = String.Empty;
            HastaGuncelleTabKanGrubu.Text = String.Empty;
            HastaGuncelleTabTCTextBox.Text = String.Empty;
            HastaGuncelleTabTelefonTextBox.Text = String.Empty;
            HastaGuncelleTabEpostaTextBox.Text = String.Empty;
            HastaGuncelleTabDogumYeri.Text = String.Empty;
            HastaGuncelleTabDogumTarihiDateTimePicker.Text = String.Empty;
            HastaGuncelleTabCinsiyet.Text = String.Empty;
            HastaGuncelleTabSosyalGuvenceTuru.Text = String.Empty;
            HastaGuncelleTabSosyalGuvenceNoTextBox.Text = String.Empty;

        }

        private void searchHastaButton_Click(object sender, EventArgs e)
        {

            

            for (int i = 0; i < hastaDatagrid.Rows.Count; i++)
            {
                if (!hastaDatagrid.Rows[i].IsNewRow)
                {
                    if (hastaDatagrid[0, i].Value.ToString() == hastaSearchTextBox.Text)
                    {
                        hastaDatagrid.Rows[i].Selected = true;
                        MessageBox.Show("HASTA BULUNDU!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hastaDatagrid.FirstDisplayedScrollingRowIndex = hastaDatagrid.SelectedRows[0].Index;
                    }

                    else
                    {
                        hastaDatagrid.Rows[i].Selected = false;
                        
                    }
                   
                }
            }


               
          

           

        }

        
       
        private void hastaSilButton_Click(object sender, EventArgs e)
        {
            


           
            if(hastaDatagrid.CurrentRow == null)
            {
                MessageBox.Show("NULL");
            }
            else
            {
                string index = hastaDatagrid.CurrentRow.Cells[0].Value.ToString();
                hastaProvider.hastaSil(index);
                MessageBox.Show("HASTA BAŞARI İLE SİLİNDİ !", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hastaListeleGrid();
            }
         
          



        }

       

        private void silRandevuButton_Click(object sender, EventArgs e)
        {
            
          

            if (randevuDatagrid.CurrentRow == null)
            {
                MessageBox.Show("NULL");
            }
            else
            {
                string index = randevuDatagrid.CurrentRow.Cells[0].Value.ToString();
                randevuProvider.randevuSil(index);
                MessageBox.Show("RANDEVU BAŞARI İLE SİLİNDİ !", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                randevuListeleGrid();
            }

        }

        private void personelSilButton_Click(object sender, EventArgs e)
        {
            
            if(presonelDatagrid.CurrentRow == null)
            {
                MessageBox.Show("Secili Deger Bulunamadi");
            }
            else
            {

          
            string index = presonelDatagrid.CurrentRow.Cells[1].Value.ToString();
            personelProvider.personelSil(index);
            MessageBox.Show("PERSONEL BAŞARI İLE SİLİNDİ !", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonelListele();
            }
        }

        private void personelGuncelleButton_Click(object sender, EventArgs e)
        {

            // // string eskiPersonel = presonelDatagrid.CurrentRow.Cells[1].Value.ToString();

            // //PersonelBilgileri eskiPersonel = new PersonelBilgileri();

            // //eskiPersonel = (PersonelBilgileri)presonelDatagrid.CurrentRow.DataBoundItem;
            //string eskiPersonel = presonelDatagrid.CurrentRow.Cells[1].Value.ToString();

            // PersonelBilgileri yeniPersonel = new PersonelBilgileri();
            // yeniPersonel.personelTC = PersonelGuncelleTabTCtextBox.ToString();
            // yeniPersonel.personelTuru = PersonelGuncelleTabPersonelTuru.ToString();
            // yeniPersonel.personelAdi = PersonelGuncelleTabAdTextBox.ToString();
            // yeniPersonel.personelSoyadi = PersonelGuncelleTabSoyadTextBox.ToString();
            // yeniPersonel.personelPoliklinik = PersonelGuncelleTabPoliklinik.ToString();
            // yeniPersonel.personelTelefon = PersonelGuncelleTabTelefonTextBox.ToString();
            // yeniPersonel.personelUnvan = PersonelGuncelleTabUnvan.ToString();
            // yeniPersonel.personelEposta = PersonelGuncelleTabEpostaTextBox.ToString();
            // yeniPersonel.personelAdres = PersonelGuncelleTabAdresRichBox.Text.ToString();
            // personelProvider.Guncelle(eskiPersonel, yeniPersonel);
            // PersonelListele();

            string sorgu = "UPDATE personelBilgileri SET personelTC=@personelTC,personelTuru=@personelTuru,personelAdi=@personelAdi,personelSoyadi=@personelSoyadi,personelPoliklinik=@personelPoliklinik,personelTelefon=@personelTelefon,personelUnvan=@personelUnvan,personelEposta=@personelEposta,personelAdres=@personelAdres WHERE personelTC=@personelTC";
            SqlCommand = new SqlCommand(sorgu, SqlConnection);
            SqlCommand.Parameters.AddWithValue("@personelTC", PersonelGuncelleTabTCtextBox.Text);
            SqlCommand.Parameters.AddWithValue("@personelTuru", PersonelGuncelleTabPersonelTuru.Text);
            SqlCommand.Parameters.AddWithValue("@personelAdi", PersonelGuncelleTabAdTextBox.Text);
            SqlCommand.Parameters.AddWithValue("@personelSoyadi", PersonelGuncelleTabSoyadTextBox.Text);
            SqlCommand.Parameters.AddWithValue("@personelPoliklinik", PersonelGuncelleTabPoliklinik.Text);
            SqlCommand.Parameters.AddWithValue("@personelTelefon", PersonelGuncelleTabTelefonTextBox.Text);
            SqlCommand.Parameters.AddWithValue("@personelUnvan", PersonelGuncelleTabUnvan.Text);
            SqlCommand.Parameters.AddWithValue("@personelEposta", PersonelGuncelleTabEpostaTextBox.Text);
            SqlCommand.Parameters.AddWithValue("@personelAdres", PersonelGuncelleTabAdresRichBox.Text);
            SqlConnection.Open();
            SqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
            MessageBox.Show("GUNCELLEME BASARILI");
            PersonelListele();


            





        }

        private void presonelDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(presonelDatagrid.CurrentRow == null)
            {
                MessageBox.Show("Secili Deger Bulunamadi !");
            }
            else
            {
                string index = presonelDatagrid.CurrentRow.Cells[1].Value.ToString();
                MessageBox.Show("secilirow" + index);
                personelProvider.personelListele(index, PersonelGuncelleTabPersonelTuru, PersonelGuncelleTabTCtextBox, PersonelGuncelleTabAdTextBox, PersonelGuncelleTabSoyadTextBox, PersonelGuncelleTabPoliklinik, PersonelGuncelleTabTelefonTextBox, PersonelGuncelleTabUnvan, PersonelGuncelleTabEpostaTextBox, PersonelGuncelleTabAdresRichBox);
            }

            


        }

        private void hastaDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(hastaDatagrid.CurrentRow == null)
            {
                MessageBox.Show("Secili Deger Bulunamadi !");
            }
            else
            {

            string index = hastaDatagrid.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show("secilirow" + index);
            hastaProvider.hastaBoxListele(index, HastaGuncelleTabAdTextBox, HastaGuncelleTabSoyadTextBox, HastaGuncelleTabKanGrubu, HastaGuncelleTabTCTextBox, HastaGuncelleTabTelefonTextBox, HastaGuncelleTabEpostaTextBox, HastaGuncelleTabDogumYeri, HastaGuncelleTabDogumTarihiDateTimePicker, HastaGuncelleTabCinsiyet, HastaGuncelleTabSosyalGuvenceTuru, HastaGuncelleTabSosyalGuvenceNoTextBox);
            }
        }

    

        private void hastaGuncelleButton_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE hastaBilgileri SET hastaTC=@hastaTC,hastaAdi=@hastaAdi,hastaSoyadi=@hastaSoyadi,hastaDogumyeri=@hastaDogumyeri,hastaDogumtarihi=@hastaDogumtarihi,hastaCinsiyet=@hastaCinsiyet,hastaSosyalguvenceTuru=@hastaSosyalguvenceturu,hastaSosyalguvenceNO=@hastaSosyalguvenceNO,hastaKangrubu=@hastaKangrubu,hastaTelefon=@hastaTelefon,hastaEposta=@hastaEposta WHERE hastaTC=@hastaTC";
            SqlCommand = new SqlCommand(sorgu, SqlConnection);
            SqlCommand.Parameters.AddWithValue("@hastaAdi", HastaGuncelleTabAdTextBox.Text);
            SqlCommand.Parameters.AddWithValue("@hastaSoyadi", HastaGuncelleTabSoyadTextBox.Text);
            SqlCommand.Parameters.AddWithValue("@hastaKangrubu", HastaGuncelleTabKanGrubu.Text);
            SqlCommand.Parameters.AddWithValue("@hastaTC", HastaGuncelleTabTCTextBox.Text);
            SqlCommand.Parameters.AddWithValue("@hastaTelefon", HastaGuncelleTabTelefonTextBox.Text);
            SqlCommand.Parameters.AddWithValue("@hastaEposta", HastaGuncelleTabEpostaTextBox.Text);
            SqlCommand.Parameters.AddWithValue("@hastaDogumyeri", HastaGuncelleTabDogumYeri.Text);
            SqlCommand.Parameters.AddWithValue("@hastaDogumtarihi", HastaGuncelleTabDogumTarihiDateTimePicker.Value);
            SqlCommand.Parameters.AddWithValue("@hastaCinsiyet", HastaGuncelleTabCinsiyet.Text);
            SqlCommand.Parameters.AddWithValue("@hastaSosyalguvenceturu", HastaGuncelleTabSosyalGuvenceTuru.Text);
            SqlCommand.Parameters.AddWithValue("@hastaSosyalguvenceNO", HastaGuncelleTabSosyalGuvenceNoTextBox.Text);
            SqlConnection.Open();
            SqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
            MessageBox.Show("GUNCELLEME BASARILI");
            hastaListeleGrid();
           









        }

        private void guncelleRandevuButton_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE RandevuBilgileri SET hastaTC=@hastaTC,personelAdi=@personelAdi,randevuTarihi=@randevuTarihi,randevuSaati=@randevuSaati,poliklinikAdi=@poliklinikAdi WHERE hastaTC=@hastaTC";
            SqlCommand = new SqlCommand(sorgu, SqlConnection);
            SqlCommand.Parameters.AddWithValue("@hastaTC", hastaTcKontrolTextBox.Text);
            SqlCommand.Parameters.AddWithValue("@poliklinikAdi", polklinikSecimComboBox.Text);
            SqlCommand.Parameters.AddWithValue("@randevuTarihi", RandevuTarihidateTimePicker.Text);
            SqlCommand.Parameters.AddWithValue("@personelAdi", doktorSecimComboBox.Text);
            SqlCommand.Parameters.AddWithValue("@randevuSaati", randevuSaatiTextbox.Text);
            SqlConnection.Open();
            SqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
            MessageBox.Show("GUNCELLEME BASARILI");
            randevuListeleGrid();
            







        }

        private void randevuDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (randevuDatagrid.CurrentRow == null)
            {
                MessageBox.Show("Secili Deger Bulunamadi !");
            }
            else
            {


                string index = randevuDatagrid.CurrentRow.Cells[0].Value.ToString();
                MessageBox.Show("secilirow" + index);
                randevuProvider.randevuBoxListele(index, hastaTcKontrolTextBox, polklinikSecimComboBox, RandevuTarihidateTimePicker, doktorSecimComboBox, randevuSaatiTextbox);
            }
        }

        private void searchPersonelButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < presonelDatagrid.Rows.Count; i++)
            {
                if (!presonelDatagrid.Rows[i].IsNewRow)
                {
                    if (presonelDatagrid[1, i].Value.ToString() == PersonelGuncelleTabAramaTextBox.Text)
                    {
                        presonelDatagrid.Rows[i].Selected = true;
                        MessageBox.Show("PERSONEL BULUNDU!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        presonelDatagrid.FirstDisplayedScrollingRowIndex = presonelDatagrid.SelectedRows[0].Index;
                    }

                    else
                    {
                        presonelDatagrid.Rows[i].Selected = false;

                    }

                }
            }


        }

        private void searchRandevuButton_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < randevuDatagrid.Rows.Count; i++)
            {
                if (!randevuDatagrid.Rows[i].IsNewRow)
                {
                    if (randevuDatagrid[0, i].Value.ToString() == randevuGuncelleTabAramaTextBox.Text)
                    {
                        randevuDatagrid.Rows[i].Selected = true;
                        MessageBox.Show("RANDEVU BULUNDU!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        randevuDatagrid.FirstDisplayedScrollingRowIndex = randevuDatagrid.SelectedRows[0].Index;
                    }

                    else
                    {
                        randevuDatagrid.Rows[i].Selected = false;

                    }

                }
            }
        }

        private void refreshPersonelGridButton_Click(object sender, EventArgs e)
        {
            PersonelListele();
            PersonelGuncelleTabPersonelTuru.Text = String.Empty;
            PersonelGuncelleTabTCtextBox.Text = String.Empty;
            PersonelGuncelleTabAdTextBox.Text = String.Empty;
            PersonelGuncelleTabSoyadTextBox.Text = String.Empty;
            PersonelGuncelleTabPoliklinik.Text = String.Empty;
            PersonelGuncelleTabTelefonTextBox.Text = String.Empty;
            PersonelGuncelleTabUnvan.Text = String.Empty;
            PersonelGuncelleTabEpostaTextBox.Text = String.Empty;
            PersonelGuncelleTabAdresRichBox.Text = String.Empty;

        }

        private void refreshRandevuGridButton_Click(object sender, EventArgs e)
        {
            randevuListeleGrid();
            hastaTcKontrolTextBox.Text = String.Empty;
            polklinikSecimComboBox.Text = String.Empty;
            RandevuTarihidateTimePicker.Text = String.Empty;
            doktorSecimComboBox.Text = String.Empty;
            randevuSaatiTextbox.Text = String.Empty;
        }

        private void bekleyenHastadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(bekleyenHastadataGridView.CurrentRow == null)
            //{
            //    MessageBox.Show("Secili Deger Bulunamadi");

            //}

        }

        private void muayneIptalButton_Click(object sender, EventArgs e)
        {
            hastaKayitNoTextBox.Text = String.Empty;
            HastaTCTextBox.Text = String.Empty;
            hastaNoTextBox.Text = String.Empty;
            hastaSayisiTextBox.Text = String.Empty;
            hastaAdiTextBox.Text = String.Empty;
            hastaSoyadiTextBox.Text = String.Empty;
            hastaCinsiyetTextBox.Text = String.Empty;
            hastaKangrubuTextBox.Text = String.Empty;
            muayneBitisTextBox.Text = String.Empty;




            hastaAtesiTextBox.Text = String.Empty;
            hastaKiloTextBox.Text = String.Empty;
            hastaBoyTextBox.Text = String.Empty;
            hastaNabizTextBox.Text = String.Empty;
            tansiyonBuyukTextBox.Text = String.Empty;
            tansiyonKucukTextBox.Text = String.Empty;
            hastaHikayesiTextBox.Text = String.Empty;
            hastaBulgulariTextBox.Text = String.Empty;
            hastaKararTextBox.Text = String.Empty;
            muayneBitisDateTimePicker.Text = String.Empty;
            muayneBitisTextBox.Text = String.Empty;

        }

        private void hastaKayitTelefonTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
