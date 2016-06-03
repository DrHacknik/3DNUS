using _3DNUS;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DNUS_Material_Edition
{
    public partial class Form1 : MaterialForm
    {
        private string server = "http://nus.cdn.c.shop.nintendowifi.net/ccs/download/";
        private YLS yls;

        public Form1()
        {
            InitializeComponent();
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (_dmy_sndr_, _dmy_cert_, _dmy_chain_, _dmy_ejjoj_) => true;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t_log.Text += " " + DateTime.Now;
            MessageBox.Show("Do keep in mind, that this very early Dev Build.", "Keep in Mind:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void firmwdownload(string firm, string reg)
        {
            string cd = Path.GetDirectoryName(Application.ExecutablePath);

            if (reg == null || reg.Length != 1 || !yls.regions.ContainsKey(reg[0]))
            {
                MessageBox.Show("Invalid region! Valid regions are:\r\n" + String.Join(", ", yls.regions.Keys.ToArray()), "Invalid region", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //better be safe'n'paranoid
            if (yls == null) if (File.Exists(cd + "\\titlelist.csv")) yls = YLS.Import(cd + "\\titlelist.csv");
                else
                {
                    MessageBox.Show("Can't read title list, file doesn't exist.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            WebClient titlelist = new WebClient();

            Directory.CreateDirectory(cd + "\\" + t_titleid.Text);

            YLS_Sysver sys = new YLS_Sysver();
            sys.label = firm;

            foreach (YLS_Title t in yls.regions[reg[0]])
            {
                YLS_Titlever optimal = null;

                foreach (YLS_Titlever tv in t.ver)
                {
                    if (tv.sysver == sys) { optimal = tv; break; }
                    if (tv.sysver < sys && (optimal == null || tv.sysver > optimal.sysver)) optimal = tv;
                }

                if (optimal == null) continue;

                singledownload(t.id.ToString("X16"), optimal.version.ToString());
                Application.DoEvents();
            }
            t_log.Text += "\r\n" + DateTime.Now + " Firmware Download complete!";
        }

        private void log(string msg)
        {
            t_log.AppendText("\r\n" + msg);
        }

        private void extensionManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Application.StartupPath + "\\Extension Manager.exe");
            }
            catch
            {
                MessageBox.Show("We're unable to locate the Executable, please make sure it's there!", "3DNUS: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                WebClient titlelist = new WebClient();
                String cd = Path.GetDirectoryName(Application.ExecutablePath);
                titlelist.DownloadFile("https://yls8.mtheall.com/ninupdates/titlelist.php?sys=ctr&csv=1", cd + "\\titlelist.csv");
            }
            catch
            {
                MessageBox.Show("Unable to grab Titlelist; Make sure you have an Internet Connection!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                WebClient titlelist = new WebClient();
                String cd = Path.GetDirectoryName(Application.ExecutablePath);
                titlelist.DownloadFile("https://yls8.mtheall.com/ninupdates/titlelist.php?sys=ktr&csv=1", cd + "\\titlelist.csv");
            }
            catch
            {
                MessageBox.Show("Unable to grab Titlelist; Make sure you have an Internet Connection!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            t_titleid.Text = t_titleid.Text.Trim();
            t_version.Text = t_version.Text.Trim();

            if (t_titleid.Text.Length == 0 || t_version.Text.Length == 0)
            {
                MessageBox.Show("Please enter a Firmware or Title to download;" +
                    "Ex: 8.1.0-23 ---- USA; Or 00000000000 ---- v1024 ");
                return;
            }
            if (c_cia.Checked && !File.Exists("make_cdn_cia.exe"))
            {
                MessageBox.Show("Error: make_cdn_cia.exe can't be found in the working directory!\r\n" +
                    "This option will be unavailable while make_cdn_cia.exe is not found", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c_cia.Checked = false;
            }

            String cd = Path.GetDirectoryName(Application.ExecutablePath);

            if (yls == null) if (File.Exists(cd + "\\titlelist.csv")) yls = YLS.Import(cd + "\\titlelist.csv");
                else
                {
                    MessageBox.Show("Can't read title list, file doesn't exist.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            if (t_titleid.Text.Contains("."))
            {
                string firmw = t_titleid.Text;
                string reg = t_version.Text;

                Match match = Regex.Match(firmw, @"(\d+)\.(\d+)(\.(\d+))?(-(\d+))?([a-zA-Z])?");
                if (!match.Success)
                {
                    MessageBox.Show("Invalid firmware string format!");
                    return;
                }

                firmw = (match.Groups[1] + "." + match.Groups[2] + "." + (match.Groups[4].Success ? match.Groups[4].ToString() : "0") + "-" + (match.Groups[6].Success ? match.Groups[6].ToString() : "999"));
                t_titleid.Text = firmw;
                t_titleid.Update();

                switch (reg.ToUpper())
                {
                    case "EUR": reg = "E"; break;
                    case "USA": reg = "U"; break;
                    case "JPN": reg = "J"; break;
                    case "TWN": reg = "T"; break;
                    case "CHN": reg = "C"; break;
                    case "KOR": reg = "K"; break;
                }

                t_version.Text = reg;
                t_version.Update();

                log(DateTime.Now + " Downloading Firmware: " + firmw + reg);

                firmwdownload(firmw, reg);
            }
            else
            {
                string title = t_titleid.Text;
                string version = t_version.Text;
                if (version[0] == 'v') { version = version.Substring(1); t_version.Text = version; t_version.Update(); }
                singledownload(title, version);
            }
        }

        private void singledownload(string title, string version)
        {
            log("\r\n" + DateTime.Now + " Downloading " + title + " v" + version + "...");
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
            string ftmp = cd + "\\tmp";
            string downloadtmd = server + title + "/" + "tmd." + version;
            string downloadcetk = server + title + "/cetk";

            Directory.CreateDirectory(ftmp);

            try
            {
                WebClient dtmd = new WebClient();
                dtmd.DownloadFile(downloadtmd, @ftmp + "\\tmd");
                dtmd.DownloadFile(downloadcetk, @ftmp + "\\cetk");
            }
            catch
            {
                log("\r\n" + DateTime.Now + " Error downloading title " + title + " v" + version + " make sure the entered title ID and versions are correct");
                return;
            }

            //amount of contents
            FileStream tmd = File.Open(ftmp + "\\tmd", FileMode.Open, FileAccess.Read);

            tmd.Seek(518, SeekOrigin.Begin);
            byte[] cc = new byte[2];
            tmd.Read(cc, 0, 2);
            Array.Reverse(cc);
            int contentcounter = BitConverter.ToInt16(cc, 0);

            log("Title has " + contentcounter + " contents");

            //notifyIcon1.BalloonTipText = "Title has " + contentcounter + " contents";
            // notifyIcon1.ShowBalloonTip(1);

            //download files
            WebClient contd = new WebClient();

            for (int i = 1; i <= contentcounter; i++)
            {
                try
                {
                    int contentoffset = 2820 + (48 * (i - 1));
                    tmd.Seek(contentoffset, SeekOrigin.Begin);
                    byte[] cid = new byte[4];
                    tmd.Read(cid, 0, 4);
                    string contentid = BitConverter.ToString(cid).Replace("-", "");
                    string downname = ftmp + "\\" + contentid;
                    contd.DownloadFile(server + title + "/" + contentid, @downname);
                    log(DateTime.Now + " Downloading complete");

                    //notifyIcon1.BalloonTipText = "Download complete";
                    // notifyIcon1.ShowBalloonTip(1);
                }
                catch
                {
                }
            }

            tmd.Close();
            if (c_cia.Checked)
            {
                //create cia
                log(DateTime.Now + " Packing as .cia ...");
                string command;
                if (t_titleid.Text.Contains("."))
                {
                    command = " " + "tmp" + " " + t_titleid.Text + "\\" + title + ".cia";
                }
                else
                {
                    command = " " + "tmp" + " " + title + ".cia";
                }

                Process create = new Process();
                create.StartInfo.FileName = "make_cdn_cia.exe";
                create.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                create.StartInfo.Arguments = command;
                create.Start();
                create.WaitForExit();
                Directory.Delete(ftmp, true);
            }
            else
            {
                if (t_titleid.Text.Contains("."))
                {
                    Directory.Move(ftmp, cd + "\\" + t_titleid.Text + "\\" + title);
                }
                else
                {
                    Directory.Move(ftmp, cd + "\\" + title);
                }
            }
            log(DateTime.Now + " Done.");
        }

        private void materialContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }
    }
}