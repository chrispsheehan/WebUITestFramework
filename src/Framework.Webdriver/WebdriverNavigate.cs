using NLog;
using OpenQA.Selenium;

namespace Framework.Webdriver
{
    public class WebdriverNavigate
    {
        private readonly IWebDriver _driver;

        private readonly Logger _log = LogManager.GetCurrentClassLogger();

        public WebdriverNavigate(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateTo(string targetUrl)
        {
            _log.Trace($"Navigating to {targetUrl}");

            _driver.Url = targetUrl;
        }
    }
}