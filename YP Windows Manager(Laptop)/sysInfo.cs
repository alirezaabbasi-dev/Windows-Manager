using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;



namespace YP_Windows_Manager_Computer_
{
    public partial class sysInfo : Telerik.WinControls.UI.RadForm
    {
        public sysInfo()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //New features
            string ramInfo = GetSystemRAMInfo();
            string cpuinfo = GetCPUInfo();
            sysInfoList.Items.Add ("RAM: " + ramInfo);
            sysInfoList.Items.Add("CPU Model: " + cpuinfo);

            sysInfoList.Items.Add("PC Information:");
            sysInfoList.Items.Add("");
            sysInfoList.Items.Add("PC Name: " + Environment.MachineName.ToString());
            sysInfoList.Items.Add("User Name: " + Environment.UserName.ToString());
            sysInfoList.Items.Add("User Doamin Name: " + Environment.UserDomainName.ToString());
            sysInfoList.Items.Add("Processor Counter: " + Environment.ProcessorCount.ToString());
            sysInfoList.Items.Add("OS Version: " + Environment.OSVersion.ToString());
            sysInfoList.Items.Add("System Directory: " + Environment.SystemDirectory.ToString());
            sysInfoList.Items.Add("Working Set: " + Environment.WorkingSet.ToString());
            sysInfoList.Items.Add("Application directory: " + Environment.CurrentDirectory.ToString());
            //frm settings
            MinimizeBox = true;
            MaximizeBox = false;
            ControlBox = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            WM frm = new WM();
            frm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "System time: " + DateTime.Now.ToString();
        }
        private string GetSystemRAMInfo()
        {
            try
            {
                ObjectQuery ramQuery = new ObjectQuery("SELECT * FROM Win32_ComputerSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(ramQuery);
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject obj in collection)
                {
                    ulong totalRamBytes = Convert.ToUInt64(obj["TotalPhysicalMemory"]);
                    double totalRamGB = totalRamBytes / (1024.0 * 1024.0 * 1024.0);
                    return $"{totalRamGB:F2} GB"; // Display the exact value with 2 decimal places.
                }
            }
            catch (Exception ex)
            {
                return "Unknown";
            }

            return "Unknown";
        }

        private string GetCPUInfo()
        {
            try
            {
                ObjectQuery cpuQuery = new ObjectQuery("SELECT * FROM Win32_Processor");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(cpuQuery);
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject obj in collection)
                {
                    string cpuModel = obj["Name"].ToString();
                    return cpuModel;
                }
            }
            catch (Exception ex)
            {
                return "Unknown";
            }

            return "Unknown";
        }

    }
}
