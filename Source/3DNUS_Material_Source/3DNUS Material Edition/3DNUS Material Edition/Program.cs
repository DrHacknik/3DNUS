using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace _3DNUS_Material_Edition
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            System.Net.ServicePointManager.ServerCertificateValidationCallback = (_dmy_sndr_, _dmy_cert_, _dmy_chain_, _dmy_ejjoj_) => true;
            MaterialSkinManager skinmgr = MaterialSkinManager.Instance;
            skinmgr.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmgr.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);

            Application.Run(new FormMain());
        }
    }
}
