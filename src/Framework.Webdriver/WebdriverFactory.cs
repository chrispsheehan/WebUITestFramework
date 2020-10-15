using System;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Webdriver
{
    public class WebdriverFactory
    {
        private readonly IWebDriver _driver;

        private readonly Logger _log = LogManager.GetCurrentClassLogger();

        public WebdriverFactory()
        {
            _log.Info("Initialising web driver");

            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public IWebDriver Get()
        {
            return _driver;
        }
    }
}