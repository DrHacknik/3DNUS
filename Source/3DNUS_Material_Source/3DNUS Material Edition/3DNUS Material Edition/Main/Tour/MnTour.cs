using MaterialSkin.Controls;
using System;

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