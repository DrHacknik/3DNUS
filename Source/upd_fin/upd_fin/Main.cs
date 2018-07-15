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
        private bool is64 = System.Environment.Is64BitOperatingSystem;
        public readonly String cd = Path.GetDirectoryName(Application.ExecutablePath);
        private PictureBox pcx_Logo;
        private Label lbl_status;
        private Timer tmr_failure;
        private IContainer components;
        private WebClient upd_dwld = new WebClient();

        public Main()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pcx_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.tmr_failure = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcx_Logo)).BeginInit();
            this.SuspendLayout();
            //
            // pcx_Logo
            //
            this.pcx_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pcx_Logo.BackgroundImage = global::upd_fin.Properties.Resources.new_3dnus_logo_128;
            this.pcx_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcx_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcx_Logo.Location = new System.Drawing.Point(0, 0);
            this.pcx_Logo.Name = "pcx_Logo";
            this.pcx_Logo.Size = new System.Drawing.Size(400, 300);
            this.pcx_Logo.TabIndex = 0;
            this.pcx_Logo.TabStop = false;
            //
            // lbl_status
            //
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(0, 277);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(400, 23);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "%stat%";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // tmr_failure
            //
            this.tmr_failure.Interval = 6500;
            this.tmr_failure.Tick += new System.EventHandler(this.tmr_failure_Tick);
            //
            // Main
            //
            this.BackgroundImage = global::upd_fin.Properties.Resources.Splash_new_with_gradient;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pcx_Logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcx_Logo)).EndInit();
            this.ResumeLayout(false);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_status.Text = "Downloading config file...";
                if (is64 == true)
                {
                    upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/DrHacknik/3DNUS/master/Updates/x64/3DNUS_Material_Edition.exe.config"), cd + "\\3DNUS_Material_Edition.exe.config.new");
                    lbl_status.Text = "Preparing...";
                    Application.Exit();
                }
                if (is64 == false)
                {
                    upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/DrHacknik/3DNUS/master/Updates/x32/3DNUS_Material_Edition.exe.config"), cd + "\\3DNUS_Material_Edition.exe.config.new");
                    Process.Start(cd + "\\upd_fin.exe");
                    lbl_status.Text = "Preparing...";
                    Application.Exit();
                }

                lbl_status.Text = "Downloading dependecies...";
                upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/DrHacknik/3DNUS/master/Updates/MaterialSkin.dll"), cd + "\\MaterialSkin.dll.new");
            }
            catch
            {
                lbl_status.Text = "Unable to update. [Get Config Failed] - Closing in 6,500 intervals";
                tmr_failure.Start();
                return;
            }
            try
            {
                File.Delete(cd + "\\3DNUS_Material_Edition.exe.config");
                File.Delete(cd + "MaterialSkin.dll");
                File.Move(cd + "\\MaterialSkin.dll.new", cd + "\\MaterialSkin.dll");
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
                lbl_status.Text = "Unable to update. [Overall Failure] - Closing in 6,500 intervals";
                tmr_failure.Start();
                return;
            }
        }

        private void tmr_failure_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}