using OpenQA.Selenium;

namespace Framework.Webdriver
{
    public class WebdriverFind
    {
        private readonly IWebDriver _driver;

        public WebdriverFind(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement Element(By by)
        {
            return _driver.FindElement(by);
        }
    }
}