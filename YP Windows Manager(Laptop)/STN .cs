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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace YP_Windows_Manager_Computer_
{
    public partial class Form3 : Telerik.WinControls.UI.RadForm
    {
        RegistryKey addreg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        Microsoft.Win32.RegistryKey remreg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public Form3()
        { 
            InitializeComponent();
            if (addreg.GetValue("yp-wm") != null)
            {
                activeBtn.IsChecked = true;
                deactiveBtn.IsChecked = false;
            }
            else
            {
                activeBtn.IsChecked = false;
                deactiveBtn.IsChecked = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            WM frm = new WM();
            frm.Show();
        }

        private void radRadioButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            addreg.SetValue("yp-wm", Application.ExecutablePath.ToString());
        }

        private void radRadioButton2_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            remreg.DeleteValue("yp-wm", false);
        }
    }
}
