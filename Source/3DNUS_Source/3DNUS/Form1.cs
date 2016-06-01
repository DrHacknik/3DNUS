using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _3DNUS
{
    public partial class Main : Form
    {
        private string server = "http://nus.cdn.c.shop.nintendowifi.net/ccs/download/";

        private YLS yls = null;

        public Main()
        {
            InitializeComponent();
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (_dmy_sndr_, _dmy_cert_, _dmy_chain_, _dmy_ejjoj_) => true;
        }

        private void b_download_Click(object sender, EventArgs e)
        {
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
            log("\r\n" + DateTime.Now + " Firmware Download complete!");
            notifyIcon1.BalloonTipText = "Firmware download complete!";
            notifyIcon1.ShowBalloonTip(1);
        }

        private void log(string msg)
        {
            t_log.AppendText("\r\n" + msg);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
                notifyIcon1.BalloonTipText = "Downloading Firmware: " + firmw + reg;
                notifyIcon1.ShowBalloonTip(1);
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
                notifyIcon1.BalloonTipText = " Error downloading title " + title + " v" + version + " make sure the entered title ID and versions are correct";
                notifyIcon1.ShowBalloonTip(10);
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

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = pictureBox2.BackgroundImage;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = pictureBox3.BackgroundImage;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://gbatemp.net/threads/3dnus-mod-by-dr-hacknik.392360/");
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] workers = Process.GetProcessesByName("3DNUS Upd - Lite");
                foreach (Process worker in workers)
                {
                    worker.Kill();
                    worker.WaitForExit();
                    worker.Dispose();
                }
                Application.Exit();
            }
            catch
            {
            }
        }

        private void newPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://gbatemp.net/threads/3dnus-mod-by-dr-hacknik.392360/");
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void withGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VNM is Not Ready to Use Yet!", "VNM:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // VNM_Load form = new VNM_Load();
            // form.Show();
        }

        private void about3DNUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.Show();
        }

        private void SysSelectRadio_CheckedChanged(object sender, EventArgs e)
        {
            WebClient titlelist = new WebClient();
            String cd = Path.GetDirectoryName(Application.ExecutablePath);

            yls = null;
            RadioButton chk = panel1.Controls.OfType<RadioButton>().FirstOrDefault(ch => ch.Checked);

            if (chk == null) return;

            switch (chk.Name)
            {
                case "radioButton1":
                    titlelist.DownloadFile("http://yls8.mtheall.com/ninupdates/titlelist.php?sys=ktr&csv=1", cd + "\\titlelist.csv");
                    break;

                case "radioButton2":
                case "radioButton3":
                    titlelist.DownloadFile("http://yls8.mtheall.com/ninupdates/titlelist.php?sys=ctr&csv=1", cd + "\\titlelist.csv");
                    break;

                default:
                    MessageBox.Show("Well, this shouldn't be happening!\r\nDeveloper! " +
                        "Please update Form1.cs @ SysSelectRadio_CheckedChanged!\r\n\r\nThanks! :D",
                        "Developer error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            if (File.Exists(cd + "\\titlelist.csv")) yls = YLS.Import(cd + "\\titlelist.csv");
        }

        private void withoutGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VNM is Not Ready to Use Yet!", "VNM:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // VNM_Load form = new VNM_Load();
            // form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
            MessageBox.Show("This is a Development build! There may or may not be Bugs or Incomplete parts of 3DNUS. Please continue with caution!", "3DNUS: Dev Build Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            t_log.Text = DateTime.Now + " | 3DNUS Log Console:";
            label4.Text = DateTime.Now + "";

            if (yls == null) { radioButton2.Checked = false; radioButton2.Checked = true; }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] workers = Process.GetProcessesByName("3DNUS Upd - Lite");
                foreach (Process worker in workers)
                {
                    worker.Kill();
                    worker.WaitForExit();
                    worker.Dispose();
                }
                Application.Exit();
            }
            catch
            {
            }
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void backgroundModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.BalloonTipText = "3DNUS is now In Background Mode; Any Running Downloads Will Continue.";
            notifyIcon1.ShowBalloonTip(5);
        }

        private void startDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string firmw = t_titleid.Text;
            string reg = t_version.Text;
            notifyIcon1.BalloonTipText = "Downloading Firmware: " + firmw + reg;
            notifyIcon1.ShowBalloonTip(5);
            {
                if (t_titleid.Text.Length == 0 || t_version.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a titleid/firmware and version/region");
                    return;
                }
                if (t_titleid.Text.Contains("."))
                {
                    log(DateTime.Now + " Downloading Firmware: " + firmw + reg);
                    firmwdownload(firmw, reg);
                }
                else
                {
                    string title = t_titleid.Text;
                    string version = t_version.Text;
                    singledownload(title, version);
                }
            }
        }

        private void t_log_TextChanged(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void vnm_open_3ds_package_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VNM Can't stop when it's not Running!", "VNM:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void originalPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://gbatemp.net/threads/3dnus.376488/");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void extensionManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
            //MessageBox.Show("Extension Manager is Not Ready to Use Yet!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Process.Start(cd + "\\Extension Manager.exe");
        }

        private void downloadExtensionsPackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There was an Error When Attempting to Redirect to the Download Server! Try Again Later.", "Download Manager - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //string cd = Path.GetDirectoryName(Application.ExecutablePath);
            // WebClient ext_pck = new WebClient();
            //ext_pck.DownloadFile("https://jkza6w.bn1301.livefilestore.com/y3mVce3ztlAZYJotXcG8qWk4q_PLtWAvtieJkK-r85gt7WH4bhg_Eub1Y5pJirTmIhlHQun8ErgwmwfxDvlyamtQc_4DuR2KImjmkLypR-ti1UTothBcvlHzia4BrYw59vaUP30MBBjCxaw1KICGB_s4HOhPdNh9jVMMWk-N-7gz6c/3DNUS%20Extensions.zip?download&psid=1", cd + "\\Extension_Pack.zip");
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.Show();
        }

        private void dumpLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cd = Path.GetDirectoryName(Application.ExecutablePath);

            {
                {
                    string filename = String.Format("{0:yyyy-MM-dd}__{1}", DateTime.Now, "Log.txt");
                    string path = Path.Combine(cd, filename);
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("LOG_DUMP START;  " + DateTime.Now + " | " + t_log.Text);
                    }
                }
            }
        }

        private void openRepoInBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://drhackniks-repo.webflow.io/");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
        }

        private void eURRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem5.Text;
            t_version.Text = "EUR";
        }

        private void uSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem3.Text;
            t_version.Text = "USA";
        }

        private void eURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem3.Text;
            t_version.Text = "EUR";
        }

        private void jPNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem3.Text;
            t_version.Text = "JPN";
        }

        private void uSAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem4.Text;
            t_version.Text = "USA";
        }

        private void eURToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem4.Text;
            t_version.Text = "EUR";
        }

        private void jPNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem4.Text;
            t_version.Text = "JPN";
        }

        private void uSAToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem5.Text;
            t_version.Text = "USA";
        }

        private void jPNToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem5.Text;
            t_version.Text = "JPN";
        }

        private void uSAToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem6.Text;
            t_version.Text = "USA";
        }

        private void eURToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem6.Text;
            t_version.Text = "EUR";
        }

        private void jPNToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem6.Text;
            t_version.Text = "JPN";
        }

        private void uSAToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem7.Text;
            t_version.Text = "USA";
        }

        private void eURToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem7.Text;
            t_version.Text = "EUR";
        }

        private void jPNToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem7.Text;
            t_version.Text = "JPN";
        }

        private void uSAToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem8.Text;
            t_version.Text = "USA";
        }

        private void eURToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem8.Text;
            t_version.Text = "EUR";
        }

        private void jPNToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            t_titleid.Text = toolStripMenuItem8.Text;
            t_version.Text = "JPN";
        }

        private void download_Tick(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Process[] workers = Process.GetProcessesByName("3DNUS Upd - Lite");
                foreach (Process worker in workers)
                {
                    worker.Kill();
                    worker.WaitForExit();
                    worker.Dispose();
                }
                Application.Exit();
            }
            catch
            {
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dev_material_gui form = new dev_material_gui();
            form.Show();
        }
    }
}