/* ==============================================================================

    This is the Update service.
    Any form can call this Service by
    simply doing "SvcUpd.SvcUpdate();"
    Just remember to include the service.

    You may then pass through String
    data from "SvcUpdateStat."

    For example:

    lbl_upd.Text = SvcUpd.SvcUpdateStat;

    This will allow you to display current
    Update information in any way you wish.

    ----------------------------------------------------------------------------

    You may also get Error codes by passing
    through the same information. Simply do something
    like the following:

     if (SvcUpd.SvcUpdateStat == "Unable to update. [Overall Failure]")
     {
        //Code
     }
     if (SvcUpd.SvcUpdateStat == "Unable to update. [Get Binary Failed]")
     {
        //Code
     }
     if (SvcUpd.SvcUpdateStat == "No new Updates")
     {
        //Code
     }

   ==============================================================================
*/

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace _3DNUS_Material_Edition.Services
{
    internal class SvcUpd

    {
        private static bool is64 = System.Environment.Is64BitOperatingSystem;
        private static string cd = Application.StartupPath;
        public static string SvcUpdateStat = null;

        //public static System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer
        //{
        //    Interval = 5000
        //};

        public static void SvcUpdate()
        {
            try
            {
                try
                {
                    File.Delete(Path.Combine(cd, "Update_Info.txt"));
                    File.Delete(Path.Combine(cd, "Update_URI.txt"));
                    File.Delete(Path.Combine(cd, "3DNUS_old.exe"));
                    File.Delete(Path.Combine(cd, "3DNUS_new.exe"));
                    File.Delete(Path.Combine(cd, "upd_fin.exe"));
                }
                catch
                {
                    SvcUpdateStat = "Unable to update. [Cleanup Failed]";
                    return;
                }

                WebClient get_info = new WebClient();
                get_info.DownloadFile(new Uri("https://raw.githubusercontent.com/DrHacknik/3DNUS/master/Updates/Update_Info.txt"), cd + "\\Update_Info.txt");
                WebClient upd_dwld = new WebClient();
                using (Stream upd = File.Open(cd + "\\Update_Info.txt", FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(upd))
                    {
                        string rd_upd = null;

                        rd_upd = reader.ReadToEnd();

                        if (rd_upd == Application.ProductVersion)
                        {
                            SvcUpdateStat = "No new Updates";
                        }
                        else
                        {
                            try
                            {
                                SvcUpdateStat = "Downloading New update...";
                                if (is64 == true)
                                {
                                    upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/DrHacknik/3DNUS/master/Updates/x64/3DNUS.exe"), cd + "\\3DNUS_new.exe");
                                    WebClient get_fin = new WebClient();
                                    get_fin.DownloadFile(new Uri("https://raw.githubusercontent.com/DrHacknik/3DNUS/master/Updates/upd_fin.exe"), cd + "\\upd_fin.exe");
                                    Process.Start(cd + "\\upd_fin.exe");
                                    SvcUpdateStat = "Preparing...";
                                    Application.Exit();
                                }
                                if (is64 == false)
                                {
                                    upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/DrHacknik/3DNUS/master/Updates/x32/3DNUS.exe"), cd + "\\3DNUS_new.exe");
                                    WebClient get_fin = new WebClient();
                                    get_fin.DownloadFile(new Uri("https://raw.githubusercontent.comD/rHacknik/3DNUS/master/Updates/upd_fin.exe"), cd + "\\upd_fin.exe");
                                    Process.Start(cd + "\\upd_fin.exe");
                                    SvcUpdateStat = "Preparing...";
                                    Application.Exit();
                                }
                            }
                            catch
                            {
                                SvcUpdateStat = "Unable to update. [Get Binary Failed]";
                            }
                        }
                    }
                }
            }
            catch
            {
                SvcUpdateStat = "Unable to update. [Overall Failure]";
            }
        }

        //private static void Tm_Tick(object sender, EventArgs e)
        //{
        //    tm.Stop();
        //    Form dm = new MnMain();
        //    dm.Show();
        //    return;
        //}
    }
}