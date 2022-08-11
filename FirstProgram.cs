using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace CSharpSeleniumTraining {
    class FirstProgram {
        static void Main (string[] args) {
            FirefoxOptions options = new FirefoxOptions (); //optional
            options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            IWebDriver driver = new FirefoxDriver(@"C:\SeleniumWebdrivers\", options);

            driver.Navigate ().GoToUrl ("https://www.google.com");
            driver.FindElement (By.Name ("q")).SendKeys ("Shan Konduru" + Keys.Return);
            Thread.Sleep (5000);
            driver.Quit ();
        }
    }
}