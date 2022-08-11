using System;
using System.Linq.Expressions;
using System.Threading;
using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

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
            PickCorrectBrowser (Consts.BrowserName);
        }

        public static void PickCorrectBrowser (string browserName) {
            BrowserType browserType;
            if (browserName.ToLower ().Equals ("ff")) {
                browserType = BrowserType.FireFox;
            } else if (browserName.ToLower ().Equals ("ch")) {
                browserType = BrowserType.Chrome;
            } else if (browserName.ToLower ().Equals ("ie")) {
                browserType = BrowserType.InternetExplorer;
            } else if (browserName.ToLower ().Equals ("sa")) {
                browserType = BrowserType.Safari;
            } else if (browserName.ToLower ().Equals ("ed")) {
                browserType = BrowserType.Edge;
            } else if (browserName.ToLower ().Equals ("bb")) {
                browserType = BrowserType.Brave;
            } else {
                browserType = BrowserType.FireFox;
            }

            switch (browserType) {
                case BrowserType.FireFox:
                    options = new FirefoxOptions ();
                    options.BrowserExecutableLocation = Consts.BrowserExecutableLocation;
                    driver = new FirefoxDriver (Consts.WebDriverLocation, options);
                    break;
                case BrowserType.Chrome:
                    driver = new ChromeDriver (Consts.WebDriverLocation);
                    break;
                    /*
                    case BrowserType.InternetExplorer:
                        driver = new InternetExplorerDriver (Consts.WebDriverLocation);
                        break;
                        */
                default:
                    options = new FirefoxOptions ();
                    options.BrowserExecutableLocation = Consts.BrowserExecutableLocation;
                    driver = new FirefoxDriver (Consts.WebDriverLocation, options);
                    break;

            }
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