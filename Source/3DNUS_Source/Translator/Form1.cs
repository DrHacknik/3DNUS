using MarcusD.Util;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Translator
{
    public partial class FormTranslate : Form
    {
        private Ini i = new Ini("lel.ini");

        public FormTranslate()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
            else if (e.Control)
            {
                if (e.KeyCode == Keys.S)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    i["lel"]["kek"] = rch_trans.Text;
                }
                else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Q)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lang_open.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lang_save.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dev_about form = new dev_about();
            form.Show();
        }

        private void lang_open_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                rch_trans.LoadFile(lang_open.FileName);
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to load the File you requested!", "Translator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lang_save_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                rch_trans.SaveFile(lang_save.FileName, RichTextBoxStreamType.PlainText);
            }
            catch
            {
                MessageBox.Show("There was an Error when trying to save the File you requested!", "Translator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}