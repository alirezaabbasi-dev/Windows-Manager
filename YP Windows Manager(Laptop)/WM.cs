using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
#pragma warning disable CS0105 // Using directive appeared previously in this namespace
#pragma warning restore CS0105 // Using directive appeared previously in this namespace
using System.Net.NetworkInformation;
using MetroFramework;
using Telerik.WinControls;
using System.IO;

namespace YP_Windows_Manager_Computer_
{
    public partial class WM : Telerik.WinControls.UI.RadForm
    {
        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000001,
            SHERB_NOSOUND = 0x00000004
        }
        public WM()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private bool CheckForDVDDrive()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.CDRom)
                {
                    return true;
                }
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Color colour = ColorTranslator.FromHtml("#212121");
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
                        // Apply dark mode styles
                        this.ThemeName = fluentDarkTheme1.ThemeName;

                        Panel1.BackColor = colour;
                        Panel3.BackColor = colour;
                        Panel4.BackColor = colour;
                        Panel2.BackColor = colour;

                        bChargeInfo.ForeColor = Color.White;
                        bChargeInfo.BackColor = colour;
                        //panels backcolor
                        Panel1.BackColor = Color.Black;
                        Panel2.BackColor = Color.Black;
                        Panel3.BackColor = Color.Black;
                        Panel4.BackColor = Color.Black;
                        //all btn backcolor
                        shutdownBtn.BackColor = colour;
                        restartBtn.BackColor = colour;
                        singoutBtn.BackColor = colour;
                        logcancellBtn.BackColor = colour;
                        openDVDBtn.BackColor = colour;
                        disconnect_dial_Btn.BackColor = colour;
                        emptyRecycleBtn.BackColor = colour;
                        insProgBtn.BackColor = colour;
                        appStnBtn.BackColor = colour;
                        cleanTmpBtn.BackColor = colour;
                        WEB_TXT_INPUT.BackColor = colour;
                        HomePage_Btn.BackColor = colour;
                        OpenWeb_Btn.BackColor = colour;
                        refreshBtn.BackColor = colour;
                        sysInfoBtn.BackColor = colour;
                        checkHealthBtn.BackColor = colour;
                        aboutBtn.BackColor = colour;
                        hibernate_btn.BackColor = colour;
                        sleep_btn.BackColor = colour;
                        //all btn forecolor
                        shutdownBtn.ForeColor = L_mode_colour;
                        restartBtn.ForeColor = L_mode_colour;
                        singoutBtn.ForeColor = L_mode_colour;
                        logcancellBtn.ForeColor = L_mode_colour;
                        openDVDBtn.ForeColor = L_mode_colour;
                        disconnect_dial_Btn.ForeColor = L_mode_colour;
                        emptyRecycleBtn.ForeColor = L_mode_colour;
                        insProgBtn.ForeColor = L_mode_colour;
                        appStnBtn.ForeColor = L_mode_colour;
                        cleanTmpBtn.ForeColor = L_mode_colour;
                        WEB_TXT_INPUT.ForeColor = L_mode_colour;
                        HomePage_Btn.ForeColor = L_mode_colour;
                        OpenWeb_Btn.ForeColor = L_mode_colour;
                        refreshBtn.ForeColor = L_mode_colour;
                        sysInfoBtn.ForeColor = L_mode_colour;
                        checkHealthBtn.ForeColor = L_mode_colour;
                        aboutBtn.ForeColor = L_mode_colour;
                        hibernate_btn.ForeColor = L_mode_colour;
                        sleep_btn.ForeColor = L_mode_colour;
                        //Dark Mode for all elements
                        Panel1.ThemeName = fluentDarkTheme1.ThemeName;
                        Panel3.ThemeName = fluentDarkTheme1.ThemeName;
                        Panel4.ThemeName = fluentDarkTheme1.ThemeName;
                        Panel2.ThemeName = fluentDarkTheme1.ThemeName;

                        restartBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        singoutBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        logcancellBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        openDVDBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        disconnect_dial_Btn.ThemeName = fluentDarkTheme1.ThemeName;
                        emptyRecycleBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        insProgBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        appStnBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        WEB_TXT_INPUT.ThemeName = fluentDarkTheme1.ThemeName;
                        HomePage_Btn.ThemeName = fluentDarkTheme1.ThemeName;
                        OpenWeb_Btn.ThemeName = fluentDarkTheme1.ThemeName;
                        refreshBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        sysInfoBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        checkHealthBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        aboutBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        hibernate_btn.ThemeName = fluentDarkTheme1.ThemeName;
                        sleep_btn.ThemeName = fluentDarkTheme1.ThemeName;
                        shutdownBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        printersList.ThemeName = fluentDarkTheme1.ThemeName;
                        cleanTmpBtn.ThemeName = fluentDarkTheme1.ThemeName;
                    }
                    else
                    {
                        // Apply light mode styles
                        this.ThemeName = fluentTheme1.ThemeName;

                        bChargeInfo.ForeColor = colour;
                        bChargeInfo.BackColor = L_mode_colour1;
                        //panels backcolor
                        Panel1.BackColor = L_mode_colour1;
                        Panel2.BackColor = L_mode_colour1;
                        Panel3.BackColor = L_mode_colour1;
                        Panel4.BackColor = L_mode_colour1;
                        //all btn backcolor
                        shutdownBtn.BackColor = L_mode_colour;
                        restartBtn.BackColor = L_mode_colour;
                        singoutBtn.BackColor = L_mode_colour;
                        logcancellBtn.BackColor = L_mode_colour;
                        openDVDBtn.BackColor = L_mode_colour;
                        disconnect_dial_Btn.BackColor = L_mode_colour;
                        emptyRecycleBtn.BackColor = L_mode_colour;
                        insProgBtn.BackColor = L_mode_colour;
                        appStnBtn.BackColor = L_mode_colour;
                        cleanTmpBtn.BackColor = L_mode_colour;
                        WEB_TXT_INPUT.BackColor = L_mode_colour;
                        HomePage_Btn.BackColor = L_mode_colour;
                        OpenWeb_Btn.BackColor = L_mode_colour;
                        refreshBtn.BackColor = L_mode_colour;
                        sysInfoBtn.BackColor = L_mode_colour;
                        checkHealthBtn.BackColor = L_mode_colour;
                        aboutBtn.BackColor = L_mode_colour;
                        hibernate_btn.BackColor = L_mode_colour;
                        sleep_btn.BackColor = L_mode_colour;
                        //all btn forecolor
                        shutdownBtn.ForeColor = colour;
                        restartBtn.ForeColor = colour;
                        singoutBtn.ForeColor = colour;
                        logcancellBtn.ForeColor = colour;
                        openDVDBtn.ForeColor = colour;
                        disconnect_dial_Btn.ForeColor = colour;
                        emptyRecycleBtn.ForeColor = colour;
                        insProgBtn.ForeColor = colour;
                        appStnBtn.ForeColor = colour;
                        cleanTmpBtn.ForeColor = colour;
                        WEB_TXT_INPUT.ForeColor = colour;
                        HomePage_Btn.ForeColor = colour;
                        OpenWeb_Btn.ForeColor = colour;
                        refreshBtn.ForeColor = colour;
                        sysInfoBtn.ForeColor = colour;
                        checkHealthBtn.ForeColor = colour;
                        aboutBtn.ForeColor = colour;
                        hibernate_btn.ForeColor = colour;
                        sleep_btn.ForeColor = colour;
                        //Light Mode for all elements
                        Panel1.ThemeName = fluentTheme1.ThemeName;
                        Panel3.ThemeName = fluentTheme1.ThemeName;
                        Panel4.ThemeName = fluentTheme1.ThemeName;
                        Panel2.ThemeName = fluentTheme1.ThemeName;

                        restartBtn.ThemeName = fluentTheme1.ThemeName;
                        singoutBtn.ThemeName = fluentTheme1.ThemeName;
                        logcancellBtn.ThemeName = fluentTheme1.ThemeName;
                        openDVDBtn.ThemeName = fluentTheme1.ThemeName;
                        disconnect_dial_Btn.ThemeName = fluentTheme1.ThemeName;
                        emptyRecycleBtn.ThemeName = fluentTheme1.ThemeName;
                        insProgBtn.ThemeName = fluentTheme1.ThemeName;
                        appStnBtn.ThemeName = fluentTheme1.ThemeName;
                        WEB_TXT_INPUT.ThemeName = fluentTheme1.ThemeName;
                        HomePage_Btn.ThemeName = fluentTheme1.ThemeName;
                        OpenWeb_Btn.ThemeName = fluentTheme1.ThemeName;
                        refreshBtn.ThemeName = fluentTheme1.ThemeName;
                        sysInfoBtn.ThemeName = fluentTheme1.ThemeName;
                        checkHealthBtn.ThemeName = fluentTheme1.ThemeName;
                        aboutBtn.ThemeName = fluentTheme1.ThemeName;
                        hibernate_btn.ThemeName = fluentTheme1.ThemeName;
                        sleep_btn.ThemeName = fluentTheme1.ThemeName;
                        shutdownBtn.ThemeName = fluentTheme1.ThemeName;
                        cleanTmpBtn.ThemeName = fluentTheme1.ThemeName;
                        printersList.ThemeName = fluentTheme1.ThemeName;
                    }
                }
                //WM
                GetInstalledPrinters();
                PowerStatus powerStatus = SystemInformation.PowerStatus;
                int batteryLevel = (int)(powerStatus.BatteryLifePercent * 100);
                bChargeInfo.Text = $"Battery Level: {batteryLevel}%";

                bool dvdDriveExists = CheckForDVDDrive();
                openDVDBtn.Enabled = dvdDriveExists;
            }

        }

        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath,
      RecycleFlags dwFlags);

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ShutDown", "/s /t 10");
        }

        private void singoutBtn_Click(object sender, EventArgs e)
        {
            RadMessageBox.ThemeName = this.ThemeName;
            DialogResult result = Telerik.WinControls.RadMessageBox.Show("Do you want to put the system in LogOut mode?", "LogOut", MessageBoxButtons.YesNo, RadMessageIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("ShutDown", "/l /t 10");
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ShutDown", "/r /t 10");
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
            if (WEB_TXT_INPUT.Text == "")
            {
                MetroMessageBox.Show(this, "Error For empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RegistryKey user = Registry.CurrentUser;
                RegistryKey change = user.OpenSubKey("Software", true).OpenSubKey("Microsoft", true).OpenSubKey("Internet Explorer", true).OpenSubKey("Main", true);
                change.SetValue("Start Page", WEB_TXT_INPUT.Text.ToString());


                MetroFramework.MetroMessageBox.Show(this, "'" + WEB_TXT_INPUT.Text + "'" + "\nyour home page now.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            System.Diagnostics.Process.Start("msedge.exe", "https://www.google.com/search?q=" + WEB_TXT_INPUT.Text);
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
            Color colour = ColorTranslator.FromHtml("#212121");
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
                        // Apply dark mode styles
                        this.ThemeName = fluentDarkTheme1.ThemeName;

                        Panel1.BackColor = colour;
                        Panel3.BackColor = colour;
                        Panel4.BackColor = colour;
                        Panel2.BackColor = colour;

                        bChargeInfo.ForeColor = Color.White;
                        bChargeInfo.BackColor = colour;
                        //panels backcolor
                        Panel1.BackColor = Color.Black;
                        Panel2.BackColor = Color.Black;
                        Panel3.BackColor = Color.Black;
                        Panel4.BackColor = Color.Black;
                        //all btn backcolor
                        shutdownBtn.BackColor = colour;
                        restartBtn.BackColor = colour;
                        singoutBtn.BackColor = colour;
                        logcancellBtn.BackColor = colour;
                        openDVDBtn.BackColor = colour;
                        disconnect_dial_Btn.BackColor = colour;
                        emptyRecycleBtn.BackColor = colour;
                        insProgBtn.BackColor = colour;
                        appStnBtn.BackColor = colour;
                        cleanTmpBtn.BackColor = colour;
                        WEB_TXT_INPUT.BackColor = colour;
                        HomePage_Btn.BackColor = colour;
                        OpenWeb_Btn.BackColor = colour;
                        refreshBtn.BackColor = colour;
                        sysInfoBtn.BackColor = colour;
                        checkHealthBtn.BackColor = colour;
                        aboutBtn.BackColor = colour;
                        hibernate_btn.BackColor = colour;
                        sleep_btn.BackColor = colour;
                        //all btn forecolor
                        shutdownBtn.ForeColor = L_mode_colour;
                        restartBtn.ForeColor = L_mode_colour;
                        singoutBtn.ForeColor = L_mode_colour;
                        logcancellBtn.ForeColor = L_mode_colour;
                        openDVDBtn.ForeColor = L_mode_colour;
                        disconnect_dial_Btn.ForeColor = L_mode_colour;
                        emptyRecycleBtn.ForeColor = L_mode_colour;
                        insProgBtn.ForeColor = L_mode_colour;
                        appStnBtn.ForeColor = L_mode_colour;
                        cleanTmpBtn.ForeColor = L_mode_colour;
                        WEB_TXT_INPUT.ForeColor = L_mode_colour;
                        HomePage_Btn.ForeColor = L_mode_colour;
                        OpenWeb_Btn.ForeColor = L_mode_colour;
                        refreshBtn.ForeColor = L_mode_colour;
                        sysInfoBtn.ForeColor = L_mode_colour;
                        checkHealthBtn.ForeColor = L_mode_colour;
                        aboutBtn.ForeColor = L_mode_colour;
                        hibernate_btn.ForeColor = L_mode_colour;
                        sleep_btn.ForeColor = L_mode_colour;
                        //Dark Mode for all elements
                        Panel1.ThemeName = fluentDarkTheme1.ThemeName;
                        Panel3.ThemeName = fluentDarkTheme1.ThemeName;
                        Panel4.ThemeName = fluentDarkTheme1.ThemeName;
                        Panel2.ThemeName = fluentDarkTheme1.ThemeName;

                        restartBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        singoutBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        logcancellBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        openDVDBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        disconnect_dial_Btn.ThemeName = fluentDarkTheme1.ThemeName;
                        emptyRecycleBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        insProgBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        appStnBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        WEB_TXT_INPUT.ThemeName = fluentDarkTheme1.ThemeName;
                        HomePage_Btn.ThemeName = fluentDarkTheme1.ThemeName;
                        OpenWeb_Btn.ThemeName = fluentDarkTheme1.ThemeName;
                        refreshBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        sysInfoBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        checkHealthBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        aboutBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        hibernate_btn.ThemeName = fluentDarkTheme1.ThemeName;
                        sleep_btn.ThemeName = fluentDarkTheme1.ThemeName;
                        shutdownBtn.ThemeName = fluentDarkTheme1.ThemeName;
                        printersList.ThemeName = fluentDarkTheme1.ThemeName;
                        cleanTmpBtn.ThemeName = fluentDarkTheme1.ThemeName;
                    }
                    else
                    {
                        // Apply light mode styles
                        this.ThemeName = fluentTheme1.ThemeName;

                        bChargeInfo.ForeColor = colour;
                        bChargeInfo.BackColor = L_mode_colour1;
                        //panels backcolor
                        Panel1.BackColor = L_mode_colour1;
                        Panel2.BackColor = L_mode_colour1;
                        Panel3.BackColor = L_mode_colour1;
                        Panel4.BackColor = L_mode_colour1;
                        //all btn backcolor
                        shutdownBtn.BackColor = L_mode_colour;
                        restartBtn.BackColor = L_mode_colour;
                        singoutBtn.BackColor = L_mode_colour;
                        logcancellBtn.BackColor = L_mode_colour;
                        openDVDBtn.BackColor = L_mode_colour;
                        disconnect_dial_Btn.BackColor = L_mode_colour;
                        emptyRecycleBtn.BackColor = L_mode_colour;
                        insProgBtn.BackColor = L_mode_colour;
                        appStnBtn.BackColor = L_mode_colour;
                        cleanTmpBtn.BackColor = L_mode_colour;
                        WEB_TXT_INPUT.BackColor = L_mode_colour;
                        HomePage_Btn.BackColor = L_mode_colour;
                        OpenWeb_Btn.BackColor = L_mode_colour;
                        refreshBtn.BackColor = L_mode_colour;
                        sysInfoBtn.BackColor = L_mode_colour;
                        checkHealthBtn.BackColor = L_mode_colour;
                        aboutBtn.BackColor = L_mode_colour;
                        hibernate_btn.BackColor = L_mode_colour;
                        sleep_btn.BackColor = L_mode_colour;
                        //all btn forecolor
                        shutdownBtn.ForeColor = colour;
                        restartBtn.ForeColor = colour;
                        singoutBtn.ForeColor = colour;
                        logcancellBtn.ForeColor = colour;
                        openDVDBtn.ForeColor = colour;
                        disconnect_dial_Btn.ForeColor = colour;
                        emptyRecycleBtn.ForeColor = colour;
                        insProgBtn.ForeColor = colour;
                        appStnBtn.ForeColor = colour;
                        cleanTmpBtn.ForeColor = colour;
                        WEB_TXT_INPUT.ForeColor = colour;
                        HomePage_Btn.ForeColor = colour;
                        OpenWeb_Btn.ForeColor = colour;
                        refreshBtn.ForeColor = colour;
                        sysInfoBtn.ForeColor = colour;
                        checkHealthBtn.ForeColor = colour;
                        aboutBtn.ForeColor = colour;
                        hibernate_btn.ForeColor = colour;
                        sleep_btn.ForeColor = colour;
                        //Light Mode for all elements
                        Panel1.ThemeName = fluentTheme1.ThemeName;
                        Panel3.ThemeName = fluentTheme1.ThemeName;
                        Panel4.ThemeName = fluentTheme1.ThemeName;
                        Panel2.ThemeName = fluentTheme1.ThemeName;

                        restartBtn.ThemeName = fluentTheme1.ThemeName;
                        singoutBtn.ThemeName = fluentTheme1.ThemeName;
                        logcancellBtn.ThemeName = fluentTheme1.ThemeName;
                        openDVDBtn.ThemeName = fluentTheme1.ThemeName;
                        disconnect_dial_Btn.ThemeName = fluentTheme1.ThemeName;
                        emptyRecycleBtn.ThemeName = fluentTheme1.ThemeName;
                        insProgBtn.ThemeName = fluentTheme1.ThemeName;
                        appStnBtn.ThemeName = fluentTheme1.ThemeName;
                        WEB_TXT_INPUT.ThemeName = fluentTheme1.ThemeName;
                        HomePage_Btn.ThemeName = fluentTheme1.ThemeName;
                        OpenWeb_Btn.ThemeName = fluentTheme1.ThemeName;
                        refreshBtn.ThemeName = fluentTheme1.ThemeName;
                        sysInfoBtn.ThemeName = fluentTheme1.ThemeName;
                        checkHealthBtn.ThemeName = fluentTheme1.ThemeName;
                        aboutBtn.ThemeName = fluentTheme1.ThemeName;
                        hibernate_btn.ThemeName = fluentTheme1.ThemeName;
                        sleep_btn.ThemeName = fluentTheme1.ThemeName;
                        shutdownBtn.ThemeName = fluentTheme1.ThemeName;
                        cleanTmpBtn.ThemeName = fluentTheme1.ThemeName;
                        printersList.ThemeName = fluentTheme1.ThemeName;
                    }
                }
            }
                this.Refresh();
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
            if (e.KeyChar == (char)13)
            {
                System.Diagnostics.Process.Start("iexplore.exe", "https://" + WEB_TXT_INPUT.Text);
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
            System.Diagnostics.Process.Start("cleanmgr");
        }

        private void hibernate_btn_Click(object sender, EventArgs e)
        {
            RadMessageBox.ThemeName = this.ThemeName;
            DialogResult result = Telerik.WinControls.RadMessageBox.Show("Do you want to put the system in Hibernate mode?", "Hibernate", MessageBoxButtons.YesNo, RadMessageIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.SetSuspendState(PowerState.Hibernate, true, false);
            }
        }

        private void sleep_btn_Click(object sender, EventArgs e)
        {
            RadMessageBox.ThemeName = this.ThemeName;
            DialogResult result = Telerik.WinControls.RadMessageBox.Show("Do you want to put the system in Sleep mode?", "Sleep", MessageBoxButtons.YesNo, RadMessageIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.SetSuspendState(PowerState.Suspend, true, false);
            }
        }
    }
}



