using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;

namespace CSharpSeleniumTraining {
    class SimpleTest : TestAutomationBase {

        static void Main (string[] args) {
            IWebDriver driver = new ChromeDriver (Consts.WebDriverLocation);
            driver.Navigate ().GoToUrl ("https://www.google.com/");
            Thread.Sleep (5000);
            driver.Quit ();
        }
    }
}