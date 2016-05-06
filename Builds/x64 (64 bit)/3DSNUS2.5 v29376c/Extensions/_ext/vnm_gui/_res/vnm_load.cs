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
    public partial class VNM_Load : Form
    {
        public VNM_Load()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Value = 100;
            label1.Text = "Starting VNM.... Error, Firmware NOT Installed!";
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VNM_GUI form = new VNM_GUI();
            form.Show();
            Close();
        }
    }
}
