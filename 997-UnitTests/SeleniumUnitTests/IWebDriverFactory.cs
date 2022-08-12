using OpenQA.Selenium;

namespace SeleniumUnitTests {

    public interface IWebDriverFactory {
        public IWebDriver Create ();
    }
}