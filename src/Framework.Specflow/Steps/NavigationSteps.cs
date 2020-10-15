using TechTalk.SpecFlow;
using Framework.Webdriver;

namespace WebUITestFramework.Steps
{
    [Binding]
    public class NavigationSteps
    {
        private readonly WebdriverNavigate _wedriverNavigate;

        public NavigationSteps(WebdriverNavigate webdriverNavigate)
        {
            _wedriverNavigate = webdriverNavigate;
        }

        [Given(@"I navigated to (.*)")]
        public void GivenINavigateToURL(string targetUrl)
        {
            _wedriverNavigate.NavigateTo(targetUrl);
        }
    }
}