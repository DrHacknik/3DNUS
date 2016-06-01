//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.IO;
//using System.Text.RegularExpressions;

//namespace _3DNUS
//{
//    public class YLS
//    {
//        public Dictionary<char, List<YLS_Title>> regions;

//        public YLS()
//        {
//            regions = new Dictionary<char, List<YLS_Title>>();
//        }

//        public void Entry(char region, YLS_Title wat)
//        {
//            if (!regions.ContainsKey(region))
//            {
//                regions[region] = new List<YLS_Title>();
//            }

//            regions[region].Add(wat);
//        }

//        public static YLS Import(String wat)
//        {
//            if (!File.Exists(wat)) return null;
//            YLS yls = new YLS();
//            YLS_Title titl = null;
//            String[] line = null;
//            using (StreamReader str = File.OpenText(wat))
//            {
//                str.ReadLine();

//                while (!str.EndOfStream)
//                {
//                    line = str.ReadLine().Split(',');
//                    if (line.Length != 4) continue;

//                    titl = new YLS_Title();

//                    titl.id = Convert.ToUInt64(line[0], 16);

//                    if (titl.id == 0x4013000001B02) line[3] = line[3].Replace("02-11-15 GPIO", "9.5.0-22");
//                    if (titl.id == 0x400102002CA00) line[3] = line[3].Replace("10-02-14 JPN", "9.1.0-20J");

//                    Match mat = Regex.Match(line[3], @"(\d+)\.(\d+)\.(\d+)-(\d+)");

//                    foreach (String ver in line[2].Split(' '))
//                    {
//                        while (mat.Success && String.IsNullOrEmpty(mat.ToString())) mat = mat.NextMatch(); //stupid dotNOT Regex engine ¬_¬
//                        if (!mat.Success) throw new InvalidDataException("Invalid report file!");

//                        titl.ver.Add(new YLS_Titlever() { version = int.Parse(ver.Substring(1)), sysver = new YLS_Sysver() { label = mat.ToString() } });

//                        mat = mat.NextMatch();
//                    }

//                    if (mat != null && mat.Success) throw new InvalidDataException("Invalid report file!");
//                    else
//                        yls.Entry(line[1][0], titl);
//                }
//            }
//            return yls;
//        }
//    }

//    public class YLS_Title
//    {
//        public UInt64 id;
//        public List<YLS_Titlever> ver;

//        public YLS_Title()
//        {
//            ver = new List<YLS_Titlever>();
//        }
//    }

//    public class YLS_Titlever
//    {
//        public int version;
//        public YLS_Sysver sysver;

//        public override string ToString()
//        {
//            return "v" + version + " " + sysver;
//        }
//    }

//    public class YLS_Sysver : IComparable<YLS_Sysver>
//    {
//        public String label
//        {
//            get
//            {
//                return intstr;
//            }
//            set
//            {
//                Match match = Regex.Match(value, @"(\d+)\.(\d+)\.(\d+)-(\d+)");
//                if (!match.Success) throw new ArgumentException("Invalid pattern!");
//                _major = int.Parse(match.Groups[1].Value);
//                _minor = int.Parse(match.Groups[2].Value);
//                _build = int.Parse(match.Groups[3].Value);
//                _rev = int.Parse(match.Groups[4].Value);
//                this.intstr = value;
//            }
//        }

//        public int major
//        {
//            get
//            {
//                return _major;
//            }
//            set
//            {
//                _major = value;
//                rebuild();
//            }
//        }

//        public int minor
//        {
//            get
//            {
//                return _minor;
//            }
//            set
//            {
//                _minor = value;
//                rebuild();
//            }
//        }

//        public int build
//        {
//            get
//            {
//                return _build;
//            }
//            set
//            {
//                _build = value;
//                rebuild();
//            }
//        }

//        public int rev
//        {
//            get
//            {
//                return _rev;
//            }
//            set
//            {
//                _rev = value;
//                rebuild();
//            }
//        }



//        private String intstr;
//        private int _major;
//        private int _minor;
//        private int _build;
//        private int _rev;

//        private void rebuild()
//        {
//            intstr = _major + "." + _minor + "." + _build + "-" + _rev;
//        }

//        public int CompareTo(YLS_Sysver other)
//        {
//            //if (other == null) throw new NullReferenceException();
//            //return this.str.CompareTo(other.str);
//            if (this.major < other.major) return -1;
//            if (this.major > other.major) return 1;
//            if (this.minor < other.minor) return -1;
//            if (this.minor > other.minor) return 1;
//            if (this.build < other.build) return -1;
//            if (this.build > other.build) return 1;
//            if (this.rev == 999 || other.rev == 999) return 0;
//            if (this.rev < other.rev) return -1;
//            if (this.rev > other.rev) return 1;
//            return 0;
//        }

//        public static Boolean operator <(YLS_Sysver me, YLS_Sysver other)
//        {
//            return me.CompareTo(other) == -1;
//        }

//        public static Boolean operator >(YLS_Sysver me, YLS_Sysver other)
//        {
//            return me.CompareTo(other) == 1;
//        }

//        public static Boolean operator ==(YLS_Sysver me, YLS_Sysver other)
//        {
//            return me.CompareTo(other) == 0;
//        }

//        public static Boolean operator !=(YLS_Sysver me, YLS_Sysver other)
//        {
//            return me.CompareTo(other) != 0;
//        }

//        public static Boolean operator >=(YLS_Sysver me, YLS_Sysver other)
//        {
//            return me.CompareTo(other) != -1;
//        }

//        public static Boolean operator <=(YLS_Sysver me, YLS_Sysver other)
//        {
//            return me.CompareTo(other) != 1;
//        }

//        public override string ToString()
//        {
//            return this.intstr;
//        }
//    }
//}