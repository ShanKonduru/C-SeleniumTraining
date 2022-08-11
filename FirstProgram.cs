using System;
using System.Threading;
using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace CSharpSeleniumTraining {
    class FirstProgram : TestAutomationBase {

        static void Main (string[] args) {
            Initialize ();

            driver.Navigate ().GoToUrl (Consts.ApplicationURL);
            driver.FindElement (By.Name ("q")).SendKeys ("Shan Konduru" + Keys.Return);
            Thread.Sleep (5000);
            driver.Quit ();
        }
    }
}