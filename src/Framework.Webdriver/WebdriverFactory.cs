using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Webdriver
{
    public class WebdriverFactory
    {
        public WebdriverFactory()
        {

        }

        public IWebDriver Get()
        {
            var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArguments("--headless");

            return new ChromeDriver(chromeOptions);
        }


    }
}