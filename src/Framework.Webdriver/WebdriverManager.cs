using OpenQA.Selenium;

namespace Framework.Webdriver
{
    public class WebdriverManager
    {
        private readonly IWebDriver _driver;

        public WebdriverManager(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Stop()
        {
            _driver.Close();
        }
    }
}