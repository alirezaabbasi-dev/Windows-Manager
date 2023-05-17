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
    public partial class Form6 : Telerik.WinControls.UI.RadForm
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        // we have many attributes other than these which are useful.
                        listBox1.Items.Add(sk.GetValue("DisplayName") +
                "  " + sk.GetValue("DisplayVersion"));
                    }
                }
            }
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            WM fg = new WM();
            fg.Show();
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }
    }
        }
