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
    public partial class ext_mng_main : Form
         

    {
        string cd = Path.GetDirectoryName(Application.ExecutablePath);
        public ext_mng_main()
        {
            InitializeComponent();
        }

        private void helToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot1\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot2\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openExtensionPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Extension Manager couldn't open the Installer! Error Code: 0x4000", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        private void ext_open_FileOk(object sender, CancelEventArgs e)
        {
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
           
            //Process create = new Process();
            //create.StartInfo.FileName = "7zFM.exe";
            //create.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            //create.Start();
            //create.WaitForExit();
        }

        private void aboutExtensionManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ext_about form = new ext_about();
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot3\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
            Process.Start(cd + "\\Extensions\\_ext\\Slot1\\boot_ext.exe");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot5\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot8\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot10\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot7\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot12\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot11\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot6\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot9\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ext_mng_main_Load(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                label1.Text = File.ReadAllText(cd + "\\Extensions\\_ext\\Slot1\\ext_desc.c");
                label2.Text = File.ReadAllText(cd + "\\Extensions\\_ext\\Slot2\\ext_desc.c");
                label3.Text = File.ReadAllText(cd + "\\Extensions\\_ext\\Slot3\\ext_desc.c");
                label4.Text = File.ReadAllText(cd + "\\Extensions\\_ext\\Slot4\\ext_desc.c");
                label5.Text = File.ReadAllText(cd + "\\Extensions\\_ext\\Slot5\\ext_desc.c");
                label6.Text = File.ReadAllText(cd + "\\Extensions\\_ext\\Slot6\\ext_desc.c");
                label7.Text = File.ReadAllText(cd + "\\Extensions\\_ext\\Slot7\\ext_desc.c");
                label8.Text = File.ReadAllText(cd + "\\Extensions\\_ext\\Slot8\\ext_desc.c");
                label9.Text = File.ReadAllText(cd + "\\Extensions\\_ext\\Slot9\\ext_desc.c");
                label10.Text = File.ReadAllText(cd + "\\Extensions\\_ext\\Slot10\\ext_desc.c");
                label11.Text = File.ReadAllText(cd + "\\Extensions\\_ext\\Slot11\\ext_desc.c");
                label12.Text = File.ReadAllText(cd + "\\Extensions\\_ext\\Slot12\\ext_desc.c");
                pictureBox4.BackgroundImage = Image.FromFile(cd + "\\Extensions\\_ext\\Slot1\\ext_icon.jpg");
                pictureBox1.BackgroundImage = Image.FromFile(cd + "\\Extensions\\_ext\\Slot1\\ext_icon.png");
                pictureBox2.BackgroundImage = Image.FromFile(cd + "\\Extensions\\_ext\\Slot2\\ext_icon.png");
                pictureBox5.BackgroundImage = Image.FromFile(cd + "\\Extensions\\_ext\\Slot5\\ext_icon.png");
                pictureBox6.BackgroundImage = Image.FromFile(cd + "\\Extensions\\_ext\\Slot6\\ext_icon.png");
                pictureBox6.BackgroundImage = Image.FromFile(cd + "\\Extensions\\_ext\\Slot6\\ext_icon.png");
                pictureBox7.BackgroundImage = Image.FromFile(cd + "\\Extensions\\_ext\\Slot7\\ext_icon.png");
                pictureBox8.BackgroundImage = Image.FromFile(cd + "\\Extensions\\_ext\\Slot8\\ext_icon.png");
                pictureBox9.BackgroundImage = Image.FromFile(cd + "\\Extensions\\_ext\\Slot9\\ext_icon.png");
                pictureBox10.BackgroundImage = Image.FromFile(cd + "\\Extensions\\_ext\\Slot10\\ext_icon.png");
                pictureBox11.BackgroundImage = Image.FromFile(cd + "\\Extensions\\_ext\\Slot11\\ext_icon.png");
                pictureBox12.BackgroundImage = Image.FromFile(cd + "\\Extensions\\_ext\\Slot12\\ext_icon.png");
                pictureBox13.BackgroundImage = Image.FromFile(cd + "\\Extensions\\_ext\\Slot4\\ext_icon.png");
                pictureBox5.Refresh();
                pictureBox6.Refresh();
                pictureBox7.Refresh();
                pictureBox8.Refresh();
                pictureBox9.Refresh();
                pictureBox10.Refresh();
                pictureBox11.Refresh();
                pictureBox12.Refresh();
                
            }
            catch
            {
  
            }
         

          

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            try
            {
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                Process.Start(cd + "\\Extensions\\_ext\\Slot4\\boot_ext.exe");
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to Load the Extension!", "Extension Manager:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutExtensionManagerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ext_about form = new ext_about();
            form.Show();

        }
    }
}
