using TechTalk.SpecFlow;
using System;

namespace Github.Test.Hooks
{
    [Binding]
    public class LogHook
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("started");
        }
    }
}