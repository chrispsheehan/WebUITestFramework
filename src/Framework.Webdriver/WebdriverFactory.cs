using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Webdriver
{
    public class WebdriverFactory
    {
        private readonly IWebDriver _driver;

        public WebdriverFactory()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public IWebDriver Get()
        {
            return _driver;
        }
    }
}