using System;

namespace CSharpSeleniumTraining {
    public static class Consts {

        public static IniFile settingsIni;

        public static bool IsDebug { get; set; }

        public static string BrowserExecutableLocation { get; set; }

        public static string WebDriverLocation { get; set; }

        public static string ApplicationURL { get; set; }

        static Consts () {

            settingsIni = new IniFile (@"C:\C#SeleniumTraining\Settings.ini");

            IsDebug = (settingsIni.Read ("Debug", "ExecutionMode").ToLower ().Equals ("true") || settingsIni.Read ("Debug", "ExecutionMode").ToLower ().Equals ("yes"));

            BrowserExecutableLocation = settingsIni.Read ("BrowserExecutableLocation", "BrowserToUse");
            WebDriverLocation = settingsIni.Read ("WebDriverLocation", "WebdriverToUse");
            ApplicationURL = settingsIni.Read ("ApplicationURL", "ApplicationUnderTest");
        }
    }
}