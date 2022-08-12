using System;
using OpenQA.Selenium;

namespace SeleniumUnitTests {
    public class DemoPage : BasePage {
        public DemoPage (IWebDriver driver, Uri baseUrl, string path) : base (driver, baseUrl, path) { }

        public string Title {
            get { return this.Driver.Title; }
        }
    }
}