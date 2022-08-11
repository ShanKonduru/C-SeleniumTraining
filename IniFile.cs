using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

// Change this to match your program's normal namespace
namespace CSharpSeleniumTraining {
    public class IniFile // revision 11
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly ().GetName ().Name;

        [DllImport ("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString (string section, string key, string dataValue, string FilePath);

        [DllImport ("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString (string section, string key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile (string IniPath = null) {
            Path = new FileInfo (IniPath ?? EXE + ".ini").FullName;
        }

        public string Read (string key, string section) {
            var RetVal = new StringBuilder (255);
            GetPrivateProfileString (section ?? EXE, key, "Unknown", RetVal, 255, Path);
            return RetVal.ToString ();
        }

        public void Write (string key, string dataValue, string section) {
            WritePrivateProfileString (section ?? EXE, key, dataValue, Path);
        }

        public void DeleteKey (string key, string section) {
            Write (key, null, section ?? EXE);
        }

        public void DeleteSection (string section) {
            Write (null, null, section ?? EXE);
        }

        public bool KeyExists (string key, string section) {
            return Read (key, section).Length > 0;
        }
    }
}