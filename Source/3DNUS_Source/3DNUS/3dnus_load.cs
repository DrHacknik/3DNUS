using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Reflection;

using _3DNUS.SetupWizard;
using System.Security.Cryptography;

namespace _3DNUS
{
    public partial class main_load : Form
    {
        public main_load()
        {
            InitializeComponent();
        }

        private void main_load_Shown(object sender, EventArgs e)
        {
            string cd = Path.GetDirectoryName(Application.ExecutablePath);

            CheckAssetExtract(Path.Combine(cd, "Config"), "Config");
            CheckAssetExtract(cd, "Binary");

            if(!File.Exists(Path.Combine(cd, "Config", "setup_completed.cfg")))
            {
                CheckAssetExtract(Path.Combine(cd, "Music"), "Music");

                using(WizardHello frm = new WizardHello())
                {
                    if(frm.ShowDialog() == DialogResult.Abort)
                    {
                        Application.Exit();
                        return;
                    }
                }

                Application.Restart();
                return;
            }


            if(File.ReadAllText(Path.Combine(cd, "Config", "dev_mode_cfg.cfg")) == ("1"))
            {
                panel1.Visible = true;
            }

            label2.Visible = true;

            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();
            while(sw.ElapsedMilliseconds < 5000) { Application.DoEvents(); }
            sw.Stop();

            using(Main frm = new Main())
            {
                frm.Show();
            }

            Close();
        }

        private void CheckAssetExtract(String cd, String wat, Boolean checksum = false)
        {
            if(!Directory.Exists(cd)) Directory.CreateDirectory(cd);

            Assembly ass = Assembly.GetExecutingAssembly();
            String prefix = "_3DNUS.RuntimeAssets." + wat + ".";
            int prefixlen = prefix.Length;

            foreach(String ss in ass.GetManifestResourceNames().Where(str => str.StartsWith(prefix)))
            {
                String s = ss.Substring(prefixlen);
                String fn = Path.Combine(cd, s);

                String cs = null;
                if(checksum)
                {
                    using(MD5 md = MD5.Create())
                    {
                        using(Stream sr = ass.GetManifestResourceStream(ss))
                        {
                            cs = BitConverter.ToString(md.ComputeHash(sr)).ToLower();
                        }
                    }
                }

                if(File.Exists(fn))
                    if(checksum)
                    {
                        using(FileStream fs = File.OpenRead(fn))
                        {
                            using(MD5 md = MD5.Create())
                            {
                                using(Stream sr = ass.GetManifestResourceStream(ss))
                                {
                                    if(BitConverter.ToString(md.ComputeHash(sr)).ToLower() == cs) continue;
                                }
                            }
                        }
                    }
                    else continue;

                using(Stream sr = ass.GetManifestResourceStream(ss))
                {
                    using(FileStream fs = File.OpenWrite(fn))
                    {
                        byte[] buf = new byte[0x1000];
                        int read = -1;
                        while(true)
                        {
                            read = sr.Read(buf, 0, buf.Length);
                            if(read == 0) break;
                            fs.Write(buf, 0, read);
                        }
                    }
                }
            }
        }
    }
}

