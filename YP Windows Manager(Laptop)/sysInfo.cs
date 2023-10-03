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
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection collection = searcher.Get();
            string architecture = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
            sysInfoList.Items.Add("PC Information:");
            sysInfoList.Items.Add("");
            foreach (ManagementObject obj in collection)
            {
                string manufacturer = obj["Manufacturer"].ToString();
                string product = obj["Product"].ToString();
                string serialNumber = obj["SerialNumber"].ToString();
                string motherboardInfo = $"Manufacturer: {manufacturer}  Product: {product} Serial Number: {serialNumber}";
                sysInfoList.Items.Add(motherboardInfo);

            }
            //New features
            string cpuinfo = GetCPUInfo();
            string gpuInfo = GetGPUInfo();
            string ramInfo = GetSystemRAMInfo();
            sysInfoList.Items.Add("CPU Model: " + cpuinfo);
            sysInfoList.Items.Add("Processor Counter: " + Environment.ProcessorCount.ToString());
            sysInfoList.Items.Add("RAM: " + ramInfo);
            gpuAbout.Text = gpuInfo;

            sysInfoList.Items.Add("");
            sysInfoList.Items.Add("OS Information:");
            sysInfoList.Items.Add("");
            sysInfoList.Items.Add("PC Name: " + Environment.MachineName.ToString());
            sysInfoList.Items.Add("User Name: " + Environment.UserName.ToString());
            sysInfoList.Items.Add("User Doamin Name: " + Environment.UserDomainName.ToString());
            sysInfoList.Items.Add("OS Version: " + Environment.OSVersion.ToString());
            sysInfoList.Items.Add($"System Architecture: {architecture}");

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
        private string GetGPUInfo()
        {
            try
            {
                ObjectQuery gpuQuery = new ObjectQuery("SELECT * FROM Win32_VideoController");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(gpuQuery);
                ManagementObjectCollection collection = searcher.Get();

                string gpuInfo = "";

                foreach (ManagementObject obj in collection)
                {
                    gpuInfo += "Name: " + obj["Name"].ToString() + "\n";
                    gpuInfo += "Description: " + obj["Description"].ToString() + "\n";
                    gpuInfo += "Driver Version: " + obj["DriverVersion"].ToString() + "\n";
                    gpuInfo += "Video RAM: " + (Convert.ToInt64(obj["AdapterRAM"]) / (1024 * 1024)) + " MB\n\n";
                }

                return gpuInfo;
            }
            catch (Exception ex)
            {
                return "Unknown";
            }
        }

    }
}

