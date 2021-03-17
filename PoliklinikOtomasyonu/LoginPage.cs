using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliklinikOtomasyonu
{
    
    public partial class LoginPage : Form
    {
        public int  deger;
        
        PersonelProvider personelProvider = new PersonelProvider();

        public LoginPage()
        {

          
            InitializeComponent();
           


        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }


        systemAccount sys = new systemAccount();
        


        private void loginButton_Click(object sender, EventArgs e)
        {


            //MainPage pageControl = new MainPage();

            //pageControl.gelecekDeger = deger;

            //deger = comboBox1.SelectedIndex;

            //  sys.kullanıcı(usernameTextBox, passwordTextBox,personelTurucomboBox);

            PersonelBilgileri Personel = new PersonelBilgileri();
            Personel.personelTuru = personelTurucomboBox.Text;
            Personel.personelID = usernameTextBox.Text;
            Personel.personelSifre = passwordTextBox.Text;
            personelProvider.personelLogin(Personel);




        }


    
   




    }
}
