using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace _3DNUS.Core
{
    public partial class dev_settings : MaterialForm
    {
        private String cd = Path.GetDirectoryName(Application.ExecutablePath);

        private bool is64 = System.Environment.Is64BitOperatingSystem;

        private string chck_drk = null;

        public dev_settings()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void dev_settings_Load(object sender, EventArgs e)
        {
            _3DNUS_Material_Edition.Properties.Settings.Default.Reload();

            if (_3DNUS_Material_Edition.Properties.Settings.Default.dev_auto_dump_log == "1")
            {
                chck_auto_dump.Checked = true;
            }
            else
            {
                chck_auto_dump.Checked = false;
            }
            if (_3DNUS_Material_Edition.Properties.Settings.Default.dev_dark_theme == "1")
            {
                chck_darktheme.Checked = true;
            }
            else
            {
                chck_darktheme.Checked = false;
            }
            if (_3DNUS_Material_Edition.Properties.Settings.Default.dev_auto_upd == "1")
            {
                chck_auto_upd.Checked = true;
            }
            else
            {
                chck_auto_upd.Checked = false;
            }
            if (_3DNUS_Material_Edition.Properties.Settings.Default.dev_dump_info == "1")
            {
                chck_dump_info.Checked = true;
            }
            else
            {
                chck_dump_info.Checked = false;
            }
            if (_3DNUS_Material_Edition.Properties.Settings.Default.dev_def_titlelist == "old")
            {
                old_3ds.Checked = true;
            }
            else

            if (_3DNUS_Material_Edition.Properties.Settings.Default.dev_def_titlelist == "new")
            {
                new_3ds.Checked = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (chck_auto_dump.Checked == true)
            {
                _3DNUS_Material_Edition.Properties.Settings.Default.dev_auto_dump_log = "1";
            }
            else
            {
                _3DNUS_Material_Edition.Properties.Settings.Default.dev_auto_dump_log = "0";
            }
            if (chck_darktheme.Checked == true)
            {
                _3DNUS_Material_Edition.Properties.Settings.Default.dev_dark_theme = "1";
            }
            else
            {
                _3DNUS_Material_Edition.Properties.Settings.Default.dev_dark_theme = "0";
            }
            if (chck_auto_upd.Checked == true)
            {
                _3DNUS_Material_Edition.Properties.Settings.Default.dev_auto_upd = "1";
            }
            else
            {
                _3DNUS_Material_Edition.Properties.Settings.Default.dev_auto_upd = "0";
            }
            {
                _3DNUS_Material_Edition.Properties.Settings.Default.dev_music = "0";
            }
            if (chck_dump_info.Checked == true)
            {
                _3DNUS_Material_Edition.Properties.Settings.Default.dev_dump_info = "1";
            }
            else
            {
                _3DNUS_Material_Edition.Properties.Settings.Default.dev_dump_info = "0";
            }
            if (old_3ds.Checked == true)
            {
                _3DNUS_Material_Edition.Properties.Settings.Default.dev_def_titlelist = "old";
            }

            if (new_3ds.Checked == true)
            {
                _3DNUS_Material_Edition.Properties.Settings.Default.dev_def_titlelist = "new";
            }

            //if (chck_darktheme.Checked == true)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Enabling the dark theme will require the application. By clicking Ok, the Application will restart automatically.", "3DNUS Settings: Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

            //    if (dialogResult == DialogResult.OK)
            //    {
            //        _3DNUS_Material_Edition.Properties.Settings.Default.Save();
            //        Application.Restart();
            //    }

            //    if (dialogResult == DialogResult.Cancel)
            //    {
            //        _3DNUS_Material_Edition.Properties.Settings.Default.Save();
            //        Close();
            //    }
            //}
            //else
            //{
            //    _3DNUS_Material_Edition.Properties.Settings.Default.Save();
            //    Close();
            //}
            _3DNUS_Material_Edition.Properties.Settings.Default.Save();
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
            _3DNUS_Material_Edition.Properties.Settings.Default.Reset();
            _3DNUS_Material_Edition.Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void chck_darktheme_CheckedChanged(object sender, EventArgs e)
        {
            //chck_drk = "1";
            //return;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}