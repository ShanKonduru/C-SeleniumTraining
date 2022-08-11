using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace CSharpSeleniumTraining {
    class SimpleInteractionTest : TestAutomationBase {

        static void Main (string[] args) {
            IWebDriver driver = new ChromeDriver (Consts.WebDriverLocation);
            driver.Navigate ().GoToUrl ("https://www.google.com/");
            driver.FindElement (By.Name ("q")).SendKeys ("Shan Konduru" + Keys.Return);
            Thread.Sleep (5000);
            driver.Quit ();
        }
    }
}