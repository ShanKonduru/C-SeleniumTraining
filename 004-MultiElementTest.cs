using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace CSharpSeleniumTraining {
    class MultiElementTest : TestAutomationBase {

        static void Main (string[] args) {
            IWebDriver driver = new ChromeDriver (Consts.WebDriverLocation);
            driver.Navigate ().GoToUrl ("http://webdriveruniversity.com/Login-Portal/index.html?");
            IWebElement  userName =  driver.FindElement (By.Id ("text"));
            IWebElement password  =  driver.FindElement (By.Id ("password"));
            IWebElement loginButton = driver.FindElement (By.Id ("login-button"));
            userName.SendKeys ("username" );
            password.SendKeys ("password" ); 
            loginButton.Click ();
            Thread.Sleep (5000);
            driver.Quit ();
        }
    }
}