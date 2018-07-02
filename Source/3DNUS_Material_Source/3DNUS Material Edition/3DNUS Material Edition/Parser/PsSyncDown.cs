/* ====================================

    MarcusD's sync async
      WebClient file downloader

Copyright System.DateTime.Now.Year

  Extracted from MarcusD's ATLauncher

*/
//=====================================

using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MarcusD.at
{
    public class SyncDown
    {
        public Operation op;
        private byte isset = 3;
        public Exception ex = null;
        public Boolean cancel = false;

        private volatile Boolean _stahp = false;

        public SyncDown(Operation op)
        {
            this.op = op;
        }

        public Boolean syncDown(String link, String to)
        {
            ex = null;
            cancel = false;
            using (WebClient wc = new WebClient())
            {
                Object lck = new Object();

                wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;

                String tmpfeil = to + ".__SyncDownTMP_" + (Math.Sin(to.GetHashCode() / Math.PI) * 56.0D).ToString() + "__.bak.tmp";

                if (File.Exists(to)) File.Move(to, tmpfeil);

                lock (lck)
                {
                    op.setSubValue(0);
                    op.setSubMax(0);
                    wc.DownloadFileAsync(new Uri(link), to, lck);
                    while (wc.IsBusy)
                    {
                        Application.DoEvents();
                        if (_stahp)
                        {
                            wc.CancelAsync();
                            while (wc.IsBusy) Application.DoEvents();
                            _stahp = false;
                            goto ejj;
                        }
                    }
                    isset = 3;
                }
                if (this.ex != null) goto ejj;
                if (this.cancel) goto ejj;
                File.Delete(tmpfeil);
                return true;

                ejj:

                File.Delete(to);
                if (File.Exists(tmpfeil)) File.Move(tmpfeil, to);
                return false;
            }
        }

        public void stahp()
        {
            _stahp = true;
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs param2)
        {
            if (isset != 0)
            {
                if (param2.TotalBytesToReceive > op.getSubMax())
                    op.setSubMax(param2.TotalBytesToReceive);
                isset--;
            }
            op.setSubValue(param2.BytesReceived);
        }

        private void wc_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs param1)
        {
            lock (param1.UserState)
            {
                this.ex = param1.Error;
                this.cancel = param1.Cancelled;
            }
        }
    }
}