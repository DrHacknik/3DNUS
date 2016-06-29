using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _3DNUS_Material_Edition
{
    public partial class dev_faq : Form
    {
        public dev_faq()
        {
            InitializeComponent();
        }

        private void dev_faq_Load(object sender, EventArgs e)
        {
            MaterialSkinManager skinmgr = MaterialSkinManager.Instance;
            skinmgr.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmgr.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
            //MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void dev_tab_control_Click(object sender, EventArgs e)
        {
        }
    }
}