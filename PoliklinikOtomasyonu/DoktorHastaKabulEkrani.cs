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
    public partial class DoktorHastaKabulEkrani : Form
    {
        public string ISIM;
        public DoktorHastaKabulEkrani()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
           // FormBorderStyle = FormBorderStyle.None;
        }

        private void DoktorHastaKabulEkranı_Load(object sender, EventArgs e)
        {
            polklinikHastaAdiLabel.Text = ISIM;
            
        }
    }
}
