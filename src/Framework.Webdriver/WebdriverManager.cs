using NLog;
using OpenQA.Selenium;
using System;
using System.IO;

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

        private string GenerateScreenshotPath()
        {
            string guidRef = Guid.NewGuid().ToString();

            string screenshotFolder = Directory.GetCurrentDirectory();

            return $"{screenshotFolder}/{guidRef}.png";
        }

        public void TakeScreenshot()
        {
            var screenshotPath = GenerateScreenshotPath();

            _log.Info($"Saving screenshot to {screenshotPath}");

            ITakesScreenshot screenshotDriver = _driver as ITakesScreenshot;

            Screenshot screenshot = screenshotDriver.GetScreenshot();

            screenshot.SaveAsFile(screenshotPath);
        }
    }
}