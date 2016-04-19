using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DNUS
{
    public partial class ext_pick : Form
    {
        public ext_pick()
        {
            InitializeComponent();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot2\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {


            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot1\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\dev_zip_compile\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
