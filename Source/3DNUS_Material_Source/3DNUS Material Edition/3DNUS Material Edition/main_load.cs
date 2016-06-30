using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace _3DNUS_Material_Edition
{
    public partial class main_load : Form
    {
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            splash_timer.Stop();
            FormMain f = new FormMain();
            f.Show();
            Hide();
        }
    }
}

//            }
//        }
//    }
//}