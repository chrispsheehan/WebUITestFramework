using TechTalk.SpecFlow;
using BoDi;
using Framework.Settings;

namespace Framework.Specflow.Hooks
{
    [Binding]
    public static class SettingsHook
    {
        [BeforeTestRun]
        public static void BeforeTestRun(IObjectContainer objectContainer)
        {
            objectContainer.RegisterInstanceAs(SettingsConfiguration.Build());
        }
    }
}