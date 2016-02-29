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
    public partial class vnm_debugger : Form
    {
        public vnm_debugger()
        {
            InitializeComponent();
        }

        private void bareCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            debug_bin.Text += "\r\n" + " ";
            debug_bin.Text += "\r\n" + "[00001]: Unable to Return Kernal Verbose! ";
            debug_bin.Text += "\r\n" + "[00001]: Make sure you have a Firmware Installed! ";
        }
    }
}
