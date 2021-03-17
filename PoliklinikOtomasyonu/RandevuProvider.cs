using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace PoliklinikOtomasyonu
{
    class RandevuProvider
    {


        SqlConnection SqlConnection;
        SqlCommand SqlCommand;
        
        public RandevuProvider()
        {
            ConnectionSql();
        }

        private void ConnectionSql()
        {

            SqlConnection = new SqlConnection(@"Data Source=DESKTOP-JD2HKS3;Initial Catalog=PoliklinikOtomasyonu; Integrated Security=True");
            SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;

        }


        public void randevuEkle(RandevuBilgileri randevu)
        {

            try
            {
                SqlCommand.CommandText = "Insert Into RandevuBilgileri(hastaTC,personelAdi,randevuTarihi,randevuSaati,poliklinikAdi) Values(" + randevu.hastaTC + ",'" + randevu.personelAdi + "','" +randevu.randevuTarihi + "','" + randevu.randevuSaati + "','" + randevu.poliklinikAdi + "')";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (SqlConnection != null)
                {
                    SqlConnection.Close();
                }
            }

        }

        public void randevuSil(string Hasta)
        {
            try
            {
                SqlCommand.CommandText = "Delete From RandevuBilgileri Where hastaTC='" + Hasta + "'";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (SqlConnection != null)
                {
                    SqlConnection.Close();
                }
            }
        }

        public List<RandevuBilgileri> ListeleShowgrid()
        {

            try
            {
                List<RandevuBilgileri> randevuListele = new List<RandevuBilgileri>();
                SqlCommand.CommandText = "Select *From RandevuBilgileri";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlDataReader reader = SqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    RandevuBilgileri randevu = new RandevuBilgileri();
                    randevu.hastaTC = reader[0].ToString();
                    randevu.personelAdi = reader[1].ToString();
                    randevu.randevuTarihi = reader[2].ToString();
                    randevu.randevuSaati = reader[3].ToString();
                    randevu.poliklinikAdi = reader[4].ToString();

                    randevuListele.Add(randevu);


                }
                return randevuListele;



            }



            catch
            {
                throw;
            }
            finally
            {
                if (SqlConnection != null)
                {
                    SqlConnection.Close();
                }
            }
        }

        public void randevuBoxListele(string randevuSecim, RichTextBox tc, ComboBox pol , DateTimePicker randevuTarih,ComboBox doktor,TextBox saat)
        {

            try
            {

                SqlCommand.CommandText = "Select *From RandevuBilgileri Where hastaTC ='" + randevuSecim + "'";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string tarih = randevuTarih.ToString();

                    tc.Text = reader[0].ToString();
                    doktor.Text = reader[1].ToString();
                    tarih = reader[2].ToString();
                    saat.Text = reader[3].ToString();
                    pol.Text = reader[4].ToString();






                }


            }
            catch
            {
                throw;
            }
            finally
            {
                if (SqlConnection != null)
                {
                    SqlConnection.Close();
                }
            }
        }




    }
}
