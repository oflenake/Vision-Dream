using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace VisionDream.AsyncClientServer
{
    static class MACSApplication
    {
        /// <summary>
        /// The main entry point for Manje Access Control Solution (MACS) App v0.1.0.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMACS_Launcher());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
