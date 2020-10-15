using OpenQA.Selenium;

namespace Framework.Webdriver
{
    public static class WebdriverAssert
    {
        public static bool IsDisplayed(this IWebElement webElement)
        {
            try
            {
                return webElement.Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
}