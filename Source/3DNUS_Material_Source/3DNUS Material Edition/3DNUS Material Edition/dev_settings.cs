using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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
            Properties.Settings.Default.dev_flags = txtbx_flags.Text;
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
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                btn_update.Text = "....";
                File.Delete(Path.Combine(cd, "Update_info.txt"));
                File.Delete(Path.Combine(cd, "Update_URI.txt"));
                File.Delete(Path.Combine(cd, "3DNUS_old.exe"));
                File.Delete(Path.Combine(cd, "3DNUS_new.exe"));
                File.Delete(Path.Combine(cd, "upd_fin.exe"));
                WebClient get_info = new WebClient();
                get_info.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/3DNUS/master/Update_Info.txt"), cd + "\\Update_info.txt");
                WebClient upd_dwld = new WebClient();
                using (Stream upd = File.Open(cd + "\\Update_info.txt", FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(upd))
                    {
                        string rd_upd = null;

                        rd_upd = reader.ReadToEnd();

                        if (rd_upd == Application.ProductVersion)
                        {
                            MessageBox.Show("No new Updates!");
                        }
                        else
                        {
                            btn_update.Text = "Updating";
                            if (is64 == true)
                            {
                                upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/3DNUS/master/Updates/x64/3DNUS.exe"), cd + "\\3DNUS_new.exe");
                                WebClient get_fin = new WebClient();
                                get_fin.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/3DNUS/master/Updates/upd_fin.exe"), cd + "\\upd_fin.exe");
                                Process.Start(cd + "\\upd_fin.exe");
                                btn_update.Text = "Preparing...";
                                Application.Exit();
                            }
                            if (is64 == false)
                            {
                                upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/3DNUS/master/Updates/x32/3DNUS.exe"), cd + "\\3DNUS_new.exe");
                                WebClient get_fin = new WebClient();
                                get_fin.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/3DNUS/master/Updates/upd_fin.exe"), cd + "\\upd_fin.exe");
                                Process.Start(cd + "\\upd_fin.exe");
                                btn_update.Text = "Preparing...";
                                Application.Exit();
                            }
                        }
                    }
                }
            }
            catch
            {
                btn_update.Text = "Unable to update...";
            }
        }
    }
}