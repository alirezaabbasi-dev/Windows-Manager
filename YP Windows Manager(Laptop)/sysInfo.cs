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


            listBox1.Items.Add("PC Information:");
            listBox1.Items.Add("");
            listBox1.Items.Add("PC Name: " + Environment.MachineName.ToString());
            listBox1.Items.Add("User Name: " + Environment.UserName.ToString());
            listBox1.Items.Add("User Doamin Name: " + Environment.UserDomainName.ToString());
            listBox1.Items.Add("Processor Counter: " + Environment.ProcessorCount.ToString());
            listBox1.Items.Add("OS Version: " + Environment.OSVersion.ToString());
            listBox1.Items.Add("System Directory: " + Environment.SystemDirectory.ToString());
            listBox1.Items.Add("Working Set: " + Environment.WorkingSet.ToString());
            listBox1.Items.Add("Application directory: " + Environment.CurrentDirectory.ToString());
           // listBox1.Items.Add(Environment.SystemPageSize);
          //  listBox1.Items.Add("System time:" + DateTime.Now);
           // Resizable = false;
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
