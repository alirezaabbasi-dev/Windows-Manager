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
    public partial class Form4 : Telerik.WinControls.UI.RadForm
    {
       
        public Form4()
        {
        
            InitializeComponent();
        }
       
        private void Form4_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            if (timer1.Enabled == true)
            {
                radButton1.Enabled = false;
                ControlBox = false;
                MinimizeBox = false;
                timer3.Stop();
            }
            else
                timer3.Start();
            radButton1.Enabled = true;
            ControlBox = true;
            MinimizeBox = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
            int a = 0;
            while (a < 50)
            {
                a++;
                radProgressBar1.Value1 = a;
            }

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            
            if (timer1.Enabled == false)
            {
                timer1.Start();
                ControlBox = false;
                radProgressBar1.Text = "Checking... .";
                label1.Text = "0";
            }
            else
            {
                timer1.Stop();
                ControlBox = true;
                radProgressBar1.Text = "Great, no problem";
            }
            if (true)
            {

            }
            
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (radProgressBar1.Value1==50)
            {
                radButton1.Enabled = false;
                timer1.Stop();
                radProgressBar1.Value2 = 99+1;
                radProgressBar1.Text = "Nice,no problem";
                label1.Text = "1";

            }
            if (radProgressBar1.Value2==99+1)
            {
                radButton1.Enabled = true;
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        
                WM frm = new WM();
                frm.Show();
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                radButton1.Enabled = false;
                ControlBox = false;
                MinimizeBox = false;
                timer3.Stop();
            }
            else
                timer3.Start();
                radButton1.Enabled = true;
            ControlBox = true;
            MinimizeBox = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (label1.Text=="0")
            {
                ControlBox = false;
            }
            else
            {
                ControlBox = true;
            }
        }

        private void ugToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled==true)
            {
                radButton1.Enabled = false;
            }
            else
                radButton1.Enabled = true ;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (radButton1.Enabled==false)
            {
                radButton1.ForeColor = Color.DarkGray;
            }
            else
            {
                radButton1.ForeColor = Color.Black;
            }
        }
    }
}
