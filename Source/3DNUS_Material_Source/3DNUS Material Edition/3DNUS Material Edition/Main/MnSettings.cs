using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace _3DNUS_Material_Edition
{
    public partial class dev_settings : MaterialForm
    {
        private String cd = Path.GetDirectoryName(Application.ExecutablePath);

        private bool is64 = System.Environment.Is64BitOperatingSystem;

        public dev_settings()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void dev_settings_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();

            if (Properties.Settings.Default.dev_auto_upd == "1")
            {
                chck_auto_upd.Checked = true;
            }
            else
            {
                chck_auto_upd.Checked = false;
            }
            if (Properties.Settings.Default.dev_dump_info == "1")
            {
                chck_dump_info.Checked = true;
            }
            else
            {
                chck_dump_info.Checked = false;
            }
            if (Properties.Settings.Default.dev_def_titlelist == "old")
            {
                old_3ds.Checked = true;
            }
            else

            if (Properties.Settings.Default.dev_def_titlelist == "new")
            {
                new_3ds.Checked = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
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

            Properties.Settings.Default.Save();
            Close();
        }

        private void dev_bck_music_Enter(object sender, EventArgs e)
        {
        }

        private void dev_settings_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btn_reset_settings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}