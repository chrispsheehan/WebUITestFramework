using System;
using Framework.Settings;
using NLog;
using OpenQA.Selenium;

namespace Framework.Webdriver
{
    public class WebdriverFactory : WebdriverBuilder
    {
        private readonly IWebDriver _driver;
        private readonly Logger _log = LogManager.GetCurrentClassLogger();
        private readonly TestSettings _testSettings;

        public WebdriverFactory(TestSettings testSettings) : base(testSettings)
        {
            _testSettings = testSettings;

            _log.Info("Initialising web driver");

            _driver = BuildDriver();

            SetDriver();
        }
        private void SetDriver()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(_testSettings.WaitSeconds);

            _driver.Manage().Window.Maximize();
        }

        public IWebDriver Get()
        {
            return _driver;
        }
    }
}