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
    public partial class Form1 : Form
    {
        public readonly String cd = Path.GetDirectoryName(Application.ExecutablePath);
        private WebClient upd_dwld = new WebClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Hide();
                File.Delete(cd + "\\3DNUS Material Edition.exe");
                File.Delete(cd + "\\snd\\dev_bck_music_main.mp3");
                File.Delete(cd + "\\snd\\dev_bck_music_help.mp3");
                File.Delete(cd + "\\snd\\dev_bck_music_settings.mp3");
                File.Move(cd + "\\3DNUS_new.exe", cd + "\\3DNUS Material Edition.exe");
                Directory.CreateDirectory(cd + "\\snd");
                upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/3DNUS/master/Updates/dev_bck_music_main.mp3"), cd + "\\dev_bck_music_main.mp3");
                upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/3DNUS/master/Updates/dev_bck_music_help.mp3"), cd + "\\dev_bck_music_help.mp3");
                upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/3DNUS/master/Updates/dev_bck_music_settings.mp3"), cd + "\\dev_bck_music_settings.mp3");
                upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/3DNUS/master/Updates/AxInterop.WMPLib.dll"), cd + "\\AxInterop.WMPLib.dll");
                Process.Start(cd + "\\3DNUS Material Edition.exe");
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("There were errors when Finishing the Update!", "upd_fin: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}