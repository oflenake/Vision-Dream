using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionDream.AsyncClientServer
{
    public partial class FrmMACS_Launcher : Form
    {
        private static readonly string PoweredBy = "Vision-Dream";
        // private static readonly string AppPath = Application.StartupPath + "\\VisionDream.AsyncClientServer.exe";
        private static readonly string ImagePath = Path.Combine(Path.Combine("..", ".."), "MACSImages");

        public FrmMACS_Launcher()
        {
            InitializeComponent();
        }

        private void MACS_Launcher_Load(object sender, EventArgs e)
        {
            try
            {
                lblPoweredBy.Text = "Powered by: " + PoweredBy;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMACSServer_Click(object sender, EventArgs e)
        {
            // 192.168.56.1
            FrmMACS_Server macs_server = new FrmMACS_Server();
            //macs_server
            macs_server.Show(); // or macs_server.ShowDialog(this);
        }

        private void buttonMACSClient_Click(object sender, EventArgs e)
        {
            // 192.168.56.1
            FrmMACS_Client macs_client = new FrmMACS_Client();
            macs_client.Show(); // or macs_client.ShowDialog(this);
        }
    }
}
