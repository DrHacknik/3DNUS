using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
            using (Stream upd = File.Open(cd + "\\Config.ini", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(upd))
                {
                    string line = null;
                    for (int i = 0; i < 3; ++i)
                    {
                        line = reader.ReadLine();
                    }
                    if (line == "Auto_upd=1")
                    {
                        chck_auto_upd.Checked = true;
                    }
                    if (line == "Auto_upd=0")
                    {
                        chck_auto_upd.Checked = false;
                    }
                }
                using (Stream log = File.Open(cd + "\\Config.ini", FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(log))
                    {
                        string line2 = null;
                        for (int i = 0; i < 4; ++i)
                        {
                            line2 = reader.ReadLine();
                        }

                        if (line2 == "Dump_log_sys_info=1 ")
                        {
                            chck_dump_info.Checked = true;
                        }
                        if (line2 == "Dump_log_sys_info=0")
                        {
                            chck_dump_info.Checked = false;
                        }
                    }
                    using (Stream flags = File.Open(cd + "\\Config.ini", FileMode.Open))
                    {
                        using (StreamReader reader = new StreamReader(flags))
                        {
                            string line6 = null;
                            for (int i = 0; i < 6; ++i)
                            {
                                line6 = reader.ReadLine();
                                txtbx_flags.Text = line6;
                            }
                        }
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (StreamWriter config = new StreamWriter(cd + "\\Config.ini"))
            {
                config.Write("[Config] \r\nLanguage=Defualt \r\nArch_is_64=" + is64 + " \r\nAuto_upd=1 \r\nDump_log_sys_info=1 \r\nFlags=" + txtbx_flags.Text);
            }
            Close();
        }
    }
}