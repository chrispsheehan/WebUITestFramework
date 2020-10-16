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
        public void AfterScenario(ScenarioContext scenarioContext, WebdriverManager webdriverManager)
        {
            if(scenarioContext.ScenarioExecutionStatus != ScenarioExecutionStatus.OK)
            {
                webdriverManager.TakeScreenshot();
            }

            webdriverManager.Stop();
        }
    }
}