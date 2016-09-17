using MaterialSkin.Controls;
using MaterialSkin; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3DNUS_Material_Edition
{
    public partial class dev_tour : MaterialForm
    {
        public dev_tour()
        {
            InitializeComponent();
        }

        private void dev_tour_Load(object sender, EventArgs e)
        {

        }

        private void b_next_Click(object sender, EventArgs e)
        {
            dev_tour_setup f = new dev_tour_setup();
            f.Show();
            Close(); 
        }
    }
}
