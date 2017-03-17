using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace _3DNUS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("3DNUS Upd - Lite.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer1.Stop();
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void trackBar1_ControlAdded(object sender, ControlEventArgs e)
        {
            progressBar1.Value += 2;
        }

        private void trackBar1_ControlRemoved(object sender, ControlEventArgs e)
        {
            progressBar1.Value -= 2;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value += 5;
            }
            catch
            {
            }
        }

        private void comboBox4_TextUpdate(object sender, EventArgs e)
        {
        }

        private void st_ext_mng_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //Reads the Config(s), then Enables Settings and Checkbox's
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
            using (StreamReader adv_dns_read = new StreamReader(cd + "\\Config\\adv_dns_add_p.cfg"))
            {
                adv_dns_read.Read();
            }
            if (File.ReadAllText(cd + "\\Config\\dev_mode_cfg.cfg") == ("1"))
            {
                checkBox11.Checked = true;
            }
            if (File.ReadAllText(cd + "\\Config\\dev_mode_cfg.cfg") == ("0"))
            {
                checkBox11.Checked = false;
            }
            if (File.ReadAllText(cd + "\\Config\\dev_mode_cfg.cfg") == (""))
            {
                checkBox11.Checked = false;
            }
            if (File.ReadAllText(cd + "\\Config\\vnm.cfg") == ("1"))
            {
                checkBox3.Checked = true;
            }
            if (File.ReadAllText(cd + "\\Config\\vnm.cfg") == ("0"))
            {
                checkBox3.Checked = false;
            }
            if (File.ReadAllText(cd + "\\Config\\vnm.cfg") == (""))
            {
                checkBox3.Checked = false;
            }
            if (File.ReadAllText(cd + "\\Config\\vnm_install_signed.cfg") == ("1"))
            {
                checkBox6.Checked = true;
            }
            if (File.ReadAllText(cd + "\\Config\\vnm_install_signed.cfg") == ("0"))
            {
                checkBox6.Checked = false;
            }
            if (File.ReadAllText(cd + "\\Config\\vnm_install_signed.cfg") == (""))
            {
                checkBox6.Checked = false;
            }
            if (File.ReadAllText(cd + "\\Config\\adv_dns.cfg") == (""))
            {
                checkBox5.Checked = false;
            }
            if (File.ReadAllText(cd + "\\Config\\adv_dns.cfg") == ("0"))
            {
                checkBox5.Checked = false;
            }
            if (File.ReadAllText(cd + "\\Config\\adv_dns.cfg") == ("1"))
            {
                checkBox5.Checked = true;
            }
            if (File.ReadAllText(cd + "\\Config\\adv_px.cfg") == ("1"))
            {
                checkBox4.Checked = true;
            }
            if (File.ReadAllText(cd + "\\Config\\adv_px.cfg") == ("0"))
            {
                checkBox4.Checked = false;
            }
            if (File.ReadAllText(cd + "\\Config\\adv_px.cfg") == (""))
            {
                checkBox4.Checked = false;
            }

            textBox4.Text = File.ReadAllText(cd + "\\Config\\adv_dns_add_p.cfg");
            textBox5.Text = File.ReadAllText(cd + "\\Config\\adv_dns_add_s.cfg");
            textBox6.Text = File.ReadAllText(cd + "\\Config\\adv_dns_ip4.cfg");
            textBox7.Text = File.ReadAllText(cd + "\\Config\\adv_sub_mask.cfg");
            textBox1.Text = File.ReadAllText(cd + "\\Config\\adv_px_add.cfg");
            textBox2.Text = File.ReadAllText(cd + "\\Config\\adv_px_usr.cfg");
            textBox3.Text = File.ReadAllText(cd + "\\Config\\adv_px_pass.cfg");
            label18.Text = File.ReadAllText(cd + "\\Config\\ext_sandbox_val.cfg");
            //Reads All the Config Files
            File.ReadAllText(cd + "\\Config\\dev_mode_cfg.cfg");
            File.ReadAllText(cd + "\\Config\\adv_dns.cfg");
            File.ReadAllText(cd + "\\Config\\adv_dns_add_p.cfg");
            File.ReadAllText(cd + "\\Config\\adv_dns_add_s.cfg");
            File.ReadAllText(cd + "\\Config\\adv_dns_ip4.cfg");
            File.ReadAllText(cd + "\\Config\\adv_px.cfg");
            File.ReadAllText(cd + "\\Config\\adv_px_add.cfg");
            File.ReadAllText(cd + "\\Config\\adv_px_pass.cfg");
            File.ReadAllText(cd + "\\Config\\adv_px_usr.cfg");
            File.ReadAllText(cd + "\\Config\\adv_sub_mask.cfg");
            File.ReadAllText(cd + "\\Config\\dev_mode_cfg.cfg");
            File.ReadAllText(cd + "\\Config\\ext_ext.cfg");
            File.ReadAllText(cd + "\\Config\\ext_net_4.cfg");
            File.ReadAllText(cd + "\\Config\\ext_sandbox.cfg");
            File.ReadAllText(cd + "\\Config\\ext_sandbox_md.cfg");
            File.ReadAllText(cd + "\\Config\\ext_sandbox_st.cfg");
            File.ReadAllText(cd + "\\Config\\upd_auto.cfg");
            File.ReadAllText(cd + "\\Config\\upd_custom.cfg");
            File.ReadAllText(cd + "\\Config\\upd_custom_svr.cfg");
            File.ReadAllText(cd + "\\Config\\ver_dis.cfg");
            File.ReadAllText(cd + "\\Config\\vnm.cfg");
            File.ReadAllText(cd + "\\Config\\vnm_fw.cfg");
            File.ReadAllText(cd + "\\Config\\vnm_install_signed.cfg");
            File.ReadAllText(cd + "\\Config\\vnm_skip_failed.cfg");
            File.ReadAllText(cd + "\\Config\\upd_checker.cfg");

            label13.Text = File.ReadAllText(cd + "\\Config\\ver_dis.cfg");
            //If ext_sandbox_val.cfg has Text stating the Size in MB, then this will determine the setting.
            //For example; "if (File.ReadAllText(cd + "\\Config\\ext_sandbox_val.cfg") == "Whatever in MB")"
            //{
            // Label18.Text = "Whatever in MB"
            //picturebox4.Width = Whatever Value, same as Setting.
            //progressBar1.Value = Whatever Value, same as Setting.
            //}
            if (File.ReadAllText(cd + "\\Config\\ext_sandbox_val.cfg") == "0MB")
            {
                label18.Text = "0MB";
                pictureBox4.Width = 0;
                progressBar1.Value = 0;
            }
            if (File.ReadAllText(cd + "\\Config\\ext_sandbox_val.cfg") == "10MB")
            {
                label18.Text = "10MB";
                pictureBox4.Width = 10;
                progressBar1.Value = 10;
            }
            if (File.ReadAllText(cd + "\\Config\\ext_sandbox_val.cfg") == "20MB")
            {
                label18.Text = "20MB";
                pictureBox4.Width = 20;
                progressBar1.Value = 20;
            }
            if (File.ReadAllText(cd + "\\Config\\ext_sandbox_val.cfg") == "30MB")
            {
                label18.Text = "30MB";
                pictureBox4.Width = 30;
                progressBar1.Value = 30;
            }
            if (File.ReadAllText(cd + "\\Config\\ext_sandbox_val.cfg") == "40MB")
            {
                label18.Text = "40MB";
                pictureBox4.Width = 40;
                progressBar1.Value = 40;
            }
            if (File.ReadAllText(cd + "\\Config\\ext_sandbox_val.cfg") == "50MB")
            {
                label18.Text = "50MB";
                pictureBox4.Width = 50;
                progressBar1.Value = 50;
            }
            if (File.ReadAllText(cd + "\\Config\\ext_sandbox_val.cfg") == "60MB")
            {
                label18.Text = "60MB";
                pictureBox4.Width = 60;
                progressBar1.Value = 60;
            }
            if (File.ReadAllText(cd + "\\Config\\ext_sandbox_val.cfg") == "70MB")
            {
                label18.Text = "70MB";
                pictureBox4.Width = 70;
                progressBar1.Value = 70;
            }
            if (File.ReadAllText(cd + "\\Config\\ext_sandbox_val.cfg") == "80MB")
            {
                label18.Text = "80MB";
                pictureBox4.Width = 80;
                progressBar1.Value = 80;
            }

            if (File.ReadAllText(cd + "\\Config\\ext_sandbox_val.cfg") == "90MB")
            {
                label18.Text = "90MB";
                pictureBox4.Width = 88;
                progressBar1.Value = 90;
            }
            if (File.ReadAllText(cd + "\\Config\\ext_sandbox_val.cfg") == "100MB")
            {
                label18.Text = "100MB";
                pictureBox4.Width = 178;
                progressBar1.Value = 100;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
            webBrowser1.Navigate("http://yls8.mtheall.com/ninupdates/reports.php");
            timer2.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click_3(object sender, EventArgs e)
        {
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            //Refresh Titlelist and Browser's
            pictureBox1.Visible = true;
            webBrowser1.Refresh();
            webBrowser2.Refresh();

            //Refresh Configuration
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
            File.ReadAllText(cd + "\\Config\\dev_mode_cfg.cfg");
            File.ReadAllText(cd + "\\Config\\adv_dns.cfg");
            File.ReadAllText(cd + "\\Config\\adv_dns_add_p.cfg");
            File.ReadAllText(cd + "\\Config\\adv_dns_add_s.cfg");
            File.ReadAllText(cd + "\\Config\\adv_dns_ip4.cfg");
            File.ReadAllText(cd + "\\Config\\adv_px.cfg");
            File.ReadAllText(cd + "\\Config\\adv_px_add.cfg");
            File.ReadAllText(cd + "\\Config\\adv_px_pass.cfg");
            File.ReadAllText(cd + "\\Config\\adv_px_usr.cfg");
            File.ReadAllText(cd + "\\Config\\adv_sub_mask.cfg");
            File.ReadAllText(cd + "\\Config\\dev_mode_cfg.cfg");
            File.ReadAllText(cd + "\\Config\\ext_ext.cfg");
            File.ReadAllText(cd + "\\Config\\ext_net_4.cfg");
            File.ReadAllText(cd + "\\Config\\ext_sandbox.cfg");
            File.ReadAllText(cd + "\\Config\\ext_sandbox_md.cfg");
            File.ReadAllText(cd + "\\Config\\ext_sandbox_st.cfg");
            File.ReadAllText(cd + "\\Config\\upd_auto.cfg");
            File.ReadAllText(cd + "\\Config\\upd_custom.cfg");
            File.ReadAllText(cd + "\\Config\\upd_custom_svr.cfg");
            File.ReadAllText(cd + "\\Config\\ver_dis.cfg");
            File.ReadAllText(cd + "\\Config\\vnm.cfg");
            File.ReadAllText(cd + "\\Config\\vnm_fw.cfg");
            File.ReadAllText(cd + "\\Config\\vnm_install_signed.cfg");
            File.ReadAllText(cd + "\\Config\\vnm_skip_failed.cfg");
            File.ReadAllText(cd + "\\Config\\upd_checker.cfg");
        }

        private void button1_Click_2(object sender, EventArgs e)
        //Code for when saving Config's from a Text Field or Checkbox, to either val's "0" or "1"
        //To do this, use a StreamWrite Line, and an If or Else Statement, or None.
        //It's not too Clean for now, sorry.
        {
            string cd = Path.GetDirectoryName(Application.ExecutablePath);

            {
                File.ReadAllText(cd + "\\Config\\dev_mode_cfg.cfg");
                {
                    using (StreamWriter dev_modeWriter = new StreamWriter(cd + "\\Config\\dev_mode_cfg.cfg"))
                    {
                        if (checkBox11.Checked == true)
                        {
                            dev_modeWriter.Write("1");
                        }
                        if (checkBox11.Checked == false)
                        {
                            dev_modeWriter.Write("0");
                        }
                        using (StreamWriter vnm_cfg = new StreamWriter(cd + "\\Config\\vnm.cfg"))
                        {
                            if (checkBox3.Checked == true)
                            {
                                vnm_cfg.Write("1");
                            }
                            if (checkBox3.Checked == false)
                            {
                                vnm_cfg.Write("0");
                            }
                            using (StreamWriter vnm_fw_cfg = new StreamWriter(cd + "\\Config\\vnm_fw.cfg"))
                            {
                                if (textBox10.Text == "default")
                                {
                                    vnm_fw_cfg.Write("default");
                                }
                                if (textBox10.Text == "default")
                                {
                                    vnm_fw_cfg.Write("default");
                                }
                                using (StreamWriter vnm_inst_cfg = new StreamWriter(cd + "\\Config\\vnm_install_signed.cfg"))
                                {
                                    if (checkBox6.Checked == true)
                                    {
                                        vnm_inst_cfg.Write("1");
                                    }
                                    if (checkBox6.Checked == false)
                                    {
                                        vnm_inst_cfg.Write("0");
                                    }

                                    using (StreamWriter vnm_skip_failed_cfg = new StreamWriter(cd + "\\Config\\vnm_skip_failed.cfg"))
                                    {
                                        if (checkBox7.Checked == true)
                                        {
                                            vnm_skip_failed_cfg.Write("1");
                                        }
                                        if (checkBox7.Checked == false)
                                        {
                                            vnm_skip_failed_cfg.Write("0");
                                        }
                                        using (StreamWriter adv_dns = new StreamWriter(cd + "\\Config\\adv_dns.cfg"))
                                        {
                                            if (checkBox5.Checked == true)
                                            {
                                                adv_dns.Write("1");
                                            }
                                            if (checkBox5.Checked == false)
                                            {
                                                adv_dns.Write("0");
                                            }
                                            using (StreamWriter adv_dns_add_p = new StreamWriter(cd + "\\Config\\adv_dns_add_p.cfg"))
                                            {
                                                adv_dns_add_p.Write(textBox4.Text);
                                            }
                                            using (StreamWriter obdWriter = new StreamWriter("config.cfg"))
                                            {
                                            }
                                            using (StreamWriter adv_dns_add_s = new StreamWriter(cd + "\\Config\\adv_dns_add_s.cfg"))
                                            {
                                                adv_dns_add_s.Write(textBox5.Text);
                                            }
                                            using (StreamWriter adv_dns_ip4 = new StreamWriter(cd + "\\Config\\adv_dns_ip4.cfg"))
                                            {
                                                adv_dns_ip4.Write(textBox6.Text);
                                            }
                                            using (StreamWriter adv_sub_mask = new StreamWriter(cd + "\\Config\\adv_sub_mask.cfg"))
                                            {
                                                adv_sub_mask.Write(textBox7.Text);
                                            }
                                            using (StreamWriter adv_px = new StreamWriter(cd + "\\Config\\adv_px.cfg"))
                                            {
                                                if (checkBox4.Checked == true)
                                                {
                                                    adv_px.Write("1");
                                                }
                                                if (checkBox4.Checked == false)
                                                {
                                                    adv_px.Write("0");
                                                }
                                                using (StreamWriter adv_px_pass = new StreamWriter(cd + "\\Config\\adv_px_add.cfg"))
                                                {
                                                    adv_px_pass.Write(textBox1.Text);
                                                }
                                                using (StreamWriter adv_px_usr = new StreamWriter(cd + "\\Config\\adv_px_usr.cfg"))
                                                {
                                                    adv_px_usr.Write(textBox2.Text);
                                                }
                                                using (StreamWriter adv_px_pass = new StreamWriter(cd + "\\Config\\adv_px_pass.cfg"))
                                                {
                                                    adv_px_pass.Write(textBox3.Text);
                                                }
                                                using (StreamWriter ext_sandbox_val = new StreamWriter(cd + "\\Config\\ext_sandbox_val.cfg"))
                                                {
                                                    ext_sandbox_val.Write(label18.Text);
                                                }

                                                label1.Visible = true;
                                                timer1.Start();
                                                //MessageBox.Show("Note: The Config isn't saved in this Preview Ver of the Settings Manager!", "Settings:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void webBrowser2_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void webBrowser2_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void webBrowser2_NewWindow(object sender, CancelEventArgs e)
        {
            MessageBox.Show("A new Browser Window has been Opened, some things may not Work Properly", "Settings:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value -= 10;
                pictureBox4.Width -= 10;
                if (pictureBox4.Width == 178)
                {
                    label18.Text = "0MB";
                }
                if (progressBar1.Value == 5)
                {
                    label18.Text = "5MB";
                }
                if (progressBar1.Value == 10)
                {
                    label18.Text = "10MB";
                }
                if (progressBar1.Value == 20)
                {
                    label18.Text = "20MB";
                }
                if (progressBar1.Value == 30)
                {
                    label18.Text = "30MB";
                }
                if (progressBar1.Value == 40)
                {
                    label18.Text = "40MB";
                }
                if (progressBar1.Value == 50)
                {
                    label18.Text = "50MB";
                }
                if (progressBar1.Value == 60)
                {
                    label18.Text = "60MB";
                }
                if (progressBar1.Value == 60)
                {
                    label18.Text = "70MB";
                }
                if (progressBar1.Value == 70)
                {
                    label18.Text = "80MB";
                }
                if (progressBar1.Value == 80)
                {
                    label18.Text = "90MB";
                }
                if (progressBar1.Value == 100)
                {
                    label18.Text = "100MB";
                }
            }
            catch
            {
                MessageBox.Show("You can't Decrease the Value any More!", "Settings Manager:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value += 10;
                pictureBox4.Width += 10;
                if (pictureBox4.Width == 178)
                {
                    label18.Text = "0MB";
                }
                if (progressBar1.Value == 5)
                {
                    label18.Text = "5MB";
                }
                if (progressBar1.Value == 10)
                {
                    label18.Text = "10MB";
                }
                if (progressBar1.Value == 20)
                {
                    label18.Text = "20MB";
                }
                if (progressBar1.Value == 30)
                {
                    label18.Text = "30MB";
                }
                if (progressBar1.Value == 40)
                {
                    label18.Text = "40MB";
                }
                if (progressBar1.Value == 50)
                {
                    label18.Text = "50MB";
                }
                if (progressBar1.Value == 60)
                {
                    label18.Text = "60MB";
                }
                if (progressBar1.Value == 60)
                {
                    label18.Text = "70MB";
                }
                if (progressBar1.Value == 70)
                {
                    label18.Text = "80MB";
                }
                if (progressBar1.Value == 80)
                {
                    label18.Text = "90MB";
                }
                if (progressBar1.Value == 100)
                {
                    label18.Text = "100MB";
                }
            }
            catch
            {
                MessageBox.Show("You can't Increase the Value any More!", "Settings Manager:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 0)
            {
                label18.Text = "0MB";
            }
            if (progressBar1.Value == 5)
            {
                label18.Text = "5MB";
            }
            if (progressBar1.Value == 10)
            {
                label18.Text = "10MB";
            }
            if (progressBar1.Value == 20)
            {
                label18.Text = "20MB";
            }
            if (progressBar1.Value == 30)
            {
                label18.Text = "30MB";
            }
            if (progressBar1.Value == 40)
            {
                label18.Text = "40MB";
            }
            if (progressBar1.Value == 50)
            {
                label18.Text = "50MB";
            }
            if (progressBar1.Value == 60)
            {
                label18.Text = "60MB";
            }
            if (progressBar1.Value == 60)
            {
                label18.Text = "70MB";
            }
            if (progressBar1.Value == 70)
            {
                label18.Text = "80MB";
            }
            if (progressBar1.Value == 80)
            {
                label18.Text = "90MB";
            }
            if (progressBar1.Value == 100)
            {
                label18.Text = "100MB";
            }
        }
    }
}