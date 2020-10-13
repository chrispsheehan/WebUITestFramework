using TechTalk.SpecFlow;
using BoDi;

namespace Framework.Hooks
{
    [Binding]
    public class WebdriverHook
    {
        [BeforeScenario]
        public void BeforeScenario(IObjectContainer objectContainer)
        {
            objectContainer.RegisterInstanceAs("asasas");
        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}