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
using Telerik.WinControls.UI;

namespace YP_Windows_Manager_Computer_
{
    public partial class waitFrm : Telerik.WinControls.UI.RadForm
    {
        public waitFrm()
        {
            InitializeComponent();
        }

        private void waitfrm_Load(object sender, EventArgs e)
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
                        this.BackColor = colour;
                        this.ForeColor = L_mode_colour;
                        radWaitingBar1.BackColor = colour;
                    }
                    else
                    {
                        // Apply light mode styles
                        this.ThemeName = fluentTheme1.ThemeName;
                        this.BackColor = L_mode_colour;
                        this.ForeColor = colour;
                        radWaitingBar1.BackColor = L_mode_colour;
                    }
                }
            }

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
    }
}
