using System;

namespace CSharpSeleniumTraining {
    public static class Consts {

        public static IniFile settingsIni;

        public static bool IsDebug { get; set; }

        public static bool IsHeadless { get; set; }

        public static string BrowserName { get; set; }

        public static string BrowserExecutableLocation { get; set; }

        public static string WebDriverLocation { get; set; }

        public static string ApplicationURL { get; set; }

        static Consts () {

            settingsIni = new IniFile (@"C:\C#SeleniumTraining\Settings.ini");

            IsDebug = (settingsIni.Read ("Debug", "ExecutionMode").ToLower ().Equals ("true") ||
                settingsIni.Read ("Debug", "ExecutionMode").ToLower ().Equals ("yes"));

            IsHeadless = (settingsIni.Read ("Headless", "BrowserToUse").ToLower ().Equals ("true") ||
                settingsIni.Read ("Headless", "BrowserToUse").ToLower ().Equals ("yes"));

            BrowserName = settingsIni.Read ("BrowserName", "BrowserToUse");
            BrowserExecutableLocation = settingsIni.Read ("BrowserExecutableLocation", "BrowserToUse");
            WebDriverLocation = settingsIni.Read ("WebDriverLocation", "WebdriverToUse");
            ApplicationURL = settingsIni.Read ("ApplicationURL", "ApplicationUnderTest");
        }
    }

    public enum BrowserType {
        Chrome = 1,
        FireFox = 2,
        Edge = 3,
        InternetExplorer = 4,
        Safari = 5,
        Brave = 6,
        Unknown = 99
    }
}