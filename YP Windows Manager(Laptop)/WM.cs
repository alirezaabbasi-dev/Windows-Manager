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
        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000001,
            SHERB_NOSOUND = 0x00000004
        }
        public WM()
        {
          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                GetInstalledPrinters();
                this.Text = "YP WM (Beta)";
                this.ThemeName = fluentTheme1.ThemeName;
                radPanel1.ThemeName = fluentTheme1.ThemeName;
                radPanel2.ThemeName = fluentTheme1.ThemeName;
                radPanel3.ThemeName = fluentTheme1.ThemeName;
                radPanel4.ThemeName = fluentTheme1.ThemeName;

                PowerStatus powerStatus = SystemInformation.PowerStatus;
                int batteryLevel = (int)(powerStatus.BatteryLifePercent* 100);
                bChargeInfo.Text = $"Battery Level: {batteryLevel}%";
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath,
          RecycleFlags dwFlags);

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ShutDown", "/s /t 60");
        }

        private void singoutBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ShutDown", "/l /t 60");
            HelpButton.ToString();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ShutDown", "/r /t 60");
        }

        private void logcancellBtn_Click(object sender, EventArgs e)
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
        private void openDVDBtn_Click(object sender, EventArgs e)
        {
            int ret = MciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
        }

        private void emptyRecycleBtn_Click(object sender, EventArgs e)
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

        private void sysInfoBtn_Click(object sender, EventArgs e)
        {
            sysInfo info = new sysInfo();
            info.Show();
            this.Hide();
        }

        private void appStnBtn_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void GetInstalledPrinters()
        {
            foreach (string printerName in PrinterSettings.InstalledPrinters)
                printersList.Items.Add(printerName);
        }

        private void checkHealthBtn_Click(object sender, EventArgs e)
        {
            healthCheck health = new healthCheck();
            health.Show();
            this.Hide();
        }

        private void RadButton13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msedge.exe", "https://www.google.com/search?q=" + radTextBox1.Text);
        }

        private void RadTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            aboutFrm about = new aboutFrm();
            about.Show();
            this.Hide();
        }

        private void insProgBtn_Click(object sender, EventArgs e)
        {   
       installedAppFrm installedApp = new installedAppFrm();
            installedApp.Show();
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


        private void printersList_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cleanTmpBtn_Click(object sender, EventArgs e)
        {

        }
    }
}



 