using TechTalk.SpecFlow;
using Framework.Webdriver;

namespace WebUITestFramework.PageObjects
{
    [Binding]
    public class HomePageObject
    {
        private readonly WebdriverFind _webdriverFind;

        public HomePageObject(WebdriverFind webdriverFind)
        {
            _webdriverFind = webdriverFind;
        }

        public bool SignInBtnIsDisplayed()
        {
            return _webdriverFind.Element(HomePageElements.SignInBtn).IsDisplayed();
        }

        public bool UserFieldIsdisplayed()
        {
            return _webdriverFind.Element(HomePageElements.UserField).IsDisplayed();
        }

        public bool EmailFieldIsdisplayed()
        {
            return _webdriverFind.Element(HomePageElements.EmailField).IsDisplayed();
        }
    }
}