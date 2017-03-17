using _3DNUS.i18n;
using _3DNUS.SetupWizard;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DNUS
{
    public partial class main_load : Form
    {
        public main_load()
        {
            InitializeComponent();
            labelVersion.Text = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion + " v" + 0;
            labelVersion.Left = this.Width - labelVersion.Width;
        }

        private void main_load_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            string cd = Path.GetDirectoryName(Application.ExecutablePath);

            do//not mess up the variable list :)
            {
                BackgroundWorker bgw = new BackgroundWorker();
                bgw.DoWork += (dis, earg) =>
                {
                    CheckAssetExtract(Path.Combine(cd, "Config"), "Config");
                    CheckAssetExtract(Path.Combine(cd, "Language"), "i18n", true);
                    CheckAssetExtract(cd, "Binary", true);
                };
                bgw.RunWorkerAsync();
                while (bgw.IsBusy)
                    Application.DoEvents();
            }
            while (false);

            Localizer.LoadLang(File.ReadAllText(Path.Combine(cd, "Config", "lang_selected.cfg")));

            if (!File.Exists(Path.Combine(cd, "Config", "setup_completed.cfg")))
            {
                labelProgress.Text = "Preparing for first run...";

                Application.DoEvents();

                CheckAssetExtract(Path.Combine(cd, "Music"), "Music", true);

                using (WizardHello frm = new WizardHello())
                {
                    Hide();
                    if (frm.ShowDialog() == DialogResult.Abort)
                    {
                        Application.Exit();
                        return;
                    }
                }

                Application.Restart();
                return;
            }

            if (File.ReadAllText(Path.Combine(cd, "Config", "dev_mode_cfg.cfg")) == ("1"))
            {
                panel1.Visible = true;
            }

            labelProgress.Text = Localizer.Translate("Splash", "cfg_loaded");

            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();

            using (Main frm = new Main())
            {
                while (sw.ElapsedMilliseconds < 5000) { Application.DoEvents(); }
                sw.Stop();
                Hide();
                frm.ShowDialog();
            }
        }

        private static void CheckAssetExtract(String cd, String wat, Boolean checksum = false)
        {
            if (!Directory.Exists(cd)) Directory.CreateDirectory(cd);

            Assembly ass = Assembly.GetExecutingAssembly();
            String prefix = "_3DNUS.RuntimeAssets." + wat + ".";
            int prefixlen = prefix.Length;

            foreach (String ss in ass.GetManifestResourceNames().Where(str => str.StartsWith(prefix)))
            {
                String s = ss.Substring(prefixlen);
                String fn = Path.Combine(cd, s);

                if (File.Exists(fn))
                    if (checksum)
                    {
                        String cs = null;

                        using (Stream sr = ass.GetManifestResourceStream(ss))
                        {
                            using (MD5 md = MD5.Create())
                            {
                                cs = BitConverter.ToString(md.ComputeHash(sr)).ToLower();
                            }
                        }

                        using (FileStream fs = File.OpenRead(fn))
                        {
                            using (MD5 md = MD5.Create())
                            {
                                if (BitConverter.ToString(md.ComputeHash(fs)).ToLower() == cs) continue;
                            }
                        }
                    }
                    else continue;

                using (Stream sr = ass.GetManifestResourceStream(ss))
                {
                    using (FileStream fs = File.OpenWrite(fn))
                    {
                        byte[] buf = new byte[0x1000];
                        int read = -1;
                        while (true)
                        {
                            read = sr.Read(buf, 0, buf.Length);
                            if (read == 0) break;
                            fs.Write(buf, 0, read);
                        }
                    }
                }
            }
        }

        private void main_load_Load(object sender, EventArgs e)
        {
        }
    }
}