using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YP_Windows_Manager_Computer_
{
    public partial class waitfrm : Telerik.WinControls.UI.RadForm
    {
        public waitfrm()
        {
            InitializeComponent();
        }

        private void waitfrm_Load(object sender, EventArgs e)
        {

            FormBorderStyle = FormBorderStyle.Fixed3D;
            radWaitingBar1.StartWaiting();
            this.Text = "";
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WM nr = new WM();
            this.Hide();
           
            nr.Show();
            timer1.Stop();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
