using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PoliklinikOtomasyonu
{
    class HastaProvider
    {

        SqlConnection SqlConnection;
        SqlCommand SqlCommand;
        PoliklinikProvider poliklinikProvider = new PoliklinikProvider();
        public HastaProvider()
        {
            ConnectionSql();
        }

        private void ConnectionSql()
        {

            SqlConnection = new SqlConnection(@"Data Source=DESKTOP-JD2HKS3;Initial Catalog=PoliklinikOtomasyonu; Integrated Security=True");
            SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;

        }


           public void hastaEkle(HastaBilgileri hasta)
        {

            try
            {
                SqlCommand.CommandText = "Insert Into hastaBilgileri(hastaTC,hastaAdi,hastaSoyadi,hastaDogumyeri,hastaDogumtarihi,hastaCinsiyet,hastaSosyalguvenceturu,hastaSosyalguvenceNO,hastaKangrubu,hastaTelefon,hastaEposta,hastaKayitNO,hastaNo) Values(" + hasta.hastaTC + ",'" + hasta.hastaAdi + "','" + hasta.hastaSoyadi+ "','" + hasta.hastaDogumyeri+ "','" + hasta.hastaDogumtarihi.ToString()+ "','" + hasta.hastaCinsiyet+ "','" + hasta.hastaSosyalGuvenceturu+ "','" + hasta.hastaSosyalguvenceNO + "','" + hasta.hastaKangrubu+ "','" + hasta.hastaTelefon + "','" + hasta.hastaEposta+"','"+hasta.hastaKayitNO+"','"+hasta.hastaNo+ "')";
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


        public void hastaKontrol(HastaBilgileri hasta,HastaRandevuEkrani randevuEkrani)
        {
            MainPage Anasayfa = new MainPage();
           


            try
            {
                SqlCommand.CommandText = "select *from hastaBilgileri where hastaTC='" + hasta.hastaTC + "'";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlCommand.ExecuteNonQuery();
                SqlDataReader dataReader = SqlCommand.ExecuteReader();
                if(randevuEkrani.polklinikSecimComboBox.Text == "")
                {
                    MessageBox.Show("Lutfen Poliklinik Secimi Yapiniz ! ", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dataReader.Read() == true)
                    {

                        MessageBox.Show("HASTA SISTEMDE BULUNDU !", "BASARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        randevuEkrani.Size = new System.Drawing.Size(504, 736);
                        randevuEkrani.randevuSaatiGroupBox.Visible = true;
                        randevuEkrani.randevuKontrolButton.Visible = false;
                        randevuEkrani.doktorSecimComboBox.Visible = true;
                        randevuEkrani.randevuSaatiTextbox.Visible = true;
                        randevuEkrani.islemiSonlandirButton.Visible = true;
                        randevuEkrani.randevuyuKaydetButton.Visible = true;
                        randevuEkrani.label3.Visible = true;
                        randevuEkrani.label5.Visible = true;
                        randevuEkrani.hastaTcKontrolTextBox.Enabled = false;
                        PoliklinikBilgileri Poliklinik = new PoliklinikBilgileri();
                        Poliklinik.poliklinikAdi = randevuEkrani.polklinikSecimComboBox.Text;
                        poliklinikProvider.poliklinikDoktorbulma(Poliklinik, randevuEkrani);


                    }
                    else
                    {
                        MessageBox.Show("HASTA SISTEMDE BULUNAMADI\nLUTFEN TC NO KONTROL EDINIZ VEYA\nSEKRETERLIKTEN HASTA KAYDI OLUSTURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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


       
        public void hastaListele(string hastaSecim,TextBox tc,TextBox ad, TextBox soyad , TextBox cinsiyet , TextBox kangrubu ,TextBox kayitNo , TextBox hastaNo)
        {

            try
            {
                
                SqlCommand.CommandText = "Select *From hastaBilgileri Where hastaTC ='" + hastaSecim + "'";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    tc.Text = reader[0].ToString();
                    ad.Text = reader[1].ToString();
                    soyad.Text = reader[2].ToString();
                    cinsiyet.Text = reader[5].ToString();
                    kangrubu.Text = reader[8].ToString();
                    kayitNo.Text = reader[11].ToString();
                    hastaNo.Text = reader[12].ToString();


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




        public List<HastaBilgileri> ListeleShowgrid()
        {

            try
            {
                List<HastaBilgileri> hastaListesigrid = new List<HastaBilgileri>();
                SqlCommand.CommandText = "Select *From hastaBilgileri";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlDataReader reader = SqlCommand.ExecuteReader();

                while (reader.Read())
                    {
                        HastaBilgileri hasta = new HastaBilgileri();
                        hasta.hastaTC = reader[0].ToString();
                        hasta.hastaAdi = reader[1].ToString();
                        hasta.hastaSoyadi = reader[2].ToString();


                        hastaListesigrid.Add(hasta);


                    }
                     return hastaListesigrid;



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





        public void muayneEkle(muayneBilgileri muayne)
        {

            try
            {
                SqlCommand.CommandText = "Insert Into muayneBilgileri(hastaTC,muayneTarihi,hastaAtesi,hastaKilo,hastaBoy,hastaNabiz,tansiyonBuyuk,tansiyonKucuk,hastaHikayesi,hastaBulgulari,hastaKarar,personelTC,hastaTanisi,hastaTetkik,hastaLab,muayneSaati) Values(" + muayne.hastaTC + ",'" + muayne.hastaMuayneTarihi + "','" + muayne.hastaAtesi + "','" + muayne.hastaKilo+ "','" + muayne.hastaBoy+ "','" + muayne.hastaNabiz + "','" + muayne.tansiyonBuyuk + "','" + muayne.tansiyonKucuk + "','" + muayne.hastaHikayesi + "','" + muayne.hastaBulgulari + "','" + muayne.hastaKarar+ "','" + muayne.hastaMuaynePersonel + "','" + muayne.hastaTanisi + "','"+muayne.hastaTetkik+"','"+muayne.hastaLab+"','"+muayne.muayneSaat+"')";
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


        public List<muayneBilgileri> muayneListele(string Hastasecim)
        {

            try
            {
                List<muayneBilgileri> muayneListesi = new List<muayneBilgileri>();
                SqlCommand.CommandText = "Select *From muayneBilgileri Where hastaTC ='" + Hastasecim + "'";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    muayneBilgileri muayne = new muayneBilgileri();
                    
                    muayne.hastaTC = reader[0].ToString();
                    muayne.hastaMuayneTarihi = reader[1].ToString();


                    muayneListesi.Add(muayne);
                }

                return muayneListesi;
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




        public List<string> muayneBilgisi(string tarihSecim)
        {
            string tumBilgi, tarih, hikaye, bulgu, karar, tani, tetik, lab, tc;
            int ates, kilo, boy, nabiz, buyuk, kucuk;
            



            try
            {
                List<string> muayneListesi = new List<string>();
                SqlCommand.CommandText = "Select *From muayneBilgileri Where muayneTarihi ='" + tarihSecim + "'";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    muayneBilgileri muayne = new muayneBilgileri();
                   tarih= muayne.hastaMuayneTarihi = reader[1].ToString();
                    ates =  muayne.hastaAtesi = Convert.ToInt32(reader[2].ToString());
                  kilo = muayne.hastaKilo = Convert.ToInt32(reader[3].ToString());
                    boy = muayne.hastaBoy = Convert.ToInt32(reader[4].ToString());
                    nabiz= muayne.hastaNabiz = Convert.ToInt32(reader[5].ToString());
                    buyuk = muayne.tansiyonBuyuk = Convert.ToInt32(reader[6].ToString());
                    kucuk= muayne.tansiyonKucuk = Convert.ToInt32(reader[7].ToString());
                    hikaye= muayne.hastaHikayesi = reader[8].ToString();
                     bulgu= muayne.hastaBulgulari = reader[9].ToString();
                     karar= muayne.hastaKarar = reader[10].ToString();
                    tani= muayne.hastaTanisi = reader[12].ToString();
                    tetik= muayne.hastaTetkik = reader[13].ToString();
                    lab= muayne.hastaLab = reader[14].ToString();
                    tc= muayne.hastaTC = reader[0].ToString();
                    //muayne.hastaMuayneTarihi = reader[1].ToString();



                    tumBilgi = "TARİH:" + tarih + "\n" +"HASTA TC:"+tc+"\n"+"****HASTA ÖLÇÜM BİLGİLERİ****\n"+"HASTANIN ATEŞİ: "+ates+"*C\n"+"HASTANIN KİLOSU: "+kilo+"KG\n"+"HASTANIN BOYU: "+boy+"CM\n"+"HASTANIN NABZI: "+nabiz+"BPM\n"+"HASTANIN KAN BASINCI: "+buyuk+"mm/Hg"+" "+kucuk+"mm/Hg\n"+"****HASTANIN TESPİT EDİLEN BİLGİLERİ:****\n"+"HASTANIN HİKAYESİ:"+hikaye+"\n"+"HASTANIN BULGULARI:"+ bulgu+"\n"+"DOKTOR KARARI:"+karar+"\n"+"****TANI/TETKIK VE LAB BILGILERI****\n"+"HASTA TANISI:"+tani+"\n"+"ISTENILEN TETKIKLER:"+tetik+"\n"+"LAB TESTLERI"+lab+"\n";
                    muayneListesi.Add(tumBilgi);
                }
                

                return muayneListesi;

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



        public void hastaSil(string Hasta)
        {
            try
            {
                SqlCommand.CommandText = "Delete From hastaBilgileri Where hastaTC='" +Hasta+ "'";
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




        public void hastaBoxListele(string hastasecim, TextBox ad, TextBox soyad, ComboBox kangrubu, TextBox tc, TextBox tel,  TextBox eposta, ComboBox dogumyeri, DateTimePicker dogumtarihi,ComboBox cinsiyet,ComboBox sgkTuru,TextBox sosyal_guvence_no)
        {

            try
            {

                SqlCommand.CommandText = "Select *From hastaBilgileri Where hastaTC ='" + hastasecim + "'";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string tarih = dogumtarihi.ToString();
                    tc.Text = reader[0].ToString();
                    ad.Text = reader[1].ToString();
                    soyad.Text = reader[2].ToString();
                    dogumyeri.Text = reader[3].ToString();
                    tarih = reader[4].ToString();
                    cinsiyet.Text = reader[5].ToString();
                    sgkTuru.Text = reader[6].ToString();
                    sosyal_guvence_no.Text = reader[7].ToString();
                    kangrubu.Text = reader[8].ToString();
                    tel.Text = reader[9].ToString();
                    eposta.Text = reader[10].ToString();
                    




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






    

