using MaterialSkin;
using System;
using System.Windows.Forms;

namespace _3DNUS_Material_Edition
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            System.Net.ServicePointManager.ServerCertificateValidationCallback = (_dmy_sndr_, _dmy_cert_, _dmy_chain_, _dmy_ejjoj_) => true;
            if (Properties.Settings.Default.dev_dark_theme == "0")
            {
                MaterialSkinManager skinmgr = MaterialSkinManager.Instance;
                skinmgr.Theme = MaterialSkinManager.Themes.LIGHT;
                skinmgr.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.BLACK);
            }
            else
            {
                MaterialSkinManager skinmgr = MaterialSkinManager.Instance;
                skinmgr.Theme = MaterialSkinManager.Themes.DARK;
                skinmgr.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
            }

            Application.Run(new FmLoad());
        }
    }
}