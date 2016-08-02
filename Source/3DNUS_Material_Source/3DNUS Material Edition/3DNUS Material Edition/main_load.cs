using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace _3DNUS_Material_Edition
{
    public partial class main_load : Form
    {
        public readonly String cd = Path.GetDirectoryName(Application.ExecutablePath);
        private bool is64 = System.Environment.Is64BitOperatingSystem;
        private bool checksum;

        public main_load()
        {
            InitializeComponent();
        }

        private void main_load_Load(object sender, EventArgs e)
        {
            //string cd = Application.StartupPath;
            //if (!Directory.Exists(cd)) Directory.CreateDirectory(cd);

            //Assembly ass = Assembly.GetExecutingAssembly();
            //String prefix = "_3DNUS.RuntimeAssets." + wat + ".";
            //int prefixlen = prefix.Length;

            //foreach (String ss in ass.GetManifestResourceNames().Where(str => str.StartsWith(prefix)))
            //{
            //    String s = ss.Substring(prefixlen);
            //    String fn = Path.Combine(cd, s);

            //    if (File.Exists(fn))
            //        if (checksum)
            //        {
            //            String cs = null;

            //            using (Stream sr = ass.GetManifestResourceStream(ss))
            //            {
            //                using (MD5 md = MD5.Create())
            //                {
            //                    cs = BitConverter.ToString(md.ComputeHash(sr)).ToLower();
            //                }
            //            }

            //            using (FileStream fs = File.OpenRead(fn))
            //            {
            //                using (MD5 md = MD5.Create())
            //                {
            //                    if (BitConverter.ToString(md.ComputeHash(fs)).ToLower() == cs) continue;
            //                }
            //            }
            //        }
            //        else continue;

            //    using (Stream sr = ass.GetManifestResourceStream(ss))
            //    {
            //        using (FileStream fs = File.OpenWrite(fn))
            //        {
            //            byte[] buf = new byte[0x1000];
            //            int read = -1;
            //            while (true)
            //            {
            //                read = sr.Read(buf, 0, buf.Length);
            //                if (read == 0) break;
            //                fs.Write(buf, 0, read);
            if (Properties.Settings.Default.dev_auto_upd == "")
            {
                Properties.Settings.Default.dev_auto_upd = "1";
                Properties.Settings.Default.dev_music = "1";
                Properties.Settings.Default.Save();
                Application.Restart();
            }
            if (Properties.Settings.Default.dev_auto_upd == "1")
            {
                try
                {
                    dev_status.Text = "Checking for Updates...";
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
                                dev_status.Text = "No new Updates";
                                splash_timer.Start();
                            }
                            else
                            {
                                dev_status.Text = "Downloading New update...";
                                if (is64 == true)
                                {
                                    upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/3DNUS/master/Updates/x64/3DNUS.exe"), cd + "\\3DNUS_new.exe");
                                    WebClient get_fin = new WebClient();
                                    get_fin.DownloadFile(new Uri("https://github.com/zoltx23/3DNUS/blob/master/Updates/upd_fin.exe?raw=true"), cd + "\\upd_fin.exe");
                                    Process.Start(cd + "\\upd_fin.exe");
                                    dev_status.Text = "Preparing...";
                                    Application.Exit();
                                }
                                if (is64 == false)
                                {
                                    upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/3DNUS/master/Updates/x32/3DNUS.exe"), cd + "\\3DNUS_new.exe");
                                    WebClient get_fin = new WebClient();
                                    get_fin.DownloadFile(new Uri("https://github.com/zoltx23/3DNUS/blob/master/Updates/upd_fin.exe?raw=true"), cd + "\\upd_fin.exe");
                                    Process.Start(cd + "\\upd_fin.exe");
                                    dev_status.Text = "Preparing...";
                                    Application.Exit();
                                }
                            }
                        }
                    }
                }
                catch
                {
                    dev_status.Text = "Unable to update...";
                    splash_timer.Start();
                }
            }
            else
            {
                splash_timer.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            splash_timer.Stop();
            FormMain f = new FormMain();
            f.Show();
            Hide();
        }

        private void main_load_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {
        }

        private void pic_splash_logo_Click(object sender, EventArgs e)
        {
        }
    }
}

//            }
//        }
//    }
//}