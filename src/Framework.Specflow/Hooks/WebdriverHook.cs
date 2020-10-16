using TechTalk.SpecFlow;
using BoDi;
using Framework.Webdriver;

namespace Framework.Specflow.Hooks
{
    [Binding]
    public class WebdriverHook
    {
        [BeforeScenario]
        public void BeforeScenario(IObjectContainer objectContainer)
        {
            objectContainer.RegisterInstanceAs(new WebdriverFactory().Get());
        }

        [AfterScenario]
        public void AfterScenario(WebdriverManager webdriverManager)
        {
            webdriverManager.TakeScreenshot();

            webdriverManager.Stop();
        }
    }
}