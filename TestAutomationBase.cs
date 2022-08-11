using System;
using System.Threading;
using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace CSharpSeleniumTraining {
    public class TestAutomationBase {

        public static FirefoxOptions options;
        public static IWebDriver driver;

        public static void Initialize () {
            if (Consts.IsDebug) {
                PrintData ("BrowserExecutableLocation",
                    Consts.BrowserExecutableLocation,
                    "WebDriverLocation",
                    Consts.WebDriverLocation,
                    "ApplicationURL",
                    Consts.ApplicationURL);
            }

            options = new FirefoxOptions (); //optional
            options.BrowserExecutableLocation = Consts.BrowserExecutableLocation;
            driver = new FirefoxDriver (Consts.WebDriverLocation, options);
        }

        public static void PrintData (string data) {
            Console.WriteLine (data);
        }

        public static void PrintData (params string[] data) {
            foreach (var item in data) {
                Console.WriteLine (item);
            }
            Console.WriteLine ("******************");
        }
    }
}