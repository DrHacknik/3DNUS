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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upd_fin
{
    public partial class Form1 : Form
    {
        public readonly String cd = Path.GetDirectoryName(Application.ExecutablePath);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
            File.Delete(cd + "\\3DNUS Material Edition.exe");
            File.Move(cd + "\\3DNUS_new.exe", cd + "\\3DNUS Material Edition.exe");
            Process.Start(cd + "\\3DNUS Material Edition.exe");
            Application.Exit();
        }
    }
}