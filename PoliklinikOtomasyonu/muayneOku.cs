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

    
    public partial class muayneOku : Form
    {
        public string muayneDeger;
        HastaProvider provider = new HastaProvider();
        public muayneOku()
        {
            InitializeComponent();
        }

        private void muayneOku_Load(object sender, EventArgs e)
        {

            richTextBox1.Text = string.Join(" ",provider.muayneBilgisi(muayneDeger));


        }
    }
}
