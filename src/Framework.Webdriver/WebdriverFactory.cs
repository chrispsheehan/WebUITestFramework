using System;
using Framework.Settings;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace Framework.Webdriver
{
    public class WebdriverFactory
    {
        private IWebDriver _driver;
        private readonly Logger _log = LogManager.GetCurrentClassLogger();
        private readonly TestSettings _testSettings;

        public WebdriverFactory(TestSettings testSettings)
        {
            _testSettings = testSettings;

            _log.Info("Initialising web driver");

            BuildDriver();

            ManageDriver();
        }
        private void BuildDriver()
        {
            switch(_testSettings.BrowserName)
            {
                case DriverBrowser.Firefox :
                {
                    BuildFirefoxDriver();

                    break;
                }
                case DriverBrowser.Chrome :
                {
                    BuildChromeDriver();

                    break;
                }
                default:
                    throw BuildExeception();
            }
        }

        private ArgumentException BuildExeception()
        {
            return new ArgumentException($"BrowserType: {_testSettings.BrowserType} Browser: {_testSettings.BrowserName} not supported :(");
        }

        private void BuildFirefoxDriver()
        {
            switch(_testSettings.BrowserType)
            {
                case DriverType.Remote :
                {
                    var firefoxOptions = new FirefoxOptions
                    {
                        BrowserVersion = "",
                        PlatformName = "LINUX",
                    };

                    _driver = new RemoteWebDriver(new Uri(_testSettings.RemoteUrl), firefoxOptions.ToCapabilities());

                    break;
                }
                default:
                    throw BuildExeception();
            }
        }

        private void BuildChromeDriver()
        {
            switch(_testSettings.BrowserType)
            {
                case DriverType.Remote :
                {
                    var chromeOptions = new ChromeOptions
                    {
                        BrowserVersion = "",
                        PlatformName = "LINUX",
                    };

                    _driver = new RemoteWebDriver(new Uri(_testSettings.RemoteUrl), chromeOptions.ToCapabilities());

                    break;
                }
                case DriverType.Local :
                {
                    _driver = new ChromeDriver();

                    break;
                }
                default:
                    throw BuildExeception();
            }
        }

        private void ManageDriver()
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