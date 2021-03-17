using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PoliklinikOtomasyonu
{
    public partial class StateMachine : Form
    {
        //public StateMachine()
        //{
        //    Thread splashThread = new Thread(loginStart);
        //    splashThread.Start();
        //    Thread.Sleep(2500);
        //    InitializeComponent();
        //    splashThread.Abort();
        //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        //}

        //public void loginStart()
        //{
        //    Application.Run(new SplashScreen());
        //}

        public StateMachine()
        {
         
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
      
        private void StateMachine_Load(object sender, EventArgs e)
        {

        }

        private void loginPanelButton_Click(object sender, EventArgs e)
        {
            LoginPage frm = new LoginPage();
            frm.Show();
        }

        private void randevuSistemiButton_Click(object sender, EventArgs e)
        {
            HastaRandevuEkrani frm = new HastaRandevuEkrani();
            frm.Show();
        }
    }
}
