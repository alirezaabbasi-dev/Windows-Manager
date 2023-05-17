using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik;
using Telerik.WinControls;
using Telerik.WinControls.Themes;

namespace YP_Windows_Manager_Computer_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FluentTheme flnt = new FluentTheme();

            bool runed;

            System.Threading.Mutex mtx = new System.Threading.Mutex(true, "yp-wm-CPTP-ver:---_2.0.2", out runed);

            if (!runed)
            {
                RadMessageBox.ThemeName = flnt.ThemeName;

                Telerik.WinControls.RadMessageBox.Show("The " + "YP Windows Manager(Laptop)" + " is running", "YP", MessageBoxButtons.OK);
            }
            else
            {
                Application.Run(new waitfrm());
            }

        }
    }
}
