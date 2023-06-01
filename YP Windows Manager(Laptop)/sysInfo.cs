using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
                MaximizeBox = false ;
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
            label1.Text = "System time: "+DateTime.Now.ToString();
        }
    }
}
