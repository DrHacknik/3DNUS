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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("3DNUS Upd - Lite.exe");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/zoltx23Inc");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://plus.google.com/u/1/100349679489621053794/posts");
        }
    }
}
