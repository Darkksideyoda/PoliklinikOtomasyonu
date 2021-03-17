using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliklinikOtomasyonu
{
  
    class systemAccount
    {

        public int unvanDeger;

        SqlConnection ConnectionSql = new SqlConnection(@"Data Source=DESKTOP-JD2HKS3;Initial Catalog=PoliklinikOtomasyonu; Integrated Security=True");
        SqlCommand CommandSql;
        SqlDataReader ReadSql;



        MainPage Anasayfa = new MainPage();

        public SqlDataReader kullanıcı(TextBox personelID, TextBox personelSifre,ComboBox personelTuru)
        {

            string deger = personelTuru.SelectedIndex.ToString();

            unvanDeger = personelTuru.SelectedIndex;

            ConnectionSql.Open();
            CommandSql = new SqlCommand();
            CommandSql.Connection = ConnectionSql;
            CommandSql.CommandText = "select *from personelBilgileri where personelID='" + personelID.Text + "' and personelSifre='" + personelSifre.Text + "' and personelTuru='" + personelTuru.Text + "'";



            ReadSql = CommandSql.ExecuteReader();
            if (ReadSql.Read() == true)
            {


                Anasayfa.gelecekDeger = personelTuru.Text;
                MessageBox.Show("Giriş başarılı");
                Anasayfa.ShowDialog();

               

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata");

            }
            ConnectionSql.Close();
            return ReadSql;


        }


    }
}
