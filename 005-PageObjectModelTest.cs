using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace CSharpSeleniumTraining {

    public class IndexPage : TestAutomationBase {

        private IWebDriver _driver;
        private IWebElement _userName;
        private IWebElement _password;
        private IWebElement _signIn;

        public IndexPage (IWebDriver driver) {
            _driver = driver;
            _userName = _driver.FindElement (By.Id ("text"));
            _password = _driver.FindElement (By.Id ("password"));
            _signIn = _driver.FindElement (By.Id ("login-button"));
        }

        public void Login (string username, string password) {
            _userName.SendKeys (username);
            _password.SendKeys (password);
            _signIn.Click ();
        }

        public void Close () {
            _driver.Quit ();
        }
    }

    class PageObjectModelTest : TestAutomationBase {

        static void Main (string[] args) {
            IWebDriver driver = new ChromeDriver (Consts.WebDriverLocation);
            driver.Navigate ().GoToUrl ("http://webdriveruniversity.com/Login-Portal/index.html?");
            IndexPage indexPage = new IndexPage (driver);
            indexPage.Login ("username", "passwprd");
            Thread.Sleep (5000);
            indexPage.Close ();
        }
    }
}