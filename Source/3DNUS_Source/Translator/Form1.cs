using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MarcusD.Util;

namespace Translator
{
    public partial class FormTranslate : Form
    {
        Ini i = new Ini("lel.ini");

        public FormTranslate()
        {
            InitializeComponent();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
            else if(e.Control)
            {
                if(e.KeyCode == Keys.S)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    i["lel"]["kek"] = textBox1.Text;
                }
                else if(e.KeyCode == Keys.W || e.KeyCode == Keys.Q)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }
    }
}
