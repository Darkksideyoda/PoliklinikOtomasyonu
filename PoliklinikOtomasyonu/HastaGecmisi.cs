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
     
    public partial class HastaGecmisi : Form
    {

        HastaProvider provider = new HastaProvider();
        public string hastaTC;
        public HastaGecmisi()
        {
            InitializeComponent();
        }



        void hastaListele()
        {

            listeleDatagridview.DataSource = provider.muayneListele(hastaTC);
            foreach (DataGridViewColumn column in listeleDatagridview.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void HastaGecmisi_Load(object sender, EventArgs e)
        {
            hastaListele();
            
            listeleDatagridview.Columns[12].Width = 255;
            listeleDatagridview.Columns[15].Width = 255;
            listeleDatagridview.Columns[0].Visible = false;
            listeleDatagridview.Columns[1].Visible = false;
            listeleDatagridview.Columns[2].Visible = false;
            listeleDatagridview.Columns[3].Visible = false;
            listeleDatagridview.Columns[4].Visible = false;
            listeleDatagridview.Columns[5].Visible = false;
            listeleDatagridview.Columns[6].Visible = false;
            listeleDatagridview.Columns[7].Visible = false;
            listeleDatagridview.Columns[8].Visible = false;
            listeleDatagridview.Columns[9].Visible = false;
            listeleDatagridview.Columns[10].Visible = false;
            listeleDatagridview.Columns[11].Visible = false;
            listeleDatagridview.Columns[13].Visible = false;
            listeleDatagridview.Columns[14].Visible = false;
            listeleDatagridview.Columns[16].Visible = false;
            listeleDatagridview.Columns[17].Visible = false;
            listeleDatagridview.Columns[18].Visible = false;
            listeleDatagridview.Columns[19].Visible = false;
            listeleDatagridview.Columns[20].Visible = false;
            listeleDatagridview.Columns[21].Visible = false;
            listeleDatagridview.Columns[22].Visible = false;
            listeleDatagridview.Columns[23].Visible = false;
            listeleDatagridview.Columns[24].Visible = false;
            listeleDatagridview.Columns[25].Visible = false;
            listeleDatagridview.Columns[26].Visible = false;
            listeleDatagridview.Columns[27].Visible = false;




        }

        private void listeleDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(listeleDatagridview.CurrentRow == null)
            {
                MessageBox.Show("Secili Deger Bulunamadi");
            }
            else
            {
                muayneOku muayneGecmisi = new muayneOku();
                string index = listeleDatagridview.CurrentRow.Cells[12].Value.ToString();
                muayneGecmisi.muayneDeger = index;
                MessageBox.Show("HASTA GECMISI SAYAFASI:" + index);
                muayneGecmisi.Show();
            }
         
        }
    }
}
