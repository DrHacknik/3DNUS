using _3DNUS.i18n;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _3DNUS.SetupWizard
{
    public partial class WizardEula : LocalizedForm
    {
        private int posx, posy;
        private Boolean dragging = false;

        public WizardEula()
        {
            InitializeComponent();
        }

        private void WizardEula_Load(object sender, EventArgs e)
        {
            RichTextBox1.Lines = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Language", Localizer.sellang + "_eula.txt"));
        }

        public override IEnumerable<Control> TranslationTrigger()
        {
            yield return Label1;
            yield return Label2;
            yield return RadioButton1;
            yield return RadioButton2;
            yield return Button1;
        }

        public override void PostTranslate()
        {
            RadioButton2.Left = RadioButton1.Right + 4;
            Button1.Left = (this.Width - Button1.Width - 2);
        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            Button1.Enabled = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Button1.Enabled = false;
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
                MessageBox.Show("You won't be able to use 3DNUS until you don't complete the first time setup!", "3DNUS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}