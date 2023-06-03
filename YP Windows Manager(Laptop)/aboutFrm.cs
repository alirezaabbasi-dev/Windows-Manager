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
    public partial class aboutFrm : Telerik.WinControls.UI.RadForm
    {
        public aboutFrm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void RadButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/alirezaabbasi-dev");
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            WM frm1 = new WM();
            frm1.Show();

        }

        private void RadButton3_Click(object sender, EventArgs e)
        {
            ColorDialog cdl = new ColorDialog();
            if (cdl  .ShowDialog()==DialogResult.OK )
            {
                aboutTxt .ForeColor = cdl .Color;
            }
        }

        private void RadColorBox1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
