using MaterialSkin;
using MaterialSkin.Controls;
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

namespace _3DNUS_Material_Edition
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t_log.Text += " " + DateTime.Now;
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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            {


                if (materialSingleLineTextField1.Text.Length == 0 || materialSingleLineTextField2.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a titleid/firmware and version/region");
                    return;
                }
                if (materialSingleLineTextField1.Text.Contains("."))
                {
                    string firmw = materialSingleLineTextField1.Text;
                    string reg = materialSingleLineTextField2.Text;
                    log("Downloading Firmware: " + firmw + reg);
                    firmwdownload(firmw, reg);
                }
                else
                {
                    string title = materialSingleLineTextField1.Text;
                    string version = materialSingleLineTextField2.Text;
                    singledownload(title, version);
                }

            }
        }
            
       
            private void singledownload(string title, string version)
        {
            log("\r\nDownloading " + title + " v" + version + "...");
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
            string ftmp = cd + "\\tmp";
            string downloadtmd = "http://nus.cdn.c.shop.nintendowifi.net/ccs/download/" + title + "/" + "tmd." + version;
            string downloadcetk = "http://nus.cdn.c.shop.nintendowifi.net/ccs/download/" + title + "/cetk";

            Directory.CreateDirectory(ftmp);

            try
            {
                WebClient dtmd = new WebClient();
                dtmd.DownloadFile(downloadtmd, @ftmp + "\\tmd");
                dtmd.DownloadFile(downloadcetk, @ftmp + "\\cetk");
            }
            catch
            {
                log("\r\nError downloading title " + title + " v" + version + " make sure the entered title ID and versions are correct");
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

            //download files
            WebClient contd = new WebClient();
            for (int i = 1; i <= contentcounter; i++)
            {
                int contentoffset = 2820 + (48 * (i - 1));
                tmd.Seek(contentoffset, SeekOrigin.Begin);
                byte[] cid = new byte[4];
                tmd.Read(cid, 0, 4);
                string contentid = BitConverter.ToString(cid).Replace("-", "");
                string downname = ftmp + "\\" + contentid;
                contd.DownloadFile("http://nus.cdn.c.shop.nintendowifi.net/ccs/download/" + title + "/" + contentid, @downname);
                log("Downloading complete");
            }

            tmd.Close();
            if (materialCheckBox1.Checked)
            {
                //create cia
                log("Packing as .cia ...");
                string command;
                if (materialSingleLineTextField1.Text.Contains("."))
                {
                    command = " " + "tmp" + " " + materialSingleLineTextField1.Text + "\\" + title + ".cia";
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
                if (materialSingleLineTextField1.Text.Contains("."))
                {
                    Directory.Move(ftmp, cd + "\\" + materialSingleLineTextField1.Text + "\\" + title);
                }
                else
                {
                    Directory.Move(ftmp, cd + "\\" + title);
                }

            }
            log("Done.");
        }
        private void firmwdownload(string firm, string reg)
        {

            string cd = Path.GetDirectoryName(Application.ExecutablePath);
            WebClient titlelist = new WebClient();
            titlelist.DownloadFile("http://yls8.mtheall.com/ninupdates/titlelist.php?sys=ctr&csv=1", cd + "\\titlelist.csv");

            string[] titles = File.ReadAllLines(cd + "\\titlelist.csv");
            Directory.CreateDirectory(cd + "\\" + materialSingleLineTextField1.Text);
            foreach (string select1 in titles.Skip(1))
            {
                if (select1.Contains(reg))
                {
                    string title;
                    string version;

                    int[] wantedfw = Array.ConvertAll(materialSingleLineTextField1.Text.Replace(".", "").Split('-'), int.Parse);
                    string[] csv = select1.Split(',');
                    string firmwaresls = csv[3].Replace(" Initial scan", "").Replace("(stage1)", "").Replace("(stage2)", "").Replace("(stage3)", "").Replace("(stage4)", "").Replace("(stage5)", "").Replace("(stage6)", "").Replace("(stage7)", "").Replace("E", "").Replace("U", "").Replace("J", "");
                    string[] csvfirm = firmwaresls.Split(' ');
                    int[] csvfu = Array.ConvertAll(csvfirm[0].Replace(".", "").Split('-'), int.Parse);

                    if (wantedfw[1] >= csvfu[1] && wantedfw[0] >= csvfu[0])
                    {
                        string use = null;
                        foreach (string temp in csvfirm)
                        {
                            string currentclean = temp;
                            int[] intcc = Array.ConvertAll(currentclean.Replace(".", "").Split('-'), int.Parse);

                            if (wantedfw[0] < intcc[0] && wantedfw[1] < intcc[1])
                            {
                                break;
                            }
                            use = currentclean;
                        }
                        //set download title
                        title = csv[0];
                        // find version number
                        int verindex = Array.IndexOf(csvfirm, use);
                        // get version number
                        if (csv[2].Contains(" "))
                        {
                            string[] aver = csv[2].Split(' ');
                            version = aver[verindex].Replace("v", "");
                        }
                        else
                        {
                            version = csv[2].Replace("v", "");
                        }
                        //send the command
                        singledownload(title, version);

                    }
                }
            }
            log("\r\nDownloading firmware complete!");
        }
        private void log(string msg)
        {
            t_log.AppendText("\r\n" + msg);
        }
    }
}


    
  