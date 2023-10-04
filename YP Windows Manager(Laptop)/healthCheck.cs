using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
<<<<<<< HEAD
using static MetroFramework.Drawing.MetroPaint;
=======
using System.Management;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
>>>>>>> New_Features

namespace YP_Windows_Manager_Computer_
{
    public partial class healthCheck : Telerik.WinControls.UI.RadForm
    {
<<<<<<< HEAD
=======

>>>>>>> New_Features
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
                MaximizeBox = false;
                ControlBox = true;
                MinimizeBox = true;
        }

        private async void radButton1_Click(object sender, EventArgs e)
        {
            radButton1.Enabled = false;
            ControlBox = false;
            MinimizeBox = false;
            progressBar.Visible = true;
            progressBar.Value= 0;
            progressBar.Style = ProgressBarStyle.Marquee;
           
            progressBar.MarqueeAnimationSpeed = 30;

            await Task.Delay(3000); 

            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.Value = 100;

            CheckHardwareHealth();
            ControlBox = true;
            MinimizeBox = true;
            radButton1.Enabled = true;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
<<<<<<< HEAD
        { 
=======
        {
>>>>>>> New_Features
                WM frm = new WM();
                frm.Show();
        }

        private void ugToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
