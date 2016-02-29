using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DNUS
{
    public partial class ext_mng_main : Form
    {
        public ext_mng_main()
        {
            InitializeComponent();
        }

        private void helToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Extension: VNM_GUI.ext Can not be Removed!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Extension: Ext_mng_base_fw.ext Can not be Removed!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void openExtensionPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ext_open.ShowDialog();
        }
    }
}
