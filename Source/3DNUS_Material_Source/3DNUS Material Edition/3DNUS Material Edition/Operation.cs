/* ====================================

    MarcusD's beautyful
     Console progress monitor
 
Copyright System.DateTime.Now.Year


  Extracted from MarcusD's ATLauncher
    Slightly edited to be better :P
*/
//=====================================


using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MarcusD.at
{
    public class Operation
    {
        private Object lck;

        public ProgressBar progbar;
        public ProgressBar subbar;
        public Control lblprog;
        public Control lblsub;

        public String main
        {
            get
            {
                return lblprog.Text;
            }
            set
            {
                lblprog.Text = value.Replace("\n", "\r\n");
            }
        }
        public String sub
        {
            get
            {
                return lblsub.Text;
            }
            set
            {
                lblsub.Text = value.Replace("\n", "\r\n");
            }
        }

        public Operation() { }

        #region public

        public void setProgMax(long i)
        {
            int k = (int)i;
            if(k == 0) k = 1;
            if(k < progbar.Value)
            {
                progbar.Value = k;
            }
            progbar.Maximum = k;
        }

        public long getProgMax()
        {
            return progbar.Maximum;
        }

        public void setProgValue(long i)
        {
            progbar.Value = Math.Min((int)i, progbar.Maximum);
        }

        public long getProgValue()
        {
            return progbar.Value;
        }

        public void setProgText(String str)
        {
            main = str;
        }

        public String getProgText()
        {
            return main;
        }

        public void setSubText(String str)
        {
            sub = str;
        }

        public String getSubText()
        {
            return sub;
        }

        public void setSubMax(long i)
        {
            int k = (int)i;
            if(k == 0) k = 1;
            if(k < subbar.Value)
            {
                subbar.Value = k;
            }
            subbar.Maximum = k;
        }

        public long getSubMax()
        {
            return subbar.Maximum;
        }

        public void setSubValue(long i)
        {
            subbar.Value = Math.Min((int)i, subbar.Maximum);
        }

        public long getSubValue()
        {
            return subbar.Value;
        }

        #endregion
    }
}