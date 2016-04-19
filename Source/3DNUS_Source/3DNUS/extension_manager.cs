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
    public partial class ext_mng_load : Form
    {
        public ext_mng_load()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ext_mng_load_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ext_pick form = new ext_pick();
            form.Show();
            timer2.Stop();
            Close();
        }
    }
}
