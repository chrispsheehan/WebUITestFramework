using TechTalk.SpecFlow;
using BoDi;
using Framework.Settings;

namespace Framework.Specflow.Hooks
{
    [Binding]
    public static class SettingsHook
    {
        public static TestSettings AppSettings;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            AppSettings = SettingsConfiguration.Build();
        }

        [BeforeFeature]
        public static void BeforeFeature(IObjectContainer objectContainer)
        {
            objectContainer.RegisterInstanceAs(AppSettings);
        }
    }
}