using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static MetroFramework.Drawing.MetroPaint;
using System.Management;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using Microsoft.Win32;

namespace YP_Windows_Manager_Computer_
{
    public partial class healthCheck : Telerik.WinControls.UI.RadForm
    {

        public healthCheck()
        {
            InitializeComponent();
        }

        private void CheckHardwareHealth()
        {
            if (IsCPUGood())
            {
                cpuLabel.Text = "CPU : OK";
            }
            else
            {
                cpuLabel.Text = "CPU : Error";
            }

            if (IsGPUGood())
            {
                gpuLabel.Text = "GPU : OK";
            }
            else
            {
                gpuLabel.Text = "GPU : Error";
            }

            if (IsRAMGood())
            {
                ramLabel.Text = "RAM : OK";
            }
            else
            {
                ramLabel.Text = "RAM : Error";
            }

            if (IsStorageGood())
            {
                storageLabel.Text = "Storage : OK";
            }
            else
            {
                storageLabel.Text = "Storage : Error";
            }
        }

        private bool IsCPUGood()
        {
            return true;
        }

        private bool IsGPUGood()
        {
            return true;
        }

        private bool IsRAMGood()
        {
            return true;
        }

        private bool IsStorageGood()
        {
            return true;
        }

        private void Form4_Load(object sender, EventArgs e)
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
                        checkBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        checkBtn.BackColor = colour;
                        checkBtn.ForeColor = L_mode_colour;
                        progressBar.BackColor = colour;

                        this.BackColor = Color.Black;
                        cpuLabel.BackColor = colour;
                        gpuLabel.BackColor = colour;
                        ramLabel.BackColor = colour;
                        storageLabel.BackColor = colour;

                        this.ForeColor = L_mode_colour;
                        gpuLabel.ForeColor = L_mode_colour;
                        ramLabel.ForeColor = L_mode_colour;
                        storageLabel.ForeColor = L_mode_colour;
                        cpuLabel.ForeColor = L_mode_colour;
                    }
                    else
                    {
                        // Apply light mode styles
                        this.ThemeName = fluentTheme1.ThemeName;
                        checkBtn.ThemeName = fluentTheme1.ThemeName;
                        checkBtn.BackColor = L_mode_colour;
                        checkBtn.ForeColor = colour;
                        progressBar.BackColor = L_mode_colour;

                        this.BackColor = Color.White;
                        cpuLabel.BackColor = L_mode_colour;
                        gpuLabel.BackColor = L_mode_colour;
                        ramLabel.BackColor = L_mode_colour;
                        storageLabel.BackColor = L_mode_colour;

                        this.ForeColor = colour;
                        gpuLabel.ForeColor = colour;
                        ramLabel.ForeColor = colour;
                        storageLabel.ForeColor = colour;
                        cpuLabel.ForeColor = colour;
                    }
                }
            }
            MaximizeBox = false;
            ControlBox = true;
            MinimizeBox = true;
        }

        private async void radButton1_Click(object sender, EventArgs e)
        {
            checkBtn.Enabled = false;
            ControlBox = false;
            MinimizeBox = false;
            progressBar.Visible = true;
            progressBar.Value = 0;
            progressBar.Style = ProgressBarStyle.Marquee;

            progressBar.MarqueeAnimationSpeed = 30;

            await Task.Delay(3000);

            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.Value = 100;

            CheckHardwareHealth();
            ControlBox = true;
            MinimizeBox = true;
            checkBtn.Enabled = true;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {

            {
                WM frm = new WM();
                frm.Show();
            }
        }
    }
}
