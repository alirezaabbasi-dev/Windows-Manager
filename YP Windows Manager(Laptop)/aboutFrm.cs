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
    public partial class aboutFrm : Telerik.WinControls.UI.RadForm
    {
        public aboutFrm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Color colour = ColorTranslator.FromHtml("43, 43, 43");
            Color L_mode_colour = ColorTranslator.FromHtml("242, 242, 242");
            Color L_mode_colour1 = ColorTranslator.FromHtml("204, 204, 204");

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

                        aboutTxt.BackColor = colour;
                        aboutTxt.ForeColor = L_mode_colour;

                        github__Btn.BackColor = Color.Black;
                        github__Btn.ForeColor = L_mode_colour;

                        okBtn.BackColor = Color.Black;
                        okBtn.ForeColor = L_mode_colour;

                        txtColor__Btn.BackColor = colour;
                        txtColor__Btn.ForeColor = L_mode_colour;
                    }
                    else
                    {
                        // Apply light mode styles
                        this.ThemeName = fluentTheme1.ThemeName;
                        this.BackColor = L_mode_colour;
                        this.ForeColor = colour;

                        aboutTxt.BackColor = L_mode_colour;
                        aboutTxt.ForeColor = colour;

                        github__Btn.BackColor = L_mode_colour1;
                        github__Btn.ForeColor = colour;

                        okBtn.BackColor = L_mode_colour1;
                        okBtn.ForeColor = colour;

                        txtColor__Btn.BackColor = L_mode_colour;
                        txtColor__Btn.ForeColor = colour;


                    }
                }
            }
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
            if (cdl.ShowDialog() == DialogResult.OK)
            {
                aboutTxt.ForeColor = cdl.Color;
            }
        }

        private void RadColorBox1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
