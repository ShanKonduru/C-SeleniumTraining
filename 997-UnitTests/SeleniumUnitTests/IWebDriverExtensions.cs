using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumUnitTests {
    public static class IWebDriverExtensions {
        public static IReadOnlyCollection<IWebElement> FindElementsByVisibleTextIgnoreCase (this IWebDriver driver, string text) {
            return driver.FindElements (By.XPath (string.Format ("//*[contains(translate(.,'ABCDEFGHIJKLMNOPQRSTUVWXYZ','abcdefghijklmnopqrstuvwxyz'),'{0}')]", text)));
        }
    }
}