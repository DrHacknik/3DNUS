using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MarcusD.Util;

namespace _3DNUS.i18n
{
    public static class Localizer
    {
        private static Ini dict;
        private static String sellang = "default";
        private static HashSet<LocalizedForm> frmlst;

        static Localizer()
        {
            frmlst = new HashSet<LocalizedForm>();

            LoadLang(sellang);
        }

        public static void LoadLang(String name)
        {
            String path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Language", name + ".ini");
            if (!File.Exists(path)) return;
            dict = new Ini(path);
            sellang = name;

            foreach(LocalizedForm lm in frmlst)
            {
                if(lm == null) continue;
                if(lm.Tag == null) continue;

                PleaseTrigger(lm);
            }

            Application.DoEvents();
        }

        public static String Translate(String sect, String wat)
        {
            return dict[sect].Read(wat, "!nodef%" + wat);
        }

        public static void SubscribeHook(LocalizedForm frm)
        {
            if(frm == null) return;
            frmlst.Add(frm);
        }

        public static void UnsubscribeHook(LocalizedForm frm)
        {
            if(frm == null) return;
            frmlst.Remove(frm);
        }

        public static void PleaseTrigger(LocalizedForm frm)
        {
            if(frm == null) return;
            if(frm.Tag == null) return;
            IEnumerable<Control> ie = frm.TranslationTrigger();
            if(ie == null) return;
            foreach(Control ctl in ie)
            {
                if(ctl == null) continue;
                if(ctl.Tag == null) continue;
                ctl.Text = Translate(frm.Tag.ToString(), ctl.Tag.ToString());
            }
        }
    }
}
