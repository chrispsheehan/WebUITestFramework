using System;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Framework.Webdriver
{
    public class WebdriverFactory
    {
        private readonly IWebDriver _driver;

        private readonly Logger _log = LogManager.GetCurrentClassLogger();

        public WebdriverFactory()
        {
            _log.Info("Initialising web driver");

            // _driver = new ChromeDriver();


            var chromeOptions = new ChromeOptions
            {
                BrowserVersion = "",
                PlatformName = "LINUX"
            };

            chromeOptions.AddArgument("--start-maximised");

            _driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chromeOptions);

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);            
        }

        public IWebDriver Get()
        {
            return _driver;
        }
    }
}