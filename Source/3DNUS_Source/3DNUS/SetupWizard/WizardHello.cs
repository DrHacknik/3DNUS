using _3DNUS.i18n;
using MarcusD.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _3DNUS.SetupWizard
{
    public partial class WizardHello : LocalizedForm
    {
        private WMPLib.WindowsMediaPlayer mp;
        private int posx, posy;
        private Boolean dragging = false;

        private List<String> langs = new List<String>();

        public WizardHello()
        {
            InitializeComponent();
            mp = new WMPLib.WindowsMediaPlayer();
            dropLangsel.Items.Clear();

            foreach (String file in Directory.GetFiles(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Language"), "*.ini", SearchOption.TopDirectoryOnly))
            {
                try
                {
                    dropLangsel.Items.Add(new Ini(file)["_meta"].Read("name", Path.GetFileNameWithoutExtension(file).ToUpper()));
                    langs.Add(Path.GetFileNameWithoutExtension(file));
                }
                catch
                {
                    MessageBox.Show("Language file \"" + Path.GetFileName(file) + "\" is invalid, so it will be discarded",
                    "Language file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            if (Bottom > scr.WorkingArea.Height + scr.WorkingArea.Y) { Top = scr.WorkingArea.Height - Height + scr.WorkingArea.Y; };
            if (Left > scr.WorkingArea.Width - Width + scr.WorkingArea.X) { Left = scr.WorkingArea.Width - Width + scr.WorkingArea.X; };
            if (Top < 0) { Top = 0; };
            if (Left < 0) { Left = 0; };
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
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
            if (!File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Config", "setup_completed.cfg")))
            {
                MessageBox.Show("You will NOT be able to use 3DNUS until you have completed the setup!", "3DNUS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            Close();
        }

        public override IEnumerable<Control> TranslationTrigger()
        {
            yield return Label1;
            yield return Label5;
            yield return Label2;
        }

        public override void PostTranslate()
        {
            Label2.Left = (this.Width / 2) - (Label2.Width / 2);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            using (WizardEula frm = new WizardEula())
            {
                Hide();
                this.DialogResult = frm.ShowDialog();
            }
            Close();
        }

        private void dropLangsel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropLangsel.SelectedIndex != -1)
            {
                Localizer.LoadLang(langs[dropLangsel.SelectedIndex]);
            }
        }
    }
}