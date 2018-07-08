using System;
using System.IO;
using System.Windows.Forms;

namespace _3DNUS_Material_Edition
{
    public partial class FmLoad : Form
    {
        public readonly String cd = Path.GetDirectoryName(Application.ExecutablePath);
        private bool is64 = System.Environment.Is64BitOperatingSystem;
        private Form mn = new MnMain();

        public FmLoad()
        {
            InitializeComponent();
        }

        private void main_load_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_auto_upd == "1")
            {
                splash_timer.Stop();
                SvcUpd.SvcUpdate();
                tmr_get_upd_stat.Start();
            }
            else
            {
                if (Properties.Settings.Default.dev_tour == "")
                {
                    Form dv = new dev_tour();
                    dv.Show();
                    this.Hide();
                }
                else
                {
                    splash_timer.Start();
                }
            }
            if (!File.Exists(cd + "\\3DNUS Material Edition.exe.old"))
            {
                File.Delete(cd + "\\3DNUS Material Edition.exe.old");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            splash_timer.Stop();
            mn.Show();
            Hide();
        }

        private void tmr_get_upd_stat_Tick(object sender, EventArgs e)
        {
            //Fetch Svc Status
            lbl_status.Text = SvcUpd.SvcUpdateStat;
            this.Refresh();

            //Fetch and check Error codes
            if (SvcUpd.SvcUpdateStat == "Unable to update. [Overall Failure]")
            {
                splash_timer.Start();
            }
            if (SvcUpd.SvcUpdateStat == "Unable to update. [Get Binary Failed]")
            {
                splash_timer.Start();
            }
            if (SvcUpd.SvcUpdateStat == "No new Updates")
            {
                splash_timer.Start();
            }
        }
    }
}