using MaterialSkin.Controls;
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
    public partial class dev_tour_setup : MaterialForm
    {
        public dev_tour_setup()
        {
            InitializeComponent();
        }

        private void dev_tour_setup_Load(object sender, EventArgs e)
        {

        }

        private void b_fin_Click(object sender, EventArgs e)
        {
            if (chck_auto_upd.Checked == true)
            {
                Properties.Settings.Default.dev_auto_upd = "1";
            }
            else
            {
                Properties.Settings.Default.dev_auto_upd = "0";
            }
            if (chck_music.Checked == true)
            {
                Properties.Settings.Default.dev_music = "1";
            }
            else
            {
                Properties.Settings.Default.dev_music = "0";
            }
            if (chck_dump_info.Checked == true)
            {
                Properties.Settings.Default.dev_dump_info = "1";
            }
            else
            {
                Properties.Settings.Default.dev_dump_info = "0";
            }
            if (old_3ds.Checked == true)
            {
                Properties.Settings.Default.dev_def_titlelist = "old";
            }

            if (new_3ds.Checked == true)
            {
                Properties.Settings.Default.dev_def_titlelist = "new";
            }

            txtbx_flags.Text = Properties.Settings.Default.dev_flags;
            Properties.Settings.Default.Save();
            Close();
            FormMain f = new FormMain();
            f.Show();
        }
    }
}
