using TechTalk.SpecFlow;
using BoDi;
using NLog;

namespace Framework.Specflow.Hooks
{
    [Binding]
    public class LogHook
    {
        private static Logger _frameworkLog;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            _frameworkLog  = LogManager.GetCurrentClassLogger();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            _frameworkLog.Info($"Starting Feature: {featureContext.FeatureInfo.Title}");
        }

        [BeforeScenario]
        public void BeforeScenario(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            Logger scenarioLog = LogManager.GetCurrentClassLogger();

            objectContainer.RegisterInstanceAs(scenarioLog);

            scenarioLog.Info($"Starting Scenario: {scenarioContext.ScenarioInfo.Title}");
        }

        [AfterScenario]
        public void AfterScenario(Logger scenarioLog, ScenarioContext scenarioContext)
        {
            scenarioLog.Info($"Finishing Scenario: {scenarioContext.ScenarioInfo.Title}");
        }

        [AfterFeature]
        public static void AfterFeature(FeatureContext featureContext)
        {
            _frameworkLog.Info($"Finishing Feature: {featureContext.FeatureInfo.Title}");
        }
    }
}