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
using Telerik.WinControls.Themes;

namespace YP_Windows_Manager_Computer_
{
    public partial class installedAppFrm : Telerik.WinControls.UI.RadForm
    {
        public installedAppFrm()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Color colour = ColorTranslator.FromHtml("43, 43, 43");
            Color L_mode_colour = ColorTranslator.FromHtml("242, 242, 242");

            // Read the registry key to determine the current theme
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
            {
                if (key != null)
                {
                    // Get the value of "AppsUseLightTheme" (0 = Dark Mode enabled, 1 = Light Mode enabled)
                    int appsUseLightTheme = (int)key.GetValue("AppsUseLightTheme", 1);

                    // Check if dark mode is enabled
                    if (appsUseLightTheme == 0)
                    {
                        ThemeName = fluentDarkTheme1.ThemeName;
                        InstalledList.ThemeName = fluentDarkTheme1.ThemeName;
                        this.BackColor = colour;
                        this.ForeColor = L_mode_colour;

                    }
                    else
                    {
                        // Apply light mode styles
                        this.ThemeName = fluentTheme1.ThemeName;
                        this.ThemeName = fluentTheme1.ThemeName;
                        this.BackColor = L_mode_colour;
                        this.ForeColor = colour;

                    }
                }
            }

            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        // we have many attributes other than these which are useful.
                        InstalledList.Items.Add(sk.GetValue("DisplayName") +
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

        private void InstalledList_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
