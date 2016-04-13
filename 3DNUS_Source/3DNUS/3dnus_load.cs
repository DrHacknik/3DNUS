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

namespace _3DNUS
{
    public partial class main_load : Form
    {
        public main_load()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
            timer1.Stop();
            if (File.ReadAllText(Path.Combine(cd, "Config", "setup_completed.cfg")) == (""))
            {
                Process.Start(Path.Combine(cd, "dev_first_time_setup.exe"));
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
            timer1.Stop();
            if (File.ReadAllText(Path.Combine(cd, "Config", "setup_completed.cfg")) == ("1"))
            {
                Main form = new Main();
                form.Show();
                Hide();
            }
           
        }

        private void main_load_Load(object sender, EventArgs e)
       { 
            Process.Start("3DNUS Upd - Lite.exe");
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                {
                    //Read all Config Files into RAM (.cfg)
                    File.ReadAllText(Path.Combine(cd, "Config", "dev_mode_cfg.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "adv_dns.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "adv_dns_add_p.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "adv_dns_add_s.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "adv_dns_ip4.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "adv_px.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "adv_px_add.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "adv_px_pass.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "adv_px_usr.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "adv_sub_mask.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "dev_mode_cfg.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "ext_ext.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "ext_net_4.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "ext_sandbox.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "ext_sandbox_md.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "ext_sandbox_st.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "upd_auto.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "upd_custom.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "upd_custom_svr.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "ver_dis.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "vnm.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "vnm_fw.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "vnm_install_signed.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "vnm_skip_failed.cfg"));
                    File.ReadAllText(Path.Combine(cd, "Config", "upd_checker.cfg"));



                    {

                        if (File.ReadAllText(Path.Combine(cd, "Config", "dev_mode_cfg.cfg")) == ("1"))
                        {
                            panel1.Visible = true;
                        }





                        // Process create = new Process();
                        // create.StartInfo.FileName = "3DNUS_Upd.exe";
                        //Application.Exit();
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Visible = true;
            timer2.Stop();
        }
    }
}

