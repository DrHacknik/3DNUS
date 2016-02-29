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
using System.Net;
using System.Diagnostics;



namespace _3DNUS

{
    public partial class VNM_GUI : Form
    {

        public VNM_GUI()

        {
            InitializeComponent();
        }
        private void log(string msg)
        {
            t_log.AppendText("\r\n" + msg);
        }
        private void VNM_GUI_Load(object sender, EventArgs e)
        {
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tiny512ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void installciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vnm_open_3ds_package.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = System.DateTime.Now.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aboutVNMGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VNM_About form = new VNM_About();
            form.Show();
        }

        private void debuggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vnm_debugger form = new vnm_debugger();
            form.Show();
        }

        private void vnm_open_3ds_package_FileOk(object sender, CancelEventArgs e)
        {
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
            string ver = vnm_open_3ds_package.FileName;
            log("[1]Installing...." + ver + "....");
            timer2.Start();
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string ver = vnm_open_3ds_package.FileName;
            log("\r\n" + "[2]Unpacking Title: " + ver + " ----> " + "VNM_NAND....");
            timer2.Stop();

        }
    }
}
