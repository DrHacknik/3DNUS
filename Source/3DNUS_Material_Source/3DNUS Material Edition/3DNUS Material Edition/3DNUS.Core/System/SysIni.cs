using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace _3DNUS_Material_Edition.Core.System
{
    public class Ini
    {
        public String path;
        protected Dictionary<String, IniSection> container;

        public Ini(String path, int initsize = Int16.MaxValue)
        {
            this.path = Path.GetFullPath(path);
            if (!File.Exists(this.path)) File.WriteAllText(this.path, "");
            this.container = initial(initsize);
        }

        public class IniSection
        {
            private String section;
            private Ini ini;

            public IniSection(Ini ini, String section)
            {
                this.ini = ini;
                this.section = section;
            }

            public int Write(String k, String v)
            {
                int stuff = WritePrivateProfileString(this.section, k, v, this.ini.path);
                if (Marshal.GetLastWin32Error() != 0) throw new Win32Exception(Marshal.GetLastWin32Error());
                return stuff;
            }

            public String Read(String k, String def = "", int maxsize = 255)
            {
                StringBuilder sb = new StringBuilder(maxsize);
                GetPrivateProfileString(this.section, k, def, sb, maxsize, this.ini.path);
                if (Marshal.GetLastWin32Error() != 0) throw new Win32Exception(Marshal.GetLastWin32Error());
                return sb.ToString();
            }

            public int ReadInt(String k, int def = 0)
            {
                return GetPrivateProfileInt(this.section, k, def, this.ini.path);
            }

            public int WriteStruct<T>(String k, object v) where T : struct
            {
                int sizeofv = Marshal.SizeOf(v);
                IntPtr pointer = Marshal.AllocCoTaskMem(sizeofv);
                Marshal.StructureToPtr(v, pointer, false);
                int toret = WritePrivateProfileStruct(this.section, k, pointer, sizeofv, this.ini.path);
                if (Marshal.GetLastWin32Error() != 0) throw new Win32Exception(Marshal.GetLastWin32Error());
                Marshal.FreeCoTaskMem(pointer);
                return toret;
            }

            public Nullable<T> ReadStruct<T>(String k) where T : struct
            {
                Type type = typeof(T);
                int sizeofv = Marshal.SizeOf(type);
                IntPtr pointer = Marshal.AllocCoTaskMem(sizeofv);
                int toret = GetPrivateProfileStruct(this.section, k, pointer, sizeofv, this.ini.path);
                object stuff = (toret == 0 ? null : Marshal.PtrToStructure(pointer, type));
                Marshal.FreeCoTaskMem(pointer);
                return (T)stuff;
            }

            public String[] List(int size = Int16.MaxValue)
            {
                String str = new String('\0', size);
                IntPtr ptr = Marshal.StringToHGlobalAnsi(str);
                GetPrivateProfileSection(this.section, ptr, size, this.ini.path);
                str = Marshal.PtrToStringAnsi(ptr, size);
                Marshal.FreeHGlobal(ptr);
                List<String> lst = new List<String>();
                StringBuilder sb = new StringBuilder();
                Boolean zero = true;
                foreach (char ch in str)
                {
                    if (ch == '\0')
                        if (zero)
                            break;
                        else
                        {
                            zero = true;
                            lst.Add(sb.ToString());
                            sb = new StringBuilder();
                        }
                    else
                    {
                        zero = false;
                        sb.Append(ch);
                    }
                }

                String[] stra = new String[lst.Count];
                for (int i = 0; i != stra.Length; i++)
                {
                    stra[i] = lst[i];
                }

                return stra;
            }

            public String this[string section]
            {
                get
                {
                    return Read(section);
                }
                set
                {
                    Write(section, value);
                }
            }
        }

        protected Dictionary<String, IniSection> initial(int size = Int16.MaxValue)
        {
            String[] sects = List(size);
            Dictionary<String, IniSection> inisec = new Dictionary<String, IniSection>();
            foreach (String str in sects)
            {
                inisec.Add(str, new IniSection(this, str));
            }
            return inisec;
        }

        public String[] List(int size = Int16.MaxValue)
        {
            String str = new String('\0', size);
            IntPtr ptr = Marshal.StringToHGlobalAnsi(str);
            GetPrivateProfileSectionNames(ptr, size, this.path);
            str = Marshal.PtrToStringAnsi(ptr, size);
            Marshal.FreeHGlobal(ptr);
            List<String> lst = new List<String>();
            StringBuilder sb = new StringBuilder();
            Boolean zero = true;
            foreach (char ch in str)
            {
                if (ch == '\0')
                    if (zero) break;
                    else
                    {
                        zero = true;
                        lst.Add(sb.ToString());
                        sb = new StringBuilder();
                    }
                else
                {
                    zero = false;
                    sb.Append(ch);
                }
            }

            String[] stra = new String[lst.Count];
            for (int i = 0; i != stra.Length; i++)
            {
                stra[i] = lst[i];
            }

            return stra;
        }

        public IniSection GetSection(string name)
        {
            IniSection dummy;
            if (!container.TryGetValue(name, out dummy))
            {
                dummy = new IniSection(this, name);
                container.Add(name, dummy);
            }
            return dummy;
        }

        [DllImport("KERNEL32", SetLastError = true)]
        protected static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder sbpointer, int maxsize, string inifile);

        [DllImport("KERNEL32")]
        protected static extern int GetPrivateProfileInt(string section, string key, int def, string inifile);

        [DllImport("KERNEL32")]
        protected static extern int GetPrivateProfileSection(string section, IntPtr sb, int size, string inifile);

        [DllImport("KERNEL32")]
        protected static extern int GetPrivateProfileSectionNames(IntPtr sb, int size, string inifile);

        [DllImport("KERNEL32", SetLastError = true)]
        protected static extern int WritePrivateProfileString(string section, string key, string val, string inifile);

        [DllImport("KERNEL32")]
        protected static extern int GetPrivateProfileStruct(string section, string key, IntPtr pstruct, int size, string inifile);

        [DllImport("KERNEL32", SetLastError = true)]
        protected static extern int WritePrivateProfileStruct(string section, string key, IntPtr pstruct, int size, string inifile);

        public IniSection this[string section]
        {
            get
            {
                return this.GetSection(section);
            }
        }
    }
}