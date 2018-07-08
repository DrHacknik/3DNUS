﻿using MaterialSkin;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upd_fin
{
    public partial class Main : Form
    {
        public readonly String cd = Path.GetDirectoryName(Application.ExecutablePath);
        private WebClient upd_dwld = new WebClient();

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Hide();
                File.Delete(cd + "\\3DNUS_Material_Edition.exe.config");
                File.Move(cd + "\\3DNUS Material Edition.exe.config.new", cd + "\\3DNUS Material Edition.exe.config");
                File.Move(cd + "\\3DNUS Material Edition.exe", cd + "\\3DNUS Material Edition.exe.old");
                if (!File.Exists(cd + "\\snd\\dev_bck_music_help.mp3"))
                {
                    File.Delete(cd + "\\snd\\dev_bck_music_help.mp3");
                }

                if (!File.Exists(cd + "\\snd\\dev_bck_music_settings.mp3"))
                {
                    File.Delete(cd + "\\snd\\dev_bck_music_settings.mp3");
                }
                File.Move(cd + "\\3DNUS_new.exe", cd + "\\3DNUS Material Edition.exe");
                if (!Directory.Exists(cd + "\\snd") == false)
                {
                    Directory.CreateDirectory(cd + "\\snd");
                }

                Process.Start(cd + "\\3DNUS Material Edition.exe");
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("There were errors when Finishing the Update!", "upd_fin: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}