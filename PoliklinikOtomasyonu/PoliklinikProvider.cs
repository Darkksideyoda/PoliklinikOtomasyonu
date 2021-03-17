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
    class PoliklinikProvider
    {

        SqlConnection SqlConnection;
        SqlCommand SqlCommand;

        public PoliklinikProvider()
        {
            ConnectionSql();
        }

        public void ConnectionSql()
        {
            SqlConnection = new SqlConnection(@"Data Source=DESKTOP-JD2HKS3;Initial Catalog=PoliklinikOtomasyonu; Integrated Security=True");
            SqlCommand = new SqlCommand();
            SqlCommand.Connection = SqlConnection;


        }

        public void poliklinikDoktorbulma(PoliklinikBilgileri poliklinik,HastaRandevuEkrani randevuEkrani)
        {

            try
            {
                SqlCommand.CommandText = "select *from personelBilgileri where personelPoliklinik='" + poliklinik.poliklinikAdi + "'";
                SqlCommand.CommandType = CommandType.Text;
                SqlConnection.Open();
                SqlCommand.ExecuteNonQuery();
                SqlDataReader dataReader = SqlCommand.ExecuteReader();
                if (dataReader.Read() == true)
                {
                    randevuEkrani.doktorSecimComboBox.Items.Add(dataReader.GetValue(2).ToString()+dataReader.GetValue(3).ToString());
                   
                }
                else
                {
                    MessageBox.Show("SECMIS OLDUGUNUZ POLIKLINIKTE DOKTOR BULUNMAMAKTADIR", "HATA");
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



    }
}
