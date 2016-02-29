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
    public partial class vnm_installer : Form
    {
        public vnm_installer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vnm_installer_Load(object sender, EventArgs e)
        {
            vnm_open_3ds_package.ShowDialog();
            in_id.Text = vnm_open_3ds_package.SafeFileName;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Extracting Package to: VNM/sdmc/Nintendo....";
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = "Removing Tmp and Cache Directory's....";
            Directory.Delete("cache", true);
            timer2.Stop();
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Text = "Done!";
            label1.ForeColor = Color.Green;
            timer3.Stop();
            button1.Text = "Exit";
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = 100;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Installing....";
            //if (checkBox1.Checked)
          //  {
             //   string cd = Path.GetDirectoryName(Application.ExecutablePath);
             //   Directory.CreateDirectory(cd + "\\Package_Title");
           // }
            try
            {
                //Creates Folders, and Installs the Package(s)
                progressBar1.Value = 0;
                progressBar1.Style = ProgressBarStyle.Marquee;
                label1.ForeColor = Color.Black;
                label1.Text = "Installing Package....";
                string cd = Path.GetDirectoryName(Application.ExecutablePath);
                string cf = cd + "\\VNM\\sdmc\\Nintendo 3DS\\" + in_id.Text + "\\extdata";
                string fileo = cd + "\\" + "Package_Title";
                string newp = cd + "\\";
                string cacf = cd + vnm_open_3ds_package.SafeFileName;
                string cacd = cd + "\\VNM\\sdmc\\Nintendo 3DS\\" + vnm_open_3ds_package.SafeFileName + "\\extdata";
                Directory.CreateDirectory(cd + "\\VNM\\sdmc\\Nintendo 3DS\\" + in_id.Text + "\\");
                Directory.Move(fileo, cf);
                Directory.CreateDirectory(cd + "\\Cache" + "\\" + "extdata");
                Directory.CreateDirectory(cd + "\\VNM\\Cached_Titles");
                timer1.Start();
                Directory.CreateDirectory(cd + "\\Package_Title");





            }
            catch
            {
                //A Returned Error (Only if the Package is Already Installed)
                label1.Text = "The Title is Already Installed!!";
                label1.ForeColor = Color.Red;
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 100;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
       
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string cd = Path.GetDirectoryName(Application.ExecutablePath);
            Directory.CreateDirectory(cd + "\\Package_Title");
        }
    }
}
