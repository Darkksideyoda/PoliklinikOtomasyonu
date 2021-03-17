using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PoliklinikOtomasyonu
{
    class PersonelProvider
    {
        SqlConnection SqlConnection;
        SqlCommand SqlCommand;
        
       
        public PersonelProvider()
        {
            ConnectionSql();
        }

        public void ConnectionSql()
        {
            SqlConnection = new SqlConnection(@"Data Source=DESKTOP-JD2HKS3;Initial Catalog=PoliklinikOtomasyonu; Integrated Security=True");
            SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;
            
        
        }

        public void personelEkle(PersonelBilgileri personel)
        {

            try
            {
                SqlCommand.CommandText = "Insert Into personelBilgileri(personelTC,personelTuru,personelAdi,personelSoyadi,personelPoliklinik,personelTelefon,personelUnvan,personelEposta,personelAdres,personelID,personelSifre) Values(" + personel.personelTC + ",'" + personel.personelTuru + "','" + personel.personelAdi + "','" + personel.personelSoyadi + "','" + personel.personelPoliklinik + "','" + personel.personelTelefon + "','" + personel.personelUnvan + "','" + personel.personelEposta + "','" + personel.personelAdres + "','" + personel.personelID + "','" + personel.personelSifre + "')";
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

        public void personelLogin(PersonelBilgileri personel)
        {
            MainPage Anasayfa = new MainPage();
            
            try
            {
                SqlCommand.CommandText = "select *from personelBilgileri where personelID='" + personel.personelID + "' and personelSifre='" + personel.personelSifre + "' and personelTuru='" + personel.personelTuru + "'";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlCommand.ExecuteNonQuery();
                SqlDataReader dataReader = SqlCommand.ExecuteReader();
                if (dataReader.Read() == true)
                {


                    string valuePersonelTC = personel.personelTC = dataReader[0].ToString();
                    Anasayfa.personeGelenTC = valuePersonelTC;
                    Anasayfa.gelecekDeger = personel.personelTuru;

                     
                     string valuePersonelAD =  personel.personelAdi = dataReader[2].ToString();
                     string valuePersonelSOYAD = personel.personelSoyadi = dataReader[3].ToString();
                     string tamAD = valuePersonelAD+""+valuePersonelSOYAD;
                    Anasayfa.personelAd = tamAD;


                    MessageBox.Show("PERSONEL ADI: " + tamAD);

                    MessageBox.Show("GIRIS BASARILI");
                    Anasayfa.ShowDialog();
                    

                }
                else
                {
                    MessageBox.Show("HATALI GIRIS PARAMETRELERI\nLUTFEN GIRIS BILGILERINIZI KONTROL EDINIZ","HATA");
                }

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







        public List<RandevuBilgileri> personelHastasi(string PersonelAd)
        {



            try
            {
                List<RandevuBilgileri> randevuList = new List<RandevuBilgileri>();
                SqlCommand.CommandText = "Select *From RandevuBilgileri Where personelAdi='" + PersonelAd + "'";
                
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    RandevuBilgileri randevuBilgileri = new RandevuBilgileri();
                    randevuBilgileri.hastaTC = reader[0].ToString();
                    randevuBilgileri.randevuTarihi = reader[2].ToString();
                    // randevuBilgileri.randevuTarihi = Convert.ToDateTime(reader[2].ToString());
                    randevuBilgileri.randevuSaati = reader[3].ToString();
                    randevuList.Add(randevuBilgileri);
                }

                return randevuList;
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


        public List<PersonelBilgileri> Listele()
        {

            try
            {
                List<PersonelBilgileri> personelListesi = new List<PersonelBilgileri>();
                SqlCommand.CommandText = "Select *From personelBilgileri";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    PersonelBilgileri personel = new PersonelBilgileri();
                 
                    personel.personelTC = reader[0].ToString();
                    personel.personelAdi = reader[1].ToString();
                    personel.personelSoyadi = reader[2].ToString();
                    personel.personelTuru = reader[3].ToString();
                    personel.personelPoliklinik = reader[4].ToString();
                    personel.personelUnvan = reader[5].ToString();
                    personel.personelTelefon = reader[6].ToString();
                    

                    personelListesi.Add(personel);
                }

                return personelListesi;
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

        public void personelSil(string personel)
        {
            try
            {
                SqlCommand.CommandText = "Delete From personelBilgileri Where personelTC='" + personel + "'";
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

        //public void Guncelle(PersonelBilgileri eskiPersonel, PersonelBilgileri yeniPersonel)
        //{
        //    try
        //    {
        //        SqlCommand.CommandText = "Update personelBilgileri SET personelTC='" + yeniPersonel.personelTC + "',personelTuru='" + yeniPersonel.personelTuru + "',personelAdi='" + yeniPersonel.personelAdi + "',personelSoyadi='" + yeniPersonel.personelSoyadi + "',personelPoliklinik='" + yeniPersonel.personelPoliklinik + "',personelTelefon='" + yeniPersonel.personelTelefon + "',personelUnvan='" + yeniPersonel.personelUnvan + "',personelEposta='" + yeniPersonel.personelEposta + "',personelAdres='" + yeniPersonel.personelAdres + "' Where personelTC=" + eskiPersonel.personelTC + "";
        //        SqlCommand.CommandType = CommandType.Text;
        //        SqlConnection.Open();
        //        SqlCommand.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        if (SqlConnection != null)
        //        {
        //            SqlConnection.Close();
        //        }
        //    }

        //}








        //public void Guncelle(string eskiPersonel, PersonelBilgileri yeniPersonel)
        //{
        //    try
        //    {
        //        SqlCommand.CommandText = "Update personelBilgileri SET personelTC='" + yeniPersonel.personelTC + "',personelTuru='" + yeniPersonel.personelTuru + "',personelAdi='" + yeniPersonel.personelAdi + "',personelSoyadi='" + yeniPersonel.personelSoyadi + "',personelPoliklinik='" + yeniPersonel.personelPoliklinik + "',personelTelefon='" + yeniPersonel.personelTelefon + "',personelUnvan='" + yeniPersonel.personelUnvan + "',personelEposta='" + yeniPersonel.personelEposta + "',personelAdres='" + yeniPersonel.personelAdres + "' Where personelTC=" + eskiPersonel + "";
        //        SqlCommand.CommandType = CommandType.Text;
        //        SqlConnection.Open();
        //        SqlCommand.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        if (SqlConnection != null)
        //        {
        //            SqlConnection.Close();
        //        }
        //    }

        //}








        public void personelListele(string personelSecim, ComboBox tur,TextBox tc, TextBox ad, TextBox soyad, ComboBox poliklinik, TextBox tel, TextBox unvan, TextBox eposta,RichTextBox adres)
        {

            try
            {

                SqlCommand.CommandText = "Select *From personelBilgileri Where personelTC ='" + personelSecim + "'";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    tc.Text = reader[0].ToString();
                    tur.Text = reader[1].ToString();
                    ad.Text = reader[2].ToString();
                    soyad.Text = reader[3].ToString();
                    poliklinik.Text = reader[4].ToString();
                    tel.Text = reader[5].ToString();
                    unvan.Text = reader[6].ToString();
                    eposta.Text = reader[7].ToString();
                    adres.Text = reader[8].ToString();

                   


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
