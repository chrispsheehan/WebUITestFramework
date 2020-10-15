using OpenQA.Selenium;

namespace Framework.Webdriver
{
    public class WebdriverNavigate
    {
        private readonly IWebDriver _driver;

        public WebdriverNavigate(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateTo(string targetUrl)
        {
            _driver.Url = targetUrl;
        }
    }
}