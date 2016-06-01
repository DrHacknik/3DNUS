using MarcusD.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _3DNUS.i18n
{
    public static class Localizer
    {
        public static String sellang { get; private set; }
        private static Dictionary<String, Dictionary<String, String>> dict;
        private static HashSet<LocalizedForm> frmlst;

        static Localizer()
        {
            sellang = "default";
            frmlst = new HashSet<LocalizedForm>();
            dict = new Dictionary<String, Dictionary<String, String>>();

            LoadLang(sellang);
        }

        public static void LoadLang(String name)
        {
            String path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Language", name + ".ini");
            if (!File.Exists(path)) return;
            Ini ini = new Ini(path);
            sellang = name;

            dict.Clear();

            foreach (String sect in ini.List())
            {
                Dictionary<String, String> di = new Dictionary<String, String>();
                foreach (String k in ini[sect].List())
                {
                    String[] sp = k.Split(new char[] { '=' }, 2);
                    try
                    {
                        di[sp[0]] = Regex.Unescape(sp[1]);
                    }
                    catch { }
                }
                dict[sect] = di;
            }

            foreach (LocalizedForm lm in frmlst)
            {
                if (lm == null) continue;
                if (lm.Tag == null) continue;

                PleaseTrigger(lm);
            }

            Application.DoEvents();
        }

        public static String Translate(String sect, String wat)
        {
            if (dict == null) return "!MISSINGNO.%";
            Dictionary<String, String> s;
            if (!dict.TryGetValue(sect, out s)) return "!nosect%" + sect;
            String tr;
            if (!s.TryGetValue(wat, out tr)) return "!nokey%" + sect + "?" + wat;
            return tr;
        }

        public static void SubscribeHook(LocalizedForm frm)
        {
            if (frm == null) return;
            frmlst.Add(frm);
        }

        public static void UnsubscribeHook(LocalizedForm frm)
        {
            if (frm == null) return;
            frmlst.Remove(frm);
        }

        public static void PleaseTrigger(LocalizedForm frm)
        {
            if (frm == null) return;
            if (frm.Tag == null) return;
            IEnumerable<Control> ie = frm.TranslationTrigger();
            if (ie == null) return;
            foreach (Control ctl in ie)
            {
                if (ctl == null) continue;
                if (ctl.Tag == null) continue;
                ctl.Text = Translate(frm.Tag.ToString(), ctl.Tag.ToString());
            }
            frm.PostTranslate();
        }
    }
}