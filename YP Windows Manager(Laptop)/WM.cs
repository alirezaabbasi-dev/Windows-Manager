using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
     using Telerik.WinControls.UI;
using System.Drawing.Printing;
#pragma warning disable CS0105 // Using directive appeared previously in this namespace
#pragma warning restore CS0105 // Using directive appeared previously in this namespace
using System.Net.NetworkInformation;
using MetroFramework;
namespace YP_Windows_Manager_Computer_
{
    public partial class WM : Telerik.WinControls.UI.RadForm
    {
        //startup

        //
        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000001,
            SHERB_NOSOUND = 0x00000004
        }
        public WM()
        {
//reg.SetValue("Startup", Application.ExecutablePath.ToString());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetInstalledPrinters();

            this.ThemeName = fluentTheme1.ThemeName;
            radPanel1.ThemeName = fluentTheme1.ThemeName;
            radPanel2.ThemeName = fluentTheme1.ThemeName;
            radPanel3.ThemeName = fluentTheme1.ThemeName;
            radPanel4.ThemeName = fluentTheme1.ThemeName;

        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath,
          RecycleFlags dwFlags);
        private void RadButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ShutDown", "/s /t 60");
        }

        private void RadButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ShutDown", "/l /t 60");
            HelpButton.ToString();
        }

        private void RadButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ShutDown", "/r /t 60");
        }

        private void RadButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ShutDown", "/a");
            HelpButton.ToString();
            MetroMessageBox.Show(this, "Logoff Cancelled");
        }
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int MciSendString(string lpstrCommand,
      StringBuilder lpstrReturnString,
      int uReturnLength,
      IntPtr hwndCallback);
        private void RadButton5_Click(object sender, EventArgs e)
        {
            int ret = MciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
        }

        private void RadButton16_Click(object sender, EventArgs e)
        {
            int ret = MciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
        }
        private void RadButton6_Click(object sender, EventArgs e)
        {
            uint result = SHEmptyRecycleBin(IntPtr.Zero, null, 0);
        }

        private void RadButton7_Click(object sender, EventArgs e)
        {
            if (radTextBox1.Text == "")
            {
                MetroMessageBox.Show(this, "Error For empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RegistryKey user = Registry.CurrentUser;
                RegistryKey change = user.OpenSubKey("Software", true).OpenSubKey("Microsoft", true).OpenSubKey("Internet Explorer", true).OpenSubKey("Main", true);
                change.SetValue("Start Page", radTextBox1.Text.ToString());


                MetroFramework.MetroMessageBox.Show(this, "'" + radTextBox1.Text + "'" + "\nyour home page now.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void RadButton8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rasdial", "/disconnect");
            MetroMessageBox.Show(this, "internet Dial-Up Disconnected ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RadButton9_Click(object sender, EventArgs e)
        {
            Form2 asd = new Form2();
            asd.Show();
            this.Hide();
        }

        private void RadButton10_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();

        }

        private void RadButton11_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void GetInstalledPrinters()
        {
            foreach (string printerName in PrinterSettings.InstalledPrinters)
                printersList.Items.Add(printerName);
        }

        private void RadButton12_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void RadButton13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msedge.exe", "https://www.google.com/search?q=" + radTextBox1.Text);
        }

        private void RadTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadButton14_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void RadButton15_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();

        }

        private void RadProgressBar1_Click(object sender, EventArgs e)
        {



        }
        PowerStatus power = SystemInformation.PowerStatus;
        private void Timer1_Tick(object sender, EventArgs e)
        {
               
        }
        private String Getvalue;
        private void Button1_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            PingReply pingStatus = ping.Send("google.com");

            if (pingStatus.Status == IPStatus.Success)
            {
                MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show("Disonnected");

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
     
        }

        private void RadLabel1_Click(object sender, EventArgs e)
        {

        }

        private void RadTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char )13)
            {
                System.Diagnostics.Process.Start("iexplore.exe", "https://" + radTextBox1.Text);
            }
        }

        private void RadLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void tmrh_Tick(object sender, EventArgs e)
        {
            
            if (this.Opacity==100)
            {
                this.Opacity = 90;
            }
            if (this.Opacity==90)
            {
                this.Opacity = 70;
            }
            if (this.Opacity==70)
            {
                this.Opacity = 40;
            }
            if (this.Opacity==40)
            {
                
               
               
            }
        }

        private void printersList_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}



 