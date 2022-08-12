using System;
using System.IO;
using System.Xml;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace SeleniumUnitTests {

    [TestClass]
    public class SeleniumUnitTest {
        private static IWebDriverFactory factory;
        private static Uri baseUrl;
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver> (() => factory.Create ());

        public IWebDriver Driver
        {
            get
            {
                return SeleniumUnitTest.driver.Value;
            }
        }

        public Uri BaseUrl
        {
            get
            {
                return SeleniumUnitTest.baseUrl;
            }
        }

        public TestContext TestContext { get; set; }

        [AssemblyInitialize]
        public static void AssemblyInitialize (TestContext context) {
            var webDriverType = (string) context.Properties["WebDriver"];
            var baseUrl = (string) context.Properties["BaseUrl"];

            switch (webDriverType) {
                case "chrome":
                default:
                    var workingDirectory = Path.GetDirectoryName (Assembly.GetExecutingAssembly ().Location);
                    var options = new ChromeOptions ();
                    options.AddArguments (new string[] {
                        "--no-sandbox",
                        "--headless",
                        "--disable-gpu"
                    });
                    SeleniumUnitTest.factory = new ChromeDriverFactory (workingDirectory, options, TimeSpan.FromSeconds (60));
                    break;
            }

            SeleniumUnitTest.baseUrl = new Uri (baseUrl);
        }

        [TestCleanup]
        public virtual void TestCleanup () {
            driver.Value.Dispose ();
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup () {
            driver.Dispose ();
        }

        [TestInitialize]
        public virtual void TestInitialize()
        {
        }

        [TestMethod]
        public void TestMethod1 () { 
        }
    }
}