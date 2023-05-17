using Microsoft.Win32;
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
    public partial class Form3 : Telerik.WinControls.UI.RadForm
    {
        RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        Microsoft.Win32.RegistryKey hazf = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public Form3()
        {
          
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            reg.SetValue("yp-wm-CPTP-ver:---_2.0.2", Application.ExecutablePath.ToString());
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            hazf.DeleteValue("yp-wm-CPTP-ver:---_2.0.2", false);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            WM frm = new WM();
            frm.Show();
        }
    }
}
