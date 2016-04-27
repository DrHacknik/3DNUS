using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using _3DNUS.i18n;

namespace _3DNUS.SetupWizard
{
    public partial class WizardHello : LocalizedForm
    {
        WMPLib.WindowsMediaPlayer mp;
        int posx, posy;
        Boolean dragging = false;


        public WizardHello()
        {
            InitializeComponent();
            mp = new WMPLib.WindowsMediaPlayer();
        }

        private void WizardHello_Load(object sender, EventArgs e)
        {
            String teste = "file:///" + Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Music", "upd_bck_music.mp3").Replace("\\", "/");
            mp.URL = teste;
            mp.settings.volume = 20;
            mp.settings.setMode("loop", true);
            mp.controls.play();
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            Screen scr = Screen.FromControl(this);
            if(Bottom > scr.WorkingArea.Height + scr.WorkingArea.Y) { Top = scr.WorkingArea.Height - Height + scr.WorkingArea.Y; };
            if(Left > scr.WorkingArea.Width - Width + scr.WorkingArea.X) { Left = scr.WorkingArea.Width - Width + scr.WorkingArea.X; };
            if(Top < 0) { Top = 0; };
            if(Left < 0) { Left = 0; };
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Left = MousePosition.X - posx;
                Top = MousePosition.Y - posy;
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            posx = e.Location.X;
            posy = e.Location.Y;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if(!File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Config", "setup_completed.cfg")))
            {
                MessageBox.Show("You will NOT be able to use 3DNUS, until you have Completed the Setup!", "3DNUS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            Close();
        }

        public override IEnumerable<Control> TranslationTrigger()
        {
            yield return Label1;
            yield return Label5;
        }
    }
}
