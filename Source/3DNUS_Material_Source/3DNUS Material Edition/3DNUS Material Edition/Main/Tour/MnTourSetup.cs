using MaterialSkin.Controls;
using System;
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
            if (chck_auto_dump.Checked == true)
            {
                Properties.Settings.Default.dev_auto_dump_log = "1";
            }
            else
            {
                Properties.Settings.Default.dev_auto_dump_log = "0";
            }
            if (chck_darktheme.Checked == true)
            {
                Properties.Settings.Default.dev_dark_theme = "1";
            }
            else
            {
                Properties.Settings.Default.dev_dark_theme = "0";
            }
            if (chck_auto_upd.Checked == true)
            {
                Properties.Settings.Default.dev_auto_upd = "1";
            }
            else
            {
                Properties.Settings.Default.dev_auto_upd = "0";
            }
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

            Properties.Settings.Default.dev_tour = "1";
            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}