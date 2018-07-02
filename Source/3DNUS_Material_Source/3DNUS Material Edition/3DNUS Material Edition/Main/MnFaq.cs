using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace _3DNUS_Material_Edition
{
    public partial class dev_faq : MaterialForm
    {
        private String cd = Path.GetDirectoryName(Application.ExecutablePath);

        public dev_faq()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void dev_faq_Load(object sender, EventArgs e)
        {
            rch_debug.Text = "--Log Dump Start--" + "\r\n" + "\r\n SystemOS: " + Environment.OSVersion + "\r\n" + "\r\n Program Version: " + Application.ProductVersion + "\r\n" + "\r\n Debug State: " + "Unknown" + "\r\n" + " \r\n Time Dumped: " + DateTime.Now + "\r\n" + "\r\n---------------------------------------" + "\r\n" + "\r\n Write your Experience in the best way possible here. \r\nAlso, include the JIT Error below (If Possible).";
            MaterialSkinManager skinmgr = MaterialSkinManager.Instance;
            skinmgr.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmgr.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
            //MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void dev_tab_control_Click(object sender, EventArgs e)
        {
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
        }

        private void btn_prep_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://mail.google.com/mail/?view=cm&fs=1&to=3dnus.feedback@gmail.com&su=" + "3DNUS_Feedback - " + txt_user.Text + "&body=" + rch_debug.Text + " Type of Crash: " + txt_type.Text);
        }

        private void dev_bck_music_Enter(object sender, EventArgs e)
        {
        }
    }
}