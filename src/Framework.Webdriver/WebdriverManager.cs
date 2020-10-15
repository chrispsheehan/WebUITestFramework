using NLog;
using OpenQA.Selenium;

namespace Framework.Webdriver
{
    public class WebdriverManager
    {
        private readonly IWebDriver _driver;

        private readonly Logger _log = LogManager.GetCurrentClassLogger();

        public WebdriverManager(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Stop()
        {
            _log.Info("Closing web driver");

            _driver.Close();
        }
    }
}