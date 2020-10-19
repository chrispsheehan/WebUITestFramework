using System;
using Framework.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace Framework.Webdriver
{
    public class WebdriverBuilder
    {
        private readonly TestSettings _testSettings;

        public WebdriverBuilder(TestSettings testSettings)
        {
            _testSettings = testSettings;
        }

        internal IWebDriver BuildDriver()
        {
            switch(_testSettings.BrowserName)
            {
                case DriverBrowser.Firefox :
                {
                    return BuildFirefoxDriver();
                }
                case DriverBrowser.Chrome :
                {
                    return BuildChromeDriver();
                }
                default:
                    throw BuildExeception();
            }
        }

        private ArgumentException BuildExeception()
        {
            return new ArgumentException($"BrowserType: {_testSettings.BrowserType} Browser: {_testSettings.BrowserName} not supported :(");
        }

        private IWebDriver BuildFirefoxDriver()
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

                    return new RemoteWebDriver(new Uri(_testSettings.RemoteUrl), firefoxOptions.ToCapabilities());
                }
                default:
                    throw BuildExeception();
            }
        }

        private IWebDriver BuildChromeDriver()
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

                    return new RemoteWebDriver(new Uri(_testSettings.RemoteUrl), chromeOptions.ToCapabilities());
                }
                case DriverType.Local :
                {
                    return new ChromeDriver();
                }
                default:
                    throw BuildExeception();
            }
        }
    }
}