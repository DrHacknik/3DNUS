using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DNUS_Material_Edition.Main
{
    public partial class MnAbout : MaterialForm
    {
        public MnAbout()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void MnAbout_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_dark_theme == "1")
            {
                lbl_header.ForeColor = System.Drawing.Color.White;
                lbl_body.ForeColor = System.Drawing.Color.White;
            }
            lbl_header.Text = "3DNUS version " + Application.ProductVersion + " - " + Properties.Settings.Default.dev_build_codename;
            lbl_body.Text = "This is the new Lightweight version of 3DNUS." + "\r\n\r\nVisit the forum post or GitHub for more Info.\r\n" +
                "\r\nThanks a Ton to @MarcusD for alot of His work." +
                "\r\n\r\n3DNUS is licensed under the GNU General Public License v3.\r\n\r\nThis project uses the Following Libraries:" +
                "\r\n\r\n• The MaterialSkin Library - Ignace Maes\r\n• YLS Parser - MarcusD\r\n• Windows Media Library - Deprecated\r\n• SimpliiU Code-base - For the Update service";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_usage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When typing your Title ID, make sure you type it correctly. For example: \r\n000000000 v0000 (ID followed by the Version.)" +
                "\r\nIf you're downloading a Full firmware, please type it as follows: XX.X followed by U, J, or E. \r\nU for USA, J for Japan, and E for Europe. \r\nOr for Example: 11.5U",
                "Usage Information:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}